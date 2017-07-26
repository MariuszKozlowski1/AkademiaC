using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SpeedwayBetting.Models
{
    class ModelOperations
    {
        private SpeedwayBettingEntities DB = new SpeedwayBettingEntities();

        public bool UserLogin(tblUsers user)
        {
            DB = new SpeedwayBettingEntities();
            var readUser = (from u in DB.tblUsers
                            where u.Login == user.Login
                            select u).FirstOrDefault();
            if (readUser != null && readUser.Password == CalculateMD5Hash(user.Password))
            {
                Properties.Settings.Default.UserLogin = readUser.Login;
                Properties.Settings.Default.UserID = readUser.ID;
                return true;
            }
            return false;
        }

        public bool CreateUser(tblUsers user)
        {
            var readUser = (from u in DB.tblUsers
                            where u.Login == user.Login
                            select u).ToList();
            if (readUser.Count == 0)
            {
                string plainPassword = user.Password;
                user.Password = CalculateMD5Hash(user.Password);
                DB.tblUsers.Add(user);
                DB.SaveChanges();
                user.Password = plainPassword;
                return true;
            }
            return false;
        }

        public bool CreateMatch(tblMatches match)
        {
            DB.tblMatches.Add(match);
            DB.SaveChanges();
            return true;
        }

        public ObservableCollection<tblMatches> ReadMatchList()
        {
            var matchList = (from m in DB.tblMatches
                             where m.Result == null
                             select m).ToList();

            ObservableCollection<tblMatches> result = new ObservableCollection<tblMatches>(matchList);
            return result;
        }

        public ObservableCollection<UserWithPoints> ReadResults()
        {
            var resultList = (from m in DB.tblBets
                              group m by m.UserID into g
                              select new UserWithPoints 
                              {
                                  ID = g.Key,
                                  Points = g.Sum(p => p.Points),
                              }).ToList();
            var userWithPointsList = (from r in resultList
                                          join u in DB.tblUsers on r.ID equals u.ID
                                          orderby r.Points descending
                                          select new UserWithPoints
                                          {
                                              ID = r.ID,
                                              Login = u.Login,
                                              Points = r.Points
                                          }).ToList();

            ObservableCollection<UserWithPoints> result = new ObservableCollection<UserWithPoints>(userWithPointsList);
            return result;
        }

        public string CreateBet(int matchID, string bet)
        {
            var myBet = (from b in DB.tblBets
                         where b.MatchID == matchID
                         where b.UserID == Properties.Settings.Default.UserID
                         select b).FirstOrDefault();
            if (myBet == null)
            {
                tblBets tBet = new tblBets();
                tBet.MatchID = matchID;
                tBet.Bet = bet;
                tBet.UserID = Properties.Settings.Default.UserID;
                tBet.Points = 0;
                DB.tblBets.Add(tBet);
                DB.SaveChanges();
                return "";
            }
            else
            {
                return myBet.Bet;
            }
        }

        public void UpdateMatchesWithResult(int matchID, string result)
        {
            var resultToUpdate = (from m in DB.tblMatches
                          where m.ID == matchID
                          select m).FirstOrDefault();
            resultToUpdate.Result = result;

            var bets = (from b in DB.tblBets
                        where b.MatchID == matchID
                        select b).ToList();

            foreach (var bet in bets)
            {
                int hostsPointsResult = Convert.ToInt16(result.Substring(0, 2));
                int visitorsPointsResult = Convert.ToInt16(result.Substring(3, 2));
                int hostsPointsBet = Convert.ToInt16(bet.Bet.Substring(0, 2));
                int visitorsPointsBet = Convert.ToInt16(bet.Bet.Substring(3, 2));
                if ((hostsPointsBet - visitorsPointsBet) * (hostsPointsResult - visitorsPointsResult) > 0)
                {
                    bet.Points = 1;
                }
                if (result == bet.Bet)
                {
                    bet.Points = 3;
                }
            }
            DB.SaveChanges();
        }

        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}

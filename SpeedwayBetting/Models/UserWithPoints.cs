using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayBetting.Models
{
    class UserWithPoints
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public Nullable<int> Points { get; set; }
    }
}

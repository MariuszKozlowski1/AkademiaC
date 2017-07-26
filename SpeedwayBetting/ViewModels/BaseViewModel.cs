using SpeedwayBetting.Helpers;
using SpeedwayBetting.Models;

namespace SpeedwayBetting.ViewModels
{
    class BaseViewModel : NotificationObject
    {
        protected ModelOperations dbOperations = new ModelOperations();
    }
}

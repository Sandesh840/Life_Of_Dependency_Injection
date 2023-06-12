using LifecycleofDepInj.Interface;

namespace LifecycleofDepInj.Services
{
    public class UserGuid:IUserGuIdInterface
    {
        public string _Guid{ get; set; }
        public UserGuid()
        {
            //get random GUID
            _Guid=Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _Guid;
        }
    }
}

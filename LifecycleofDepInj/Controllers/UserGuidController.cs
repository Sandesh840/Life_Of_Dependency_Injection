using LifecycleofDepInj.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LifecycleofDepInj.Controllers
{
    public class UserGuidController : Controller
    {
        private readonly IUserGuIdInterface _userGuIdInterface;
        public UserGuidController(IUserGuIdInterface userGuIdInterface)
        {
            _userGuIdInterface = userGuIdInterface;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetGuid()
        {
            ViewBag.FirstGuid = _userGuIdInterface.GetGuid();
            //create new service
            var anotherUserGuidService = HttpContext.RequestServices.GetService<IUserGuIdInterface>();
            ViewBag.SecondUserGuid = anotherUserGuidService.GetGuid();
            return View();
        }
    }
}

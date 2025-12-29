using Microsoft.AspNetCore.Mvc;

namespace ViewTypes.Components
{
    public class Message:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string msg = "Hi from View Component";
            return View("Default",msg);
        }
    }
}

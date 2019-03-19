namespace JsonResultDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class JsonDemoController : Controller
    {
        /// <summary>  
        /// Welcome Note Message  
        /// </summary>  
        /// <returns>In a Json Format</returns>  
        public JsonResult WelcomeNote()
        {
            bool isAdmin = false;
            //TODO: Check the user if it is admin or normal user, (true-Admin, false- Normal user)  
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";

            return Json(output);
        }
    }
}

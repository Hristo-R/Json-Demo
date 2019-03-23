namespace JsonResultDemo.Controllers
{
    using JsonResultDemo.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class JsonDemoController : Controller
    {
        // Welcome Note Message  
        // <returns>In a Json Format</returns>  
        public JsonResult WelcomeNote()
        {
            bool isAdmin = false;
            //TODO: Check the user if it is admin or normal user, (true-Admin, false- Normal user)  
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";

            return Json(output);
        }

        // Get the Users  
        private List<UserModel> GetUsers()
        {
            var usersList = new List<UserModel>
            {
                new UserModel
                {
                    UserId = 1,
                    UserName = "Ram",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "chand",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }
    }
}
﻿namespace JsonResultDemo.Controllers
{
    using JsonResultDemo.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
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
                    UserId = 2,
                    UserName = "chand",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 3,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }

        // Get the Users data in Json Format  
        public JsonResult GetUsersData()
        {
            var users = GetUsers();
            return Json(users);
        }

        // Sample View  
        public ActionResult Sample()
        {
            return View();
        }

        /// <summary>  
        /// Update the user details  
        /// </summary>  
        /// <param name="usersJson">users list in JSON Format</param>  
        /// <returns></returns>  
        //[HttpPost]
        //public JsonResult UpdateUsersDetail(string usersJson)
        //{
        //    var js = new JavaScriptSerializer();
        //    UserModel[] user = js.Deserialize<UserModel[]>(usersJson);

        //    //TODO: user now contains the details, you can do required operations  
        //    return Json("User Details are updated");
        //}

        [HttpPost]
        public ActionResult Update(string usersJson)
        {
            // UserModel[] user = Deserialize<UserModel[]>(usersJson);
            object o = JsonConvert.DeserializeObject(usersJson);
            string json2 = JsonConvert.SerializeObject(o, Formatting.Indented);

            return new EmptyResult();
        }
    }
}
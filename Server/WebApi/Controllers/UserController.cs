﻿using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;

namespace Server.Controllers
{
    public class UserController : ApiController
    {
        private UserHandler _userHandler;

        public UserController()
        {
            _userHandler = new UserHandler(); 
        }
        public List<User> Get()
        {
            return _userHandler.Get();
        }

        public User Get(int id)
        {
            return _userHandler.Get(id);
        }

        public void Post([FromBody]User user)
        {
            _userHandler.Post(user);
        }

        public void Delete(int id)
        {
        }
    }
}
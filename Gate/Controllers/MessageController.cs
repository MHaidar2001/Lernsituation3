﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gate.Controllers
{
    public class MessageController : ApiController
    {
        #region Eigenschaften
        private controller _verwalter;

        #endregion

        #region Accessoren/Modifier
        public controller Verwalter { get => _verwalter; set => _verwalter = value; }

        #endregion

        #region Konstruktoren
        public MessageController():base()
        {
            Verwalter = Global.Verwalter;
        }
        #endregion

        #region Worker
        // GET: api/Message
        public string Get(string user="" )
        {

            Verwalter.SessionErstellen(user);
            return user;
        }

        // GET: api/Message/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Message
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Message/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Message/5
        public void Delete(int id)
        {
        }
        #endregion
    }
        
        
}

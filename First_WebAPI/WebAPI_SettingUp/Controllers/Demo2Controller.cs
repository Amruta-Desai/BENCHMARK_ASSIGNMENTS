using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_SettingUp.Controllers
{
    public class Demo2Controller : ApiController
    {
        //public string get()
        //{
        //    return "Welcome to my first Web API";
        //}

        public List<string> get()
        {
            List<string> datalist = new List<string>();
            datalist.Add("data1");
            datalist.Add("data1");
            return datalist;    
        }
    }
}

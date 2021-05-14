using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BbsWebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            SqlConnection conn = new SqlConnection("server=127.0.0.1;port=3306;database=my_bbs;uid=root;pwd=password;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable res = ds.Tables[0];
            DataRow dr = res.Rows[0];
            var value = dr["UserNo"].ToString();

            return "Hello World!!!";
        }
        [HttpPost]
        public string Insert(string userNo, string password)
        {
            return "Hello World!!!";
        }
        [HttpPut]
        public string Update()
        {
            return "Hello World!!!";
        }
        [HttpDelete]
        public string Remove()
        {
            return "Hello World!!!";
        }
    }
}
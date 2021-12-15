using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace AppFoodApi.Controllers
{
    public class AppFoodController : ApiController
    {

        [Route("api/AppFoodController/testApi")]
        [HttpGet]

        public IHttpActionResult testApi()
        {
            return Ok("chao mưng bạn");
        }

        [Route("api/AppFoodController/GetNhaHang")]
        [HttpGet]

        public IHttpActionResult GetNhaHang()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("Get_Nhahang");
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }
            // GET: AppFood
            //public ActionResult Index()
            //{
            //    return View();
            //}
        }
}
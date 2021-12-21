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

        [Route("api/AppFoodController/TestApi")]
        [HttpGet]

        public IHttpActionResult TestApi()
        {
            return Ok("chao mưng bạn");
        }

        [Route("api/AppFoodController/GetNhaHang")]
        [HttpGet]

        public IHttpActionResult GetNhaHang()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("GetAllNhaHang");
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/GetMonAnNhaHang")]
        [HttpGet]

        public IHttpActionResult GetMonAnNhaHang(int manh)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("manh", manh);
                DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/InsertGioHang")]
        [HttpGet]

        public IHttpActionResult InsertGioHang(int mand, int mama)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                param.Add("mama", mama);
                //DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                DataTable result = Database.Database.ReadTable("InsertGioHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }


        [Route("api/AppFoodController/GetGioHang")]
        [HttpGet]

        public IHttpActionResult GetGioHang(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                //DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                DataTable result = Database.Database.ReadTable("GetGioHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/DeleteGioHang")]
        [HttpGet]

        public IHttpActionResult DeleteGioHang(int magh)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("magh", magh);
                //DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                //DataTable result = 
                    Database.Database.ReadTable("DeleteGioHang", param);
                return Ok(1);
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
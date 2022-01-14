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


        [Route("api/AppFoodController/CheckOneUser")]
        [HttpGet]

        public IHttpActionResult CheckOneUser(string username,string pw)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("username", username);
                param.Add("pw", pw);
                //DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                //DataTable result = 
                DataTable result = Database.Database.ReadTable("CheckOneUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }


        [Route("api/AppFoodController/CreateUser")]
        [HttpGet]

        public IHttpActionResult CreateUser(string username, string pw,string name, string SDT =null ,string EMAIL=null , DateTime? NGAYSINH=null)
        { 
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("username", username);
                param.Add("pw", pw);
                param.Add("hoten", name);
                param.Add("SDT ", SDT);
                param.Add("EMAIL", EMAIL);
                param.Add("NGAYSINH", NGAYSINH);
                //DataTable result = Database.Database.ReadTable("GetMonAnByNhaHang", param);
                //DataTable result = 
                DataTable result = Database.Database.ReadTable("CreateUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/InsertHoaDon")]
        [HttpGet]

        public IHttpActionResult InsertHoaDon(int mand, float tongtien,DateTime tgdat,DateTime tggiao,float ship)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                param.Add("tongtien", tongtien);
                param.Add("tgdat", tgdat);
                param.Add("tggiao", tggiao);
                param.Add("ship", ship);

                DataTable result = Database.Database.ReadTable("InsertHoaDon", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/InsertCTHoaDon")]
        [HttpGet]

        public IHttpActionResult InsertCTHoaDon(int mahd,int mama,int soluong)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mahd", mahd);
                param.Add("mama", mama);
                param.Add("soluong", soluong);

                DataTable result = Database.Database.ReadTable("InsertCTHoaDon", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/GetHoaDonByUser")]
        [HttpGet]

        public IHttpActionResult GetHoaDonByUser(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.Database.ReadTable("GetHoaDonByUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/AppFoodController/GetCTHoaDon")]
        [HttpGet]

        public IHttpActionResult GetCTHoaDon(int mahd)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mahd", mahd);
                DataTable result = Database.Database.ReadTable("GetCTHoaDon", param);
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
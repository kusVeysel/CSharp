using APIApplication.DB;
using APIApplication.Models;
using Newtonsoft.Json;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace APIApplication.Controllers
{
    [RoutePrefix("api/Emp")]
    public class EmpController : BaseController
    {
        [HttpGet]
        [Route("CalisanListe")]
        [SwaggerOperation(Tags = new[] { "Çalışan İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public List<EmpApiVM> CalisanListe()
        {
            List<EmpApiVM> resultList = new List<EmpApiVM>();
            List<Employees> dbEmpList = db2.Employees.ToList();
            List<Orders> dbOrderList = db2.Orders.ToList();

            foreach (Employees employee in dbEmpList)
            {
                List<SiparisApiVM> siparisVmList = new List<SiparisApiVM>();

                EmpApiVM vm = new EmpApiVM();
                vm.ID = employee.EmployeeID;
                vm.Isim = employee.FirstName;
                vm.Soyisim = employee.LastName;

                List<Orders> orderWithEmpID = dbOrderList.Where(x => x.EmployeeID == employee.EmployeeID).ToList();

                foreach (Orders order in orderWithEmpID)
                {
                    SiparisApiVM vmSip = new SiparisApiVM();
                    vmSip.ID = order.OrderID;
                    vmSip.Ulke = order.ShipCountry;
                    vmSip.Sehir = order.ShipCity;
                    vmSip.KargoAdres = order.ShipAddress;
                    //vmSip.KargoTarih = order.ShippedDate.Value.ToString("dd.MM.yyyy");
                    vmSip.SiparisTarih = order.OrderDate.Value.ToString("dd.MM.yyyy");

                    siparisVmList.Add(vmSip);
                }
                vm.SiparisListe = siparisVmList;
                resultList.Add(vm);
            }

            return resultList;
        }

        [HttpGet]
        [Route("CalisanDetay/{id}")]
        [SwaggerOperation(Tags = new[] { "Çalışan İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public EmpApiVM CalisanDetay(int ID)
        {
            EmpApiVM result = new EmpApiVM();
            Employees dbEmp = db2.Employees.Find(ID);
            List<Orders> dbOrderList = db2.Orders.ToList();

            List<SiparisApiVM> siparisVmList = new List<SiparisApiVM>();

            result.ID = dbEmp.EmployeeID;
            result.Isim = dbEmp.FirstName;
            result.Soyisim = dbEmp.LastName;

            List<Orders> orderWithEmpID = dbOrderList.Where(x => x.EmployeeID == dbEmp.EmployeeID).ToList();

            foreach (Orders order in orderWithEmpID)
            {
                SiparisApiVM vmSip = new SiparisApiVM();
                vmSip.ID = order.OrderID;
                vmSip.Ulke = order.ShipCountry;
                vmSip.Sehir = order.ShipCity;
                vmSip.KargoAdres = order.ShipAddress;
                //vmSip.KargoTarih = order.ShippedDate.Value.ToString("dd.MM.yyyy");
                vmSip.SiparisTarih = order.OrderDate.Value.ToString("dd.MM.yyyy");

                siparisVmList.Add(vmSip);
            }
            result.SiparisListe = siparisVmList;


            return result;
        }

        [HttpPost] // Action'ın tipi]
        [Route("AdminEkle")] // Action'ın adresi
        [SwaggerOperation(Tags = new[] { "Çalışan İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public IHttpActionResult InsertAdmin(Admin data)
        {
            if (data == null)
            {
                return Content(HttpStatusCode.BadRequest, "Admin verisi boş olamaz.");
            }

            db.Admin.Add(data);
            db.SaveChanges();

            return Content(HttpStatusCode.OK, "Admin başarıyla eklendi.");
        }

        [HttpPost] // Action'ın tipi]
        [Route("AdminEkleStr")] // Action'ın adresi
        [SwaggerOperation(Tags = new[] { "Çalışan İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public IHttpActionResult InsertAdminStr(string data)
        {
            try
            {
                Admin adminData = JsonConvert.DeserializeObject<Admin>(data);

                db.Admin.Add(adminData);
                db.SaveChanges();

                return Content(HttpStatusCode.OK, "Admin başarıyla eklendi.");

            }
            catch (Exception)
            {
                return Content(HttpStatusCode.BadRequest, "Geçersiz JSON formatı!");
            }

        }

        [HttpPost] // Action'ın tipi]
        [Route("AdminBul")] // Action'ın adresi
        [SwaggerOperation(Tags = new[] { "Çalışan İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public IHttpActionResult FindAdminWithName(string username, string phone)
        {
            Admin dbResult = db.Admin.Where(x => x.UserName == username && x.Telefon == phone).FirstOrDefault();

            if (dbResult == null)
            {
                return Content(HttpStatusCode.NotFound, "Admin bulunamadı.");
            }
            else
            {
                return Content(HttpStatusCode.OK, dbResult);
            }
        }

    }
}
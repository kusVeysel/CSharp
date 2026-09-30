using APIApplication.DB;
using System.Web.Http;

namespace APIApplication.Controllers
{
    public class BaseController : ApiController
    {
        protected VeyselEntities db = new VeyselEntities();
        protected NorthwindEntities db2 = new NorthwindEntities();
    }
}
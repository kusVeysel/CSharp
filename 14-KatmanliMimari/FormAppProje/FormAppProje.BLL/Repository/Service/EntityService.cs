using FormAppProje.BLL.Repository.Entity;

namespace FormAppProje.BLL.Repository.Service
{
    public class EntityService
    {
        // kısa yol için: ctor yazıp tab'a bas
        public EntityService()
        {
            _adminService = new AdminRepository();
            _urunService = new UrunRepository();
        }

        private AdminRepository _adminService;

        public AdminRepository AdminService
        {
            get { return _adminService; }
            set { _adminService = value; }
        }
        //public AdminRepository AdminService1 { get; set; }

        // açık property yazımının kısa yolu: propfull yazıp tab'a bas
        private UrunRepository _urunService;

        public UrunRepository UrunService
        {
            get { return _urunService; }
            set { _urunService = value; }
        }


    }
}

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
            _empService = new EmployessRepository();
            _orderService = new OrderRepository();
            _orderDetailService = new OrderDetailRepository();
        }

        //public AdminRepository AdminService1 { get; set; }

        // açık property yazımının kısa yolu: propfull yazıp 2 defa tab'a bas
        private AdminRepository _adminService;

        public AdminRepository AdminService
        {
            get { return _adminService; }
            set { _adminService = value; }
        }

        private UrunRepository _urunService;

        public UrunRepository UrunService
        {
            get { return _urunService; }
            set { _urunService = value; }
        }

        private EmployessRepository _empService;

        public EmployessRepository EmpService
        {
            get { return _empService; }
            set { _empService = value; }
        }

        private OrderRepository _orderService;

        public OrderRepository OrderService
        {
            get { return _orderService; }
            set { _orderService = value; }
        }

        private OrderDetailRepository _orderDetailService;

        public OrderDetailRepository OrderDetailService
        {
            get { return _orderDetailService; }
            set { _orderDetailService = value; }
        }



    }
}

using SuTakip.BLL.Repository.Entity;

namespace SuTakip.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _adminService = new AdminRepository();
            _boyutService = new BoyutRepository();
            _faturaService = new FaturaRepository();
            _kategoriService = new KategoriRepository();
            _kategoriUrunService = new KategoriUrunRepository();
            _listeFiyatService = new ListeFiyatRepository();
            _logTabloService = new LogTabloRepository();
            _materyalService = new MateryalRepository();
            _musteriService = new MusteriRepository();
            _odemeService = new OdemeRepository();
            _satinAlmaService = new SatinAlmaRepository();
            _siparisService = new SiparisRepository();
            _tedarikciService = new TedarikciRepository();
            _stokTabloService = new StokTabloRepository();
            _urunService = new UrunRepository();
        }

        private AdminRepository _adminService;
        public AdminRepository AdminService
        {
            get { return _adminService; }
            set { _adminService = value; }
        }

        private BoyutRepository _boyutService;
        public BoyutRepository BoyutService
        {
            get { return _boyutService; }
            set { _boyutService = value; }
        }

        private FaturaRepository _faturaService;
        public FaturaRepository FaturaService
        {
            get { return _faturaService; }
            set { _faturaService = value; }
        }

        private KategoriRepository _kategoriService;
        public KategoriRepository KategoriService
        {
            get { return _kategoriService; }
            set { _kategoriService = value; }
        }

        private KategoriUrunRepository _kategoriUrunService;
        public KategoriUrunRepository KategoriUrunService
        {
            get { return _kategoriUrunService; }
            set { _kategoriUrunService = value; }
        }

        private ListeFiyatRepository _listeFiyatService;
        public ListeFiyatRepository ListeFiyatService
        {
            get { return _listeFiyatService; }
            set { _listeFiyatService = value; }
        }

        private LogTabloRepository _logTabloService;
        public LogTabloRepository LogTabloService
        {
            get { return _logTabloService; }
            set { _logTabloService = value; }
        }

        private MateryalRepository _materyalService;
        public MateryalRepository MateryalService
        {
            get { return _materyalService; }
            set { _materyalService = value; }
        }

        private MusteriRepository _musteriService;
        public MusteriRepository MusteriService
        {
            get { return _musteriService; }
            set { _musteriService = value; }
        }

        private OdemeRepository _odemeService;
        public OdemeRepository OdemeService
        {
            get { return _odemeService; }
            set { _odemeService = value; }
        }

        private SatinAlmaRepository _satinAlmaService;
        public SatinAlmaRepository SatinAlmaService
        {
            get { return _satinAlmaService; }
            set { _satinAlmaService = value; }
        }

        private SiparisRepository _siparisService;
        public SiparisRepository SiparisService
        {
            get { return _siparisService; }
            set { _siparisService = value; }
        }

        private TedarikciRepository _tedarikciService;
        public TedarikciRepository TedarikciService
        {
            get { return _tedarikciService; }
            set { _tedarikciService = value; }
        }

        private StokTabloRepository _stokTabloService;
        public StokTabloRepository StokTabloService
        {
            get { return _stokTabloService; }
            set { _stokTabloService = value; }
        }

        private UrunRepository _urunService;
        public UrunRepository UrunService
        {
            get { return _urunService; }
            set { _urunService = value; }
        }
    }
}

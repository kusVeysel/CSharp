namespace CoreAPI.Models
{
    public static class Methods
    {
        public static List<KisiVM> DbKisiGetir()
        {

            KisiVM kisi1 = new KisiVM
            {
                ID = 1,
                Ad = "Veysel",
                Soyad = "Kaya",
                Email = "veyselkaya@example.com",
                Telefon = "1234567890"
            };
            KisiVM kisi2 = new KisiVM
            {
                ID = 2,
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Email = "ahmetyilmaz@example.com",
                Telefon = "0987654321"
            };
            KisiVM kisi3 = new KisiVM
            {
                ID = 3,
                Ad = "Mehmet",
                Soyad = "Demir",
                Email = "mehmetdemir@example.com",
                Telefon = "1111111111"
            };


            return new List<KisiVM>{kisi1, kisi2, kisi3}; 
        }
    }
}
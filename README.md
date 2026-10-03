# CSharp --- C# ve .NET Öğrenme Notları

Bu depo, **C# programlama dili** ve **.NET ekosistemi** konularını temel seviyeden başlayarak ileri konulara doğru öğrenmek için hazırlanmış örnekler, alıştırmalar ve proje notları içerir.

> **Not:** Aşağıdaki açıklamalar klasör adlarına göre hazırlanmıştır.
> Her klasördeki örneklerin kapsamı, klasör içeriği geliştikçe genişletilebilir.

------------------------------------------------------------------------

## 📁 Proje ve Konu Yapısı

  -----------------------------------------------------------------------
  Klasör                              İçerik / Amaç
  ----------------------------------- -----------------------------------
  `01-DeğişkenTipleri`                Değişken tanımlama, temel veri
                                      tipleri, sabitler ve tür
                                      dönüşümleri

  `02-IfElseYapisi`                   `if`, `else if`, `else` ve koşullu
                                      karar yapıları

  `03-HesapMakinesi`                  Temel işlemleri ve koşul yapılarını
                                      bir araya getiren hesap makinesi
                                      örneği

  `04-DizilerGenericlesitDonguler`    Diziler, döngüler ve Generic
                                      koleksiyonlara giriş

  `05-HazirMetotlar`                  C# ve .NET tarafından sunulan hazır
                                      metotların kullanımı

  `06-ClassYapisi`                    Sınıf, nesne, alan, özellik, metot
                                      ve kurucu metot kavramları

  `07-OOP`                            Nesne yönelimli programlama;
                                      kapsülleme, kalıtım, çok biçimlilik
                                      ve soyutlama

  `08-StringMetotlar`                 Metin işlemleri ve `string`
                                      sınıfının metotları

  `09-PizzaSiparisFormu`              Form ve sipariş akışını bir araya
                                      getiren örnek uygulama

  `10-SuStokTakipFormu`               Stok takibi ve form tabanlı
                                      uygulama örneği

  `11-MSSQL`                          Microsoft SQL Server ve ilişkisel
                                      veritabanı temelleri

  `12-AdoNet`                         C# uygulamalarından veritabanına
                                      ADO.NET ile bağlanma ve veri
                                      işlemleri

  `13-EntityFramework`                Entity Framework ile
                                      nesne-veritabanı eşlemesi ve veri
                                      erişimi

  `14-KatmanliMimari`                 Uygulamayı sorumluluklarına göre
                                      katmanlara ayırma

  `15-MVC`                            Model-View-Controller yaklaşımı ve
                                      web uygulaması düzeni

  `16-WebAPI`                         HTTP üzerinden veri sunan API uç
                                      noktaları geliştirme

  `17-CoreAPI(Temel)`                 ASP.NET Core Web API temelleri(VS Code üzerinden)

  `18-WebCoreAPI`                     ASP.NET Core Web API geliştirme ve
                                      ilgili yapılandırmalar

  `ConsoleMetotlari`                  Konsol uygulamalarında kullanılan
                                      metotlar ve örnekler
  -----------------------------------------------------------------------

------------------------------------------------------------------------

## 🧭 Önerilen Öğrenme Sırası

Klasörler numaralandırılarak temel konulardan uygulama geliştirmeye doğru bir sıra oluşturulmuştur:

1.  **C# temelleri:** Değişkenler, veri tipleri ve koşullar
2.  **Kontrol ve veri yapıları:** Döngüler, diziler ve koleksiyonlar
3.  **Metotlar ve sınıflar:** Hazır metotlar, sınıf yapısı ve OOP
4.  **Uygulama örnekleri:** Hesap makinesi, sipariş formu ve stok takip
    formu
5.  **Veritabanı:** MSSQL, ADO.NET ve Entity Framework
6.  **Uygulama mimarisi:** Katmanlı mimari ve MVC
7.  **Web geliştirme:** Web API ve ASP.NET Core Web API

Konuları yalnızca okuyarak değil, örnekleri çalıştırıp değiştirerek ve benzer küçük uygulamalar yazarak pekiştirin.

------------------------------------------------------------------------

## 🏗️ Katmanlı Mimari

`14-KatmanliMimari` klasöründe katmanlı mimariye ilişkin çalışmalar bulunur. Amaç, uygulamanın farklı sorumluluklarını ayrı projelerde veya klasörlerde düzenlemektir.

Yaygın bir örnek yapı:

-   **UI / Presentation:** Kullanıcı arayüzü ve kullanıcı etkileşimleri
-   **BLL / Business Logic:** İş kuralları, doğrulamalar ve süreç
    yönetimi
-   **DAL / Data Access:** Veritabanı erişimi ve veri kalıcılığı
-   **Entities / Models:** Uygulamada kullanılan veri modelleri

Katmanların ve proje isimlerinin tam düzeni uygulamanın ihtiyacına göre değişebilir. Katmanlar ayrı projeler olarak oluşturulduğunda, gerekli bağlantılar **Project Reference** ile tanımlanır. Bir katmanın yalnızca ihtiyaç duyduğu diğer katmanlara bağımlı olması hedeflenir.

------------------------------------------------------------------------

## 🌐 Web API ve Swagger

`16-WebAPI`, `17-CoreAPI(Temel)` ve `18-WebCoreAPI` klasörleri web API konularıyla ilgilidir.

Web API, HTTP istekleri aracılığıyla veriye veya uygulama işlevlerine erişim sağlar. Yaygın HTTP metotları:

-   `GET`: Veri okuma
-   `POST`: Yeni veri oluşturma
-   `PUT`: Var olan veriyi güncelleme
-   `DELETE`: Veri silme

ASP.NET Core projelerinde Swagger / OpenAPI, API uç noktalarını belgelemek ve desteklenen istekleri tarayıcı üzerinden denemek için kullanılabilir. Projede Swagger arayüzünün etkinleştirilmiş olması gerekir; adres çoğunlukla `/swagger` olur.

------------------------------------------------------------------------

## 🗄️ MSSQL, ADO.NET ve Entity Framework

Veritabanı konuları şu klasörlerde ele alınır:

-   `11-MSSQL`: SQL Server ve SQL sorgularının temelleri
-   `12-AdoNet`: Bağlantı, komut çalıştırma ve sonuçları okuma gibi
    ADO.NET işlemleri
-   `13-EntityFramework`: C# modelleri ile veritabanı tabloları arasında
    eşleme ve veri erişimi

### Entity Framework Core için yaygın paketler

ASP.NET Core / EF Core projesinin sürümüne ve kullanılan araçlara göre gerekli paketler değişebilir. SQL Server kullanılan bir EF Core projesinde genellikle şu paketler değerlendirilir:

-   `Microsoft.EntityFrameworkCore.SqlServer`: SQL Server sağlayıcısı
-   `Microsoft.EntityFrameworkCore.Design`: Tasarım zamanı işlemleri
-   `Microsoft.EntityFrameworkCore.Tools`: Visual Studio Package Manager
    Console araçları

Paket sürümlerinin, projenin kullandığı .NET ve EF Core sürümleriyle uyumlu olmasına dikkat edin.

### Migration komutları

Aşağıdaki komutlar, EF Core araçları kurulu ve proje yapılandırması tamamlanmışsa kullanılabilir:

``` bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Birden fazla proje bulunan çözümlerde başlangıç projesini ve `DbContext` sınıfının bulunduğu projeyi ayrıca belirtmek gerekebilir. Örneğin:

``` bash
dotnet ef migrations add InitialCreate --project ./VeriErisimProjesi --startup-project ./WebApiProjesi
dotnet ef database update --project ./VeriErisimProjesi --startup-project ./WebApiProjesi
```

`VeriErisimProjesi` ve `WebApiProjesi` örnek isimlerdir; kendi proje
adlarınızla değiştirilmelidir.

------------------------------------------------------------------------

## 🛠️ .NET CLI Komutları

.NET SDK kurulumunu ve projeyi terminal üzerinden yönetmek için temel komutlar:

### SDK kontrolü

``` bash
dotnet --version
dotnet --list-sdks
```

-   `dotnet --version`: Kullanılan varsayılan SDK sürümünü gösterir.
-   `dotnet --list-sdks`: Sistemde yüklü SDK sürümlerini listeler.

### Yeni Web API projesi oluşturma

``` bash
dotnet new webapi -n OrnekWebApi
cd OrnekWebApi
```

`OrnekWebApi`, örnek proje adıdır.

### Derleme ve çalıştırma

``` bash
dotnet restore
dotnet build
dotnet run
```

-   `dotnet restore`: Proje bağımlılıklarını geri yükler.
-   `dotnet build`: Projeyi derler ve derleme hatalarını gösterir.
-   `dotnet run`: Uygulamayı çalıştırır.

Geliştirme sırasında dosya değişikliklerini izleyerek çalıştırmak için:

``` bash
dotnet watch run
```

Komutları, ilgili `.csproj` dosyasının bulunduğu proje dizininde çalıştırın. Birden fazla proje içeren bir çözümde doğru dizinde olduğunuzu kontrol edin.

------------------------------------------------------------------------

## ▶️ Örnekleri Çalıştırma

Klasörlerin her biri bağımsız bir proje veya örnek içerebilir. Genel olarak:

1.  İlgili klasörü VS Code veya Visual Studio ile açın.
2.  Projenin `.csproj` dosyasının bulunduğu dizine geçin.
3.  Terminalde `dotnet restore` komutunu çalıştırın.
4.  Derleme kontrolü için `dotnet build` komutunu çalıştırın.
5.  Konsol veya web uygulamasını çalıştırmak için `dotnet run` komutunu
    kullanın.

Bazı örnekler Windows Forms gibi belirli bir çalışma ortamı gerektirebilir. Bu tür projelerde `.csproj` dosyasındaki hedef framework ve proje türünü kontrol edin.

------------------------------------------------------------------------

## 💡 Geliştirme Notları

-   Kod örneklerinde anlamlı değişken ve metot isimleri kullanın.
-   Her örneği çalıştırdıktan sonra değerleri veya koşulları
    değiştirerek sonucu gözlemleyin.
-   Hata mesajlarını dikkatlice okuyun; çoğu zaman sorunlu dosya ve
    satır hakkında bilgi verir.
-   Veritabanı bağlantı bilgileri ve parolalar gibi gizli bilgileri Git
    deposuna eklemeyin. Geliştirme ortamında yapılandırma dosyaları veya
    ortam değişkenleri kullanın.
-   Yeni konu veya örnek eklediğinizde bu README dosyasındaki klasör
    tablosunu güncelleyin.

------------------------------------------------------------------------

## 🎯 Amaç

Bu depo, C# temellerinden başlayarak nesne yönelimli programlama, veritabanı erişimi, katmanlı mimari ve ASP.NET Core Web API geliştirmeye uzanan kişisel bir öğrenme alanıdır. Her klasör ilgili konuyu küçük örnekler ve uygulamalar üzerinden pekiştirmek amacıyla düzenlenmiştir.

---

**Veysel KUŞ**
# CSharp Notları

Bu depo, **C# programlama dilini ve .NET ekosistemini temelden başlayarak öğrenmek** için hazırlanmış örnekler, alıştırmalar ve uygulama projeleri içerir. İçerik; temel dil özelliklerinden nesne yönelimli programlamaya, veritabanı işlemlerinden ASP.NET Web API geliştirmeye kadar ilerleyen bir öğrenme sırasına göre düzenlenmiştir.

> \[!NOTE\]
> Açıklamalar mevcut klasör yapısı ve proje adları temel alınarak hazırlanmıştır. Klasörlerdeki örnekler geliştikçe bu doküman da güncellenebilir.

## 📑 İçindekiler

* [📂 Depo Yapısı](#-depo-yapısı)

* [🎯 Önerilen Öğrenme Sırası](#-önerilen-öğrenme-sırası)

* [🛠️ Teknik Bilgiler](#️-teknik-bilgiler)

  * [14 - Katmanlı Mimari](#14---katmanlı-mimari)

  * [16 - ASP.NET Web API (.NET Framework) + Swagger](#16---aspnet-web-api-net-framework--swagger)

  * [17 - ASP.NET Core Web API (Temel) & .NET CLI](#17---aspnet-core-web-api-temel--net-cli)

  * [18 - ASP.NET Core Web API + JWT & EF Core](#18---aspnet-core-web-api--jwt--ef-core)

* [💡 HTTP Metotları](#-http-metotları)

* [📝 Geliştirme Notları](#-geliştirme-notları)

* [📌 Amaç](#-amaç)

## 📂 Depo Yapısı

| Klasör | İçerik | 
| ----- | ----- | 
| `01-DegiskenTipleri` | Değişkenler, temel veri tipleri ve değer atama | 
| `02-IfElseYapisi` | `if`, `else if`, `else` ve koşullu işlem akışı | 
| `03-HesapMakinesi` | Temel matematiksel işlemleri uygulayan örnek | 
| `04-DizilerGenericListDonguler` | Diziler, `List<T>` ve döngüler | 
| `05-HazirMetotlar` | .NET'in hazır metotları ve sık kullanılan işlemler | 
| `06-ClassYapisi` | Sınıflar, nesneler, alanlar, özellikler ve metotlar | 
| `07-OOP` | Nesne yönelimli programlama yaklaşımı | 
| `08-StringMetotlar` | Metin işlemleri ve `string` metotları | 
| `09-PizzaSiparisFormu` | Sipariş formu üzerinden uygulama geliştirme | 
| `10-SuStokTakipFormu` | Stok takibi odaklı uygulama örneği | 
| `11-MSSQL` | Microsoft SQL Server ve veritabanı temelleri | 
| `12-AdoNet` | ADO.NET ile veritabanı bağlantısı ve veri işlemleri | 
| `13-EntityFramework` | Entity Framework ile nesne tabanlı veritabanı işlemleri | 
| `14-KatmanliMimari` | Katmanlı mimari ve projelerin sorumluluklara ayrılması | 
| `15-MVC` | MVC mimarisiyle web uygulaması geliştirme | 
| `16-WebAPI` | ASP.NET Web API — .NET Framework tabanlı çalışma | 
| `17-CoreAPI(Temel)` | VS Code ve .NET CLI ile temel ASP.NET Core Web API | 
| `18-WebCoreAPI` | ASP.NET Core Web API ve Entity Framework Core çalışmaları | 
| `ConsoleMetotlari` | Konsol uygulamalarında kullanılan metot ve örnekler | 

## 🎯 Önerilen Öğrenme Sırası

Klasörler numaralandırılarak temel konulardan daha kapsamlı uygulamalara doğru ilerleyecek şekilde düzenlenmiştir.

1. **C# Temelleri:** Değişkenler, veri tipleri ve koşul yapıları (`01` - `03`).

2. **Kontrol ve Koleksiyon Yapıları:** Döngüler, diziler ve `List<T>` (`04`).

3. **Metotlar ve OOP:** Hazır metotlar, sınıflar, nesneler ve OOP prensipleri (`05` - `08`).

4. **Masaüstü / Form Uygulamaları:** Pizza sipariş formu ve su stok takip formu (`09` - `10`).

5. **Veritabanı Erişim Yöntemleri:** MSSQL, ADO.NET ve Entity Framework (`11` - `13`).

6. **Uygulama Mimarileri:** Katmanlı mimari ve MVC (`14` - `15`).

7. **Web API & Web Servisleri:** .NET Framework Web API ve ASP.NET Core Web API (`16` - `18`).

## 🛠️ Teknik Bilgiler

### 14 - Katmanlı Mimari

`14-KatmanliMimari` klasörü, uygulama sorumluluklarını ayrı katmanlara ayırma yaklaşımını ele alır. Böylece iş kuralları, veri erişimi ve kullanıcı arayüzü birbirinden ayrılır; kodun bakımı ve test edilmesi kolaylaşır.

> \[!IMPORTANT\]
> Proje veya namespace isimlendirmesinde `.` alt klasör/katman mantığına karşılık gelir. Bu yüzden katman isimlendirmelerinde sonuna `/` değil `.` tercih edilir (Örn: `Uygulama.BLL`).

Yaygın katman düzeni:

| Katman | Sorumluluk | 
| ----- | ----- | 
| **UI / Presentation** | Kullanıcı arayüzü ve kullanıcı etkileşimleri | 
| **BLL / Business Logic** | İş kuralları, doğrulamalar ve uygulama akışı | 
| **DAL / Data Access** | Veritabanına erişim ve veri okuma/yazma işlemleri | 
| **Entities / Models** | Uygulamada kullanılan veri modelleri | 

#### Visual Studio'da Örnek Kurulum

1. Önce boş bir **Solution** oluşturun.

2. Kullanıcı arayüzü projesini ekleyin (Örn: `Uygulama.UI`).

3. Solution'a sağ tıklayıp **Add → New Project** diyerek `Class Library` türünde katman projelerini ekleyin: `Uygulama.BLL`, `Uygulama.DAL` ve `Uygulama.Entities`.

4. Projeniz **Core** ise Class Library'leri de **Core** formatında oluşturduğunuzdan emin olun.

5. Katman bağımlılıklarını **Add → Project Reference** üzerinden tanımlayın (UI → BLL → DAL/Entities).

### 16 - ASP.NET Web API (.NET Framework) + Swagger

Bu klasör, klasik .NET Framework tabanlı Web Application şablonu kullanılarak geliştirilen Web API çalışmalarını içerir.

#### Swagger / OpenAPI Entegrasyonu

API uç noktalarını tarayıcı üzerinden test etmek için Swagger kullanılır.

* **ASP.NET Core:** Referanslara sağ tık → *Manage NuGet Packages* → `Swashbuckle.AspNetCore` paketini yükleyin.

* **.NET Framework:** Referanslara sağ tık → *Manage NuGet Packages* → `Swashbuckle` paketini yükleyin.

> \[!TIP\]
> Projeyi çalıştırdıktan sonra varsayılan olarak adresin sonuna `/swagger` ekleyerek Swagger UI arayüzüne erişebilirsiniz.

### 17 - ASP.NET Core Web API (Temel) & .NET CLI

> \[!IMPORTANT\]
> Bu klasördeki çalışmalar VS Code ve .NET CLI kullanılarak yürütülmüştür.

#### 💻 .NET CLI Komutları

Komutları ilgili proje veya solution dosyasının bulunduğu dizinde çalıştırın:

* **SDK Bilgileri:**

  ```
  dotnet --version
  dotnet --list-sdks
  
  ```

* **Web API Projesi Oluşturma:**

  ```
  dotnet new webapi -n ProjeAdi
  
  ```

* **Derleme ve Çalıştırma:**

  ```
  dotnet build
  dotnet run
  
  ```

* **Canlı Kod İzleme (Hot Reload):**

  ```
  dotnet watch run
  
  ```

### 18 - ASP.NET Core Web API + JWT & EF Core

Bu klasör, modern ASP.NET Core Web API, JWT (JSON Web Token) tabanlı kimlik doğrulama ve Entity Framework Core kullanarak veritabanı işlemlerini kapsar.

#### 📦 Gerekli Paketler

SQL Server destekli bir EF Core projesinde kullanılabilecek temel paketler:

* `Microsoft.EntityFrameworkCore.SqlServer`

* `Microsoft.EntityFrameworkCore.Design`

* `Microsoft.EntityFrameworkCore.Tools`

#### 🔄 EF Core Migration İşlemleri

Projenin bulunduğu dizinde terminal üzerinden migration komutları:

* **Migration Oluşturma:**

  ```
  dotnet ef migrations add InitialCreate --project .\proje_adi\
  
  ```

* **Veritabanını Güncelleme:**

  ```
  dotnet ef database update --project .\proje_adi\
  
  ```

> \[!WARNING\]
> `database update` komutu veritabanı şemasını doğrudan değiştirir. Canlı veya paylaşılan veritabanlarında çalıştırmadan önce bağlantı dizesini kontrol edip yedek aldığınızdan emin olun.

## 💡 HTTP Metotları

| Metot | Kullanım Amacı | 
| ----- | ----- | 
| `GET` | Veri okumak / listelemek | 
| `POST` | Yeni bir kaynak/veri oluşturmak | 
| `PUT` | Bir kaynağı bütünüyle güncellemek | 
| `PATCH` | Bir kaynağın sadece belirli alanlarını güncellemek | 
| `DELETE` | Bir kaynağı silmek | 

## 📝 Geliştirme Notları

* **İsimlendirme Standartları:** Değişken, sınıf ve metot isimlerini yaptıkları işe uygun (PascalCase / camelCase) seçin.

* **Pratik Yapma:** Kodları sadece okumak yerine değiştirerek ve breakpoint koyup adım adım izleyerek test edin.

* **Sürüm Uyumluluğu:** Kullanılan .NET SDK sürümü ile NuGet paketlerinin (örneğin EF Core paketlerinin) sürümlerinin aynı/uyumlu olduğundan emin olun.

* **Güvenlik & Hassas Veriler:** Veritabanı bağlantı cümleleri (Connection String), API anahtarları veya JWT secret key bilgilerini açık şekilde depoya pushlamayın.

## 📌 Amaç

Bu depo, C# temellerinden başlayarak nesne yönelimli programlama, uygulama geliştirme, SQL Server ile veri erişimi, katmanlı mimari ve ASP.NET Web API konularına uzanan kişisel bir öğrenme alanıdır. Amaç, her konuyu küçük ve anlaşılır örneklerle öğrenmek, ardından bu bilgileri gerçekçi uygulamalar üzerinde pekiştirmektir.

**Veysel KUŞ**
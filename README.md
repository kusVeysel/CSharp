# CSharp Notları

Bu depo, **C# programlama dilini ve .NET ekosistemini temelden başlayarak öğrenmek** için hazırlanmış örnekler, alıştırmalar ve uygulama projeleri içerir. İçerik; temel dil özelliklerinden nesne yönelimli programlamaya, veritabanı işlemlerinden ASP.NET Web API geliştirmeye kadar ilerleyen bir öğrenme sırasına göre düzenlenmiştir.

> [!NOTE]
> Açıklamalar mevcut klasör yapısı ve proje adları temel alınarak hazırlanmıştır. Klasörlerdeki örnekler geliştikçe bu doküman da güncellenebilir.

---

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

---

## 📂 Depo Yapısı

| Klasör | İçerik |
|---|---|
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

---

## 🎯 Önerilen Öğrenme Sırası

Klasörler numaralandırılarak temel konulardan daha kapsamlı uygulamalara doğru ilerleyecek şekilde düzenlenmiştir.

1. **C# Temelleri:** Değişkenler, veri tipleri ve koşul yapıları (`01` - `03`).

2. **Kontrol ve Koleksiyon Yapıları:** Döngüler, diziler ve `List<T>` (`04`).

3. **Metotlar ve OOP:** Hazır metotlar, sınıflar, nesneler ve OOP prensipleri (`05` - `08`).

4. **Masaüstü / Form Uygulamaları:** Pizza sipariş formu ve su stok takip formu (`09` - `10`).

5. **Veritabanı Erişim Yöntemleri:** MSSQL, ADO.NET ve Entity Framework (`11` - `13`).

6. **Uygulama Mimarileri:** Katmanlı mimari ve MVC (`14` - `15`).

7. **Web API & Web Servisleri:** .NET Framework Web API ve ASP.NET Core Web API (`16` - `18`).

Her örneği çalıştırıp kod üzerinde küçük değişiklikler yapmak, yalnızca kodu okumaya kıyasla konuları daha iyi pekiştirir.

---

## 🛠️ Teknik Bilgiler

### Katmanlı Mimari

`14-KatmanliMimari` klasörü, uygulama sorumluluklarını ayrı katmanlara ayırma yaklaşımını ele alır. Böylece iş kuralları, veri erişimi ve kullanıcı arayüzü birbirinden ayrılır; kodun bakımı ve test edilmesi kolaylaşır.

>[!IMPORTANT]
> Proje veya namespace isimlendirmesinde `.` alt klasör/katman mantığına karşılık gelir. Bu yüzden katman isimlendirmelerinde sonuna `/` değil `.` tercih edilir (Örn: `Uygulama.BLL`).

Yaygın bir katman düzeni şöyledir:

| Katman | Sorumluluk |
|---|---|
| **UI / Presentation** | Kullanıcı arayüzü ve kullanıcı etkileşimleri |
| **BLL / Business Logic** | İş kuralları, doğrulamalar ve uygulama akışı |
| **DAL / Data Access** | Veritabanına erişim ve veri okuma/yazma işlemleri |
| **Entities / Models** | Uygulamada kullanılan veri modelleri |

#### Visual Studio'da örnek kurulum

1. Önce bir **Solution** oluşturun. Solution adı, uygulamanın genel adını temsil eder.
2. Kullanıcı arayüzü için uygun bir proje ekleyin. Proje adını örneğin `Uygulama.UI` biçiminde belirleyebilirsiniz.
3. Solution'a sağ tıklayıp **Add → New Project** yoluyla `Class Library` türünde projeler ekleyin: `Uygulama.BLL`, `Uygulama.DAL` ve gerekiyorsa `Uygulama.Entities`.
4. Projelerin hedef framework sürümlerinin birbiriyle uyumlu olduğundan emin olun.Projeniz **Core** ise Class Library **Core** formatında açın
5. Gerekli bağımlılıkları **Add → Project Reference** üzerinden tanımlayın.

Bağımlılıkları mümkün olduğunca tek yönlü tutun. Örneğin UI katmanı BLL katmanını, BLL ise ihtiyaç duyduğu veri erişimi veya model katmanlarını kullanabilir. Katmanların birbirini karşılıklı referans etmesi, zamanla bakım ve test süreçlerini zorlaştırabilir.

> [!IMPORTANT]
> Proje türünü seçerken hedef platformu kontrol edin. Modern .NET projeleri için genellikle uygun sürümde **Class Library** kullanılır. Eski **.NET Framework** projelerinde ise hedef framework ile uyumlu proje şablonu seçilmelidir. Proje adlarındaki `.UI`, `.BLL` ve `.DAL` gibi uzantılar bir zorunluluk değil, yaygın bir isimlendirme tercihidir.

Varsayılan sınıf dosyalarını, projede kullanılmayacaklarsa silebilirsiniz.

---

### `16-WebAPI` — ASP.NET Web API (.NET Framework) + Swagger
Bu klasör, ASP.NET Web Application (.NET Framework) tabanlı Web API çalışmalarını içerir. Proje oluştururken uygun Web API şablonu seçilir. Bu yapı, klasik .NET Framework tabanlı web servisleri geliştirmek için kullanılır.


#### Swagger / OpenAPI

API uç noktalarını tarayıcı üzerinden test etmek için Swagger kullanılır.Swagger'a ulaşmak için projeyi çalıştırın(f5) ve adresin devamına `/swagger` yazın.

**Swagger Ekleme**
* **ASP.NET Core:** Dependencies sağ tık → *Manage NuGet Packages* → `Swashbuckle.AspNetCore` paketini yükleyin.

* **.NET Framework:** Referanslara sağ tık → *Manage NuGet Packages* → `Swashbuckle` paketini yükleyin.

> [!TIP]
> Swagger sayfası açılmıyorsa önce projenin başarıyla çalıştığını, doğru adres ve portu kullandığınızı, ardından Swagger servislerinin ve middleware yapılandırmasının projede bulunduğunu kontrol edin.

---

### `17-CoreAPI(Temel)` — ASP.NET Core Web API

>[!IMPORTANT]
> Bu klasördeki çalışma VS Code ve .NET CLI üzerinden yürütülmüştür. Projeyi terminalden oluşturmak, derlemek ve çalıştırmak için `.NET CLI` komutları kullanılabilir.

### 💻 .NET CLI Komutları

Komutları, ilgili proje veya solution dosyasının bulunduğu terminal dizininde çalıştırın.

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

---

## `18-WebCoreAPI` — ASP.NET Core Web API + JWT + EF Core

Bu klasör, modern ASP.NET Core Web API, JWT (JSON Web Token) tabanlı kimlik doğrulama ve Entity Framework Core kullanarak veritabanı işlemlerini kapsar.

### Entity Framework Core ve Migration

Entity Framework Core, .NET nesneleri üzerinden veritabanıyla çalışmayı sağlayan bir ORM aracıdır. **Migration**, model değişikliklerini veritabanı şemasına taşımak için kullanılır.

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

### Migration oluşturma

Proje dosyasının bulunduğu dizinde temel kullanım:

```bash
dotnet ef migrations add InitialCreate --project .\project_name\
```

- `migrations add`: Yeni migration oluşturur.
- `InitialCreate`: Migration için verdiğiniz addır; farklı bir isim de seçebilirsiniz.
- `--project`: Migration ve `DbContext` yapılandırmasının bulunduğu projeyi belirtir.

Yukarıdaki proje yollarını kendi solution yapınıza göre değiştirin. `DbContext` ve bağlantı yapılandırması doğru tanımlanmış olmalıdır.

### Migration'ı veritabanına uygulama

```bash
dotnet ef database update --project .\project_name\
```

> [!WARNING]
> `database update` komutu veritabanı şemasını doğrudan değiştirir. Canlı veya paylaşılan veritabanlarında çalıştırmadan önce bağlantı dizesini kontrol edip yedek aldığınızdan emin olun.

---

### 💡 HTTP metotları

| Metot | Kullanım amacı |
|---|---|
| `GET` | Veri okumak |
| `POST` | Yeni bir kaynak oluşturmak |
| `PUT` | Bir kaynağı bütünüyle güncellemek |
| `PATCH` | Bir kaynağın belirli alanlarını güncellemek |
| `DELETE` | Bir kaynağı silmek |

## 📝 Geliştirme Notları

- **İsimlendirme:** Değişken, sınıf ve metot adlarını yaptıkları işi anlatacak şekilde seçin.
- **Küçük adımlarla ilerleme:** Örnekleri çalıştırın; parametreleri, koşulları ve verileri değiştirerek sonuçları inceleyin.
- **Hata ayıklama:** Hata mesajında belirtilen dosya, satır ve hata türünü kontrol edin. Gerekirse hatayı küçük bir örneğe indirerek araştırın.
- **Sürüm uyumluluğu:** .NET, NuGet paketleri ve Entity Framework Core sürümlerinin birbiriyle uyumlu olmasına dikkat edin.
- **Gizli bilgiler:** Veritabanı parolalarını, API anahtarlarını ve bağlantı dizelerindeki gizli bilgileri Git deposuna eklemeyin. Geliştirme ortamında güvenli yapılandırma yöntemlerini tercih edin.
- **README güncelliği:** Yeni klasör veya proje eklendiğinde depo yapısı tablosunu ve ilgili açıklamaları güncelleyin.

---

## 📌 Amaç

Bu depo, C# temellerinden başlayarak nesne yönelimli programlama, uygulama geliştirme, SQL Server ile veri erişimi, katmanlı mimari ve ASP.NET Web API konularına uzanan kişisel bir öğrenme alanıdır. Amaç, her konuyu küçük ve anlaşılır örneklerle öğrenmek, ardından bu bilgileri gerçekçi uygulamalar üzerinde kullanabilmektir.

---

**Veysel KUŞ**

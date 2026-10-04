# CSharp Notları

Bu depo, **C# programlama dilini ve .NET ekosistemini temelden başlayarak öğrenmek** için hazırlanmış örnekler, alıştırmalar ve uygulama projeleri içerir. İçerik; temel dil özelliklerinden nesne yönelimli programlamaya, veritabanı işlemlerinden ASP.NET Web API geliştirmeye kadar ilerleyen bir öğrenme sırasına göre düzenlenmiştir.

> [!NOTE]
> Açıklamalar mevcut klasör yapısı ve proje adları temel alınarak hazırlanmıştır. Klasörlerdeki örnekler geliştikçe bu doküman da güncellenebilir.

---

## İçindekiler

- [Depo Yapısı](#depo-yapısı)
- [Önerilen Öğrenme Sırası](#önerilen-öğrenme-sırası)
- [Katmanlı Mimari](#katmanlı-mimari)
- [Web API ve Swagger](#web-api-ve-swagger)
- [.NET CLI Komutları](#net-cli-komutları)
- [Entity Framework Core ve Migration](#entity-framework-core-ve-migration)
- [Geliştirme Notları](#geliştirme-notları)
- [Amaç](#amaç)

---

## Depo Yapısı

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

> Klasör açıklamaları isimlerine göre özetlenmiştir; her klasördeki gerçek içerik zamanla farklılaşabilir.

---

## Önerilen Öğrenme Sırası

Klasörler numaralandırılarak temel konulardan daha kapsamlı uygulamalara doğru ilerleyecek şekilde düzenlenmiştir.

1. **C# temelleri:** Değişkenler, veri tipleri ve koşul yapıları.
2. **Kontrol ve koleksiyon yapıları:** Döngüler, diziler ve `List<T>`.
3. **Metotlar ve nesne yönelimli programlama:** Hazır metotlar, sınıflar, nesneler ve OOP.
4. **Küçük uygulamalar:** Hesap makinesi, pizza sipariş formu ve su stok takip formu.
5. **Veritabanı erişimi:** MSSQL, ADO.NET ve Entity Framework.
6. **Uygulama mimarileri:** Katmanlı mimari ve MVC.
7. **Web servisleri:** .NET Framework Web API ve ASP.NET Core Web API.

Her örneği çalıştırıp kod üzerinde küçük değişiklikler yapmak, yalnızca kodu okumaya kıyasla konuları daha iyi pekiştirir.

---

## Teknik Bilgiler

## Katmanlı Mimari

`14-KatmanliMimari` klasörü, uygulama sorumluluklarını ayrı katmanlara ayırma yaklaşımını ele alır. Böylece iş kuralları, veri erişimi ve kullanıcı arayüzü birbirinden ayrılır; kodun bakımı ve test edilmesi kolaylaşır.

Yaygın bir katman düzeni şöyledir:

| Katman | Sorumluluk |
|---|---|
| **UI / Presentation** | Kullanıcı arayüzü ve kullanıcı etkileşimleri |
| **BLL / Business Logic** | İş kuralları, doğrulamalar ve uygulama akışı |
| **DAL / Data Access** | Veritabanına erişim ve veri okuma/yazma işlemleri |
| **Entities / Models** | Uygulamada kullanılan veri modelleri |

### Visual Studio'da örnek kurulum

1. Önce bir **Solution** oluşturun. Solution adı, uygulamanın genel adını temsil eder.
2. Kullanıcı arayüzü için uygun bir proje ekleyin. Proje adını örneğin `Uygulama.UI` biçiminde belirleyebilirsiniz.
3. Solution'a sağ tıklayıp **Add → New Project** yoluyla `Class Library` türünde projeler ekleyin: `Uygulama.BLL`, `Uygulama.DAL` ve gerekiyorsa `Uygulama.Entities`.
4. Projelerin hedef framework sürümlerinin birbiriyle uyumlu olduğundan emin olun.
5. Gerekli bağımlılıkları **Add → Project Reference** üzerinden tanımlayın.

Bağımlılıkları mümkün olduğunca tek yönlü tutun. Örneğin UI katmanı BLL katmanını, BLL ise ihtiyaç duyduğu veri erişimi veya model katmanlarını kullanabilir. Katmanların birbirini karşılıklı referans etmesi, zamanla bakım ve test süreçlerini zorlaştırabilir.

> [!IMPORTANT]
> Proje türünü seçerken hedef platformu kontrol edin. Modern .NET projeleri için genellikle uygun sürümde **Class Library** kullanılır. Eski **.NET Framework** projelerinde ise hedef framework ile uyumlu proje şablonu seçilmelidir. Proje adlarındaki `.UI`, `.BLL` ve `.DAL` gibi uzantılar bir zorunluluk değil, yaygın bir isimlendirme tercihidir.

Varsayılan sınıf dosyalarını, projede kullanılmayacaklarsa silebilirsiniz.

---


### `16-WebAPI` — ASP.NET Web API (.NET Framework)
Bu klasör, ASP.NET Web Application (.NET Framework) tabanlı Web API çalışmalarını içerir. Proje oluştururken uygun Web API şablonu seçilir. Bu yapı, klasik .NET Framework tabanlı web servisleri geliştirmek için kullanılır.


### Swagger / OpenAPI

Swagger arayüzü, API uç noktalarını görüntülemek ve istekleri tarayıcı üzerinden denemek için kullanılabilir.

- **ASP.NET Core:** Projede OpenAPI/Swagger yapılandırmasının ve gerekli paketlerin bulunduğundan emin olun. Projeyi çalıştırdıktan sonra yapılandırılmış Swagger adresini açın; çoğu geliştirme şablonunda bu adres `/swagger` yoludur.
- **ASP.NET Web API (.NET Framework):** Swagger desteği projeye ayrıca eklenmiş olabilir. Eski projelerde yaygın seçeneklerden biri **Swashbuckle** paketidir.

Visual Studio'da paket eklemek için **Project → Manage NuGet Packages** bölümünü kullanabilirsiniz. Paket seçimini projenin .NET Framework veya modern .NET tabanlı olmasına göre yapın; aynı paket ve kurulum adımları her iki proje türü için geçerli olmayabilir.

> [!TIP]
> Swagger sayfası açılmıyorsa önce projenin başarıyla çalıştığını, doğru adres ve portu kullandığınızı, ardından Swagger servislerinin ve middleware yapılandırmasının projede bulunduğunu kontrol edin.

---

### `17-CoreAPI(Temel)` — ASP.NET Core Web API

Bu klasördeki çalışma VS Code ve .NET CLI üzerinden yürütülmüştür. Projeyi terminalden oluşturmak, derlemek ve çalıştırmak için `.NET CLI` komutları kullanılabilir.

## .NET CLI Komutları

Komutları, ilgili proje veya solution dosyasının bulunduğu terminal dizininde çalıştırın.

### SDK bilgileri

```bash
dotnet --version
dotnet --list-sdks
dotnet --list-runtimes
```

- `dotnet --version`: Varsayılan olarak kullanılan SDK sürümünü gösterir.
- `dotnet --list-sdks`: Bilgisayarda kurulu .NET SDK sürümlerini listeler.
- `dotnet --list-runtimes`: Kurulu .NET çalışma zamanı sürümlerini listeler.

### Web API projesi oluşturma

```bash
dotnet new webapi -n ProjeAdi
cd ProjeAdi
```

- `dotnet new webapi`: Web API şablonundan proje oluşturur.
- `-n ProjeAdi`: Oluşturulacak projenin adını belirler.
- `cd ProjeAdi`: Terminali proje klasörüne taşır.

Şablonun oluşturduğu başlangıç dosyaları ve OpenAPI ayarları, kurulu SDK sürümüne göre farklılık gösterebilir.

### Derleme ve çalıştırma

```bash
dotnet restore
dotnet build
dotnet run
```

- `dotnet restore`: Projenin NuGet bağımlılıklarını geri yükler.
- `dotnet build`: Projeyi derler ve derleme hatalarını bildirir.
- `dotnet run`: Uygulamayı derleyip çalıştırır.

Kod değişikliklerini izleyerek uygulamayı yeniden başlatmak için:

```bash
dotnet watch run
```

> [!NOTE]
> `dotnet` komutları için uyumlu bir .NET SDK kurulu olmalıdır. Birden fazla proje içeren solution'larda komutları doğru `.csproj` veya `.sln` dosyasını hedefleyecek şekilde çalıştırın.

---

### `18-WebCoreAPI` — ASP.NET Core Web API

Bu klasör, ASP.NET Core Web API ve ilişkili veri erişimi çalışmalarını içerir. Entity Framework Core ile birlikte kullanıldığında API uç noktaları üzerinden veritabanı işlemleri gerçekleştirilebilir.

## Entity Framework Core ve Migration

Entity Framework Core, .NET nesneleri üzerinden veritabanıyla çalışmayı sağlayan bir ORM aracıdır. **Migration**, model değişikliklerini veritabanı şemasına taşımak için kullanılır.

### Gerekli araçlar ve paketler

SQL Server kullanılan bir EF Core projesinde aşağıdaki paketler, proje yapısına ve sürümüne bağlı olarak gerekebilir:

- `Microsoft.EntityFrameworkCore.SqlServer`: SQL Server sağlayıcısı.
- `Microsoft.EntityFrameworkCore.Design`: Tasarım zamanı işlemleri ve bazı CLI komutları.
- `Microsoft.EntityFrameworkCore.Tools`: Visual Studio Package Manager Console araçları.
- `dotnet-ef`: `dotnet ef` komutları için kullanılan CLI aracı.

Paket ve araç sürümlerini projenin kullandığı EF Core sürümüyle uyumlu seçin. `dotnet-ef` aracı global veya yerel araç olarak kurulabilir; ekip projelerinde yerel araç manifesti sürüm tutarlılığı sağlayabilir.

### Migration oluşturma

Proje dosyasının bulunduğu dizinde temel kullanım:

```bash
dotnet ef migrations add InitialCreate
```

Birden fazla proje varsa, migration'ların tutulduğu projeyi ve başlangıç projesini açıkça belirtmek gerekebilir:

```bash
dotnet ef migrations add InitialCreate --project ./VeriKatmani/VeriKatmani.csproj --startup-project ./WebApi/WebApi.csproj
```

- `migrations add`: Yeni migration oluşturur.
- `InitialCreate`: Migration için verdiğiniz addır; farklı bir isim de seçebilirsiniz.
- `--project`: Migration ve `DbContext` yapılandırmasının bulunduğu projeyi belirtir.
- `--startup-project`: Uygulama yapılandırmasının çalıştırılacağı başlangıç projesini belirtir.

Yukarıdaki proje yollarını kendi solution yapınıza göre değiştirin. `DbContext` ve bağlantı yapılandırması doğru tanımlanmış olmalıdır.

### Migration'ı veritabanına uygulama

```bash
dotnet ef database update
```

Birden fazla proje kullanılıyorsa aynı `--project` ve `--startup-project` seçeneklerini bu komuta da ekleyebilirsiniz.

> [!WARNING]
> `database update`, yapılandırılmış veritabanında şema değişiklikleri yapabilir. Özellikle gerçek veya paylaşılan veritabanlarında çalıştırmadan önce bağlantı dizesini ve hedef ortamı kontrol edin; önemli verilerin yedeğini alın.

### Visual Studio Package Manager Console

Visual Studio'daki **Tools → NuGet Package Manager → Package Manager Console** üzerinden şu komutlar da kullanılabilir:

```powershell
Add-Migration InitialCreate
Update-Database
```

Bunlar PowerShell tabanlı Package Manager Console komutlarıdır; `dotnet ef` ile aynı komut biçimine sahip değildir.

---

### HTTP metotları

| Metot | Kullanım amacı |
|---|---|
| `GET` | Veri okumak |
| `POST` | Yeni bir kaynak oluşturmak |
| `PUT` | Bir kaynağı bütünüyle güncellemek |
| `PATCH` | Bir kaynağın belirli alanlarını güncellemek |
| `DELETE` | Bir kaynağı silmek |

## Geliştirme Notları

- **İsimlendirme:** Değişken, sınıf ve metot adlarını yaptıkları işi anlatacak şekilde seçin.
- **Küçük adımlarla ilerleme:** Örnekleri çalıştırın; parametreleri, koşulları ve verileri değiştirerek sonuçları inceleyin.
- **Hata ayıklama:** Hata mesajında belirtilen dosya, satır ve hata türünü kontrol edin. Gerekirse hatayı küçük bir örneğe indirerek araştırın.
- **Sürüm uyumluluğu:** .NET, NuGet paketleri ve Entity Framework Core sürümlerinin birbiriyle uyumlu olmasına dikkat edin.
- **Gizli bilgiler:** Veritabanı parolalarını, API anahtarlarını ve bağlantı dizelerindeki gizli bilgileri Git deposuna eklemeyin. Geliştirme ortamında güvenli yapılandırma yöntemlerini tercih edin.
- **README güncelliği:** Yeni klasör veya proje eklendiğinde depo yapısı tablosunu ve ilgili açıklamaları güncelleyin.

---

## Amaç

Bu depo, C# temellerinden başlayarak nesne yönelimli programlama, uygulama geliştirme, SQL Server ile veri erişimi, katmanlı mimari ve ASP.NET Web API konularına uzanan kişisel bir öğrenme alanıdır. Amaç, her konuyu küçük ve anlaşılır örneklerle öğrenmek, ardından bu bilgileri gerçekçi uygulamalar üzerinde kullanabilmektir.

---

**Veysel KUŞ**

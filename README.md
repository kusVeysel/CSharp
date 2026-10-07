# CSharp Notları

Bu depo, **C# programlama dilini ve .NET ekosistemini temelden başlayarak öğrenmek** için hazırlanmış örnekler, alıştırmalar ve uygulama projeleri içerir. İçerik; temel dil özelliklerinden nesne yönelimli programlamaya, veritabanı işlemlerinden ASP.NET Web API geliştirmeye kadar ilerleyen bir öğrenme sırasına göre düzenlenmiştir.

> [!NOTE]
> Açıklamalar mevcut klasör yapısı ve proje adları temel alınarak hazırlanmıştır. Klasörlerdeki örnekler geliştikçe bu doküman da güncellenebilir.

---

## 📑 İçindekiler

* [📂 Depo Yapısı](#-depo-yapısı)
* [🎯 Önerilen Öğrenme Sırası](#-önerilen-öğrenme-sırası)
* [🛠️ Teknik Bilgiler](#️-teknik-bilgiler)
  * [🖥️ Windows Forms İpuçları ve Sık Kullanılan Kontroller](#️-windows-forms-ipucları-ve-sık-kullanılan-kontroller)
  * [🗄️ SQL](#️-sql)
  * [🏗️ Katmanlı Mimari](#️-katmanlı-mimari)
  * [🔌 16-WebAPI — ASP.NET Web API (.NET Framework) + Swagger](#-16-webapi--aspnet-web-api-net-framework--swagger)
  * [⚡ 17-CoreAPI(Temel) — ASP.NET Core Web API](#-17-coreapitemel--aspnet-core-web-api)
  * [🔐 18-WebCoreAPI — ASP.NET Core Web API + JWT + EF Core](#-18-webcoreapi--aspnet-core-web-api--jwt--ef-core)
  * [19-DosyaIslemleri — ASP.NET Core Web API + Swagger](#19-dosyaislemleri--aspnet-core-web-api--swagger)
* [💡 HTTP Metotları](#-http-metotları)
* [📝 Geliştirme Notları](#-geliştirme-notları)
* [📌 Amaç](#-amaç)
---

## 📂 Depo Yapısı

| Klasör | İçerik |
|---|---|
| `ConsoleMetotlari`                | Konsol uygulamalarında kullanılan detaylı metot ve örnekler                                   |
| `01-DegiskenTipleri`              | Değişkenler, temel veri tipleri, değer atama ve input output işlemleri                        |
| `02-IfElseYapisi`                 | Operatörler, if, else if, else ve ternary operatör                                            |
| `03-HesapMakinesi`                | Switch - case, try - catch - finally, goto ve convert mantığı ile beraber hesap makinesi      |
| `04-DizilerGenericListDonguler`   | Diziler, `List<T>` ve döngüler                                                                |
| `05-HazirMetotlar`                | .NET'in hazır metotları ve sık kullanılan işlemler                                            |
| `06-ClassYapisi`                  | Sınıflar, nesneler, alanlar, özellikler ve metotlar                                           |
| `07-OOP`                          | Nesne yönelimli programlama yaklaşımı                                                         |
| `08-StringMetotlar`               | Form üzerinden metin işlemleri ve `string` metotları                                          |
| `09-PizzaSiparisFormu`            | Form üzerinden uygulama geliştirme                                                            |
| `10-SuStokTakipFormu`             | Form üzerinden uygulama geliştirme                                                            |
| `11-MSSQL`                        | Microsoft SQL Server ve veritabanı temelleri                                                  |
| `12-AdoNet`                       | ADO.NET ile veritabanı bağlantısı ve veri işlemleri                                           |
| `13-EntityFramework`              | Entity Framework ile nesne tabanlı veritabanı işlemleri                                       |
| `14-KatmanliMimari`               | Katmanlı mimari ve projelerin sorumluluklara ayrılması                                        |
| `15-MVC`                          | MVC mimarisiyle web uygulaması geliştirme                                                     |
| `16-WebAPI`                       | ASP.NET Web API — Swagger — .NET Framework tabanlı çalışma                                    |
| `17-CoreAPI(Temel)`               | VS Code ve .NET CLI ile temel Core API                                                        |
| `18-WebCoreAPI`                   | ASP.NET Core Web API — JWT — Entity Framework Core çalışmaları                                |
| `19-DosyaIslemleri`               | Web API ile Dosya Yönetimi | `System.IO`, `IFormFile`, File Upload/Download, Swagger          |

---

## 🎯 Önerilen Öğrenme Sırası

Klasörler numaralandırılarak temel konulardan daha kapsamlı uygulamalara doğru ilerleyecek şekilde düzenlenmiştir.

1. **C# Temelleri:** Değişkenler, veri tipleri ve koşul yapıları (`01` - `03`).

2. **Kontrol ve Koleksiyon Yapıları:** Döngüler, diziler ve `List<T>` (`04`).

3. **Metotlar ve OOP:** Hazır metotlar, sınıflar, nesneler ve OOP prensipleri (`05` - `08`).

4. **Masaüstü / Form Uygulamaları:** Pizza sipariş formu ve su stok takip formu (`09` - `10`).

5. **Veritabanı Erişim Yöntemleri:** MSSQL, ADO.NET ve Entity Framework (`11` - `13`).

6. **Uygulama Mimarileri:** Katmanlı mimari ve MVC(`14` - `15`).

7. **Web API & Web Servisleri:** .NET Framework Web API ve ASP.NET Core Web API (`16` - `19`).

Her örneği çalıştırıp kod üzerinde küçük değişiklikler yapmak, yalnızca kodu okumaya kıyasla konuları daha iyi pekiştirir.

---

## 🛠️ Teknik Bilgiler

### 🖥️ Windows Forms İpuçları ve Sık Kullanılan Kontroller

Windows Forms uygulamalarında en sık kullanılan kontroller ve dikkat edilmesi gereken pratik özellikler:

#### 1. `TextBox`
* **Metin Değeri:** `textBox1.Text` üzerinden metin okunur ve atanır.
* **Şifre Gizleme:** `PasswordChar = '*'` yapılarak girilen karakterler gizlenebilir.
* **Sadece Okunur Yapma:** `ReadOnly = true` ile kullanıcının metni değiştirmesi engellenir.
* **Çok Satırlı Metin:** `Multiline = true` yapılarak birden fazla satır girilmesine izin verilir.

#### 2. `ComboBox`
* **Eleman Ekleme/Temizleme:** `comboBox1.Items.Add("Eleman")` ile ekleme, `comboBox1.Items.Clear()` ile temizleme yapılır.
* **Seçili Eleman/İndeks:** `comboBox1.SelectedItem` veya `comboBox1.SelectedIndex` kullanılır.
* **Nesne Bağlama (Data Binding):** `DataSource`, `DisplayMember` ve `ValueMember` özellikleri kullanılarak liste/veri kaynakları kolayca bağlanabilir.
* **Yazmayı Engelleme:** `DropDownStyle = ComboBoxStyle.DropDownList` ayarlanarak kullanıcının dışarıdan metin yazması engellenir, sadece listeden seçim yapması sağlanır.

#### 3. `NumericUpDown`
* **Sayısal Değer:** `numericUpDown1.Value` (özellik `decimal` tipindedir, `int` dönüşümü için cast gerekir).
* **Sınır Belirleme:** `Minimum` ve `Maximum` özellikleri ile girilebilecek alt ve üst limitler belirlenir.

#### 4. `DataGridView`
* **Veri Bağlama:** `dataGridView1.DataSource = liste;` şeklinde veri kaynağı atanır.
* **Düzenlemeyi Kapatma:** `ReadOnly = true` yapılarak hücrelerin düzenlenmesi engellenir.
* **Satır Seçim Modu:** `SelectionMode = DataGridViewSelectionMode.FullRowSelect` ile tıklanan hücre yerine tüm satırın seçilmesi sağlanır.
* **Kullanıcı Satır Eklemesini Engelleme:** `AllowUserToAddRows = false` ile en alt sıradaki boş satır gizlenir.
* **Kullanıcı Satır Silinmesini Engelleme:** `AllowUserToDeleteRows = false` ile satır silinmesi engellenir.

#### 5. `CheckBox` ve `RadioButton`
* **Seçim Durumu:** `checkBox1.Checked` veya `radioButton1.Checked` (`bool` değer döner).
* **RadioButton Gruplama:** Aynı Panel veya GroupBox içerisindeki `RadioButton` kontrolleri tek bir grup olarak çalışır (aynı anda sadece biri seçilebilir).

#### 6. `DateTimePicker`
* **Seçilen Tarih/Saat:** `dateTimePicker1.Value` (`DateTime` tipinde değer döndürür).
* **Format Ayarı:** `Format = DateTimePickerFormat.Short` ile sadece tarih görünmesi sağlanır.

#### 7. `ListBox`
* **Eleman Ekleme:** `listBox1.Items.Add("Öğe")`
* **Çoklu Seçim:** `SelectionMode = SelectionMode.MultiSimple` veya `MultiExtended` ayarlanarak birden fazla eleman seçilebilir.

#### 💡 Pratik İpuçları & Form Olayları (Events)
* **Form Yüklenme Anı:** `Form_Load` olayı, form açılırken veritabanından veri çekmek veya kontrolleri doldurmak için kullanılır.
* **Kontrol Değişim Olayları:** `TextChanged` (TextBox), `SelectedIndexChanged` (ComboBox/ListBox) ve `CheckedChanged` (CheckBox/RadioButton) olayları değer değiştiğinde anlık işlem yapmak için kullanılır.
* **Dialog Pencereleri:** Kullanıcıya onay sorusu sormak için `MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo)` kullanılır.


### 🗄️ SQL
`11-MSSQL` klasörü içindeki `VeyselDBscript.sql` dosyasını direk açıp çalıştırarak Database'i sql'e kurun.

> [!CAUTION]
> `VeyselDBscript.sql` içinde yapacağınız değişiklikler sonraki klasörlerdeki projelerde eksik veya hatalı çalışmaya sebep olabilir. <br>
> Veri kaybı veya başka bir olay dahilinde eski verilere ulaşmak için tabloların verilerinin yedeği `VeyselDBveriler.sql` dosyası içinde bulunmaktadır.

### 🏗️ Katmanlı Mimari

`14-KatmanliMimari` klasörü, uygulama sorumluluklarını ayrı katmanlara ayırma yaklaşımını ele alır. Böylece iş kuralları, veri erişimi ve kullanıcı arayüzü birbirinden ayrılır; kodun bakımı ve test edilmesi kolaylaşır.

>[!IMPORTANT]
> Proje veya namespace isimlendirmesinde `.` alt klasör/katman mantığına karşılık gelir. Bu yüzden katman isimlendirmelerinde sonuna `/` değil `.` tercih edilir (Örn: `Uygulama.BLL`).

Yaygın bir katman düzeni şöyledir:

| Katman | Sorumluluk |
|---|---|
| **UI / Presentation**     | Kullanıcı arayüzü ve kullanıcı etkileşimleri       |
| **BLL / Business Logic**  | İş kuralları, doğrulamalar ve uygulama akışı       |
| **DAL / Data Access**     | Veritabanına erişim ve veri okuma/yazma işlemleri  |
| **Entities / Models**     | Uygulamada kullanılan veri modelleri               |

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

### 🔌 `16-WebAPI` — ASP.NET Web API (.NET Framework) + Swagger
Bu klasör, ASP.NET Web Application (.NET Framework) tabanlı Web API çalışmalarını içerir. Proje oluştururken uygun Web API şablonu seçilir. Bu yapı, klasik .NET Framework tabanlı web servisleri geliştirmek için kullanılır.

#### Swagger / OpenAPI

API uç noktalarını tarayıcı üzerinden test etmek için Swagger kullanılır.Swagger'a ulaşmak için projeyi çalıştırın(f5) ve adresin devamına `/swagger` yazın.

**Swagger Ekleme**
* **.NET Framework:** Referanslara sağ tık → *Manage NuGet Packages* → `Swashbuckle` paketini yükleyin.

> [!TIP]
> Swagger sayfası açılmıyorsa önce projenin başarıyla çalıştığını, doğru adres ve portu kullandığınızı, ardından Swagger servislerinin ve middleware yapılandırmasının projede bulunduğunu kontrol edin.

---

### ⚡ `17-CoreAPI(Temel)` — ASP.NET Core Web API

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

* **Derleme:**

  ```
  dotnet build
  ```

* **Çalıştırma:**

  ```
  dotnet run
  ```

* **Canlı Kod İzleme (Hot Reload):**

  ```
  dotnet watch run
  ```

---

## 🔐 `18-WebCoreAPI` — ASP.NET Core Web API + JWT + EF Core

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
  dotnet ef migrations add InitialCreate --project .\project_name\
  ```

* **Veritabanını Güncelleme:**

  ```
  dotnet ef database update --project .\project_name\
  ```

### Migration İşlemleri

* **Migration Oluşturma**

  ```
  dotnet ef migrations add InitialCreate --project .\project_name\
  ```

- `migrations add`: Yeni migration oluşturur.
- `InitialCreate`: Migration için verdiğiniz addır; farklı bir isim de seçebilirsiniz.
- `--project`: Migration ve `DbContext` yapılandırmasının bulunduğu projeyi belirtir.

Yukarıdaki proje yollarını kendi solution yapınıza göre değiştirin. `DbContext` ve bağlantı yapılandırması doğru tanımlanmış olmalıdır.


* **Migration'u veri tabanına ekleme**

  ```bash
  dotnet ef database update --project .\project_name\
  ```

> [!CAUTION]
> `database update` komutu veritabanı şemasını doğrudan değiştirir. Canlı veya paylaşılan veritabanlarında çalıştırmadan önce bağlantı dizesini kontrol edip yedek aldığınızdan emin olun.


### `19-DosyaIslemleri` — ASP.NET Core Web API + Swagger
BU klasörün, RESTful API üzerinden sunucuya dosya yükleme (Upload), limit belirleme, bağlantı kopukluğu durumları ele alınmıştır.

## 📦 Gerekli NuGet Paketleri (Swagger Desteği İçin)
Bu klasörde **ASP.NET Core Web API** üzerinde dosya yükleme uç noktalarını Swagger UI üzerinden doğrudan test edebilmek için aşağıdaki paketler eklenmiştir:

* `Swashbuckle.AspNetCore.Swagger`

* `Swashbuckle.AspNetCore.SwaggerGen`

* `Swashbuckle.AspNetCore.SwaggerUI`

Bu çalışmada API uç noktalarının görüntülenmesi ve test edilmesi için **Swagger / OpenAPI** kullanılmıştır. Swagger arayüzü üzerinden oluşturulan endpoint'ler incelenebilir ve API'ye gönderilecek istekler tarayıcı üzerinden test edilebilir.

Dosya işlemlerinde C# ve .NET'in dosya sistemi API'lerinden yararlanılır. Özellikle `System.IO` içerisindeki sınıflar dosya ve klasör işlemlerinin gerçekleştirilmesinde kullanılır.

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

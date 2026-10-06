using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public FilesController(IWebHostEnvironment env)
        {
            _env = env;
        }

        private string UploadsRoot => Path.Combine(_env.ContentRootPath, "uploads"); // Dosyaları kaydedilecek path

        private static string FilesNameNormalize(string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }

        private static bool ExtensionsCheck(string fileName)
        {
            var allowed = new[] { ".jpg", ".png", ".jpeg" };
            var ext = Path.GetExtension(fileName).ToLowerInvariant();

            return allowed.Contains(ext);
        }

        [HttpPost]
        [RequestSizeLimit(50_000_000)] // maks 50mb sınır koyar
        [ProducesResponseType(typeof(string), 200)] // string tipte ve 200 durum kodunu döner
        [ApiExplorerSettings(GroupName = "Başlık1")]
        public async Task<IActionResult> SingleUpload(IFormFile file, CancellationToken cancellationToken)
        {
            if (file is null || file.Length == 0)
                return BadRequest("Dosya Boş");

            if (!ExtensionsCheck(file.FileName))
                return BadRequest("Geçersiz Dosya Türü");

            Directory.CreateDirectory(UploadsRoot);

            var safeName = $"{Guid.NewGuid():N}_{FilesNameNormalize(file.FileName)}";
            var fullPath = Path.Combine(UploadsRoot, safeName);

            await using var fs = System.IO.File.Create(fullPath);
            await file.CopyToAsync(fs, cancellationToken);

            return Ok(new { saveAd = safeName, size = file.Length });
        }

        /// <summary>
        /// Çoklu Dosya Yükleme İşlemi
        /// </summary>
        /// <param name="files">Çoklu Dosya Bilgisi Taşır</param>
        /// <param name="cancellationToken">İşlem Yarım Kalırsa Devreye Girer</param>
        /// <returns></returns>
        // Projeye sağ tık -> Properties -> Build -> Output -> Documentation File 
        // Program.cs -> (swagger) kısmına git orda yazıyor
        [HttpPost]
        [RequestSizeLimit(199_000_000)] // 199mb
        [ProducesResponseType(typeof(List<string>), 200)] // List<string> tipte ve 200 durum kodunu döner
        [ApiExplorerSettings(GroupName = "Başlık2")]
        public async Task<IActionResult> MultiUpload(List<IFormFile> files, CancellationToken cancellationToken)
        {
            if (files is null || files.Count == 0)
                return BadRequest("Dosyalar Boş");

            Directory.CreateDirectory(UploadsRoot);

            var results = new List<object>();

            foreach (IFormFile file in files)
            {
                if (file.Length == 0)
                {
                    results.Add(
                        new { file = file.FileName, error = "Boş" });
                    continue;
                }
                if (!ExtensionsCheck(file.FileName))
                {
                    results.Add(
                        new { file = file.FileName, error = "Uzantı Hatası" });
                    continue;
                }

                var safeName = $"{Guid.NewGuid():N}_{FilesNameNormalize(file.FileName)}";
                var fullPath = Path.Combine(UploadsRoot, safeName);

                await using var fs = System.IO.File.Create(fullPath);
                await file.CopyToAsync(fs, cancellationToken);

                results.Add(new { file = file.FileName, savedAs = safeName, size = file.Length });


            }
            return Ok(results);
        }
    }
}

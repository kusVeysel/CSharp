using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class KisiController : ControllerBase
{
    [HttpGet]
    public string KisiGetir()
    {
        return "Veysel";
    }
    
    [HttpGet]
    public List<KisiVM> KisiListele()
    {
        return Methods.DbKisiGetir();
    }

    [HttpPost]
    public KisiVM KisiEkle(KisiVM data)
    {
        var aa = data;
        return aa;
    }
}

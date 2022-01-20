using Microsoft.AspNetCore.Mvc;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {

        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                MehsulKodu = 322345,
                Name = "İPHONE 13 PRO 128GB - SİERRA BLUE",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Price = "2899.99AZN",
                Color = "Blue",
                PhotoUrl = "https://kontakt.az/wp-content/uploads/2021/09/530304-Product-0-I-637672995748825019_800x800-min.png",
                İstehsalIli = "2021, 14 sentyabr",
                Nov  = "Smartfon",
                Ekran = "6.1",
                EsasKamera = "12 mpx + 12 mpx + 12 mpx",
                OnKamera = "12 mpx",
                DaxiliYaddas = "128 GB",
                OperativYaddas = "6 GB",
                EmeliyyatSistemi = "iOS"

            }
        };
        public IActionResult Index()
        {

            ViewData["products"] = products;
            return View();
        }
    }
}

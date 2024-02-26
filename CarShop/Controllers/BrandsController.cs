using CarShop.BusinessLogic.Interfaces;

namespace CarShop.Controllers
{
    public class BrandsController (IBrandService brandService)
        : Controller
    {
        private readonly IBrandService _brandService = brandService;
        public IActionResult Index(int pageNumber = 1)
        {
            var categories = _brandService.GetAll();
            return View();
        }
    }
}

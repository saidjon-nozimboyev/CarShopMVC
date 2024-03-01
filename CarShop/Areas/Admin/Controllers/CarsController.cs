using CarShop.BusinessLogic.Common;
using CarShop.BusinessLogic.DTOs.BrandDTOs;
using CarShop.BusinessLogic.DTOs.CarDTOs;
using CarShop.BusinessLogic.Interfaces;
using CarShop.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarShop.Areas.Admin.Controllers
{
    public class CarsController(ICarService carService,
                                ICategoryService categoryService,
                                IBrandService brandService)
        : Controller
    {
        private readonly ICarService _carService = carService;
        private readonly IBrandService _brandService = brandService;

        public ICategoryService _categoryService = categoryService;

        public IActionResult Index(int pageNumber = 1)
        {
            var cars = _carService.GetAll();
            var pageModel = new PageModel<CarDto>(cars, pageNumber);
            return View(pageModel);
        }

        public IActionResult Add()
        {
            var categories = _categoryService.GetAll();
            var brands = _brandService.GetAll();

            AddCarDto dto = new()
            {
                Categories = categories,
                Brands = brands
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult Add(AddCarDto dto)
        {
            try
            {
                _carService.Create(dto);
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, ex.Message);
                return View(dto);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _carService.Delete(id);
                return RedirectToAction("index");
            }
            catch (CustomException)
            {
                return RedirectToAction("error", "home", new { url = "/categories/index" });
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var car = _carService.GetById(id);
                UpdateCarDto dto = new()
                {
                    Id = car.Id,
                    Name = car.Name,
                    Description = car.Description,
                    Price = car.Price,
                    CategoryId = car.Category.Id,
                    BrandId = car.Brand.Id,
                    Categories = _categoryService.GetAll(),
                    Brands = _brandService.GetAll()
                };

                return View(dto);
            }
            catch (CustomException)
            {
                return RedirectToAction("error", "home", new { url = "/categories/index" });
            }
        }

        [HttpPost]
        public IActionResult Edit(UpdateCarDto dto)
        {
            try
            {
                _carService.Update(dto);
                return RedirectToAction("index");
            }
            catch (CustomException ex)
            {
                ModelState.AddModelError(ex.Key, ex.Message);
                return View(dto);
            }
        }

        public IActionResult Detail(int id)
        {
            try
            {
                var car = _carService.GetById(id);
                return View(car);
            }
            catch (CustomException)
            {
                return RedirectToAction("error", "home", new { url = "/categories/index" });
            }
        }
    }
}

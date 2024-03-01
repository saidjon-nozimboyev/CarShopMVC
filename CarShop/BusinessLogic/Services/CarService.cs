using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.BusinessLogic.Services;

public class CarService(IUnitOfWork unitOfWork) 
    : ICarService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public void Create(AddCarDto carDto)
    {
        if (carDto == null)
        {
            throw new CustomException("","CarDto was null");
        }
        if (string.IsNullOrEmpty(carDto.Name))
        {
            throw new CustomException("Name", "Car name is required");
        }

        Car car = new()
        {
            Name = carDto.Name,
            Description = carDto.Description,
            Price = carDto.Price,
            CategoryId = carDto.CategoryId,
            BrandId = carDto.BrandId,
            Brand = null,
            Category = null
        };
        _unitOfWork.Cars.Add(car);
    }

    public void Delete(int id)
    {
        var car = _unitOfWork.Cars.GetById(id);
        if (car == null) 
        {
            throw new CustomException("", "Car was not found");
        }
        _unitOfWork.Cars.Delete(car.Id);
    }

    public List<CarDto> GetAll()
    {
        var cars = _unitOfWork.Cars.GetCarsWithRelations();
        var list = cars.Select(car => car.ToCarDto()).ToList();
        return list;
    }

    public CarDto GetById(int id)
    {
        var car = _unitOfWork.Cars.GetCarsWithRelations().FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            throw new CustomException("", "Car was not found");
        }
        return car.ToCarDto();
    }

    public void Update(UpdateCarDto carDto)
    {
        var car = _unitOfWork.Cars.GetById(carDto.Id);
        if (car == null)
        {
            throw new CustomException("", "Car was not found");
        }

        car.Name = carDto.Name;
        car.Description = carDto.Description;
        car.Price = carDto.Price;
        car.CategoryId = carDto.CategoryId;
        car.BrandId = carDto.BrandId;

        _unitOfWork.Cars.Update(car);
    }
}

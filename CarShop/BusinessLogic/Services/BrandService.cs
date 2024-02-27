using AutoMapper;

namespace CarShop.BusinessLogic.Services;

public class BrandService(IUnitOfWork unitOfWork,
                          IFileService fileService,
                          IMapper mapper)
    : IBrandService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IFileService _fileService = fileService;
    private readonly IMapper _mapper = mapper;

    public void Create(AddBrandDto brandDto)
    {
        if (brandDto == null)
        {
            throw new CustomException("", "BrandDto was null");
        }
        if (string.IsNullOrEmpty(brandDto.Name))
        {
            throw new CustomException("", "Name was null or empty");
        }
        if (brandDto.Name.Length < 3 || brandDto.Name.Length > 30)
        {
            throw new CustomException("Name", "Name must be between 3 and 30 characters");
        }
        if (brandDto.file == null)
        {
            throw new CustomException("File", "Brand image is required");
        }

        Brand brand = new()
        {
            Name = brandDto.Name,
            ImageUrl = _fileService.UploadImage(brandDto.file)
        };

        _unitOfWork.Brands.Add(brand);
    }

    public void Delete(int id)
    {
        var brand = _unitOfWork.Brands.GetById(id);

        if (brand == null)
        {
            throw new CustomException("", "Brand was not found");
        }
        _fileService.DeleteImage(brand.ImageUrl);
        _unitOfWork.Brands.Delete(brand.Id);
    }

    public List<BrandDto> GetAll()
    {
        var categories = _unitOfWork.Brands.GetAll();
        var list = categories.Select(_mapper.Map<BrandDto>).ToList();
        return list;
    }

    public BrandDto GetById(int id)
    {
        var brand = _unitOfWork.Brands.GetById(id);
        if (brand == null)
        {
            throw new CustomException("", "Brand was not found");
        }

        var dto = new BrandDto()
        {
            Id = brand.Id,
            Name = brand.Name,
            ImagePath = brand.ImageUrl
        };

        return dto;
    }

    public void Update(UpdateBrandDto brandDto)
    {
        var brend = _unitOfWork.Brands.GetById(brandDto.Id);

        if (brend == null)
        {
            throw new CustomException("", "Brend not found");
        }

        if (string.IsNullOrEmpty(brandDto.Name))
        {
            throw new CustomException("", "Brend name is required");
        }

        if (brandDto.Name.Length < 3 || brandDto.Name.Length > 30)
        {
            throw new CustomException("", "Brend name must be between 3 and 30 characters");
        }

        if (brandDto.file != null)
        {
            _fileService.DeleteImage(brend.ImageUrl);
            brandDto.ImagePath = _fileService.UploadImage(brandDto.file);
        }

        brend.Name = brandDto.Name;
        brend.ImageUrl = brandDto.ImagePath;

        _unitOfWork.Brands.Update(brend);
    }
}

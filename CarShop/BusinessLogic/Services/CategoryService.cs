namespace CarShop.BusinessLogic.Services;

public class CategoryService(IUnitOfWork unitOfWork,
                             IFileService fileService)
    : ICategoryService
{

    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IFileService _fileService = fileService;
    public void Create(AddCategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<CategoryDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public CategoryDto GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(UpdateCategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }
}

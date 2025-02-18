using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MOZ.StoreManagement.Categories;

public class CategoryService : CrudAppService<
    Category, //The Book entity
    CategoryDto, //Used to show books
    int, //Primary key of the book entity
    PagedAndSortedResultRequestDto, //Used for paging/sorting
    CreateCategoryDto>,ICategoryService
{
    private readonly IRepository<Category> _categoryRepository;


    public CategoryService(IRepository<Category, int> repository, IRepository<Category> categoryRepository) : base(repository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<CategoryDto>> GetAllCategoriesAsync()
    {
        var categories = await _categoryRepository.GetListAsync();
        return ObjectMapper.Map<List<Category>, List<CategoryDto>>(categories);
    }

    public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto input)
    {
        var category = new Category(){Name = input.Name, Description = input.Description,TenantId = CurrentTenant.Id};
        await _categoryRepository.InsertAsync(category);
        return ObjectMapper.Map<Category, CategoryDto>(category);
    }
}
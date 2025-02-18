using System.Threading.Tasks;

namespace MOZ.StoreManagement.Categories;

public interface ICategoryService
{
    Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto input);
}
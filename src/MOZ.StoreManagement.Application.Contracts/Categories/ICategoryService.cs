using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MOZ.StoreManagement.Categories;

public interface ICategoryService:ICrudAppService< //The Book entity
    CategoryDto, //Used to show books
    int, //Primary key of the book entity
    PagedAndSortedResultRequestDto, //Used for paging/sorting
    CreateCategoryDto,UpdateCategoryDto>
{
    Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto input);
}
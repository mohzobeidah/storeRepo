using AutoMapper;
using MOZ.StoreManagement.Books;
using MOZ.StoreManagement.Categories;

namespace MOZ.StoreManagement.Web;

public class StoreManagementWebAutoMapperProfile : Profile
{
    public StoreManagementWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<UpdateCategoryDto, CategoryDto>().ReverseMap();
        
        //Define your object mappings here, for the Web project
    }
}

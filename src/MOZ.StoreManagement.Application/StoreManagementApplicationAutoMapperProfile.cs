using AutoMapper;
using MOZ.StoreManagement.Books;
using MOZ.StoreManagement.Categories;

namespace MOZ.StoreManagement;

public class StoreManagementApplicationAutoMapperProfile : Profile
{
    public StoreManagementApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<CreateCategoryDto, Category>().ReverseMap();
        CreateMap<CategoryDto, Category>().ReverseMap();
        CreateMap<UpdateCategoryDto, CategoryDto>().ReverseMap();
        CreateMap<UpdateCategoryDto, Category>().ReverseMap();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}

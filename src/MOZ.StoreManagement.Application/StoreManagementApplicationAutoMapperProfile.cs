using AutoMapper;
using MOZ.StoreManagement.Books;

namespace MOZ.StoreManagement;

public class StoreManagementApplicationAutoMapperProfile : Profile
{
    public StoreManagementApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}

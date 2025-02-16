using AutoMapper;
using MOZ.StoreManagement.Books;

namespace MOZ.StoreManagement.Web;

public class StoreManagementWebAutoMapperProfile : Profile
{
    public StoreManagementWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}

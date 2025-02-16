using System;
using MOZ.StoreManagement.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MOZ.StoreManagement.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = StoreManagementPermissions.Books.Default;
        GetListPolicyName = StoreManagementPermissions.Books.Default;
        CreatePolicyName = StoreManagementPermissions.Books.Create;
        UpdatePolicyName = StoreManagementPermissions.Books.Edit;
        DeletePolicyName = StoreManagementPermissions.Books.Delete;
    }
}
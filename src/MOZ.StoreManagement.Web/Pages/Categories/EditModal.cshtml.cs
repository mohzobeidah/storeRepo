using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MOZ.StoreManagement.Books;
using MOZ.StoreManagement.Categories;

namespace MOZ.StoreManagement.Web.Pages.Categories
{
    public class EditModal : StoreManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty] public UpdateCategoryDto Book { get; set; }

        private readonly ICategoryService _bookAppService;

        public EditModal(ICategoryService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public async Task OnGetAsync()
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Book = ObjectMapper.Map<CategoryDto, UpdateCategoryDto>(bookDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(Id, Book);
            return NoContent();
        }
    }
}


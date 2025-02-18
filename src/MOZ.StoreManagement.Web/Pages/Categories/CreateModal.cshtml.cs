using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MOZ.StoreManagement.Books;
using MOZ.StoreManagement.Categories;

namespace MOZ.StoreManagement.Web.Pages.Categories;


    public class CreateModal : StoreManagementPageModel
    {
        [BindProperty] public CreateCategoryDto Book1 { get; set; }

        private readonly ICategoryService _bookAppService;

        public CreateModal(ICategoryService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book1 = new CreateCategoryDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateCategoryAsync(Book1);
            return NoContent();
        }
    }

   
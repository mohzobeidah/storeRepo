﻿using System.Threading.Tasks;
using MOZ.StoreManagement.Books;
using Microsoft.AspNetCore.Mvc;

namespace MOZ.StoreManagement.Web.Pages.Books
{
    public class CreateModalModel : StoreManagementPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
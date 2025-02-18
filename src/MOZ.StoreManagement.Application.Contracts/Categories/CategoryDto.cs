using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MOZ.StoreManagement.Categories;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class CreateCategoryDto
{
    public string Name { get; set; }
    [TextArea(Rows = 4)]
    public string Description { get; set; }
   
}
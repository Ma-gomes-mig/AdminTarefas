using AdminTarefas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminTarefas.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetCategories();
            return View(categories);
        }
    }
}

using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberQuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpGet("with-subcategories")]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetCategoriesWithSubCategories()
        {
            var categories = await _categoryService.GetCategoriesWithSubCategories();
            return Ok(categories);
        }

        [HttpGet("{categoryId}/subcategories")]
        public async Task<ActionResult<IEnumerable<SubCategoryModel>>> GetSubCategories(int categoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByCategoryId(categoryId);
            return Ok(subCategories);
        }
    }

}

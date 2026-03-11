using CyberQuiz.BLL.Models.DTO;
using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CyberQuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

       
        //Initializes the controller used to serve category endpoints.      
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

       
        // Returns all available quiz categories.     
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTOModel>>> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        
        // Returns categories with nested subcategories in one response.
        [HttpGet("with-subcategories")]
        public async Task<ActionResult<IEnumerable<CategoryWithSubCategoriesDTOModel>>> GetCategoriesWithSubCategories()
        {
            var categories = await _categoryService.GetCategoriesWithSubCategories();
            return Ok(categories);
        }

       
        // Returns subcategories for the requested category id.     
        [HttpGet("{categoryId}/subcategories")]
        public async Task<ActionResult<IEnumerable<SubCategoryDTOModel>>> GetSubCategories(int categoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByCategoryId(categoryId);
            return Ok(subCategories);
        }
    }

}

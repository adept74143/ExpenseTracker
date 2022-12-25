using ExpenseTracker.Domain.Modles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var category = new Category()
            {
                CategoryId = id,
                Icon = "icon",
                Title= "Title",
                Type="Test"
            };

            return Ok(category);
        }
    }
}

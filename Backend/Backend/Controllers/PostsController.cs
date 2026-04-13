using Backend.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts([FromQuery] string? search, [FromQuery] string? category, [FromQuery] int page = 1, [FromQuery] int pageSize = 9)
        {
            var posts = PostRepository.GetPosts(search, category)
                                      .Skip((page - 1) * pageSize)
                                      .Take(pageSize);

            return Ok(posts);
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            return Ok(PostRepository.GetCategories());
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("v1/category")]
    public class CategoryController : ControllerBase
    {

        public CategoryController(IProcessEventCategoryApplication)
        {

        }

        [HttpPost("add")]
        public IActionResult InsertAsync(string name)
        {
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateAsync([FromBody] int id, [FromBody]string name)
        {
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteByIdAsync(int id, string name)
        {
            return Ok();
        }

        public IList<string> GetAllAsync(int id, string name)
        {
            return new List<string>();
        }

        public string GetById(int id, string name)
        {
            return string.Empty;
        }
    }
}

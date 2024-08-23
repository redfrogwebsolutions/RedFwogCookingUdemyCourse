using Microsoft.AspNetCore.Mvc;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedFrogCooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;

        public CategoryController(IMenuRepository categoryRepository)
        {
            _menuRepository = categoryRepository;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<MenuCategory>> GetAsync()
        {
            return _menuRepository.GetCategories();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

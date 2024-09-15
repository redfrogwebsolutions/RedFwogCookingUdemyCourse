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
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<MenuCategory>> GetAsync()
        {
            return await _categoryRepository.GetCategories();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MenuCategory),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(string id)
        {
            var category = await _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // POST api/<CategoryController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] MenuCategory category)
        {
            try
            {
                await _categoryRepository.Add(category);
                return Created($"/category/{category.Id}",category);
            }
            catch (Exception ex)
            {
                //TODO: here save the error to the log
                throw new Exception("wystapil blad ");
            }
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] MenuCategory category)
        {
            if(id != category.Id)
            {
                return BadRequest();
            }
            try
            {
                await _categoryRepository.Update(category);
                return Ok();
            }
            catch(Exception ex)
            {
                //TODO: add log
                return StatusCode(StatusCodes.Status500InternalServerError, "Wystapil blad - zoba log");
            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _categoryRepository.Delete(id);
                return Ok();
            }
            catch(Exception ex)
            {
                //TODO: add logging
                if (ex.Message == "category not found")
                {
                    return NotFound();
                }
                
                return StatusCode(StatusCodes.Status500InternalServerError, "Wystapil blad - zoba log");
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Linq;
using WebProjeApi.DAL.ApiContext;
using WebProjeApi.DAL.Entity;
using WebProjeApi.Migrations;

namespace WebProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new context();
            return Ok(c.Categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var c = new context();
            var values = c.Categories.Find(id);
            if (values == null) { return NotFound(); }
            else { return Ok(values); }

        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c = new context();
            c.Categories.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new context();
            var v = c.Categories.Find(id);
            if ( v== null)
            {
                return NotFound();  
            }
            else
            {
                c.Remove(v);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c = new context();
            var v = c.Find<Category>(p.categoryID);
            if(v== null)
            {
                return NotFound();
            }
            else
            {
                v.categoryName=p.categoryName;
                c.Update(v);
                c.SaveChanges();
                return Ok(v);
            }
        }
    }
}

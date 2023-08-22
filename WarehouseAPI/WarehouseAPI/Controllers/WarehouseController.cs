using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseAPI.Models;
using WarehouseAPI.Data;

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly ApiContext _context;

        public WarehouseController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(Warehouse product)
        {
            if(product.Id == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                var productInDb = _context.Products.Find(product.Id);

                if (productInDb == null) return new JsonResult(NotFound());

                productInDb = product;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(product));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id) 
        {  
            var result = _context.Products.Find(id);

            if(result == null) return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        [HttpDelete] 
        public JsonResult Delete(int id)
        {
            var result = _context.Products.Find(id);

            if (result == null) return new JsonResult(NotFound());

            _context.Products.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet()] 
        public JsonResult GetAll() 
        {
            var result = _context.Products.ToList();

            return new JsonResult(Ok(result));
        }
    }
}

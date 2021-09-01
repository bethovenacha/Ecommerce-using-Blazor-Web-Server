using Amarket;
using ecommerceRestApi.Models;
using ecommerceRestApi.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ecommerceRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork<Product> unit;
        private readonly AppDbContext context;
        public ProductController(AppDbContext _context)
        {
            this.context = _context;
            unit = new UnitOfWork<Product>(this.context);
           
        }
        [HttpGet]
        public async Task<ActionResult> GetProduct() {
            try
            {            
                return Ok(await unit.repository.retrieve(null,null,"Image"));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(Guid id) {
            try
            {
                return Ok(await unit.repository.retrieve(p=>p.Id==id,null, "Image"));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product) {
            try
            {
                if (product == null) {
                    return BadRequest();
                }
                var result = await unit.repository.create(product);
                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpPut("id:Guid")]
        public async Task<ActionResult<Product>> UpdateProduct(Guid id, Product product) {
            try
            {
                if (id != product.Id) {
                    return BadRequest();
                }
                var prod = await unit.repository.update(product);
                if (prod == null) {
                    return NotFound();
                }
                return await unit.repository.update(product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public async Task<ActionResult<Product>> DeleteProduct(Guid id) {
            try
            {
                if (unit.repository.delete(id) == null)
                {
                    return NotFound();
                }
                return await unit.repository.delete(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

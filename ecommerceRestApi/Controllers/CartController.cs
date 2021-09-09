using Amarket;
using ecommerceRestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerceRestApi.UnitOfWork;
namespace ecommerceRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly UnitOfWork<Cart> unit;
        private readonly AppDbContext context;
        public CartController(AppDbContext _context)
        {
            this.context = _context;
            unit = new UnitOfWork<Cart>(this.context);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCart(string id)
        {
            try
            {               
                return Ok(await unit.repository.retrieve(c => c.CartId == Guid.Parse(id), null, "Products"));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCart(string id)
        {
            try
            {    
               return Ok(await unit.repository.delete(Guid.Parse(id)));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<Cart>> CreateCart(Cart cart)
        {
            try
            {
                if (cart == null)
                {
                    return BadRequest();
                }
                var result = await unit.repository.create(cart);
                return CreatedAtAction(nameof(GetCart), new { id = cart.Id }, result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

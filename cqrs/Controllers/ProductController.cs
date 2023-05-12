using Application.Commands.AddProduct;
using Application.Commands.GetAllProduct;
using Application.DTOs.Requests;
using Domain.Aggregates.ProductAggregate;
using Infrastructure.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICommandBus commandBus;
        public ProductController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }
        // GET: api/<ProductController>
        //[HttpGet]
        //public async Task<List<Product>> Get()
        //{
        //    var result = await this.commandBus.
        //    return result;
        //}

        // GET api/<ProductController>/5
        //[HttpGet("{id}")]
        //public async string Get(int id)
        //{
        //    return "";
        //}

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProductCommand addProductCommand)
        {
            var result = await this.commandBus.SendAsync(addProductCommand);
            return Ok(result);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

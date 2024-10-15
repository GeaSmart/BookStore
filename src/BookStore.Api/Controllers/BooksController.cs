using BookStore.Dto.Requests;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await service.GetAsync();
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await service.GetAsync(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(BookRequestDto bookRequestDto)
        {
            var response = await service.AddAsync(bookRequestDto);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, BookRequestDto bookRequestDto)
        {
            var response = await service.UpdateAsync(id, bookRequestDto);
            return response ? Ok(response) : BadRequest(response);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await service.DeleteAsync(id);
            return response ? Ok(response) : BadRequest(response);
        }
    }
}

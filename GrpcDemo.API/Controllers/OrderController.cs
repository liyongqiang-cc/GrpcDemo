using GrpcDemo.Client;
using Microsoft.AspNetCore.Mvc;

namespace GrpcDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly Order.OrderClient _client;

        public OrderController(Order.OrderClient client)
        {
            _client = client;
        }

        [HttpGet("create")]
        public async Task<IActionResult> CreateOrder()
        {
            var response = await _client.CreateOrderAsync(
                new CreateRequest
                {
                    OrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                    OrderName = "年货大礼包",
                    Price = 699
                });
            return Ok(response);
        }

    }
}

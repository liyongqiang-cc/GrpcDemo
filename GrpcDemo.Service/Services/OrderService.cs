using Grpc.Core;

namespace GrpcDemo.Service.Services
{
    public class OrderService : Order.OrderBase
    {
        private readonly ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<CreateResult> CreateOrder(CreateRequest request, ServerCallContext context)
        {
            //报存数据库 todo

            return Task.FromResult(new CreateResult
            {
                IsSuccess = true,
                Message = "订单创建成功"
            });
        }
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<QueryResult> QueryOrder(QueryRequest request, ServerCallContext context)
        {
            //查询数据库 //todo

            return Task.FromResult(new QueryResult
            {
                Id = request.Id,
                OrderNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                OrderName = "年货大礼包",
                Price = 699
            });
        }
    }
}

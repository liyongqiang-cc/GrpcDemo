using Grpc.Net.Client;

namespace GrpcDemo.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////常规使用，https
            //string url = "https://localhost:7024";
            //using (var channel = GrpcChannel.ForAddress(url))
            //{
            //    var client = new Order.OrderClient(channel);
            //    var reply = client.CreateOrder(new CreateRequest()
            //    {
            //        OrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
            //        OrderName = "年货大礼包",
            //        Price = 699
            //    });

            //    Console.WriteLine($"Grpc服务https的调用结果:{reply.IsSuccess},message:{reply.Message}");
            //}
            //Console.ReadKey();
            //使用http
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            string url = "http://localhost:5269";

            using (var channel = GrpcChannel.ForAddress(url))
            {
                var client = new Order.OrderClient(channel);
                var reply = client.CreateOrder(new CreateRequest()
                {
                    OrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                    OrderName = "年货大礼包",
                    Price = 699
                });

                Console.WriteLine($"gGrpc内网http调用结果:{reply.IsSuccess},message:{reply.Message}");
            }
            Console.ReadKey();
        }
    }
}

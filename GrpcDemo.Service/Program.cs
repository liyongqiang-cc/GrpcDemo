using GrpcDemo.Service.Services;

namespace GrpcDemo.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ��� gRPC ����
            builder.Services.AddGrpc();

            // Add services to the container.
            builder.Services.AddGrpc();

            var app = builder.Build();

            // ӳ�� gRPC ����
            app.MapGrpcService<OrderService>();


            // Configure the HTTP request pipeline.
            app.MapGrpcService<GreeterService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");


            app.Run();
        }
    }
}
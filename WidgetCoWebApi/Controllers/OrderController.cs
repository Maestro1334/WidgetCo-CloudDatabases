using Azure.Storage.Queues;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Service.Interfaces;

namespace WidgetCoWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private const string QUEUE_TRIGGER = "orders";
        private readonly ILogger _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILoggerFactory loggerFactory, IOrderService orderService)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
            _orderService = orderService;
        }

        public struct AddOrderOut
        {
            [QueueOutput(QUEUE_TRIGGER)]
            public OrderDTO OrderDTO { get; set; }
            public ResponseDTO Response { get; set; }
        }

        [HttpPost(Name = "AddOrder")]
        public async Task<AddOrderOut> AddOrder([FromBody] OrderDTO orderDTO)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();

            // Get the connection string from app settings
            string connectionString = configuration["AzureWebJobsStorage"]!;

            // Instantiate a QueueClient which will be used to create and manipulate the queue
            QueueClient queueClient = new QueueClient(connectionString, QUEUE_TRIGGER, new QueueClientOptions
            {
                // queue is expecting base64 encoding
                MessageEncoding = QueueMessageEncoding.Base64
            });

            // Create the queue if it doesn't already exist
            queueClient.CreateIfNotExists();

            // Get order object in response
            ResponseDTO response = await _orderService.CreateOrder(orderDTO);

            if (queueClient.Exists())
            {
                // Send a message (with json object) to the queue
                queueClient.SendMessage(response.Message);
            }

            Console.WriteLine($"Inserted: {response.Message}");

            return new AddOrderOut
            {
                OrderDTO = orderDTO,
                Response = response
            };
        }
    }
}

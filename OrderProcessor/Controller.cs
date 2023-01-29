using Microsoft.Azure.Functions.Worker;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Service.Interfaces;
using Domain.DTOs;
using Domain.Responses;
using System.Text.Json;
using Domain.Models;

namespace OrderProcessor
{
    public class Controller
    {
        private const string QUEUE_TRIGGER = "orders";
        private const string ORDERS_TO_PROCESS_QUEUE = "orders-to-process";

        private readonly ILogger _logger;
        private readonly IOrderService _orderService;

        public Controller(ILogger logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;   
        }

        [Function("Function1")]
        public void Run([QueueTrigger("orders", Connection = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }

        [Function(nameof(AddOrder))]
        [QueueOutput(ORDERS_TO_PROCESS_QUEUE)]
        public async Task<OrderResponse> AddOrder(
        [QueueTrigger(QUEUE_TRIGGER)] OrderDTO orderToProcess)
        {
            ResponseDTO response = await _orderService.AddOrder(orderToProcess);

            Order order = JsonSerializer.Deserialize<Order>(response.Message);

            return new OrderResponse() { Id = order.Id };
        }

        [Function(nameof(ProcessOrder))]
        public async Task ProcessOrder(
            [QueueTrigger(ORDERS_TO_PROCESS_QUEUE)] OrderResponse order)
        {
            await _orderService.ProcessOrder(order);
        }
    }
}

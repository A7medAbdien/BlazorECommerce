namespace BlazorECommerce.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlaceOrder();
        Task<List<OrderOverviewDTO>> GetOrders();
        Task<OrderDetailsDTO> GetOrderDetails(int orderId);
    }
}

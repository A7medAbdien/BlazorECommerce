namespace BlazorECommerce.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder(int userId);
        Task<ServiceResponse<List<OrderOverviewDTO>>> GetOrders();
        Task<ServiceResponse<OrderDetailsDTO>> GetOrderDetails(int orderId);
    }
}

namespace BlazorECommerce.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder();
        Task<ServiceResponse<List<OrderOverviewDTO>>> GetOrders();
        Task<ServiceResponse<OrderDetailsDTO>> GetOrderDetails(int orderId);
    }
}

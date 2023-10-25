namespace BlazorECommerce.Client.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        event Action OnChange;
        public List<ProductType> ProductTypes { get; set; }
        Task GetProductTypes();
        Task AddProductType(ProductType productType);
        Task DeleteProductType(int productTypeId);
        Task UpdateProductType(ProductType productType);
        ProductType CreateNewProductType();
    }
}

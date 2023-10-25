namespace BlazorECommerce.Server.Services.ProductTypeService
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly DataContext _context;

        public ProductTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<ProductType>>> GetProductTypes()
        {
            var productTypes = await _context.ProductTypes
                .Where(pt => !pt.Deleted)
                .ToListAsync();
            return new ServiceResponse<List<ProductType>> { Data = productTypes };
        }

        public async Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType)
        {
            productType.Editing = productType.IsNew = false;
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        public async Task<ServiceResponse<List<ProductType>>> DeleteProductType(int id)
        {
            ProductType category = await GetProductTypeById(id);
            if (category == null)
            {
                return new ServiceResponse<List<ProductType>>
                {
                    Success = false,
                    Message = "Product Type not found."
                };
            }

            category.Deleted = true;
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        public async Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType)
        {
            var dbProductType = await _context.ProductTypes.FindAsync(productType.Id);
            if (dbProductType == null)
            {
                return new ServiceResponse<List<ProductType>>
                {
                    Success = false,
                    Message = "Product Type not found."
                };
            }

            dbProductType.Name = productType.Name;
            dbProductType.Visible = productType.Visible;
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        private async Task<ProductType> GetProductTypeById(int id)
        {
            return await _context.ProductTypes.FirstOrDefaultAsync(pt => pt.Id == id);
        }
    }
}

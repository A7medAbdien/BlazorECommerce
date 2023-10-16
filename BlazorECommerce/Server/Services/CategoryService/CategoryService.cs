namespace BlazorECommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var result = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = result
            };
        }
    }
}

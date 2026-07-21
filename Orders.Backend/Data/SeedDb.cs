namespace Orders.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckCountriesAsync();
        await CheckCategoriesAsync();
    }

    private async Task CheckCategoriesAsync()
    {
        if (!_context.Categories.Any())
        {
            _context.Categories.Add(new Shared.Entities.Category { Name = "Tecnología" });
            _context.Categories.Add(new Shared.Entities.Category { Name = "Ropa" });
            _context.Categories.Add(new Shared.Entities.Category { Name = "Ferreteria" });
            await _context.SaveChangesAsync();
        }
    }

    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            _context.Countries.Add(new Shared.Entities.Country { Name = "Venezuela" });
            _context.Countries.Add(new Shared.Entities.Country { Name = "México" });
            _context.Countries.Add(new Shared.Entities.Country { Name = "Colombia" });
            await _context.SaveChangesAsync();
        }
    }
}

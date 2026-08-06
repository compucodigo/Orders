using Microsoft.AspNetCore.Components;
using Orders.Frontend.Repositories;
using Orders.Shared.Entities;

namespace Orders.Frontend.Components.Pages.Countries;

public partial class CountriesIndex
{
    [Inject] private IRepository Repository { get; set; } = null!;
    private List<Country>? countries;

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Repository.GetAsync<List<Country>>("api/countries");
        countries = httpResponse.Response;

    }
}
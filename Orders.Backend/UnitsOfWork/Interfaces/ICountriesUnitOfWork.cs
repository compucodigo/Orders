using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Interfaces;

public interface ICountriesUnitOfWork
{
    Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);
    Task<ActionResponse<Country>> GetAsync(int countryId);
    Task<ActionResponse<IEnumerable<Country>>> GetAsync();
    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}

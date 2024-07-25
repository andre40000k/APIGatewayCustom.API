using APIGateway.API.Application.Entyte;

namespace APIGateway.API.Application.Interfaces
{
    public interface IRefDataService
    {
        Task<string> GetDataAsync(string data);
        Task<string> PostData(JsonObjects jsonObjects);
    }
}

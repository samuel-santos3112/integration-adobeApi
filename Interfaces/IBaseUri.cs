using api_teste_adobe.Models;
using Refit;
using System.Threading.Tasks;

namespace api_teste_adobe.Interfaces
{
    
    interface IBaseUri
    {
        [Get("/baseUris")]
        [Headers("Authorization: Bearer")]
        Task<BaseUri> GetAddressAsync();

    }
}

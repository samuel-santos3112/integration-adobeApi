using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api_teste_adobe.Interfaces;
using api_teste_adobe.Models;
using Refit;


namespace api_teste_adobe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var token = "Your Bearer Token";
                var url = RestService.For<IBaseUri>("https://api.na1.echosign.com:443/api/rest/v6/", new RefitSettings()
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(token)
                }); ;

                var baseUri = await url.GetAddressAsync();
                Console.WriteLine(baseUri.ApiAcessPoint);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

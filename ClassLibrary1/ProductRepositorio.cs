using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repositorios.WebApi
{
    public class ProductRepositorio
    {
        private HttpClient HttpClient = new HttpClient();
        private string url = "http://localhost:49693/api/products";

        public async Task<ProductViewModel> Post(ProductViewModel product)
       {
            using (var resposta = await HttpClient.PostAsJsonAsync(url,product))
            {
                resposta.EnsureSuccessStatusCode();
                return await resposta.Content.ReadAsAsync<ProductViewModel>();
            }
        }
    }
}

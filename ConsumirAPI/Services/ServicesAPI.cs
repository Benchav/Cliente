using ConsumirAPI.Models;
using Newtonsoft.Json;

namespace ConsumirAPI.Servicios
{
    public class ServicesAPI : IServicesAPI
    {
        public static  string _base;

        public ServicesAPI()
        {
            var builder = new
                ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _base = builder.GetSection("ApiSetting:baseUr1").Value;
        }

        public async Task<List<ModCategoria>> Lista()
        {
            List<ModCategoria> lista = new List<ModCategoria>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri( _base );

            var response = await cliente.GetAsync("/categoria/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModCategoria>>
                    (json_respuesta);
                lista = resultado;
            }
            return lista;
        }
    }
}

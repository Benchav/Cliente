using ConsumirAPI.Models;
using Newtonsoft.Json;

namespace ConsumirAPI.Servicios
{
    public class ServicesAPI : IServicesAPI
    {
        public static  string _baseurl;

        public ServicesAPI()
        {
            var builder = new
                ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _baseurl = builder.GetSection("ApiSetting:baseUrl").Value;
        }

        public async Task<List<ModeloCategoria>> Lista()
        {
            List<ModeloCategoria> lista = new List<ModeloCategoria>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/Categoria/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloCategoria>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }
    }
}

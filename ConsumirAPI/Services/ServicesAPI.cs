using ConsumirAPI.Models;
using Newtonsoft.Json;
using System.Text;

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


        public async Task<bool> EditarCategorias(ModeloCategoria mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/Categoria/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> Insertar(ModeloCategoria mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/Categoria/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> Delete(Guid id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync("/Categoria/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


    }
}

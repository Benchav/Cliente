using ConsumirAPI.Models;
using Newtonsoft.Json;
using System.Text;

namespace ConsumirAPI.Servicios
{
    public class ServicesAPI : IServicesAPI
    {
        public static string _baseurl;

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


        public async Task<bool> Delete(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            // var content = new StringContent(JsonConvert.SerializeObject(Id), Encoding.UTF8, "application/json");

            var response = await cliente.DeleteAsync($"/Categoria/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }




        //Rol

        public async Task<List<ModeloRol>> Listar()
        {
            List<ModeloRol> lista = new List<ModeloRol>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/Rol/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloRol>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }


        public async Task<bool> EditarRol(ModeloRol mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/Rol/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> InsertarR(ModeloRol mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/Rol/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> DeleteR(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync($"/Rol/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        //Unidad de Medida 

        public async Task<List<ModeloUMedida>> ListaU()
        {
            List<ModeloUMedida> lista = new List<ModeloUMedida>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/UMedida/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloUMedida>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }


        public async Task<bool> EditarU(ModeloUMedida mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/UMedida/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> InsertarU(ModeloUMedida mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/UMedida/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> DeleteU(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync($"/UMedida/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        // USUARIO
        public async Task<List<ModeloUsuario>> ListaUs()
        {
            List<ModeloUsuario> lista = new List<ModeloUsuario>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/Usuario/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloUsuario>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }


        public async Task<bool> EditarUs(ModeloUsuario mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/Usuario/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> InsertarUs(ModeloUsuario mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/Usuario/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> DeleteUs(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync($"/Usuario/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        // PROVEEDOR
        public async Task<List<ModeloProveedor>> ListarP()
        {
            List<ModeloProveedor> lista = new List<ModeloProveedor>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/Proveedor/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloProveedor>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }


        public async Task<bool> EditarP(ModeloProveedor mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/Proveedor/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> InsertarP(ModeloProveedor mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/Proveedor/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> DeleteP(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync($"/Proveedor/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }

        // CLIENTE
        public async Task<List<ModeloCliente>> ListarC()
        {
            List<ModeloCliente> lista = new List<ModeloCliente>();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.GetAsync("/Cliente/listar");
            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ModeloCliente>>(json_respuesta);

                lista = resultado;
            }
            return lista;
        }


        public async Task<bool> EditarC(ModeloCliente mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync("/Cliente/Modificar", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> InsertarC(ModeloCliente mc)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("/Cliente/Agregar/", content);
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }


        public async Task<bool> DeleteC(Guid Id)
        {
            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);

            var response = await cliente.DeleteAsync($"/Cliente/Eliminar/{Id}");
            if (response.IsSuccessStatusCode)
            {
                respuesta = true;
            }
            return respuesta;
        }



        // PROD
        //public async Task<List<ModeloProducto>> ObtenerProductos()
        //{
        //    List<ModeloProducto> lista = new List<ModeloProducto>();

        //    var cliente = new HttpClient();
        //    cliente.BaseAddress = new Uri(_baseurl);

        //    var response = await cliente.GetAsync("/Cliente/listar");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json_respuesta = await response.Content.ReadAsStringAsync();
        //        var resultado = JsonConvert.DeserializeObject<List<ModeloProducto>>(json_respuesta);

        //        lista = resultado;
        //    }
        //    return lista;
        //}


        //public async Task<bool> EditarC(ModeloCliente mc)
        //{
        //    bool respuesta = false;

        //    var cliente = new HttpClient();
        //    cliente.BaseAddress = new Uri(_baseurl);
        //    var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

        //    var response = await cliente.PutAsync("/Cliente/Modificar", content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        respuesta = true;
        //    }
        //    return respuesta;
        //}


        //public async Task<bool> InsertarC(ModeloCliente mc)
        //{
        //    bool respuesta = false;

        //    var cliente = new HttpClient();
        //    cliente.BaseAddress = new Uri(_baseurl);
        //    var content = new StringContent(JsonConvert.SerializeObject(mc), Encoding.UTF8, "application/json");

        //    var response = await cliente.PostAsync("/Cliente/Agregar/", content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        respuesta = true;
        //    }
        //    return respuesta;
        //}


        //public async Task<bool> DeleteC(Guid Id)
        //{
        //    bool respuesta = false;

        //    var cliente = new HttpClient();
        //    cliente.BaseAddress = new Uri(_baseurl);

        //    var response = await cliente.DeleteAsync($"/Cliente/Eliminar/{Id}");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        respuesta = true;
        //    }
        //    return respuesta;
        //}

    }
}
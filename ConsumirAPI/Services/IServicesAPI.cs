using ConsumirAPI.Models;

namespace ConsumirAPI.Servicios
{
    public interface IServicesAPI
    {
     public Task<List<ModeloCategoria>> Lista();
    }
}

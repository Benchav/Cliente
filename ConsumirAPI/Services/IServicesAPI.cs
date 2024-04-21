using ConsumirAPI.Models;

namespace ConsumirAPI.Servicios
{
    public interface IServicesAPI
    {
        Task<List<ModCategoria>> Lista();
    }
}

using ConsumirAPI.Models;

namespace ConsumirAPI.Servicios
{
    public interface IServicesAPI
    {
     public Task<List<ModeloCategoria>> Lista();

      public Task<bool> EditarCategorias(ModeloCategoria mc);

     //   Task EditarCategorias(ModeloCategoria mc);
        Task<bool> Insertar(ModeloCategoria mc);
        Task<bool> Delete(Guid id);
    }
}

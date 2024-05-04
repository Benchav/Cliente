using ConsumirAPI.Models;

namespace ConsumirAPI.Servicios
{
    public interface IServicesAPI
    {
     public Task<List<ModeloCategoria>> Lista();

      public Task<bool> EditarCategorias(ModeloCategoria mc);
      public  Task<bool> Insertar(ModeloCategoria mc);
      public Task<bool> Delete(Guid id);
    }
}

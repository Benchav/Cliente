using ConsumirAPI.Models;

namespace ConsumirAPI.Servicios
{
    public interface IServicesAPI
    {
     public Task<List<ModeloCategoria>> Lista();

      public Task<bool> EditarCategorias(ModeloCategoria mc);
      public  Task<bool> Insertar(ModeloCategoria mc);
      public Task<bool> Delete(Guid Id);

        
    //Roles
        public Task<List<ModeloRol>> Listar();
        public Task<bool> EditarRol(ModeloRol mc);
        public Task<bool> InsertarR(ModeloRol mc);
        public Task<bool> DeleteR(Guid Id);

        //Unidad de Medida
        public Task<List<ModeloUMedida>> ListaU();
        public Task<bool> EditarU(ModeloUMedida mc);
        public Task<bool> InsertarU(ModeloUMedida mc);
        public Task<bool> DeleteU(Guid Id);
    }
}

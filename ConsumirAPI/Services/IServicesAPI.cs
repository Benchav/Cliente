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


        //Usuario
        // hay que ver como hacerlo funcional ya que es un cat secundario """"

        public Task<List<ModeloUsuario>> ListaUs();
        public Task<bool> EditarUs(ModeloUsuario mc);
        public Task<bool> InsertarUs(ModeloUsuario mc);
        public Task<bool> DeleteUs(Guid Id);

        //PROVEEDOR
        public Task<List<ModeloProveedor>> ListarP();
        public Task<bool> EditarP(ModeloProveedor mc);
        public Task<bool> InsertarP(ModeloProveedor mc);
        public Task<bool> DeleteP(Guid Id);

        //CLIENTE
        public Task<List<ModeloCliente>> ListarC();
        public Task<bool> EditarC(ModeloCliente mc);
        public Task<bool> InsertarC(ModeloCliente mc);
        public Task<bool> DeleteC(Guid Id);

    }
}

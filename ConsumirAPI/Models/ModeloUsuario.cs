namespace ConsumirAPI.Models
{
    public class ModeloUsuario : BaseEntity
    {
// como este es catalogo secundario abria que ver la manera de mapearlo
// ademas de validar el inicio y registro con forme a los datos almacenados en la BD de este mismo
        public Guid IdRol { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public string Sexo { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}

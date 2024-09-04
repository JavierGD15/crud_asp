using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pruebasServicio.Models
{
    public class UsuarioModel
    {
        public int id_usuario { get; set; }
        public string? nombre { get; set; }

        public int edad { get; set; }

        public string? correo { get; set; }
    }
}

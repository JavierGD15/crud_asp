using pruebasServicio.Models;
using System.Data.SqlClient;

namespace pruebasServicio.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void InsertarUsuario(UsuarioModel usuario)
        {
            using (SqlConnection con = new SqlConnection(_configuration["ConnectionStrings:conexion"]))
            {
                using (SqlCommand cmd = new SqlCommand("sp_registrar", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = usuario.nombre;
                    cmd.Parameters.Add("@edad", System.Data.SqlDbType.Int).Value = usuario.edad;
                    cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar).Value = usuario.correo;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }

    public interface IUsuarioRepository
    {
        void InsertarUsuario(UsuarioModel usuario);
    }
}
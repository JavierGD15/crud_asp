using pruebasServicio.Models;
using pruebasServicio.Repository;

namespace pruebasServicio.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void RegistrarUsuario(UsuarioModel usuario)
        {
            // Aquí podrías agregar lógica de negocio adicional, como validaciones.
            _usuarioRepository.InsertarUsuario(usuario);
        }
    }

    public interface IUsuarioService
    {
        void RegistrarUsuario(UsuarioModel usuario);
    }
}

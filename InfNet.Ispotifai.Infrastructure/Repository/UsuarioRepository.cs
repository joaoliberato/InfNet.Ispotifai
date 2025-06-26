using InfNet.Ispotifai.Domain;
using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IspotifaiDbContext _context;
        public UsuarioRepository(IspotifaiDbContext context)
        {
            _context = context;
        }

        public Usuario ObterPorEmail(string email)
        {
            return _context.Usuario
                 .FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Usuario
                .FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Salvar(Usuario usuario)
        {
            if (usuario.IdUsuario == 0)
            {
                _context.Usuario.Add(usuario);
            }
            else
            {
                _context.Usuario.Update(usuario);
            }
            _context.SaveChanges();
        }
    }
}

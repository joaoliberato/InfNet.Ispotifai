using InfNet.Ispotifai.Domain;
using InfNet.Ispotifai.Domain.Repository;
using Microsoft.EntityFrameworkCore;
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
                 .FirstOrDefault(u => u.Email == email);
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Usuario
                .Where(u => u.IdUsuario == id)
                .Include(u => u.Favoritas)
                .FirstOrDefault();
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

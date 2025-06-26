using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Domain.Repository
{
    public interface IUsuarioRepository
    {
        void Salvar(Usuario usuario);
        Usuario ObterPorEmail(string email);
        Usuario ObterPorId(int id);
    }
}

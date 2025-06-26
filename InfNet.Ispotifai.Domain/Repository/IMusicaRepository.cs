using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Domain.Repository
{
    public interface IMusicaRepository
    {
        IEnumerable<Musica> ObterMusicas();
        Musica ObterPorId(int idMusica);
    }
}

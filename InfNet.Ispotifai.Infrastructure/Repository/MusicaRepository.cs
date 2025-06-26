using InfNet.Ispotifai.Domain;
using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Infrastructure.Repository
{
    public class MusicaRepository : IMusicaRepository
    {
        private readonly IspotifaiDbContext _context;
        public MusicaRepository(IspotifaiDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Musica> ObterMusicas()
        {
            return _context.Musica.ToList();
        }

        public Musica ObterPorId(int idMusica)
        {
            return _context.Musica.Single(m => m.IdMusica == idMusica);
        }
    }
}

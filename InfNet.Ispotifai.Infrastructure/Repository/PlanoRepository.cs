using InfNet.Ispotifai.Domain;
using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Infrastructure.Repository
{
    public class PlanoRepository : IPlanoRepository
    {
        readonly IspotifaiDbContext _context;
        public PlanoRepository(IspotifaiDbContext context)
        {
            this._context = context;
        }

        public Plano ObterPorId(int plano)
        {
            return _context.Plano.Single(p => p.IdPlano == plano);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application.Dto
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public List<MusicaFavoritaDto> Favoritas { get; set; } = [];
    }
}

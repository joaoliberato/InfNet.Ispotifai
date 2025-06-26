using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application.Dto
{
    public class MusicaFavoritaDto
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public int IdMusica { get; set; }
        public bool Favorita { get; set; }
    }
}

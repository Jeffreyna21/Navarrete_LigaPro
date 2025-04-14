using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Navarrete_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre el equipo")]

        public string Nombre { get; set; }
        [Range(0, 100)]
        public int partidosJugados { get; set; }
        [Range(0, 100)]

        public int partidosGanados { get; set; }
        [Range(0, 100)]

        public int partidosEmpatados { get; set; }
        [Range(0, 100)]
        public int partidosPerdidos { get; set; }

        public int Puntos => (partidosGanados * 3) + (partidosEmpatados * 1);


    }
}

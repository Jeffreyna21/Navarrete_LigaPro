using Navarrete_LigaPro.Models;

namespace Navarrete_LigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipos;

        public EquipoRepository()
        {
            Equipos = DevuelveListadoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosEmpatados = 0,
                partidosPerdidos = 0
            };
            equipos.Add(ldu);

            Equipo idv = new Equipo
            {
                Id = 2,
                Nombre = "Independiente del Valle",
                partidosJugados = 10,
                partidosGanados = 5,
                partidosEmpatados = 1,
                partidosPerdidos = 3
            };
            equipos.Add(idv);

            return (equipos);

        }
        public Equipo DevuelveEquipoPorID(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item => item.Id == Id);
            return equipo;
        }

        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
            //Actualizar el equipo en la base de datos

            return true;
        }
    }
}

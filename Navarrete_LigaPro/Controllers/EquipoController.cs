using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Navarrete_LigaPro.Models;
using Navarrete_LigaPro.Repositories;

namespace Navarrete_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository equipoRepository = new EquipoRepository();
            var equipos = equipoRepository.DevuelveListadoEquipos();

            equipos = equipos.OrderByDescending(item => item.partidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de Quito");

            return View(equipos);
        }
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Edit(int Id)
        {
            var ldu = _repository.DevuelveEquipoPorID(Id);
            return View(ldu);
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                //Proceso de guardado

                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_ef_mvc_agenda.Context;
using api_ef_mvc_agenda.Models;

namespace api_ef_mvc_agenda.Controllers
{
    public class AgendaController : Controller
    {
        private AgendaContext _agendacontext;

        public AgendaController(AgendaContext agendacontext)
        {
            _agendacontext = agendacontext;
        }

        public IActionResult Index()
        {
            var agendas = _agendacontext.Agendas.ToList();
            return View(agendas);
        }

        public IActionResult Criar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(Agenda agenda)
        {
            if(ModelState.IsValid)
            {
                agenda.Data = DateTime.SpecifyKind(agenda.Data, DateTimeKind.Utc);
                _agendacontext.Agendas.Add(agenda);
                _agendacontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        public IActionResult Editar(int id){
            var agendaEditarId = _agendacontext.Agendas.Find(id);

            if(agendaEditarId == null){
                return RedirectToAction(nameof(Index));
            }

            return View(agendaEditarId);
        }

        [HttpPost]
        public IActionResult Editar(Agenda agenda)
        {
            var agendaUpdate = _agendacontext.Agendas.Find(agenda.Id);

            agendaUpdate.Titulo = agenda.Titulo;
            agendaUpdate.Descricao = agenda.Descricao;
        
            agenda.Data = DateTime.SpecifyKind(agenda.Data, DateTimeKind.Utc);
            agendaUpdate.Data = agenda.Data;
            agendaUpdate.Status = agenda.Status;

            _agendacontext.Agendas.Update(agendaUpdate);
            _agendacontext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes (int id){
            var agendaId = _agendacontext.Agendas.Find(id);

            if(agendaId == null){
                return RedirectToAction(nameof(Index));
            }

            return View(agendaId);
        }

        public IActionResult FindAll()
        {
            return View();
        }

        public IActionResult Delete(int id){
            var agendaEditarId = _agendacontext.Agendas.Find(id);

            if(agendaEditarId == null){
                return RedirectToAction(nameof(Index));
            }

            return View(agendaEditarId);
        }

        [HttpPost]
        public IActionResult Delete(Agenda agenda)
        {
            var agendaDelete = _agendacontext.Agendas.Find(agenda.Id);

            _agendacontext.Agendas.Remove(agendaDelete);
            _agendacontext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
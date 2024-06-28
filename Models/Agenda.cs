using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_ef_mvc_agenda.Models
{
    public class Agenda
    {
        public enum TypesStatus
        {
            Pendente,
            Finalizado,
            Aguardando
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }   
        public TypesStatus Status  { get; set; }  
    }
}
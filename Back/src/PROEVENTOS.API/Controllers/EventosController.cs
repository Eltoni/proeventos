using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Data;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class EventosController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {

               new Evento()
               { EventoId = 1,
                Local="São Paulo",
                DataEvento = " 20/06/2021",
                Tema = "Aprendendo C#",
                QtdPessoas= 1678,
                ImagemURL= "Areatrabalho/imagens",
                Lote= "1º Lote"
                },

                new Evento()
               { EventoId = 2,
                Local="São Paulo",
                DataEvento = " 20/06/2021",
                Tema = "Aprendendo C#",
                QtdPessoas= 1092,
                ImagemURL= "Areatrabalho/imagens/logo.png",
                Lote= "1º Lote"
                }
            };
        private readonly DataContext context;

        public EventosController(DataContext context)
        {
            this.context = context;



        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return  context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
    }
}

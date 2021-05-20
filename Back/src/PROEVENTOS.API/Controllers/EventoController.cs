using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    
    public class EventoController : ControllerBase
    {

        public IEnumerable <Evento> _evento = new Evento[] {

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
        public EventoController()
        {


        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApiCelulares.Entidades;

namespace WebApiAlumnos.Controllers
{

    [ApiController]
    [Route("api/celulares")]

    public class CelularesController : ControllerBase
    {
        public ActionResult<List<Celular>> Get()
        {
            return new List<Celular>()
            {
                new Celular() {precio = 3000, modelo = "xiaomi redmi 10", descripcion = "precio calidad"},
                new Celular() {precio = 3500, modelo = "samsung a30", descripcion = "buen celular"}
            };
        }
      

    }
}

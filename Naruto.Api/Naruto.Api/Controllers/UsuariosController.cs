using Microsoft.AspNetCore.Mvc;
using Naruto.Api.DataBase;
using Naruto.Api.Models;

namespace Naruto.Api.Controllers
{

    [Route("/api/[controller]/[action]")]
    public class UsuariosController : Controller
    {
        private readonly NarutoContext _narutoContext;

        public UsuariosController(NarutoContext narutoContext)
        {
            _narutoContext = narutoContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_narutoContext.Usuarios.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {   
            return Ok(_narutoContext.Usuarios.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario model)
        {
            _narutoContext.Usuarios.Add(model);
            await _narutoContext.SaveChangesAsync();

            return Ok(model);
        }
    }
}

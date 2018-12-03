using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ucare.Datos;
using Ucare.Entidades.Usuarios;
using Ucare.Web.Models.Usuarios.Rol;

namespace Ucare.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public RolesController(DbContextSistema context)
        {
            _context = context;
        }
        
        private bool RolExists(int id)
        {
            return _context.Roles.Any(e => e.idrol == id);
        }

        // GET: api/Rol/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<RolViewModel>> Listar()
        {

            var rol = await _context.Roles.ToListAsync();

            return rol.Select(r => new RolViewModel
            {
                idrol = r.idrol,
                nombre = r.nombre,
                descripcion = r.descripcion,
                estado = r.estado
            });

        }

        // GET: api/Rol/Select
        [HttpGet("[action]")]
        public async Task<IEnumerable<SelectViewModel>> Select()
        {
            var rol = await _context.Roles.Where(r => r.estado == true).ToListAsync();

            return rol.Select(r => new SelectViewModel
            {
                idrol = r.idrol,
                nombre = r.nombre
            });
        }
    }
}
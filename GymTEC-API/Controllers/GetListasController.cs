using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymTEC_API.DB;


namespace GymTEC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetListasController : ControllerBase
    {
        private readonly ILogger<GetListasController> _logger;

        public GetListasController(ILogger<GetListasController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("GetUsuarioActual")]
        public IList<Usuario> Get_UsuarioActual()
        {
            IList<Usuario> list = new List<Usuario>();
            list.Add(Administrador.usuarioActual);
            return list;
        }
        
        [HttpGet]
        [Route("GetAdminActual")]
        public IList<Empleado> Get_AdminActual()
        {
            IList<Empleado> list = new List<Empleado>();
            list.Add(Administrador.empleadoActual);
            return list;
        }
        
        [HttpGet]
        [Route("GetSucursalActual")]
        public IList<Sucursal> Get_SucursalActual()
        {
            IList<Sucursal> list = new List<Sucursal>();
            list.Add(Administrador.sucursalActual);
            return list;
        }
        
        [HttpGet]
        [Route("GetClases")]
        public IList<Clases> Get_Clases()
        {
            return Administrador.listaClases;
        }
        
        [HttpGet]
        [Route("GetEmpleados")]
        public IList<Empleado> Get_Empleados()
        {
            return Administrador.listaEmpleados;
        }
        
        [HttpGet]
        [Route("GetInventario")]
        public IList<Inventario> Get_Inventario()
        {
            return Administrador.listaInventario;
        }
        
        [HttpGet]
        [Route("GetProductos")]
        public IList<Producto> Get_Productos()
        {
            return Administrador.listaProductos;
        }
        
        [HttpGet]
        [Route("GetPuesto")]
        public IList<Puesto> Get_Puesto()
        {
            return Administrador.listaPuesto;
        }
        
        [HttpGet]
        [Route("GetServicio")]
        public IList<Servicio> Get_Servicio()
        {
            return Administrador.listaServicio;
        }
        
        [HttpGet]
        [Route("GetSpa")]
        public IList<Spa> Get_Spa()
        {
            return Administrador.listaSpa;
        }
        
        [HttpGet]
        [Route("GetSucursal")]
        public IList<Sucursal> Get_Sucursal()
        {
            return Administrador.listaSucursal;
        }
        
        [HttpGet]
        [Route("GetTipoEquipo")]
        public IList<TipoDeEquipo> Get_TipoEquipo()
        {
            return Administrador.listaTipoEquipo;
        }
        
        [HttpGet]
        [Route("GetTipoPlanilla")]
        public IList<TipoPlanilla> Get_TipoPlanilla()
        {
            return Administrador.listaTipoPlanilla;
        }
        
        [HttpGet]
        [Route("GetUsuario")]
        public IList<Usuario> Get_Usuario()
        {
            return Administrador.listaUsuario;
        }
        
    }
}
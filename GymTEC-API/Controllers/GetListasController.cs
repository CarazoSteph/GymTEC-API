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
            return Administrador.getUsuarioActual();
        }
        
        [HttpGet]
        [Route("GetAdminActual")]
        public IList<Empleado> Get_AdminActual()
        {
            return Administrador.getAdminActual();
        }
        
        [HttpGet]
        [Route("GetSucursalActual")]
        public IList<Sucursal> Get_SucursalActual()
        {
            return Administrador.getSucursalActual();
        }
        
        [HttpGet]
        [Route("GetClases")]
        public IList<Clases> Get_Clases()
        {
            return Administrador.getClases();
        }
        
        [HttpGet]
        [Route("GetEmpleados")]
        public IList<Empleado> Get_Empleados()
        {
            return Administrador.getEmpleados();
        }
        
        [HttpGet]
        [Route("GetInventario")]
        public IList<Inventario> Get_Inventario()
        {
            return Administrador.getInventario();
        }
        
        [HttpGet]
        [Route("GetProductos")]
        public IList<Producto> Get_Productos()
        {
            return Administrador.getProductos();
        }
        
        [HttpGet]
        [Route("GetPuesto")]
        public IList<Puesto> Get_Puesto()
        {
            return Administrador.getPuesto();
        }
        
        [HttpGet]
        [Route("GetServicio")]
        public IList<Servicio> Get_Servicio()
        {
            return Administrador.getServicio();
        }
        
        [HttpGet]
        [Route("GetSpa")]
        public IList<Spa> Get_Spa()
        {
            return Administrador.getSpa();
        }
        
        [HttpGet]
        [Route("GetSucursal")]
        public IList<Sucursal> Get_Sucursal()
        {
            return Administrador.getSucusal();
        }
        
        [HttpGet]
        [Route("GetTipoEquipo")]
        public IList<TipoDeEquipo> Get_TipoEquipo()
        {
            return Administrador.getTipoEquipo();
        }
        
        [HttpGet]
        [Route("GetTipoPlanilla")]
        public IList<TipoPlanilla> Get_TipoPlanilla()
        {
            return Administrador.getTipoPlanilla();
        }
        
        [HttpGet]
        [Route("GetUsuario")]
        public IList<Usuario> Get_Usuario()
        {
            return Administrador.getUsuario();
        }
        
    }
}
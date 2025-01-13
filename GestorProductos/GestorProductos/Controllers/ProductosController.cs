using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestorProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productosController : Controller
    {
        private readonly AppDBContext _dbContext;
        public string password;

        public productosController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        { 
            return Ok(await _dbContext.Productos.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

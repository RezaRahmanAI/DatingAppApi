using DatingApi.Data;
using DatingApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserController(ApplicationDbContext context) : Controller
    {
        
        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetAll()
        {
            var users = await context.AppUsers.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> getUser(int id) {
            var user = await context.AppUsers.FindAsync(id);
            if (user == null) return NotFound();

            return user;
        }
    }
}

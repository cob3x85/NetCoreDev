using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly StoreContext _context;

    public AuthController(StoreContext context)
    {
      _context = context;

      if (_context.Users.Count() == 0)
      {
        _context.Users.Add(new User { Name = "Carlos", Description = " name test dotnet", Email = "testing@netcore.com" });
        _context.SaveChanges();
      }
    }



  }
}

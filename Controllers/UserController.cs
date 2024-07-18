using Microsoft.AspNetCore.Mvc;
using WebAppGB_ForDocker.Abstraction;
using WebAppGB_ForDocker.Dtos;
using WebAppGB_ForDocker.Models;

namespace WebAppGB_ForDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_user")]
        public ActionResult<int> AddUser(UserDto user)
        {
            try
            {
                return Ok(_repository.AddUser(user));
            }
            catch (Exception ex) 
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<RoleId> CheckUser(LoginDto login)
        {
            try
            {
                return Ok(_repository.CheckUser(login));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }
    }
}

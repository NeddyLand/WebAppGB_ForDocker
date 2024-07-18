using WebAppGB_ForDocker.Dtos;
using WebAppGB_ForDocker.Models;

namespace WebAppGB_ForDocker.Abstraction
{
    public interface IUserRepository
    {
        int AddUser(UserDto user);
        RoleId CheckUser(LoginDto login);
    }
}

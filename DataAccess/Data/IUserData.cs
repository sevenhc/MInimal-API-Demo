using DataAccess.Models;

namespace DataAccess.Data;

public interface IUserData
{
    Task AddUser(UsersModel user);
    Task DeleteUser(int id);
    Task<UsersModel?> GetUserByID(int id);
    Task<IEnumerable<UsersModel>> GetUsers();
    Task UpdateUser(UsersModel user);
}
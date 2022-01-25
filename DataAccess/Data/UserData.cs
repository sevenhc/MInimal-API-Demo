using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISQLDataAccess _db;

    public UserData(ISQLDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<UsersModel>> GetUsers() =>
        _db.LoadData<UsersModel, dynamic>(storedProcedure: "dbo.GetAllUsers", new { });

    public async Task<UsersModel?> GetUserByID(int id)
    {
        var result = await _db.LoadData<UsersModel, dynamic>(
            storedProcedure: "GetUserByID",
            new { ID = id });
        return result.FirstOrDefault();
    }

    public Task AddUser(UsersModel user) =>
        _db.SaveData(storedProcedure: "AddUser", new { user.FirstName, user.LastName });

    public Task UpdateUser(UsersModel user) =>
        _db.SaveData(storedProcedure: "UpdateUser", user);

    public Task DeleteUser(int id) =>
        _db.SaveData(storedProcedure: "DeleteUser", new { ID = id });

}

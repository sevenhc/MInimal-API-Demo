﻿
namespace DataAccess.DBAccess;

public interface ISQLDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
    Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
}
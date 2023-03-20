﻿using System.Collections.Generic;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
        User AddUser(string username, string password);
        List<int> ViewAccountIds();

        int GetBalance(int user_id);

        int GetAccountId(int userId);


    }
}

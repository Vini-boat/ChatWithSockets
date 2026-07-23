using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    internal class GroupService
    {
        private readonly Database _database;
        public GroupService(Database database)
        {
            _database = database;
        }

        public string? CreateGroup(string groupName)
        {
            bool ok = _database.CreateGroup(groupName);
            if (!ok)
            {
                return "Group name is already in use.";
            }
            return null;
        }

        public string? AddUserToGroup(string groupName, string username)
        {
            bool ok = _database.AddUserToGroup(groupName, username);
            if (!ok)
            {
                return "Error adding user to group. Please verify if user and group exist.";
            }
            return null;
        }

        public List<string> GetUserGroups(string userName)
        {
            return _database.GetUserGroups(userName);
        }

        public List<string> GetGroupUsers(string groupName)
        {
            return _database.GetGroupUsers(groupName);
        }
    }
}

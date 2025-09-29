using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Furkan", Email = "Furkan58@gmail.com", Phone = "5896578545", WillAttend = false });
            _users.Add(new UserInfo() { Id = 2, Name = "Şahan", Email = "Şahan_aydin@gmail.com", Phone = "7896547896", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Ayşe", Email = "Gülayşe@gmail.com", Phone = "05897894684", WillAttend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
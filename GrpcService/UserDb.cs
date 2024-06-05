﻿namespace GrpcService
{
    public class UserDb
    {
        public UserDb()
        {
            _users = [];
        }

        private List<User> _users;
        public List<User> Users => _users;

        public void CreateUser(string username, string password) => 
            _users.Add(new User 
            { 
                Id = Guid.NewGuid().ToString(), 
                Username = username, 
                Password = password 
            });

        public void UpdateUser(string id, string? username, string? password)
        {
            var existedUser = _users.FirstOrDefault(u => u.Id == id);
            if (existedUser != null)
            {
                if (username != null)
                    existedUser.Username = username;

                if (password != null)
                    existedUser.Password = password;
            }
        }

        public void DeleteUser(string id)
        {
            var existedUser = _users.FirstOrDefault(u => u.Id == id);
            if (existedUser != null)
            {
                _users.Remove(existedUser);
            }
        }        
    }
}

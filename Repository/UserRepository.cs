using System.Data.Common;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model.User;

namespace Repository
{
    public class UserRepository : IUser
    {
        private readonly DataBaseContext _context = new DataBaseContext();
        public void Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public List<User> Get()
        {
            return _context.User.ToList();
        }
    }
}
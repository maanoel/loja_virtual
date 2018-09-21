using LojaVirtual.Business;
using LojaVirtual.Model;
using LojaVirtual.Model.Context;
using System.Linq;

namespace LojaVirtual.Repository.Implementations
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly MySQLContext _context;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}

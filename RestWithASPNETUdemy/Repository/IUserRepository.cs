using LojaVirtual.Model;
using System.Collections.Generic;

namespace LojaVirtual.Business
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}

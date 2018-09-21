using LojaVirtual.Model;

namespace LojaVirtual.Business
{
    public interface ILoginBusiness
    {
         object FindByLogin(UserVO user);
    }
}

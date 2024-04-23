using ProjBackTeste.Application.Interface;

namespace ProjBackTeste.Application.Service
{
    public class UserService : IUserService
    {
        public UserService() { }

        public string GetUser()
        {
            return "user";
        }

        

    }
}

using CinemaODVM.Domain;
using CinemaODVM.Helpers;

namespace CinemaODVM.Services
{
    class LoginService
    {
        public static LoginResponse SignIn(LoginRequest userInfo)
        {
            var LoginInfo = LoginAPIHelper.Post<LoginResponse>("", userInfo);
            return LoginInfo;
        }
    }
}

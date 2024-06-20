namespace GestaoEquipamentos.WinFormsApp.AuthModule
{
    public class AuthController
    {
        private readonly UserRepo UserRepo;
        public AuthController()
        {
            UserRepo = new UserRepo();
        }

        public bool Auth(string username, string password)
        {
            User? user = UserRepo.FindUserByLogin(username);
            if (user != null && user.Password.Equals(password))
            {
                return true;
            }
            throw new AuthException();
        }
    }

    public class AuthException : Exception
    {
        public AuthException(string message = "Invalid credential") : base(message)
        {
        }
    }
}

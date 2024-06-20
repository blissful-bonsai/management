namespace GestaoEquipamentos.WinFormsApp.AuthModule
{
    public class UserRepo
    {
        private List<User> UserList { get; set; }

        public UserRepo()
        {
            UserList = new List<User>();
            Seed();
        }

        public User FindUserByLogin(string login)
        {
            return UserList.Find(u => u.Login == login);
        }

        private void Seed()
        {
            UserList = new List<User>();
            UserList.Add(new User { Login = "admin", Password = "admin", IsAdmin = true });
        }
    }
}

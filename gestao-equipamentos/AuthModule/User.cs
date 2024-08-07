using GestaoEquipamentos.WinFormsApp.SharedModule;
namespace GestaoEquipamentos.WinFormsApp.AuthModule
{
    public class User : BaseModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public override string Validate()
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(Login))
            {
                errorMessage = "Check login field";
            }
            return errorMessage;
        }
    }
}

namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    public class Equipment
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid SerialNumber { get; set; }
        public DateTime FabricationDate { get; set; }
        public string Brand { get; set; }
        public DateTime LastMaintenance { get; set; }


        public Equipment()
        {
            SerialNumber = Guid.NewGuid();
        }

        public string Validate()
        {
            string error = string.Empty;
            if (Name == string.Empty || Name.Length < 6)
            {
                error += "Invalid name, needs at least six characters";
            }

            return error;
        }
    }
}

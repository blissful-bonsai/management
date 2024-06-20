namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    public class EquipmentRepo
    {
        private List<Equipment> equipments { get; set; }

        public EquipmentRepo()
        {
            equipments = new List<Equipment>();
            Seed();
        }

        public void Seed()
        {
            equipments.Add(new Equipment()
            {
                FabricationDate = new DateTime(2020, 12, 09),
                Brand = "HP",
                Name = "LaserJet J6545",
                Number = "321321",
                Price = 1000
            });
            equipments.Add(new Equipment()
            {
                FabricationDate = new DateTime(2022, 05, 15),
                Brand = "Canon",
                Name = "Pixma TS8320",
                Number = "321321",
                Price = 750
            });
        }

        public List<Equipment> FindAllEquipments()
        {
            return equipments;
        }

        public void AddEquipment(Equipment equipment)
        {
            this.equipments.Add(equipment);
        }

    }
}

namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    public class EquipmentController
    {
        public EquipmentRepo EquipmentRepo { get; set; }

        public EquipmentController()
        {
            EquipmentRepo = new EquipmentRepo();
        }

        public List<Equipment> GetAllEquipments()
        {
            return EquipmentRepo.FindAllEquipments();
        }

        public void Add()
        {
            EquipmentForm equipmentForm = new EquipmentForm();
            equipmentForm.ShowDialog();

            Equipment equipment = equipmentForm.Equipment;

            // Validation
            EquipmentRepo.AddEquipment(equipment);
        }
    }
}

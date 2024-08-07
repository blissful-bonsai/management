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


        /// <summary>
        /// Controller usually asks for user interaction
        //  Usually has the return from the model-user interaction
        //  This method is showing the form AND validating/registering the data
        /// </summary>
        public void Add()
        {
            string result = string.Empty;
            // Begins the registration process
            EquipmentForm equipmentForm = new EquipmentForm();

            // Loop to make sure there are no validation errors
            do
            {
                equipmentForm.ShowErrorMessage(result);
                if (equipmentForm.ShowDialog() == DialogResult.OK)
                {
                    Equipment equipment = equipmentForm.Equipment;
                    result = equipment.Validate();

                    // If result is empty (no errors), we add the equipment to the "database"
                    if (string.IsNullOrEmpty(result))
                    {
                        EquipmentRepo.AddEquipment(equipment);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            while (!string.IsNullOrEmpty(result));
            // This is the return of the user-model interaction
        }

        public void Edit(Equipment equipment)
        {
            EquipmentForm editEquipmentForm = new EquipmentForm(equipment);
            if (equipment != null && equipment.Name != "")
            {
                if (editEquipmentForm.Equipment.Name != "" && editEquipmentForm.Equipment.Name != null)
                {
                    editEquipmentForm.ShowDialog();
                }
            }
        }

        public void Remove(Equipment equipment)
        {
            if (equipment != null && equipment.Name != "")
            {
                EquipmentRepo.DeleteEquipment(equipment);
            }
        }
    }
}

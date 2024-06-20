namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    public partial class EquipmentForm : Form
    {
        public Equipment Equipment { get; set; }
        public EquipmentForm()
        {
            Equipment equipment = new Equipment();
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        public EquipmentForm(Equipment equipment)
        {
            InitializeComponent();
            Equipment = equipment;
            nameTextBox.Text = Equipment.Name;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Equipment.Number = numberTextBox.Text;
            Equipment.Name = nameTextBox.Text;
            Equipment.FabricationDate = DateTime.Parse(dateTimeFab.Text);
            Equipment.LastMaintenance = DateTime.Parse(dateTimeLast.Text);
            Equipment.Price = decimal.Parse(priceTextBox.Text);
            Equipment.Brand = brandTextBox.Text;

            string result = Equipment.Validate();
            if (result.Length > 0)
            {
                toolStripStatusLabel1.Text = result;
                return;
            }
            this.Close();

        }
    }
}

// This form has access to the MODEL only
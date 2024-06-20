namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    public partial class EquipmentForm : Form
    {
        public Equipment Equipment { get; set; }
        public EquipmentForm()
        {
            InitializeComponent();
            Equipment = new Equipment();
            toolStripStatusLabel1.Text = "";
        }
        public EquipmentForm(Equipment equipment)
        {
            InitializeComponent();
            Equipment = equipment;
            nameTextBox.Text = Equipment.Name;
            numberTextBox.Text = Equipment.Number;
            priceTextBox.Text = Equipment.Price.ToString();
            dateTimeFab.Value = new DateTime(2020, 12, 09);
            dateTimeLast.Value = new DateTime(2020, 12, 09);
            brandTextBox.Text = Equipment.Brand;
            serialNumberTextBox.Text = Equipment.SerialNumber.ToString();
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

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

// This form has access to the MODEL only
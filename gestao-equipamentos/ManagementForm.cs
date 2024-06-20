using GestaoEquipamentos.WinFormsApp.EquipmentModule;
namespace WinFormsApp1;
public partial class ManagementForm : Form
{
    private EquipmentController EquipmentController { get; set; }
    public ManagementForm()
    {
        InitializeComponent();

        EquipmentController = new EquipmentController();

        this.dataGridView1.DataSource = EquipmentController.GetAllEquipments();
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EquipmentController.Add();
        this.dataGridView1.DataSource = EquipmentController.GetAllEquipments().ToList(); // Why?
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (this.dataGridView1.CurrentRow != null)
        {
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Equipment equipment = EquipmentController.EquipmentRepo.FindEquipmentByName(name);
            if (equipment != null && equipment.Name != "")
            {
                EquipmentController.Edit(equipment);
            }
        }
        else
        {
            MessageBox.Show("Row index out of bounds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

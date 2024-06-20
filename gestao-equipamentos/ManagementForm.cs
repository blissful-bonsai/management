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


}

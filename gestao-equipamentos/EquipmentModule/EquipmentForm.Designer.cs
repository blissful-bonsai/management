namespace GestaoEquipamentos.WinFormsApp.EquipmentModule
{
    partial class EquipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            serialNumberTextBox = new TextBox();
            priceTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            numberTextBox = new TextBox();
            label5 = new Label();
            brandTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimeFab = new DateTimePicker();
            dateTimeLast = new DateTimePicker();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 189);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // serialNumberTextBox
            // 
            serialNumberTextBox.BackColor = Color.PeachPuff;
            serialNumberTextBox.Location = new Point(137, 9);
            serialNumberTextBox.Name = "serialNumberTextBox";
            serialNumberTextBox.ReadOnly = true;
            serialNumberTextBox.Size = new Size(283, 23);
            serialNumberTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.PeachPuff;
            priceTextBox.Location = new Point(137, 154);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(283, 23);
            priceTextBox.TabIndex = 3;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 44);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 73);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "FabricationDate";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.PeachPuff;
            nameTextBox.Location = new Point(137, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(283, 23);
            nameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 131);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Brand";
            // 
            // numberTextBox
            // 
            numberTextBox.BackColor = Color.PeachPuff;
            numberTextBox.Location = new Point(137, 183);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(283, 23);
            numberTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 15);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "SerialNumber";
            // 
            // brandTextBox
            // 
            brandTextBox.BackColor = Color.PeachPuff;
            brandTextBox.Location = new Point(137, 125);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(283, 23);
            brandTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 160);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 102);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 12;
            label7.Text = "LastMaintenance";
            // 
            // dateTimeFab
            // 
            dateTimeFab.Location = new Point(137, 67);
            dateTimeFab.Name = "dateTimeFab";
            dateTimeFab.Size = new Size(283, 23);
            dateTimeFab.TabIndex = 13;
            // 
            // dateTimeLast
            // 
            dateTimeLast.Location = new Point(137, 96);
            dateTimeLast.Name = "dateTimeLast";
            dateTimeLast.Size = new Size(283, 23);
            dateTimeLast.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Location = new Point(345, 212);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 15;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 270);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(432, 22);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 17);
            toolStripStatusLabel1.Text = "Errors:";
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 292);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(dateTimeLast);
            Controls.Add(dateTimeFab);
            Controls.Add(label7);
            Controls.Add(brandTextBox);
            Controls.Add(label6);
            Controls.Add(numberTextBox);
            Controls.Add(label5);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(serialNumberTextBox);
            Controls.Add(label1);
            Name = "EquipmentForm";
            Text = "EquipmentForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox serialNumberTextBox;
        private TextBox priceTextBox;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private TextBox numberTextBox;
        private Label label5;
        private TextBox brandTextBox;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimeFab;
        private DateTimePicker dateTimeLast;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
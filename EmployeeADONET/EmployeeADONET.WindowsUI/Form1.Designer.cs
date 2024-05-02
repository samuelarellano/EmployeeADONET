namespace EmployeeADONET.WindowsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadEmployees = new Button();
            lstEmployees = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSaveEmployee = new Button();
            SuspendLayout();
            // 
            // btnLoadEmployees
            // 
            btnLoadEmployees.Location = new Point(595, 291);
            btnLoadEmployees.Name = "btnLoadEmployees";
            btnLoadEmployees.Size = new Size(75, 23);
            btnLoadEmployees.TabIndex = 0;
            btnLoadEmployees.Text = "Load Employees";
            btnLoadEmployees.UseVisualStyleBackColor = true;
            btnLoadEmployees.Click += btnLoadEmployees_Click;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(497, 47);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(262, 229);
            lstEmployees.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 63);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Occupation";
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Location = new Point(211, 162);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(75, 23);
            btnSaveEmployee.TabIndex = 4;
            btnSaveEmployee.Text = "Save";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveEmployee);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lstEmployees);
            Controls.Add(btnLoadEmployees);
            Name = "Form1";
            Text = "Employee ADONET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadEmployees;
        private ListBox lstEmployees;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnSaveEmployee;
    }
}

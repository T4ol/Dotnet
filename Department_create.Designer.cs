namespace Lab4
{
    partial class DepartmentCreate
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
            save_button = new Button();
            cancel_button = new Button();
            textBoxNameDepartment = new TextBox();
            textBoxQuntity = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // save_button
            // 
            save_button.DialogResult = DialogResult.OK;
            save_button.Location = new Point(726, 467);
            save_button.Margin = new Padding(3, 4, 3, 4);
            save_button.Name = "save_button";
            save_button.Size = new Size(86, 31);
            save_button.TabIndex = 0;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.DialogResult = DialogResult.Cancel;
            cancel_button.Location = new Point(146, 467);
            cancel_button.Margin = new Padding(3, 4, 3, 4);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(86, 31);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // textBoxNameDepartment
            // 
            textBoxNameDepartment.Location = new Point(270, 64);
            textBoxNameDepartment.Margin = new Padding(3, 4, 3, 4);
            textBoxNameDepartment.Name = "textBoxNameDepartment";
            textBoxNameDepartment.Size = new Size(114, 27);
            textBoxNameDepartment.TabIndex = 2;
            // 
            // textBoxQuntity
            // 
            textBoxQuntity.Location = new Point(270, 149);
            textBoxQuntity.Margin = new Padding(3, 4, 3, 4);
            textBoxQuntity.Name = "textBoxQuntity";
            textBoxQuntity.Size = new Size(114, 27);
            textBoxQuntity.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 160);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Quntity";
            // 
            // DepartmentCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQuntity);
            Controls.Add(textBoxNameDepartment);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DepartmentCreate";
            Text = "Department";
            Load += Department_create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_button;
        private Button cancel_button;
        private TextBox textBoxNameDepartment;
        private TextBox textBoxQuntity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
    }
}
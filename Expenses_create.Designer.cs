namespace Lab4
{
    partial class ExpensesCreate
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
            label2 = new Label();
            label1 = new Label();
            cancel_button = new Button();
            save_button = new Button();
            textBoxSumNormal = new TextBox();
            label3 = new Label();
            textBoxDate = new TextBox();
            label4 = new Label();
            comboBoxTypeExpenses = new ComboBox();
            comboBoxNameDepartment = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 12;
            label2.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 88);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 11;
            label1.Text = "Types_expenses";
            // 
            // cancel_button
            // 
            cancel_button.DialogResult = DialogResult.Cancel;
            cancel_button.Location = new Point(125, 487);
            cancel_button.Margin = new Padding(3, 4, 3, 4);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(86, 31);
            cancel_button.TabIndex = 8;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            save_button.DialogResult = DialogResult.OK;
            save_button.Location = new Point(704, 487);
            save_button.Margin = new Padding(3, 4, 3, 4);
            save_button.Name = "save_button";
            save_button.Size = new Size(86, 31);
            save_button.TabIndex = 7;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // textBoxSumNormal
            // 
            textBoxSumNormal.Location = new Point(248, 255);
            textBoxSumNormal.Margin = new Padding(3, 4, 3, 4);
            textBoxSumNormal.Name = "textBoxSumNormal";
            textBoxSumNormal.Size = new Size(114, 27);
            textBoxSumNormal.TabIndex = 10;
            textBoxSumNormal.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 259);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 12;
            label3.Text = "Sum";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(248, 339);
            textBoxDate.Margin = new Padding(3, 4, 3, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(114, 27);
            textBoxDate.TabIndex = 10;
            textBoxDate.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 343);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 12;
            label4.Text = "Date";
            // 
            // comboBoxTypeExpenses
            // 
            comboBoxTypeExpenses.FormattingEnabled = true;
            comboBoxTypeExpenses.Location = new Point(248, 88);
            comboBoxTypeExpenses.Margin = new Padding(3, 4, 3, 4);
            comboBoxTypeExpenses.Name = "comboBoxTypeExpenses";
            comboBoxTypeExpenses.Size = new Size(114, 28);
            comboBoxTypeExpenses.TabIndex = 13;
            comboBoxTypeExpenses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxNameDepartment
            // 
            comboBoxNameDepartment.FormattingEnabled = true;
            comboBoxNameDepartment.Location = new Point(248, 169);
            comboBoxNameDepartment.Margin = new Padding(3, 4, 3, 4);
            comboBoxNameDepartment.Name = "comboBoxNameDepartment";
            comboBoxNameDepartment.Size = new Size(114, 28);
            comboBoxNameDepartment.TabIndex = 14;
            comboBoxNameDepartment.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // ExpensesCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBoxNameDepartment);
            Controls.Add(comboBoxTypeExpenses);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDate);
            Controls.Add(label2);
            Controls.Add(textBoxSumNormal);
            Controls.Add(label1);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExpensesCreate";
            Text = "Expenses";
            Load += Expenses_create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button cancel_button;
        private Button save_button;
        private TextBox textBoxSumNormal;
        private Label label3;
        private TextBox textBoxDate;
        private Label label4;
        private ComboBox comboBoxTypeExpenses;
        private ComboBox comboBoxNameDepartment;
    }
}
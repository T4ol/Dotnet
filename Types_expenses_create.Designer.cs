namespace Lab4
{
    partial class TypesExpensesCreate
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
            textBoxDiscription = new TextBox();
            textBoxNameExpenses = new TextBox();
            cancel_button = new Button();
            save_button = new Button();
            textBoxNormal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 180);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 12;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 95);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // textBoxDiscription
            // 
            textBoxDiscription.Location = new Point(248, 180);
            textBoxDiscription.Margin = new Padding(3, 4, 3, 4);
            textBoxDiscription.Name = "textBoxDiscription";
            textBoxDiscription.Size = new Size(114, 27);
            textBoxDiscription.TabIndex = 10;
            textBoxDiscription.TextChanged += textBox2_TextChanged;
            // 
            // textBoxNameExpenses
            // 
            textBoxNameExpenses.Location = new Point(248, 84);
            textBoxNameExpenses.Margin = new Padding(3, 4, 3, 4);
            textBoxNameExpenses.Name = "textBoxNameExpenses";
            textBoxNameExpenses.Size = new Size(114, 27);
            textBoxNameExpenses.TabIndex = 9;
            textBoxNameExpenses.TextChanged += textBox1_TextChanged;
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
            // textBoxNormal
            // 
            textBoxNormal.Location = new Point(248, 283);
            textBoxNormal.Margin = new Padding(3, 4, 3, 4);
            textBoxNormal.Name = "textBoxNormal";
            textBoxNormal.Size = new Size(114, 27);
            textBoxNormal.TabIndex = 10;
            textBoxNormal.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 287);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Norma";
            label3.Click += label2_Click;
            // 
            // TypesExpensesCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNormal);
            Controls.Add(textBoxDiscription);
            Controls.Add(textBoxNameExpenses);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TypesExpensesCreate";
            Text = "Types_expenses";
            Load += Types_expenses_create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBoxDiscription;
        private TextBox textBoxNameExpenses;
        private Button cancel_button;
        private Button save_button;
        private TextBox textBoxNormal;
        private Label label3;
    }
}
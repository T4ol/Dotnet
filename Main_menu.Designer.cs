namespace Lab4
{
    partial class Main_menu
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
            menuStrip1 = new MenuStrip();
            отделыToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            reductToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            typexpToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            reductToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            expToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            reductToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DepartmentView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabPage2 = new TabPage();
            TypesExpensesView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            tabPage3 = new TabPage();
            ExpensesView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { отделыToolStripMenuItem, typexpToolStripMenuItem, expToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += CreateToolStripMenuItem_Click;
            // 
            // отделыToolStripMenuItem
            // 
            отделыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, reductToolStripMenuItem, deleteToolStripMenuItem });
            отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            отделыToolStripMenuItem.Size = new Size(82, 20);
            отделыToolStripMenuItem.Text = "Department";
            отделыToolStripMenuItem.Click += RuductToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(111, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click_1;
            // 
            // reductToolStripMenuItem
            // 
            reductToolStripMenuItem.Name = "reductToolStripMenuItem";
            reductToolStripMenuItem.Size = new Size(111, 22);
            reductToolStripMenuItem.Text = "Reduct";
            reductToolStripMenuItem.Click += reductToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(111, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteDepartment;
            // 
            // typexpToolStripMenuItem
            // 
            typexpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1, reductToolStripMenuItem1, deleteToolStripMenuItem1 });
            typexpToolStripMenuItem.Name = "typexpToolStripMenuItem";
            typexpToolStripMenuItem.Size = new Size(101, 20);
            typexpToolStripMenuItem.Text = "Types_expenses";
            typexpToolStripMenuItem.Click += typexpToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(180, 22);
            createToolStripMenuItem1.Text = "Create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // reductToolStripMenuItem1
            // 
            reductToolStripMenuItem1.Name = "reductToolStripMenuItem1";
            reductToolStripMenuItem1.Size = new Size(180, 22);
            reductToolStripMenuItem1.Text = "Reduct";
            reductToolStripMenuItem1.Click += reductToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(180, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteTypesExpenses;
            // 
            // expToolStripMenuItem
            // 
            expToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, reductToolStripMenuItem2, deleteToolStripMenuItem2 });
            expToolStripMenuItem.Name = "expToolStripMenuItem";
            expToolStripMenuItem.Size = new Size(67, 20);
            expToolStripMenuItem.Text = "Expenses";
            expToolStripMenuItem.Click += expToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "Create";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // reductToolStripMenuItem2
            // 
            reductToolStripMenuItem2.Name = "reductToolStripMenuItem2";
            reductToolStripMenuItem2.Size = new Size(180, 22);
            reductToolStripMenuItem2.Text = "Reduct";
            reductToolStripMenuItem2.Click += reductToolStripMenuItem2_Click;
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(180, 22);
            deleteToolStripMenuItem2.Text = "Delete";
            deleteToolStripMenuItem2.Click += deleteExpenses;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DepartmentView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Department";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DepartmentView
            // 
            DepartmentView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            DepartmentView.Dock = DockStyle.Fill;
            DepartmentView.Location = new Point(3, 3);
            DepartmentView.Name = "DepartmentView";
            DepartmentView.Size = new Size(786, 392);
            DepartmentView.TabIndex = 0;
            DepartmentView.UseCompatibleStateImageBehavior = false;
            DepartmentView.View = View.Details;
            DepartmentView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NameDepartment";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quntity";
            columnHeader3.Width = 100;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TypesExpensesView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Types_expenses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TypesExpensesView
            // 
            TypesExpensesView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            TypesExpensesView.Dock = DockStyle.Fill;
            TypesExpensesView.Location = new Point(3, 3);
            TypesExpensesView.Name = "TypesExpensesView";
            TypesExpensesView.Size = new Size(786, 392);
            TypesExpensesView.TabIndex = 0;
            TypesExpensesView.UseCompatibleStateImageBehavior = false;
            TypesExpensesView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TypeExpenses";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Discription";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Normalexpenses";
            columnHeader7.Width = 140;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ExpensesView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Expenses";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExpensesView
            // 
            ExpensesView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            ExpensesView.Dock = DockStyle.Fill;
            ExpensesView.Location = new Point(3, 3);
            ExpensesView.Name = "ExpensesView";
            ExpensesView.Size = new Size(786, 392);
            ExpensesView.TabIndex = 0;
            ExpensesView.UseCompatibleStateImageBehavior = false;
            ExpensesView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Id";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Department";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "NameExpenses";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "SumExpenses";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Date";
            columnHeader12.Width = 100;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_menu";
            Text = "Menu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem отделыToolStripMenuItem;
        private ToolStripMenuItem typexpToolStripMenuItem;
        private ToolStripMenuItem expToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem reductToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem reductToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem reductToolStripMenuItem2;
        private ListView DepartmentView;
        private ListView TypesExpensesView;
        private TabPage tabPage3;
        private ListView ExpensesView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem2;
    }
}

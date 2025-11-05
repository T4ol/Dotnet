using ClassLibrary1;
using WinFormsControlLibrary2;

namespace Lab4
{
    public partial class Main_menu : Form
    {
        private Department dep_;
        private TypesExpenses typ_exp_;
        private Expenses exp_;

        private void updateViewDepartment()
        {
            DepartmentView.Items.Clear();
            foreach (var item in DepartmentBD.Instance.Department)
            {
                ListViewItem dep = new ListViewItem($"{item.Key}");
                dep.Tag = item.Value;
                dep.SubItems.Add(item.Value.NameDepartment);
                dep.SubItems.Add($"{item.Value.Quntity}");
                DepartmentView.Items.Add(dep);
            }
        }

        private void updateViewTypesExpenses()
        {
            TypesExpensesView.Items.Clear();
            foreach (var item in DepartmentBD.Instance.TypesExpenses)
            {
                ListViewItem typexp = new ListViewItem($"{item.Key}");
                typexp.Tag = item.Value;
                typexp.SubItems.Add(item.Value.NameExpenses);
                typexp.SubItems.Add(item.Value.Descripsion);
                typexp.SubItems.Add($"{item.Value.Normal}");
                TypesExpensesView.Items.Add(typexp);
            }
        }

        private void updateViewExpenses()
        {
            // Очищаем контейнер и добавляем пользовательские элементы управления
            tabPage3.Controls.Clear();
            
            foreach (var expense in DepartmentBD.Instance.Expenses)
            {
                LibraryElement userControl = new LibraryElement(expense)
                {
                    Dock = DockStyle.Top
                };
                tabPage3.Controls.Add(userControl);
            }
        }

        public Main_menu()
        {
            InitializeComponent();
            InitializeDeleteHandlers();
        }

        private void InitializeDeleteHandlers()
        {
            DepartmentView.KeyDown += HandleDeleteKey;
            TypesExpensesView.KeyDown += HandleDeleteKey;
            this.KeyPreview = true;
            this.KeyDown += HandleDeleteKey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateViewDepartment();
            updateViewTypesExpenses();
            updateViewExpenses();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void RuductToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void typexpToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void expToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                TypesExpensesCreate form = new TypesExpensesCreate();
                DialogResult result;
                do
                {
                    result = form.ShowDialog();
                }
                while (result == DialogResult.TryAgain);

                DepartmentBD.Instance.TypesExpenses.Add((int)form.TypesExpenses.Id, form.TypesExpenses);
                updateViewTypesExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании типа трат: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TypesExpensesView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите тип расходов для редактирования");
                return;
            }

            var selectedItem = TypesExpensesView.SelectedItems[0];
            if (selectedItem.Tag is TypesExpenses selectedTypesExpenses)
            {
                TypesExpensesCreate form = new TypesExpensesCreate(selectedTypesExpenses);
                DialogResult result;

                do
                {
                    result = form.ShowDialog();
                }
                while (result == DialogResult.TryAgain);

                if (result == DialogResult.OK)
                {
                    updateViewTypesExpenses();
                    MessageBox.Show("Тип расходов успешно обновлен");
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExpensesCreate form = new ExpensesCreate();
                DialogResult result;
                do
                {
                    result = form.ShowDialog();
                }
                while (result == DialogResult.TryAgain);

                DepartmentBD.Instance.Expenses.Add(form.Expenses);
                updateViewExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании траты: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reductToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (Control control in tabPage3.Controls)
                {
                    if (control is LibraryElement userControl && userControl.Selected)
                    {
                        var expense = userControl.Expense;
                        ExpensesCreate form = new ExpensesCreate(expense);
                        
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            userControl.UpdateDisplay();
                            found = true;
                        }
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Выберите расход для редактирования");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании расхода: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                DepartmentCreate form = new DepartmentCreate();
                DialogResult result;
                do
                {
                    result = form.ShowDialog();
                }
                while (result == DialogResult.TryAgain);

                DepartmentBD.Instance.Department.Add((int)form.Department.Id, form.Department);
                updateViewDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отдела: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Выберите Отдел для редактирования");
                    return;
                }

                var selectedDepartment = DepartmentView.SelectedItems[0].Tag as Department;
                if (selectedDepartment == null) return;

                DepartmentCreate form = new DepartmentCreate(selectedDepartment);
                DialogResult result;

                do
                {
                    result = form.ShowDialog();
                }
                while (result == DialogResult.TryAgain);

                if (result == DialogResult.OK)
                {
                    DepartmentBD.Instance.Department[(int)selectedDepartment.Id] = selectedDepartment;
                    updateViewDepartment();
                    MessageBox.Show("Отдел успешно обновлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании отдела: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void HandleDeleteKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (tabPage3.Focused || tabPage3.ContainsFocus)
                {
                    deleteExpenses(sender, e);
                }
                else if (DepartmentView.Focused)
                {
                    deleteDepartment(sender, e);
                }
                else if (TypesExpensesView.Focused)
                {
                    deleteTypesExpenses(sender, e);
                }
            }
        }

        private void deleteDepartment(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = DepartmentView.SelectedItems[0];
                    int departmentId = int.Parse(selectedItem.Text);
                    string departmentName = selectedItem.SubItems[1].Text;

                    DialogResult confirmResult = MessageBox.Show(
                        $"Вы уверены, что хотите удалить отдел '{departmentName}'?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        if (DepartmentBD.Instance.Department.Remove(departmentId))
                        {
                            updateViewDepartment();
                            MessageBox.Show($"Отдел '{departmentName}' успешно удален",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить отдел",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите отдел для удаления");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка формата ID: {ex.Message}", "Ошибка формата",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении отдела: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteTypesExpenses(object sender, EventArgs e)
        {
            try
            {
                if (TypesExpensesView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = TypesExpensesView.SelectedItems[0];
                    int typesExpensesId = int.Parse(selectedItem.Text);
                    string typesExpensesName = selectedItem.SubItems[1].Text;

                    DialogResult confirmResult = MessageBox.Show(
                        $"Вы уверены, что хотите удалить тип траты '{typesExpensesName}'?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        if (DepartmentBD.Instance.TypesExpenses.Remove(typesExpensesId))
                        {
                            updateViewTypesExpenses();
                            MessageBox.Show($"Тип траты '{typesExpensesName}' успешно удален",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить тип траты",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип траты для удаления");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка формата ID: {ex.Message}", "Ошибка формата",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении типа трат: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteExpenses(object sender, EventArgs e)
        {
            try
            {
                List<LibraryElement> controlsToRemove = new List<LibraryElement>();
                
                foreach (Control control in tabPage3.Controls)
                {
                    if (control is LibraryElement userControl && userControl.Selected)
                    {
                        controlsToRemove.Add(userControl);
                    }
                }

                if (controlsToRemove.Count > 0)
                {
                    DialogResult confirmResult = MessageBox.Show(
                        $"Вы уверены, что хотите удалить выбранные расходы ({controlsToRemove.Count} шт.)?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        foreach (var userControl in controlsToRemove)
                        {
                            DepartmentBD.Instance.Expenses.Remove(userControl.Expense);
                            tabPage3.Controls.Remove(userControl);
                        }
                        
                        MessageBox.Show($"Удалено {controlsToRemove.Count} расходов",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите расходы для удаления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении расходов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
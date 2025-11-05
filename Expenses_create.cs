using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ExpensesCreate : Form
    {
        public Expenses? Expenses { get; } = new Expenses();

        public ExpensesCreate(Expenses? expenses = null)
        {
            InitializeComponent();
            if (expenses != null)
            {
                Expenses = expenses;
            }

            try
            {
                foreach (var department in DepartmentBD.Instance.Department.Values)
                {
                    comboBoxTypeExpenses.Items.Add(department);
                }

                comboBoxTypeExpenses.DisplayMember = "NameDepartment";
                comboBoxTypeExpenses.ValueMember = "Id";

                if (Expenses?.Department != null)
                {
                    comboBoxTypeExpenses.SelectedValue = Expenses.Department.Id;
                }
                else if (comboBoxTypeExpenses.Items.Count > 0)
                {
                    comboBoxTypeExpenses.SelectedIndex = 0;
                }
                else
                {
                    comboBoxTypeExpenses.SelectedIndex = -1;
                }

                comboBoxNameDepartment.Items.Clear();

                foreach (var typeExpense in DepartmentBD.Instance.TypesExpenses.Values)
                {
                    comboBoxNameDepartment.Items.Add(typeExpense);
                }

                comboBoxNameDepartment.DisplayMember = "NameExpenses";
                comboBoxNameDepartment.ValueMember = "Id";

                if (Expenses?.TypesExpenses != null)
                {
                    comboBoxNameDepartment.SelectedValue = Expenses.TypesExpenses.Id;
                }
                else if (comboBoxNameDepartment.Items.Count > 0)
                {
                    comboBoxNameDepartment.SelectedIndex = 0;
                }
                else
                {
                    comboBoxNameDepartment.SelectedIndex = -1;
                }

                textBoxSumNormal.Text = Expenses?.Sum.ToString() ?? "";
                textBoxDate.Text = Expenses?.Date.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при инициализации формы: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Expenses_create_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeExpenses.SelectedItem is not Department selectedDepartment)
                {
                    throw new ValidationException("Выберите департамент!", comboBoxTypeExpenses);
                }

                if (comboBoxNameDepartment.SelectedItem is not TypesExpenses selectedType)
                {
                    throw new ValidationException("Выберите тип расходов!", comboBoxNameDepartment);
                }

                if (string.IsNullOrWhiteSpace(textBoxSumNormal.Text))
                {
                    throw new ValidationException("Введите сумму расходов!", textBoxSumNormal);
                }

                if (!int.TryParse(textBoxSumNormal.Text, out int sum))
                {
                    throw new ValidationException("Сумма должна быть целым числом!", textBoxSumNormal);
                }

                if (sum <= 0)
                {
                    throw new ValidationException("Сумма должна быть положительным числом!", textBoxSumNormal);
                }

                if (string.IsNullOrWhiteSpace(textBoxDate.Text))
                {
                    throw new ValidationException("Введите дату!", textBoxDate);
                }

                if (!DateTime.TryParse(textBoxDate.Text, out DateTime date))
                {
                    throw new ValidationException("Введите корректную дату!", textBoxDate);
                }

                if (date > DateTime.Now)
                {
                    throw new ValidationException("Дата не может быть в будущем!", textBoxDate);
                }

                Expenses.Department = selectedDepartment;
                Expenses.TypesExpenses = selectedType;
                Expenses.Sum = sum;
                Expenses.Date = date;

                MessageBox.Show("Данные успешно сохранены!", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ValidationException vex)
            {
                vex.Control.Focus();
                if (vex.Control is TextBox textBox)
                {
                    textBox.SelectAll();
                }
                MessageBox.Show(vex.Message, "Ошибка валидации",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSumNormal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSumNormal.Text))
                {
                    textBoxSumNormal.BackColor = SystemColors.Window;
                    return;
                }

                if (!int.TryParse(textBoxSumNormal.Text, out int sum) || sum <= 0)
                {
                    textBoxSumNormal.BackColor = Color.LightPink;
                }
                else
                {
                    textBoxSumNormal.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                textBoxSumNormal.BackColor = Color.LightPink;
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxDate.Text))
                {
                    textBoxDate.BackColor = SystemColors.Window;
                    return;
                }

                if (!DateTime.TryParse(textBoxDate.Text, out DateTime date) || date > DateTime.Now)
                {
                    textBoxDate.BackColor = Color.LightPink;
                }
                else
                {
                    textBoxDate.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                textBoxDate.BackColor = Color.LightPink;
            }
        }

        private void comboBoxTypeExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeExpenses.SelectedItem == null)
                {
                    comboBoxTypeExpenses.BackColor = Color.LightPink;
                }
                else
                {
                    comboBoxTypeExpenses.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                comboBoxTypeExpenses.BackColor = Color.LightPink;
            }
        }

        private void comboBoxNameDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNameDepartment.SelectedItem == null)
                {
                    comboBoxNameDepartment.BackColor = Color.LightPink;
                }
                else
                {
                    comboBoxNameDepartment.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                comboBoxNameDepartment.BackColor = Color.LightPink;
            }
        }

        private void textBoxSumNormal_Enter(object sender, EventArgs e)
        {
            textBoxSumNormal.BackColor = SystemColors.Window;
        }

        private void textBoxDate_Enter(object sender, EventArgs e)
        {
            textBoxDate.BackColor = SystemColors.Window;
        }

        private void comboBoxTypeExpenses_Enter(object sender, EventArgs e)
        {
            comboBoxTypeExpenses.BackColor = SystemColors.Window;
        }

        private void comboBoxNameDepartment_Enter(object sender, EventArgs e)
        {
            comboBoxNameDepartment.BackColor = SystemColors.Window;
        }

        private class ValidationException : Exception
        {
            public Control Control { get; }

            public ValidationException(string message, Control control) : base(message)
            {
                Control = control;
            }
        }
    }
}
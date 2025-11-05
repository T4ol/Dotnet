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
    public partial class TypesExpensesCreate : Form
    {
        public TypesExpenses? TypesExpenses { get; } = new TypesExpenses();

        public TypesExpensesCreate(TypesExpenses? typesexpenses = null)
        {
            InitializeComponent();
            if (typesexpenses != null)
            {
                TypesExpenses = typesexpenses;
            }

            textBoxNameExpenses.Text = TypesExpenses.NameExpenses;
            textBoxDiscription.Text = TypesExpenses.Descripsion;
            textBoxNormal.Text = $"{TypesExpenses.Normal}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Types_expenses_create_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNameExpenses.Text))
                {
                    throw new ValidationException("Введите название расходов!", textBoxNameExpenses);
                }

                if (textBoxNameExpenses.Text.Length < 2)
                {
                    throw new ValidationException("Название расходов должно содержать минимум 2 символа!", textBoxNameExpenses);
                }

                if (!string.IsNullOrWhiteSpace(textBoxDiscription.Text) && textBoxDiscription.Text.Length < 5)
                {
                    throw new ValidationException("Описание должно содержать минимум 5 символов!", textBoxDiscription);
                }

                if (string.IsNullOrWhiteSpace(textBoxNormal.Text))
                {
                    throw new ValidationException("Введите норму расходов!", textBoxNormal);
                }

                if (!int.TryParse(textBoxNormal.Text, out int normal))
                {
                    throw new ValidationException("Норма расходов должна быть целым числом!", textBoxNormal);
                }

                if (normal < 0)
                {
                    throw new ValidationException("Норма расходов не может быть отрицательной!", textBoxNormal);
                }

                if (normal == 0)
                {
                    throw new ValidationException("Норма расходов не может быть равна нулю!", textBoxNormal);
                }

                TypesExpenses.NameExpenses = textBoxNameExpenses.Text.Trim();
                TypesExpenses.Descripsion = textBoxDiscription.Text.Trim();
                TypesExpenses.Normal = normal;

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
        private void textBoxNameExpenses_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNameExpenses.Text))
                {
                    textBoxNameExpenses.BackColor = SystemColors.Window;
                    return;
                }

                if (textBoxNameExpenses.Text.Length < 2)
                {
                    textBoxNameExpenses.BackColor = Color.LightPink;
                }
                else
                {
                    textBoxNameExpenses.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                textBoxNameExpenses.BackColor = Color.LightPink;
            }
        }

        private void textBoxDiscription_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxDiscription.Text))
                {
                    textBoxDiscription.BackColor = SystemColors.Window;
                    return;
                }

                if (textBoxDiscription.Text.Length < 5)
                {
                    textBoxDiscription.BackColor = Color.LightPink;
                }
                else
                {
                    textBoxDiscription.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                textBoxDiscription.BackColor = Color.LightPink;
            }
        }

        private void textBoxNormal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNormal.Text))
                {
                    textBoxNormal.BackColor = SystemColors.Window;
                    return;
                }

                if (!int.TryParse(textBoxNormal.Text, out int normal) || normal <= 0)
                {
                    textBoxNormal.BackColor = Color.LightPink;
                }
                else
                {
                    textBoxNormal.BackColor = Color.LightGreen;
                }
            }
            catch (Exception)
            {
                textBoxNormal.BackColor = Color.LightPink;
            }
        }
        private void textBoxNameExpenses_Enter(object sender, EventArgs e)
        {
            textBoxNameExpenses.BackColor = SystemColors.Window;
        }

        private void textBoxDiscription_Enter(object sender, EventArgs e)
        {
            textBoxDiscription.BackColor = SystemColors.Window;
        }

        private void textBoxNormal_Enter(object sender, EventArgs e)
        {
            textBoxNormal.BackColor = SystemColors.Window;
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
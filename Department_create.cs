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
    public partial class DepartmentCreate : Form
    {
        public Department? Department { get; } = new Department();

        public DepartmentCreate(Department? department = null)
        {
            InitializeComponent();
            if (department != null)
            {
                Department = department;
            }
            textBoxNameDepartment.Text = Department.NameDepartment;
            textBoxQuntity.Text = $"{Department.Quntity}";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNameDepartment.Text))
                {
                    MessageBox.Show("Введите название отдела", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNameDepartment.Focus();
                    return;
                }

                if (!int.TryParse(textBoxQuntity.Text, out int quantity))
                {
                    MessageBox.Show("Введите корректное количество сотрудников (целое число)", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxQuntity.Focus();
                    textBoxQuntity.SelectAll();
                    return;
                }

                if (quantity < 0)
                {
                    MessageBox.Show("Количество сотрудников не может быть отрицательным", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxQuntity.Focus();
                    textBoxQuntity.SelectAll();
                    return;
                }

                if (quantity > 10000)
                {
                    DialogResult result = MessageBox.Show(
                        $"Вы указали очень большое количество сотрудников: {quantity}. Продолжить?",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        textBoxQuntity.Focus();
                        textBoxQuntity.SelectAll();
                        return;
                    }
                }

                Department.NameDepartment = textBoxNameDepartment.Text.Trim();
                Department.Quntity = quantity;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuntity_TextChanged(object sender, EventArgs e)
        {
            ValidateQuantityField();
        }

        private void ValidateQuantityField()
        {
            if (!string.IsNullOrWhiteSpace(textBoxQuntity.Text))
            {
                if (!int.TryParse(textBoxQuntity.Text, out int quantity) || quantity < 0)
                {
                    textBoxQuntity.BackColor = Color.LightPink; 
                }
                else
                {
                    textBoxQuntity.BackColor = SystemColors.Window; 
                }
            }
            else
            {
                textBoxQuntity.BackColor = SystemColors.Window;
            }
        }
        private void textBoxNameDepartment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameDepartment.Text))
            {
                textBoxNameDepartment.BackColor = Color.LightPink;
            }
            else
            {
                textBoxNameDepartment.BackColor = SystemColors.Window;
            }
        }

        private void Department_create_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBoxNameDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_button_Click(sender, e);
            }
        }

        private void textBoxQuntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_button_Click(sender, e);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace DGV2
{
    public partial class FormDGV2 : Form
    {
        public FormDGV2()
        {
            InitializeComponent();
            comboBoxColumnType.SelectedIndex = 0;
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxColumnType.SelectedIndex;

            if (selectedIndex == 0)
            {
                // typ 1. Sloupec TextBox
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = textBoxColumnAdd.Text;
                column.Width = 50;
                column.HeaderText = textBoxColumnAdd.Text;
                // přidání sloupce do datagridview
                dataGridViewAddColumns.Columns.Add(column);
            }

            if (selectedIndex == 1)
            {
                // typ 2. Sloupec Button
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = textBoxColumnAdd.Text;
                buttonColumn.Width = 50;
                buttonColumn.HeaderText = textBoxColumnAdd.Text;
                // přidání sloupce do datagridview
                dataGridViewAddColumns.Columns.Add(buttonColumn);
            }

            if (selectedIndex == 2)
            {
                // typ 3. Sloupec CheckBox
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = textBoxColumnAdd.Text;
                checkBoxColumn.Width = 50;
                checkBoxColumn.HeaderText = textBoxColumnAdd.Text;
                // přidání sloupce do datagridview
                dataGridViewAddColumns.Columns.Add(checkBoxColumn);
            }

            if (selectedIndex == 3)
            {
                // typ 4. Sloupec ComboBox
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.Name = textBoxColumnAdd.Text;
                comboBoxColumn.Width = 50;
                comboBoxColumn.HeaderText = textBoxColumnAdd.Text;
                // přidání sloupce do datagridview
                dataGridViewAddColumns.Columns.Add(comboBoxColumn);
            }

            if (selectedIndex == 4) {
                // typ 5. Sloupec Image
                DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
                dataGridViewImageColumn.Name = textBoxColumnAdd.Text;
                dataGridViewImageColumn.Width = 50;
                dataGridViewImageColumn.HeaderText = textBoxColumnAdd.Text;
                // přidání sloupce do datagridview
                dataGridViewAddColumns.Columns.Add(dataGridViewImageColumn);
            }
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewAddColumns.Columns)
            {
                if (column.HeaderText == textBoxColumnDelete.Text)
                {
                    dataGridViewAddColumns.Columns.Remove(column);
                    return;
                }
            }
        }
    }
}

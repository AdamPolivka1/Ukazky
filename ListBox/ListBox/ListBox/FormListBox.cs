using System.Windows.Forms;

namespace ListBox
{
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newItem = textBoxAddItem.Text;
            listBoxMain.Items.Add(newItem);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int removeIndex = listBoxMain.SelectedIndex;

            if (listBoxMain.Items.Count == 0)
                return;

            if (removeIndex == -1)
            {
                removeIndex = listBoxMain.Items.Count - 1;
            }

            listBoxMain.Items.RemoveAt(removeIndex);
            textBoxActItem.Text = string.Empty;
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxMain.Items.Clear();
            textBoxActItem.Text = string.Empty;
        }

        private void listBoxMain_SelectedValueChanged(object sender, EventArgs e)
        {
            var sV = listBoxMain.SelectedItem;
            if (sV != null)
            {
                textBoxActItem.Text = sV.ToString();
            }
        }

    }
}

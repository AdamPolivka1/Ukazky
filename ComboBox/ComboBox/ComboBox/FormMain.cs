namespace ComboBox
{
    class ComboBoxItem
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public ComboBoxItem(int id, string name)
        { 
            Id = id;
            Name = name;
        }
    }

    public partial class FormMain : Form
    {
        private List<ComboBoxItem> _items = new List<ComboBoxItem>();

        public FormMain()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _items = new List<ComboBoxItem>();
            _items.Add(new ComboBoxItem(1, "Objednávka A"));
            _items.Add(new ComboBoxItem(2, "Objednávka B"));
            _items.Add(new ComboBoxItem(3, "Objednávka C"));
            _items.Add(new ComboBoxItem(4, "Objednávka D"));

            comboBox.DataSource = _items;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = _items[comboBox.SelectedIndex];
            textBox1.Text = selectedItem.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

    }
}

using System.Data;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGrid();
            RefreshDataGrid();
        }

        private void ApplyStyles()
        {
            productDGV.AllowUserToResizeRows = false; // nepůjde měnit velikost řádku
            productDGV.AllowUserToAddRows = false; // nepůjde přidávat řádky
            productDGV.RowHeadersVisible = false; // nezobrazuj odrážku aktualního řádku
            // označí celý řádek při kliknutí na sloupec
            productDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDGV.MultiSelect = false; // zakáže výběr více řádků 
            productDGV.EnableHeadersVisualStyles = false;// povol vlastní styly
            productDGV.BackgroundColor = Color.White;
            productDGV.GridColor = Color.LightSeaGreen;
            productDGV.RowTemplate.Height = 30; // výška řádků
            productDGV.RowsDefaultCellStyle.BackColor = Color.White;
            productDGV.RowsDefaultCellStyle.ForeColor = Color.Black;
            // výběr
            productDGV.DefaultCellStyle.SelectionBackColor = Color.MediumTurquoise;
            productDGV.DefaultCellStyle.SelectionForeColor = Color.White;
            // hlavička
            productDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkTurquoise;
            productDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productDGV.ColumnHeadersDefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;
            productDGV.ColumnHeadersHeight = 25;
            productDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupGrid()
        {
            // zde probíhá přizpůsobení gridu

            // 0. vyčištění
            productDGV.DataSource = null;
            productDGV.Columns.Clear();
            productDGV.Rows.Clear();

            // 1. kontexty
            ContextMenuStrip ctxMenuGrid = new ContextMenuStrip();
            ctxMenuGrid.Items.Add("[+] Upravit", null, OnEditClick);
            ctxMenuGrid.Items.Add("[-] Smazat", null, OnDeleteClick);
            productDGV.ContextMenuStrip = ctxMenuGrid;

            // nastavení stylů
            ApplyStyles();

            productDGV.AllowUserToOrderColumns = false;
            productDGV.ReadOnly = true;
        }

        private void OnDeleteClick(object? sender, EventArgs e)
        {
            MessageBox.Show("Neimplementováno");
        }

        private void OnEditClick(object? sender, EventArgs e)
        {
            MessageBox.Show("Neimplementováno");
        }

        private void RefreshDataGrid()
        {
            // zde probíhá naplnění daty
            DataTable table = new DataTable();
            table.Columns.Add("ID objednávky", typeof(int));
            table.Columns.Add("Název produktu", typeof(string));
            table.Columns.Add("Cena/ks", typeof(decimal));
            table.Columns.Add("Počet objednaní", typeof(int));

            object[][] dataDGV = new object[][]
            {
                new object[] { 1, "Notebook", 29999, 5 },
                new object[] { 2, "Myš", 499, 25 },
                new object[] { 3, "Klávesnice", 899, 15 },
                new object[] { 4, "Monitor LCD", 3999, 8 },
                new object[] { 5, "Tiskárna", 2499, 4 },
                new object[] { 6, "USB kabel", 299, 50 }
            };

            // Přidání řádků do DataGridView
            foreach (var row in dataDGV)
            {
                table.Rows.Add(row);
            }

            productDGV.DataSource = table;
        }
    }
}

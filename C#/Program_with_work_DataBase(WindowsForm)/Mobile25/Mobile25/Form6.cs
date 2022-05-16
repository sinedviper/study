using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile25 {
    public partial class Form6 : Form {

        public string MyQuery6 = "SELECT ФИО, Общая_оценка, Название, Тренер " +
            "FROM Города INNER JOIN (Оценки INNER JOIN Участники " +
            "ON Оценки.ID_Оценки = Участники.Оценки) " +
            "ON Города.ID_Города = Участники.Города ";

        public string MyConStr6 = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source = |DataDirectory|\Кристина.accdb;";
        OleDbConnection MyConnect6;
        OleDbDataAdapter MyAdapt6;
        DataTable My_dt6;

        public Form6() {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e) {
            MyConnect6 = new OleDbConnection(MyConStr6);
            MyConnect6.Open();
            MyAdapt6 = new OleDbDataAdapter(MyQuery6, MyConnect6);
            My_dt6 = new DataTable();
            MyAdapt6.Fill(My_dt6);
            dataGridView1.DataSource = My_dt6;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            MyConnect6.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            MyConnect6 = new OleDbConnection(MyConStr6);
            MyConnect6.Open();
            MyAdapt6 = new OleDbDataAdapter(MyQuery6 + " WHERE ФИО LIKE '" + textBox1.Text + "%'", MyConnect6);
            My_dt6 = new DataTable();
            MyAdapt6.Fill(My_dt6);
            dataGridView1.DataSource = My_dt6;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            MyConnect6.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            MyConnect6 = new OleDbConnection(MyConStr6);
            MyConnect6.Open();
            MyAdapt6 = new OleDbDataAdapter(MyQuery6 + " WHERE Тренер LIKE '" + textBox2.Text + "%'", MyConnect6);
            My_dt6 = new DataTable();
            MyAdapt6.Fill(My_dt6);
            dataGridView1.DataSource = My_dt6;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            MyConnect6.Close();
        }
    }
}
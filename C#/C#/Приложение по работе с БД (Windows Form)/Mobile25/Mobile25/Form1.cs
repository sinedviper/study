using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile25 {
    public partial class Form1 : Form  {

        public static string MyConStr = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source = |DataDirectory|\Кристина.accdb;";

        public System.Data.OleDb.OleDbConnection MyConnect;

        public DataSet ds;

        public OleDbDataAdapter OceAdapter;
        public OleDbDataAdapter GorAdapter;
        public OleDbDataAdapter UchAdapter;

        DataRelation OceUchRel;
        DataRelation GorUchRel;

        public string SQLStr0 = "SELECT * FROM Оценки";
        public string SQLStr1 = "SELECT * FROM Города";
        public string SQLStr2 = "SELECT * FROM Участники";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            MyConnect = new System.Data.OleDb.OleDbConnection(MyConStr);
            MyConnect.Open();
            ds = new DataSet();

            OceAdapter = new OleDbDataAdapter(SQLStr0, MyConnect);
            OceAdapter.Fill(ds, "Оценки");

            GorAdapter = new OleDbDataAdapter(SQLStr1, MyConnect);
            GorAdapter.Fill(ds, "Города");

            UchAdapter = new OleDbDataAdapter(SQLStr2, MyConnect);
            UchAdapter.Fill(ds, "Участники");

            OceUchRel = ds.Relations.Add("OceUch",
                ds.Tables["Оценки"].Columns["ID_Оценки"],
                ds.Tables["Участники"].Columns["Оценки"]);

            GorUchRel = ds.Relations.Add("GorUch",
                ds.Tables["Города"].Columns["ID_Города"],
                ds.Tables["Участники"].Columns["Города"]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (MyConnect != null && MyConnect.State != ConnectionState.Closed)
                MyConnect.Close();
        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 Form2 = new Form2(this);
            Form2.Show();
        }

        private void участникиToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 Form3 = new Form3(this);
            Form3.Show();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e) {
            Form4 Form4 = new Form4(this);
            Form4.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) {
            Spravka Spr = new Spravka();
            Spr.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e) {
            Form6 Form6 = new Form6();
            Form6.Show();
        }
    }
}
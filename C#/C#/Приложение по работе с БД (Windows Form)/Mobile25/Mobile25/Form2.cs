using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile25 {
    public partial class Form2 : Form {

        Form1 frm1;

        public Form2() {
            InitializeComponent();
        }

        public Form2(Form1 f) {
            InitializeComponent();

            frm1 = f;

            dataGridView1.DataSource = frm1.ds.Tables["Города"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.GorAdapter);
            try {
                dataGridView1.DataSource = frm1.ds.Tables[1];
                frm1.GorAdapter.Update(frm1.ds, "Города");
            }
            catch {
                MessageBox.Show("Ошибка обновления");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.GorAdapter);
            try {
                CurrencyManager CurMan = (CurrencyManager)
                    dataGridView1.BindingContext[dataGridView1.DataSource];
                if (CurMan.Count > 0) {
                    CurMan.RemoveAt(CurMan.Position);
                    frm1.GorAdapter.Update(frm1.ds, "Города");
                }
            }
            catch {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Города] " +
                "(Название, Индекс) VALUES(@name,@number)", frm1.MyConnect);

            OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY", frm1.MyConnect);

            cmd.Parameters.AddWithValue("@name", "");
            cmd.Parameters.AddWithValue("@number", "");
            cmd.ExecuteNonQuery();

            frm1.GorAdapter.Update(frm1.ds.Tables[1]);

            int a = Convert.ToInt32(cmd1.ExecuteScalar());

            DataTable MyDT = (DataTable)dataGridView1.DataSource;
            DataRow MyNewRow = MyDT.NewRow();

            MyNewRow["ID_Города"] = a;
            MyNewRow["Название"] = "";
            MyNewRow["Индекс"] = "";
            MyDT.Rows.Add(MyNewRow);
            MyDT.AcceptChanges();

            dataGridView1.CurrentCell =
                dataGridView1[1, dataGridView1.Rows.Count - 1];
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile25 {
    public partial class Form4 : Form {

        Form1 frm1;

        public Form4() {
            InitializeComponent();
        }

        public Form4(Form1 f) {
            InitializeComponent();

            frm1 = f;

            dataGridView1.DataSource = frm1.ds.Tables["Оценки"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.OceAdapter);
            try {
                dataGridView1.DataSource = frm1.ds.Tables[0];
                frm1.OceAdapter.Update(frm1.ds, "Оценки");
            }
            catch {
                MessageBox.Show("Ошибка обновления");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.OceAdapter);
            try {
                CurrencyManager CurMan = (CurrencyManager)
                    dataGridView1.BindingContext[dataGridView1.DataSource];
                if (CurMan.Count > 0) {
                    CurMan.RemoveAt(CurMan.Position);
                    frm1.OceAdapter.Update(frm1.ds, "Оценки");
                }
            }
            catch {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Оценки] " +
                "(Танец1, Танец2, Танец3, Общая_оценка) VALUES(@number,@number,@number,@number)", frm1.MyConnect);

            OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY", frm1.MyConnect);

            cmd.Parameters.AddWithValue("@number", "1");
            cmd.ExecuteNonQuery();

            frm1.OceAdapter.Update(frm1.ds.Tables[0]);

            int a = Convert.ToInt32(cmd1.ExecuteScalar());

            DataTable MyDT = (DataTable)dataGridView1.DataSource;
            DataRow MyNewRow = MyDT.NewRow();

            MyNewRow["ID_Оценки"] = a;
            MyNewRow["Танец1"] = "1";
            MyNewRow["Танец2"] = "1";
            MyNewRow["Танец3"] = "1";
            MyNewRow["Общая_оценка"] = "1";
            MyDT.Rows.Add(MyNewRow);
            MyDT.AcceptChanges();

            dataGridView1.CurrentCell =
                dataGridView1[1, dataGridView1.Rows.Count - 1];
        }
    }
}
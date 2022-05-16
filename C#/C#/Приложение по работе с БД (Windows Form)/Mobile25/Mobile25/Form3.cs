using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile25 {
    public partial class Form3 : Form {

        Form1 frm1;

        public Form3() {
            InitializeComponent();
        }

        public Form3(Form1 f) {
            InitializeComponent();

            frm1 = f;

            dataGridView1.DataSource = frm1.ds.Tables["Участники"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.UchAdapter);
            try {
                dataGridView1.DataSource = frm1.ds.Tables[2];
                frm1.UchAdapter.Update(frm1.ds, "Участники");
            }
            catch {
                MessageBox.Show("Ошибка обновления");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(frm1.UchAdapter);
            try {
                CurrencyManager CurMan = (CurrencyManager)
                    dataGridView1.BindingContext[dataGridView1.DataSource];
                if (CurMan.Count > 0) {
                    CurMan.RemoveAt(CurMan.Position);
                    frm1.UchAdapter.Update(frm1.ds, "Участники");
                }
            }
            catch {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Участники] " +
                "(ФИО, Города, Тренер, Оценки) VALUES(@name,@number,@name,@number)", frm1.MyConnect);

            OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY", frm1.MyConnect);

            cmd.Parameters.AddWithValue("@name", "");
            cmd.Parameters.AddWithValue("@number", "1");
            cmd.ExecuteNonQuery();

            frm1.UchAdapter.Update(frm1.ds.Tables[2]);

            int a = Convert.ToInt32(cmd1.ExecuteScalar());

            DataTable MyDT = (DataTable)dataGridView1.DataSource;
            DataRow MyNewRow = MyDT.NewRow();

            MyNewRow["ID_Участники"] = a;
            MyNewRow["ФИО"] = "";
            MyNewRow["Города"] = "1";
            MyNewRow["Тренер"] = "";
            MyNewRow["Оценки"] = "1";
            MyDT.Rows.Add(MyNewRow);
            MyDT.AcceptChanges();

            dataGridView1.CurrentCell =
                dataGridView1[1, dataGridView1.Rows.Count - 1];
        }
    }
}
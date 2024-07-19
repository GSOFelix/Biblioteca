using Layout.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout.Views
{
    public partial class FormPesquisa : Form
    {
        private DataTable _data;
        public int SelectId;
        public string? Nome;

        public FormPesquisa(DataTable data)
        {
            InitializeComponent();
            _data = data;
            LerDados();
        }

        private void LerDados()
        {
            dataGridView1.DataSource = _data;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Nome = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {

                SelectId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "STATUS")
            {

                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int statusValue = (byte)e.Value;
                    e.Value = ((EStatus)statusValue).ToString();
                    e.FormattingApplied = true;
                }
                else
                {

                }
            }
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("TITULO"))
            {
                dataGridView1.Columns["TITULO"].Width = 300; // Largura em pixels
            }
        }
    }
}

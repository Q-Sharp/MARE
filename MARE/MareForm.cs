using System;
using System.Windows.Forms;

namespace MARE
{
    public partial class MareForm : Form
    {
        public MareForm()
        {
            InitializeComponent();

            foreach(DataGridViewColumn c in oDGV.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void oExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oSave_Click(object sender, EventArgs e)
        {
            oGFXDataSet.Save();
        }

        private void MareForm_Load(object sender, EventArgs e)
        {
            oGFXDataSet.Load();
        }
    }
}

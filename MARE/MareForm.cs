using System;
using System.Windows.Forms;

namespace MARE
{
    public partial class MareForm : Form
    {
        public MARE oMare = new MARE();

        public MareForm()
        {
            InitializeComponent();
        }

        private void oExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oSave_Click(object sender, EventArgs e)
        {
            oMare?.SaveReg();
            oMare?.LoadReg();
        }

        private void MareForm_Load(object sender, EventArgs e)
        {
            oMare?.LoadReg();
            oDGV.DataSource = new BindingSource(oMare.AllGFX, null);
        }
    }
}

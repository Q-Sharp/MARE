using System.Windows.Forms;

namespace MARE
{
    public class MAREMessageBox : IMessageBox
    {
        public void Show(string sText)
        {
            MessageBox.Show(sText);
        }
    }
}
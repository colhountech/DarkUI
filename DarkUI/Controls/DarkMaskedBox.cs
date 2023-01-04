using DarkUI.Config;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public partial class DarkMaskedBox : MaskedTextBox
    {
        #region Constructor Region

        public DarkMaskedBox()
        {
            BackColor = Colors.LightBackground;
            ForeColor = Colors.LightText;
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
        }

        #endregion
    }
}

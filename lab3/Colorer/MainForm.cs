using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colorer
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public void ChangeColor()
        {
            ColorPanel.BackColor = Color.FromArgb(colorR.Value, colorG.Value, colorB.Value);
            string colorHex = string.Format("#{0:X2}{1:X2}{2:X2}", colorR.Value, colorG.Value, colorB.Value);
            Clipboard.SetText(colorHex);
        }

        private void colorR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BarChange(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ShowHint(object sender, EventArgs e)
        {
            Hint.Show(Clipboard.GetText(), ColorPanel);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ChangeColor();
        }
    }
}

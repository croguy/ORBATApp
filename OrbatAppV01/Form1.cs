using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbatAppV01
{
    public partial class Form1 : Form
    {
        UnitGenerator OrbatCompiler = new UnitGenerator();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orbatGenerate_MouseClick(object sender, MouseEventArgs e)
        {
            orbatOutputBox.Text = OrbatCompiler.OrbatOutput(unitClassName.Text, (int)unitID.Value, unitTextShort.Text, unitType.SelectedIndex, unitDisplayType.SelectedIndex, unitSide.SelectedIndex, unitSize.SelectedIndex, unitCustomInsignia.Text, unitCmdrName.Text, unitCmdrRank.SelectedIndex, unitSubordinates.Text, unitDescription.Text);
        }
    }
}

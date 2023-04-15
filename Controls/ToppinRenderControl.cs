using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTowerSaveEditor.Controls
{
    public partial class ToppinRenderControl : UserControl
    {
        public ToppinRenderControl()
        {
            InitializeComponent();
        }

        public enum Toppins
        {
            Mushroom,
            Cheese,
            Tomato,
            Sausage,
            Pineapple
        }

        private Toppins _toppin = Toppins.Mushroom;
        public Toppins Toppin
        {
            get => _toppin;
            set
            {
                _toppin = value;
                Invalidate();
            }
        }


        private void ToppinRenderControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

        }
    }
}

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
    public partial class PizzaTowerLevelEditor : UserControl
    {
        public PizzaTowerLevelEditor()
        {
            InitializeComponent();

            pointsNumericUpDown.Minimum = UInt32.MinValue;
            pointsNumericUpDown.Maximum = UInt32.MaxValue;

            checkIfValidPrank();
        }

        //public event EventHandler RankUpdate;

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text 
        { 
            get => groupBox.Text; 
            set => groupBox.Text = value; 
        }
        //[Category("Appearance")]
        //[EditorBrowsable(EditorBrowsableState.Always)]
        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[Bindable(true)]
        //public Image Image
        //{
        //    get => rankPictureBox.Image;
        //    set => rankPictureBox.Image = value;
        //}

        public uint Points
        {
            get => Convert.ToUInt32(pointsNumericUpDown.Value);
            set => pointsNumericUpDown.Value = value;
        }

        private uint _cRankMinimum = 0;
        private uint _bRankMinimum = 0;
        private uint _aRankMinimum = 0;
        private uint _sRankMinimum = 0;

        private bool _isPRank = false;
        public uint CRankMinimum
        {
            get => _cRankMinimum;
            set
            {
                _cRankMinimum = value;
                //RankUpdate?.Invoke(this, new EventArgs());
            }
        }
        public uint BRankMinimum
        {
            get => _bRankMinimum;
            set
            {
                _bRankMinimum = value;
                //RankUpdate?.Invoke(this, new EventArgs());
            }
        }
        public uint ARankMinimum
        {
            get => _aRankMinimum;
            set
            {
                _aRankMinimum = value;
                //RankUpdate?.Invoke(this, new EventArgs());
            }
        }
        public uint SRankMinimum
        {
            get => _sRankMinimum;
            set
            {
                _sRankMinimum = value;
                //RankUpdate?.Invoke(this, new EventArgs());
            }
        }

        public bool IsPRank
        {
            get => _isPRank;
            set
            {
                _isPRank = value;
                //RankUpdate?.Invoke(this, EventArgs.Empty);
            }
        }
        private void checkIfValidPrank()
        {
            if (Points >= SRankMinimum && mushroomToppinCheckBox.Checked && cheeseToppinCheckBox.Checked && tomatoToppinCheckBox.Checked && sausageToppinCheckBox.Checked && pineappleToppinCheckBox.Checked && secret1CheckBox.Checked && secret2CheckBox.Checked && secret3CheckBox.Checked && treasureCheckBox.Checked && lap2CheckBox.Checked)
            {
                pRankCheckBox.Enabled = true;
            }
            else
            {
                pRankCheckBox.Enabled = false;
                pRankCheckBox.Checked = false;
            }
        }

        private void updateRank()
        {
            if (Points >= SRankMinimum)
            {
                if (pRankCheckBox.Checked)
                    rankLabel.Text = "Rank: P";
                else
                    rankLabel.Text = "Rank: S";
            }
            else if (Points >= ARankMinimum)
                rankLabel.Text = "Rank: A";
            else if (Points >= BRankMinimum)
                rankLabel.Text = "Rank: B";
            else if (Points >= CRankMinimum)
                rankLabel.Text = "Rank: C";
            else
                rankLabel.Text = "Rank: D";
        }
        private void pointsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void pRankCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void mushroomToppinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void cheeseToppinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void tomatoToppinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void sausageToppinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void pineappleToppinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void secret1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void secret2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void secret3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void treasureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }

        private void lap2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }
    }
}

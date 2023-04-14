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
            set
            {
                pointsNumericUpDown.Value = value;
                checkIfValidPrank();
                updateRank();
            }
        }

        public bool MushroomToppinCollected
        {
            get => mushroomToppinCheckBox.Checked;
            set => mushroomToppinCheckBox.Checked = value;
        }
        public bool CheeseToppinCollected
        {
            get => cheeseToppinCheckBox.Checked;
            set => cheeseToppinCheckBox.Checked = value;
        }
        public bool TomatoToppinCollected
        {
            get => tomatoToppinCheckBox.Checked;
            set => tomatoToppinCheckBox.Checked = value;
        }
        public bool SausageToppinCollected
        {
            get => sausageToppinCheckBox.Checked;
            set => sausageToppinCheckBox.Checked = value;
        }
        public bool PineappleToppinCollected
        {
            get => pineappleToppinCheckBox.Checked;
            set => pineappleToppinCheckBox.Checked = value;
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
                checkIfValidPrank();
                updateRank();
            }
        }
        public uint BRankMinimum
        {
            get => _bRankMinimum;
            set
            {
                _bRankMinimum = value;
                checkIfValidPrank();
                updateRank();
            }
        }
        public uint ARankMinimum
        {
            get => _aRankMinimum;
            set
            {
                _aRankMinimum = value;
                checkIfValidPrank();
                updateRank();
            }
        }
        public uint SRankMinimum
        {
            get => _sRankMinimum;
            set
            {
                _sRankMinimum = value;
                checkIfValidPrank();
                updateRank();
            }
        }

        public bool IsPRank
        {
            get => _isPRank;
            set
            {
                _isPRank = value;

                checkIfValidPrank();
                updateRank();
            }
        }
        private void checkIfValidPrank()
        {
            if (Points >= SRankMinimum && mushroomToppinCheckBox.Checked && cheeseToppinCheckBox.Checked && tomatoToppinCheckBox.Checked && sausageToppinCheckBox.Checked && pineappleToppinCheckBox.Checked && treasureCheckBox.Checked && secretsNumericUpDown.Value == 3)
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

        private void secretsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            checkIfValidPrank();
            updateRank();
        }
    }
}

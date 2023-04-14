namespace PizzaTowerSaveEditor.Controls
{
    partial class PizzaTowerLevelEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.treasureCheckBox = new System.Windows.Forms.CheckBox();
            this.secret3CheckBox = new System.Windows.Forms.CheckBox();
            this.secret2CheckBox = new System.Windows.Forms.CheckBox();
            this.secret1CheckBox = new System.Windows.Forms.CheckBox();
            this.pRankCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.pineappleToppinCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageToppinCheckBox = new System.Windows.Forms.CheckBox();
            this.tomatoToppinCheckBox = new System.Windows.Forms.CheckBox();
            this.cheeseToppinCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomToppinCheckBox = new System.Windows.Forms.CheckBox();
            this.pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lap2CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lap2CheckBox);
            this.groupBox.Controls.Add(this.treasureCheckBox);
            this.groupBox.Controls.Add(this.secret3CheckBox);
            this.groupBox.Controls.Add(this.secret2CheckBox);
            this.groupBox.Controls.Add(this.secret1CheckBox);
            this.groupBox.Controls.Add(this.pRankCheckBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.rankLabel);
            this.groupBox.Controls.Add(this.pineappleToppinCheckBox);
            this.groupBox.Controls.Add(this.sausageToppinCheckBox);
            this.groupBox.Controls.Add(this.tomatoToppinCheckBox);
            this.groupBox.Controls.Add(this.cheeseToppinCheckBox);
            this.groupBox.Controls.Add(this.mushroomToppinCheckBox);
            this.groupBox.Controls.Add(this.pointsNumericUpDown);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(338, 149);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // treasureCheckBox
            // 
            this.treasureCheckBox.AutoSize = true;
            this.treasureCheckBox.Location = new System.Drawing.Point(262, 93);
            this.treasureCheckBox.Name = "treasureCheckBox";
            this.treasureCheckBox.Size = new System.Drawing.Size(69, 19);
            this.treasureCheckBox.TabIndex = 14;
            this.treasureCheckBox.Text = "Treasure";
            this.treasureCheckBox.UseVisualStyleBackColor = true;
            this.treasureCheckBox.CheckedChanged += new System.EventHandler(this.treasureCheckBox_CheckedChanged);
            // 
            // secret3CheckBox
            // 
            this.secret3CheckBox.AutoSize = true;
            this.secret3CheckBox.Location = new System.Drawing.Point(262, 68);
            this.secret3CheckBox.Name = "secret3CheckBox";
            this.secret3CheckBox.Size = new System.Drawing.Size(67, 19);
            this.secret3CheckBox.TabIndex = 13;
            this.secret3CheckBox.Text = "Secret 3";
            this.secret3CheckBox.UseVisualStyleBackColor = true;
            this.secret3CheckBox.CheckedChanged += new System.EventHandler(this.secret3CheckBox_CheckedChanged);
            // 
            // secret2CheckBox
            // 
            this.secret2CheckBox.AutoSize = true;
            this.secret2CheckBox.Location = new System.Drawing.Point(262, 43);
            this.secret2CheckBox.Name = "secret2CheckBox";
            this.secret2CheckBox.Size = new System.Drawing.Size(67, 19);
            this.secret2CheckBox.TabIndex = 12;
            this.secret2CheckBox.Text = "Secret 2";
            this.secret2CheckBox.UseVisualStyleBackColor = true;
            this.secret2CheckBox.CheckedChanged += new System.EventHandler(this.secret2CheckBox_CheckedChanged);
            // 
            // secret1CheckBox
            // 
            this.secret1CheckBox.AutoSize = true;
            this.secret1CheckBox.Location = new System.Drawing.Point(262, 18);
            this.secret1CheckBox.Name = "secret1CheckBox";
            this.secret1CheckBox.Size = new System.Drawing.Size(67, 19);
            this.secret1CheckBox.TabIndex = 11;
            this.secret1CheckBox.Text = "Secret 1";
            this.secret1CheckBox.UseVisualStyleBackColor = true;
            this.secret1CheckBox.CheckedChanged += new System.EventHandler(this.secret1CheckBox_CheckedChanged);
            // 
            // pRankCheckBox
            // 
            this.pRankCheckBox.AutoSize = true;
            this.pRankCheckBox.Location = new System.Drawing.Point(64, 18);
            this.pRankCheckBox.Name = "pRankCheckBox";
            this.pRankCheckBox.Size = new System.Drawing.Size(62, 19);
            this.pRankCheckBox.TabIndex = 10;
            this.pRankCheckBox.Text = "P Rank";
            this.pRankCheckBox.UseVisualStyleBackColor = true;
            this.pRankCheckBox.CheckedChanged += new System.EventHandler(this.pRankCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Points:";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rankLabel.Location = new System.Drawing.Point(6, 68);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(69, 21);
            this.rankLabel.TabIndex = 8;
            this.rankLabel.Text = "Rank: D";
            // 
            // pineappleToppinCheckBox
            // 
            this.pineappleToppinCheckBox.AutoSize = true;
            this.pineappleToppinCheckBox.Location = new System.Drawing.Point(132, 118);
            this.pineappleToppinCheckBox.Name = "pineappleToppinCheckBox";
            this.pineappleToppinCheckBox.Size = new System.Drawing.Size(117, 19);
            this.pineappleToppinCheckBox.TabIndex = 7;
            this.pineappleToppinCheckBox.Text = "Pineapple Toppin";
            this.pineappleToppinCheckBox.UseVisualStyleBackColor = true;
            this.pineappleToppinCheckBox.CheckedChanged += new System.EventHandler(this.pineappleToppinCheckBox_CheckedChanged);
            // 
            // sausageToppinCheckBox
            // 
            this.sausageToppinCheckBox.AutoSize = true;
            this.sausageToppinCheckBox.Location = new System.Drawing.Point(132, 93);
            this.sausageToppinCheckBox.Name = "sausageToppinCheckBox";
            this.sausageToppinCheckBox.Size = new System.Drawing.Size(108, 19);
            this.sausageToppinCheckBox.TabIndex = 6;
            this.sausageToppinCheckBox.Text = "Sausage Toppin";
            this.sausageToppinCheckBox.UseVisualStyleBackColor = true;
            this.sausageToppinCheckBox.CheckedChanged += new System.EventHandler(this.sausageToppinCheckBox_CheckedChanged);
            // 
            // tomatoToppinCheckBox
            // 
            this.tomatoToppinCheckBox.AutoSize = true;
            this.tomatoToppinCheckBox.Location = new System.Drawing.Point(132, 68);
            this.tomatoToppinCheckBox.Name = "tomatoToppinCheckBox";
            this.tomatoToppinCheckBox.Size = new System.Drawing.Size(105, 19);
            this.tomatoToppinCheckBox.TabIndex = 5;
            this.tomatoToppinCheckBox.Text = "Tomato Toppin";
            this.tomatoToppinCheckBox.UseVisualStyleBackColor = true;
            this.tomatoToppinCheckBox.CheckedChanged += new System.EventHandler(this.tomatoToppinCheckBox_CheckedChanged);
            // 
            // cheeseToppinCheckBox
            // 
            this.cheeseToppinCheckBox.AutoSize = true;
            this.cheeseToppinCheckBox.Location = new System.Drawing.Point(132, 43);
            this.cheeseToppinCheckBox.Name = "cheeseToppinCheckBox";
            this.cheeseToppinCheckBox.Size = new System.Drawing.Size(103, 19);
            this.cheeseToppinCheckBox.TabIndex = 4;
            this.cheeseToppinCheckBox.Text = "Cheese Toppin";
            this.cheeseToppinCheckBox.UseVisualStyleBackColor = true;
            this.cheeseToppinCheckBox.CheckedChanged += new System.EventHandler(this.cheeseToppinCheckBox_CheckedChanged);
            // 
            // mushroomToppinCheckBox
            // 
            this.mushroomToppinCheckBox.AutoSize = true;
            this.mushroomToppinCheckBox.Location = new System.Drawing.Point(132, 18);
            this.mushroomToppinCheckBox.Name = "mushroomToppinCheckBox";
            this.mushroomToppinCheckBox.Size = new System.Drawing.Size(124, 19);
            this.mushroomToppinCheckBox.TabIndex = 3;
            this.mushroomToppinCheckBox.Text = "Mushroom Toppin";
            this.mushroomToppinCheckBox.UseVisualStyleBackColor = true;
            this.mushroomToppinCheckBox.CheckedChanged += new System.EventHandler(this.mushroomToppinCheckBox_CheckedChanged);
            // 
            // pointsNumericUpDown
            // 
            this.pointsNumericUpDown.Location = new System.Drawing.Point(6, 37);
            this.pointsNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.pointsNumericUpDown.Name = "pointsNumericUpDown";
            this.pointsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.pointsNumericUpDown.TabIndex = 0;
            this.pointsNumericUpDown.ValueChanged += new System.EventHandler(this.pointsNumericUpDown_ValueChanged);
            // 
            // lap2CheckBox
            // 
            this.lap2CheckBox.AutoSize = true;
            this.lap2CheckBox.Location = new System.Drawing.Point(262, 118);
            this.lap2CheckBox.Name = "lap2CheckBox";
            this.lap2CheckBox.Size = new System.Drawing.Size(54, 19);
            this.lap2CheckBox.TabIndex = 15;
            this.lap2CheckBox.Text = "Lap 2";
            this.lap2CheckBox.UseVisualStyleBackColor = true;
            this.lap2CheckBox.CheckedChanged += new System.EventHandler(this.lap2CheckBox_CheckedChanged);
            // 
            // PizzaTowerLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "PizzaTowerLevelEditor";
            this.Size = new System.Drawing.Size(338, 149);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private NumericUpDown pointsNumericUpDown;
        private CheckBox pineappleToppinCheckBox;
        private CheckBox sausageToppinCheckBox;
        private CheckBox tomatoToppinCheckBox;
        private CheckBox cheeseToppinCheckBox;
        private CheckBox mushroomToppinCheckBox;
        private Label rankLabel;
        private CheckBox pRankCheckBox;
        private Label label1;
        private CheckBox treasureCheckBox;
        private CheckBox secret3CheckBox;
        private CheckBox secret2CheckBox;
        private CheckBox secret1CheckBox;
        private CheckBox lap2CheckBox;
    }
}

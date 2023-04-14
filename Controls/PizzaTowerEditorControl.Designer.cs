namespace PizzaTowerSaveEditor.Controls
{
    partial class PizzaTowerEditorControl
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
            PRankBitmap?.Dispose();
            SRankBitmap?.Dispose();
            ARankBitmap?.Dispose();
            BRankBitmap?.Dispose();
            CRankBitmap?.Dispose();
            DRankBitmap?.Dispose();
            EggplantRankBitmap?.Dispose();

            Console.WriteLine("Disposed of PizzaTowerEditorControl");
            GC.Collect();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.floor1TabPage = new System.Windows.Forms.TabPage();
            this.bloodsauceDungeonPizzaTowerLevelEditor = new PizzaTowerSaveEditor.Controls.PizzaTowerLevelEditor();
            this.ancientCheesePizzaTowerLevelEditor = new PizzaTowerSaveEditor.Controls.PizzaTowerLevelEditor();
            this.pizzaScapePizzaTowerLevelEditor = new PizzaTowerSaveEditor.Controls.PizzaTowerLevelEditor();
            this.johnGutterPizzaTowerLevelEditor = new PizzaTowerSaveEditor.Controls.PizzaTowerLevelEditor();
            this.floor2TabPage = new System.Windows.Forms.TabPage();
            this.floor3TabPage = new System.Windows.Forms.TabPage();
            this.floor4TabPage = new System.Windows.Forms.TabPage();
            this.floor5TabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.floor1TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.floor1TabPage);
            this.tabControl1.Controls.Add(this.floor2TabPage);
            this.tabControl1.Controls.Add(this.floor3TabPage);
            this.tabControl1.Controls.Add(this.floor4TabPage);
            this.tabControl1.Controls.Add(this.floor5TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // floor1TabPage
            // 
            this.floor1TabPage.AutoScroll = true;
            this.floor1TabPage.Controls.Add(this.bloodsauceDungeonPizzaTowerLevelEditor);
            this.floor1TabPage.Controls.Add(this.ancientCheesePizzaTowerLevelEditor);
            this.floor1TabPage.Controls.Add(this.pizzaScapePizzaTowerLevelEditor);
            this.floor1TabPage.Controls.Add(this.johnGutterPizzaTowerLevelEditor);
            this.floor1TabPage.Location = new System.Drawing.Point(4, 24);
            this.floor1TabPage.Name = "floor1TabPage";
            this.floor1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.floor1TabPage.Size = new System.Drawing.Size(884, 615);
            this.floor1TabPage.TabIndex = 0;
            this.floor1TabPage.Text = "Floor 1";
            this.floor1TabPage.UseVisualStyleBackColor = true;
            // 
            // bloodsauceDungeonPizzaTowerLevelEditor
            // 
            this.bloodsauceDungeonPizzaTowerLevelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodsauceDungeonPizzaTowerLevelEditor.ARankMinimum = ((uint)(0u));
            this.bloodsauceDungeonPizzaTowerLevelEditor.BRankMinimum = ((uint)(0u));
            this.bloodsauceDungeonPizzaTowerLevelEditor.CRankMinimum = ((uint)(0u));
            this.bloodsauceDungeonPizzaTowerLevelEditor.IsPRank = false;
            this.bloodsauceDungeonPizzaTowerLevelEditor.Location = new System.Drawing.Point(3, 450);
            this.bloodsauceDungeonPizzaTowerLevelEditor.Margin = new System.Windows.Forms.Padding(0);
            this.bloodsauceDungeonPizzaTowerLevelEditor.MinimumSize = new System.Drawing.Size(333, 149);
            this.bloodsauceDungeonPizzaTowerLevelEditor.Name = "bloodsauceDungeonPizzaTowerLevelEditor";
            this.bloodsauceDungeonPizzaTowerLevelEditor.Points = ((uint)(0u));
            this.bloodsauceDungeonPizzaTowerLevelEditor.Size = new System.Drawing.Size(878, 149);
            this.bloodsauceDungeonPizzaTowerLevelEditor.SRankMinimum = ((uint)(0u));
            this.bloodsauceDungeonPizzaTowerLevelEditor.TabIndex = 11;
            this.bloodsauceDungeonPizzaTowerLevelEditor.Text = "Bloodsauce Dungeon";
            // 
            // ancientCheesePizzaTowerLevelEditor
            // 
            this.ancientCheesePizzaTowerLevelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ancientCheesePizzaTowerLevelEditor.ARankMinimum = ((uint)(0u));
            this.ancientCheesePizzaTowerLevelEditor.BRankMinimum = ((uint)(0u));
            this.ancientCheesePizzaTowerLevelEditor.CRankMinimum = ((uint)(0u));
            this.ancientCheesePizzaTowerLevelEditor.IsPRank = false;
            this.ancientCheesePizzaTowerLevelEditor.Location = new System.Drawing.Point(3, 301);
            this.ancientCheesePizzaTowerLevelEditor.Margin = new System.Windows.Forms.Padding(0);
            this.ancientCheesePizzaTowerLevelEditor.MinimumSize = new System.Drawing.Size(333, 149);
            this.ancientCheesePizzaTowerLevelEditor.Name = "ancientCheesePizzaTowerLevelEditor";
            this.ancientCheesePizzaTowerLevelEditor.Points = ((uint)(0u));
            this.ancientCheesePizzaTowerLevelEditor.Size = new System.Drawing.Size(878, 149);
            this.ancientCheesePizzaTowerLevelEditor.SRankMinimum = ((uint)(0u));
            this.ancientCheesePizzaTowerLevelEditor.TabIndex = 10;
            this.ancientCheesePizzaTowerLevelEditor.Text = "Ancient Cheese";
            // 
            // pizzaScapePizzaTowerLevelEditor
            // 
            this.pizzaScapePizzaTowerLevelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pizzaScapePizzaTowerLevelEditor.ARankMinimum = ((uint)(0u));
            this.pizzaScapePizzaTowerLevelEditor.BRankMinimum = ((uint)(0u));
            this.pizzaScapePizzaTowerLevelEditor.CRankMinimum = ((uint)(0u));
            this.pizzaScapePizzaTowerLevelEditor.IsPRank = false;
            this.pizzaScapePizzaTowerLevelEditor.Location = new System.Drawing.Point(3, 152);
            this.pizzaScapePizzaTowerLevelEditor.Margin = new System.Windows.Forms.Padding(0);
            this.pizzaScapePizzaTowerLevelEditor.MinimumSize = new System.Drawing.Size(333, 149);
            this.pizzaScapePizzaTowerLevelEditor.Name = "pizzaScapePizzaTowerLevelEditor";
            this.pizzaScapePizzaTowerLevelEditor.Points = ((uint)(0u));
            this.pizzaScapePizzaTowerLevelEditor.Size = new System.Drawing.Size(878, 149);
            this.pizzaScapePizzaTowerLevelEditor.SRankMinimum = ((uint)(0u));
            this.pizzaScapePizzaTowerLevelEditor.TabIndex = 9;
            this.pizzaScapePizzaTowerLevelEditor.Text = "Pizzascape";
            // 
            // johnGutterPizzaTowerLevelEditor
            // 
            this.johnGutterPizzaTowerLevelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.johnGutterPizzaTowerLevelEditor.ARankMinimum = ((uint)(8000u));
            this.johnGutterPizzaTowerLevelEditor.BRankMinimum = ((uint)(4000u));
            this.johnGutterPizzaTowerLevelEditor.CRankMinimum = ((uint)(2000u));
            this.johnGutterPizzaTowerLevelEditor.IsPRank = false;
            this.johnGutterPizzaTowerLevelEditor.Location = new System.Drawing.Point(3, 3);
            this.johnGutterPizzaTowerLevelEditor.Margin = new System.Windows.Forms.Padding(0);
            this.johnGutterPizzaTowerLevelEditor.MinimumSize = new System.Drawing.Size(333, 149);
            this.johnGutterPizzaTowerLevelEditor.Name = "johnGutterPizzaTowerLevelEditor";
            this.johnGutterPizzaTowerLevelEditor.Points = ((uint)(0u));
            this.johnGutterPizzaTowerLevelEditor.Size = new System.Drawing.Size(878, 149);
            this.johnGutterPizzaTowerLevelEditor.SRankMinimum = ((uint)(16000u));
            this.johnGutterPizzaTowerLevelEditor.TabIndex = 8;
            this.johnGutterPizzaTowerLevelEditor.Text = "John Gutter";
            // 
            // floor2TabPage
            // 
            this.floor2TabPage.Location = new System.Drawing.Point(4, 24);
            this.floor2TabPage.Name = "floor2TabPage";
            this.floor2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.floor2TabPage.Size = new System.Drawing.Size(884, 615);
            this.floor2TabPage.TabIndex = 1;
            this.floor2TabPage.Text = "Floor 2";
            this.floor2TabPage.UseVisualStyleBackColor = true;
            // 
            // floor3TabPage
            // 
            this.floor3TabPage.Location = new System.Drawing.Point(4, 24);
            this.floor3TabPage.Name = "floor3TabPage";
            this.floor3TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.floor3TabPage.Size = new System.Drawing.Size(884, 615);
            this.floor3TabPage.TabIndex = 2;
            this.floor3TabPage.Text = "Floor 3";
            this.floor3TabPage.UseVisualStyleBackColor = true;
            // 
            // floor4TabPage
            // 
            this.floor4TabPage.Location = new System.Drawing.Point(4, 24);
            this.floor4TabPage.Name = "floor4TabPage";
            this.floor4TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.floor4TabPage.Size = new System.Drawing.Size(884, 615);
            this.floor4TabPage.TabIndex = 3;
            this.floor4TabPage.Text = "Floor 4";
            this.floor4TabPage.UseVisualStyleBackColor = true;
            // 
            // floor5TabPage
            // 
            this.floor5TabPage.Location = new System.Drawing.Point(4, 24);
            this.floor5TabPage.Name = "floor5TabPage";
            this.floor5TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.floor5TabPage.Size = new System.Drawing.Size(884, 615);
            this.floor5TabPage.TabIndex = 4;
            this.floor5TabPage.Text = "Floor 5";
            this.floor5TabPage.UseVisualStyleBackColor = true;
            // 
            // PizzaTowerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "PizzaTowerEditorControl";
            this.Size = new System.Drawing.Size(892, 643);
            this.Load += new System.EventHandler(this.PizzaTowerEditorControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.floor1TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage floor1TabPage;
        private TabPage floor2TabPage;
        private TabPage floor3TabPage;
        private TabPage floor4TabPage;
        private TabPage floor5TabPage;
        private PizzaTowerLevelEditor bloodsauceDungeonPizzaTowerLevelEditor;
        private PizzaTowerLevelEditor ancientCheesePizzaTowerLevelEditor;
        private PizzaTowerLevelEditor pizzaScapePizzaTowerLevelEditor;
        private PizzaTowerLevelEditor johnGutterPizzaTowerLevelEditor;
    }
}

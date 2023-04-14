namespace PizzaTowerSaveEditor.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaTowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sugarySpireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoutdigov1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheesedUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaTowerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sugarySpireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoutdigov1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cheesedUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.aboutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAutoToolStripMenuItem,
            this.loadDialogToolStripMenuItem,
            this.unloadToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton1.Text = "File";
            // 
            // loadAutoToolStripMenuItem
            // 
            this.loadAutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaTowerToolStripMenuItem,
            this.toolStripSeparator2,
            this.sugarySpireToolStripMenuItem,
            this.scoutdigov1ToolStripMenuItem,
            this.cheesedUpToolStripMenuItem});
            this.loadAutoToolStripMenuItem.Name = "loadAutoToolStripMenuItem";
            this.loadAutoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadAutoToolStripMenuItem.Text = "Load (Auto)";
            // 
            // pizzaTowerToolStripMenuItem
            // 
            this.pizzaTowerToolStripMenuItem.Image = global::PizzaTowerSaveEditor.Properties.Resources.PizzaTowerIcon;
            this.pizzaTowerToolStripMenuItem.Name = "pizzaTowerToolStripMenuItem";
            this.pizzaTowerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.pizzaTowerToolStripMenuItem.Text = "Pizza Tower";
            this.pizzaTowerToolStripMenuItem.Click += new System.EventHandler(this.pizzaTowerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // sugarySpireToolStripMenuItem
            // 
            this.sugarySpireToolStripMenuItem.Image = global::PizzaTowerSaveEditor.Properties.Resources.SugarySpireIcon;
            this.sugarySpireToolStripMenuItem.Name = "sugarySpireToolStripMenuItem";
            this.sugarySpireToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sugarySpireToolStripMenuItem.Text = "Sugary Spire";
            this.sugarySpireToolStripMenuItem.Click += new System.EventHandler(this.sugarySpireToolStripMenuItem_Click);
            // 
            // scoutdigov1ToolStripMenuItem
            // 
            this.scoutdigov1ToolStripMenuItem.Image = global::PizzaTowerSaveEditor.Properties.Resources.Scoutdigo;
            this.scoutdigov1ToolStripMenuItem.Name = "scoutdigov1ToolStripMenuItem";
            this.scoutdigov1ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.scoutdigov1ToolStripMenuItem.Text = "Scoutdigo (v1)";
            this.scoutdigov1ToolStripMenuItem.Click += new System.EventHandler(this.scoutdigov1ToolStripMenuItem_Click);
            // 
            // cheesedUpToolStripMenuItem
            // 
            this.cheesedUpToolStripMenuItem.Name = "cheesedUpToolStripMenuItem";
            this.cheesedUpToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cheesedUpToolStripMenuItem.Text = "Cheesed Up";
            this.cheesedUpToolStripMenuItem.Click += new System.EventHandler(this.cheesedUpToolStripMenuItem_Click);
            // 
            // loadDialogToolStripMenuItem
            // 
            this.loadDialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaTowerToolStripMenuItem1,
            this.toolStripSeparator3,
            this.sugarySpireToolStripMenuItem1,
            this.scoutdigov1ToolStripMenuItem1,
            this.cheesedUpToolStripMenuItem1});
            this.loadDialogToolStripMenuItem.Name = "loadDialogToolStripMenuItem";
            this.loadDialogToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadDialogToolStripMenuItem.Text = "Load (Dialog)";
            // 
            // pizzaTowerToolStripMenuItem1
            // 
            this.pizzaTowerToolStripMenuItem1.Image = global::PizzaTowerSaveEditor.Properties.Resources.PizzaTowerIcon;
            this.pizzaTowerToolStripMenuItem1.Name = "pizzaTowerToolStripMenuItem1";
            this.pizzaTowerToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.pizzaTowerToolStripMenuItem1.Text = "Pizza Tower";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // sugarySpireToolStripMenuItem1
            // 
            this.sugarySpireToolStripMenuItem1.Image = global::PizzaTowerSaveEditor.Properties.Resources.SugarySpireIcon;
            this.sugarySpireToolStripMenuItem1.Name = "sugarySpireToolStripMenuItem1";
            this.sugarySpireToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.sugarySpireToolStripMenuItem1.Text = "Sugary Spire";
            // 
            // scoutdigov1ToolStripMenuItem1
            // 
            this.scoutdigov1ToolStripMenuItem1.Image = global::PizzaTowerSaveEditor.Properties.Resources.Scoutdigo;
            this.scoutdigov1ToolStripMenuItem1.Name = "scoutdigov1ToolStripMenuItem1";
            this.scoutdigov1ToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.scoutdigov1ToolStripMenuItem1.Text = "Scoutdigo (v1)";
            // 
            // cheesedUpToolStripMenuItem1
            // 
            this.cheesedUpToolStripMenuItem1.Name = "cheesedUpToolStripMenuItem1";
            this.cheesedUpToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.cheesedUpToolStripMenuItem1.Text = "Cheesed Up";
            // 
            // unloadToolStripMenuItem
            // 
            this.unloadToolStripMenuItem.Name = "unloadToolStripMenuItem";
            this.unloadToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unloadToolStripMenuItem.Text = "Unload";
            this.unloadToolStripMenuItem.Click += new System.EventHandler(this.unloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PizzaTowerSaveEditor.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::PizzaTowerSaveEditor.Properties.Resources.SaveAs;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.aboutToolStripButton.Text = "About";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton aboutToolStripButton;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem loadAutoToolStripMenuItem;
        private ToolStripMenuItem pizzaTowerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sugarySpireToolStripMenuItem;
        private ToolStripMenuItem scoutdigov1ToolStripMenuItem;
        private ToolStripMenuItem cheesedUpToolStripMenuItem;
        private ToolStripMenuItem loadDialogToolStripMenuItem;
        private ToolStripMenuItem pizzaTowerToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem sugarySpireToolStripMenuItem1;
        private ToolStripMenuItem scoutdigov1ToolStripMenuItem1;
        private ToolStripMenuItem cheesedUpToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem unloadToolStripMenuItem;
    }
}
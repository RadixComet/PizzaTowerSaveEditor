﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PizzaTowerSaveEditor.Controls
{
    public partial class PizzaTowerEditorControl : UserControl
    {
        public PizzaTowerEditorControl()
        {
            InitializeComponent();
        }

        public static bool IsInDesignMode()
        {
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            return false;
        }

        public Bitmap? PRankBitmap { get; private set; } = null;
        public Bitmap? SRankBitmap { get; private set; } = null;
        public Bitmap? ARankBitmap { get; private set; } = null;
        public Bitmap? BRankBitmap { get; private set; } = null;
        public Bitmap? CRankBitmap { get; private set; } = null;
        public Bitmap? DRankBitmap { get; private set; } = null;
        public Bitmap? EggplantRankBitmap { get; private set; } = null;

        private void PizzaTowerEditorControl_Load(object sender, EventArgs e)
        {
            PRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.P.png")!);
            SRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.S.png")!);
            ARankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.A.png")!);
            BRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.B.png")!);
            CRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.C.png")!);
            DRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.D.png")!);
            EggplantRankBitmap = new Bitmap(Assembly.GetExecutingAssembly()!.GetManifestResourceStream("PizzaTowerSaveEditor.Resources.Pizza_Tower.Ranks.Eggplant.png")!);

        }

        //private void pizzaTowerLevelEditor_RankUpdate(object sender, EventArgs e)
        //{
        //    if (IsInDesignMode())
        //        return;

        //    PizzaTowerLevelEditor editor = (PizzaTowerLevelEditor)sender;

        //    editor.Image?.Dispose();


        //    if (editor.Points >= editor.SRankMinimum && editor.Image != SRankBitmap)
        //    {
        //        editor.Image?.Dispose();
        //        editor.Image = SRankBitmap;
        //    }
        //    else if (editor.Points >= editor.ARankMinimum && editor.Image != ARankBitmap)
        //    {
        //        editor.Image?.Dispose();
        //        editor.Image = ARankBitmap;
        //    }
        //    else if (editor.Points >= editor.BRankMinimum && editor.Image != BRankBitmap)
        //    {
        //        editor.Image = BRankBitmap;
        //    }
        //    else if (editor.Points >= editor.CRankMinimum && editor.Image != CRankBitmap)
        //    {
        //        editor.Image = CRankBitmap;
        //    }
        //    else
        //    {
        //        if (editor.Image != DRankBitmap)
        //        {
        //            editor.Image = DRankBitmap;
        //        }
        //    }
        //    Console.WriteLine($"{GC.GetTotalMemory(false).ToString()}");
            
        //}
    }
}

using System;
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

        private string _saveFileLocation = string.Empty;
        public PizzaTowerEditorControl(string saveFileLocation)
        {
            InitializeComponent();
            _saveFileLocation = saveFileLocation;
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

            loadSaveInfo();
        }


        void loadSaveInfo()
        {
            var saveFile = new IniFile(_saveFileLocation);
            loadFloor1();

            return;

            void loadFloor1()
            {

                johnGutterPizzaTowerLevelEditor.MushroomToppinCollected = saveFile.Read("entrance1", "Toppin") == "1.000000";
                johnGutterPizzaTowerLevelEditor.CheeseToppinCollected = saveFile.Read("entrance2", "Toppin") == "1.000000";
                johnGutterPizzaTowerLevelEditor.TomatoToppinCollected = saveFile.Read("entrance3", "Toppin") == "1.000000";
                johnGutterPizzaTowerLevelEditor.SausageToppinCollected = saveFile.Read("entrance4", "Toppin") == "1.000000";
                johnGutterPizzaTowerLevelEditor.PineappleToppinCollected = saveFile.Read("entrance5", "Toppin") == "1.000000";


            }
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

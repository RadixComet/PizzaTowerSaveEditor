using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace PizzaTowerSaveEditor.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"Loaded Resource Names");
            foreach (var resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                Console.WriteLine(resource);
        }
        public static string PizzaTowerGlobalSaveDirectory => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\PizzaTower_GM2";
        public static string PizzaTowerSaveDirectory => $"{PizzaTowerGlobalSaveDirectory}\\saves";

        public static string PizzaTowerGlobalSaveDataFilepath => $"{PizzaTowerGlobalSaveDirectory}\\saveData.ini";

        public static string PizzaTowerSave1DataFilepath => $"{PizzaTowerSaveDirectory}\\saveData1.ini";
        public static string PizzaTowerSave2DataFilepath => $"{PizzaTowerSaveDirectory}\\saveData2.ini";
        public static string PizzaTowerSave3DataFilepath => $"{PizzaTowerSaveDirectory}\\saveData3.ini";

        public void LoadSaveEditor()
        {

        }

        public void UnloadSaveEditor()
        {

        }


        #region Toolstrip
        #region Autoload
        private void pizzaTowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(PizzaTowerGlobalSaveDataFilepath))
            {
                MessageBox.Show($"Unable to load the Global Save Data for Pizza Tower located at:\n\"{PizzaTowerGlobalSaveDataFilepath}\"", "Error Loading File");
                return;
            }
            Console.WriteLine($"Loaded: \"{PizzaTowerGlobalSaveDataFilepath}\"");

            this.Controls.Add(new Controls.PizzaTowerEditorControl() { Dock = DockStyle.Fill });
            this.Controls[this.Controls.Count - 1].BringToFront();

        }
        private void sugarySpireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scoutdigov1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cheesedUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void unloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls[0]?.Dispose();
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }
        #endregion

    }
}
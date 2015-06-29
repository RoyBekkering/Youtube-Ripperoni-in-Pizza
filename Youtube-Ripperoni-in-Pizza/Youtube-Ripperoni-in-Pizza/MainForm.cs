using System.Windows.Forms;

namespace Youtube_Ripperoni_in_Pizza
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.contentSearch.DownloadControl = this.downloads;
        }
    }
}
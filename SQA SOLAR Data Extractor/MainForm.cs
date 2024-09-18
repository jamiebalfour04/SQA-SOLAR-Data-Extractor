namespace SQA_SOLAR_Data_Extractor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)";
            ofd.Multiselect = false;
            ofd.Title = "Select a CSV input source";
            CSVExtractor.ReadCsvFile(ofd.FileName);
        }
    }
}

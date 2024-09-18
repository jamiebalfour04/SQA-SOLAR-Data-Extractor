namespace SQA_SOLAR_Data_Extractor
{
    public partial class MainForm : Form
    {

        public string[,] data;
        public string[] columns;
        public string[,] actualPupils;

        public MainForm()
        {
            InitializeComponent();
        }

        public Boolean listContains(string forename, string surname)
        {
            for(int i = 0; i < actualPupils.GetLength(0); i++)
            {
                if (actualPupils[i, 0] == forename && actualPupils[i, 1] == surname)
                {
                    return true;
                }
            }

            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            ofd.Multiselect = false;
            ofd.Title = "Select a CSV input source";
            ofd.ShowDialog();
            data = CSVExtractor.ReadCsvFile(ofd.FileName);



            for (int i = 1; i < data.GetLength(0); i++)
            {
                Console.WriteLine(data[i, 1]);

            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            ofd.Multiselect = false;
            ofd.Title = "Select a CSV input source";
            ofd.ShowDialog();
            actualPupils = CSVExtractor.ReadCsvFile(ofd.FileName);



            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output = "";
            for(int i = 0; i < data.GetLength(0); i++)
            {
                if (listContains(data[i, 0], data[i, 1]))
                {
                    for(int j = 0; j < data.GetLength(1); j++)
                    {
                        output += data[i, j];

                        if (j + 1 < data.GetLength(1) - 1)
                        {
                            output += ", ";
                        }
                      
                    }
                    output += '\n';
                }
                
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.Title = "Select a CSV input source";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, output);
        }
    }
}

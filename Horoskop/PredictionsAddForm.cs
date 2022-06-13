using System;
using System.Windows.Forms;

namespace Horoskop
{
    public partial class PredictionsAddForm : MetroFramework.Forms.MetroForm
    {
        private FileHandling fileHandling;


        public PredictionsAddForm()
        {
            InitializeComponent();
            fileHandling = new FileHandling();

        }

        private void PredictionsAddForm_Load(object sender, EventArgs e)
        {
            fileHandling.readPredictions();
            fileTextBox.Lines = fileHandling.Predictions.ToArray();
            fileTextBox.Text += "\r\n";
            fileTextBox.SelectionStart = fileTextBox.Text.Length;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String[] lines = fileTextBox.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();
            }
            fileHandling.Predictions.Clear();

            foreach (String line in lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                    fileHandling.Predictions.Add(line);
            }
            fileHandling.writePredictions();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

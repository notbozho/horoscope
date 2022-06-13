using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Horoskop
{
    public partial class MainApplication : MetroFramework.Forms.MetroForm
    {
        private FileHandling fileHandling;
        private Predictions predictions;
        private String[] zodiacs = { "Овен", "Телец", "Близнаци", "Рак", "Лъв", "Дева", "Везни", "Скорпион", "Стрелец", "Козирог", "Водолей", "Риби" };


        public MainApplication()
        {
            InitializeComponent();
            fileHandling = new FileHandling();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileHandling.readPredictions();
            predictions = new Predictions(fileHandling.Predictions);
            this.Text = "Дневен хороскоп - " + DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            PredictionsAddForm predictionsAddForm = new PredictionsAddForm();
            predictionsAddForm.ShowDialog();

            //refresh predictions
            fileHandling.readPredictions();
            predictions.init(fileHandling.Predictions);
        }

        private String lastSelectedZodiac = "";
        private void zodiacCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String zodiacName = zodiacCombo.SelectedItem?.ToString();


            if (zodiacName == null || zodiacName == lastSelectedZodiac) return;

            zodiacNameLabel.Visible = true;
            zodiacNameLabel.Text = zodiacName;

            //load zodiac icon
            zodiacIcon.Image = Image.FromFile(fileHandling.getImagePath(zodiacName));

            //move icon and label to center
            int x = (this.Width / 2) - (zodiacIcon.Width + zodiacNameLabel.Width) / 2;
            int y = zodiacIcon.Location.Y;

            zodiacIcon.Location = new Point(x, y);
            zodiacNameLabel.Location = new Point(x + (zodiacIcon.Width + 5), y);

            List<String> zodiacPredictions = predictions.getZodiacPredictions(zodiacName);
            predictionsLabel.Text = "";

            if (zodiacPredictions.Count < 1) predictionsLabel.Text = "Няма повече предсказания !";
            foreach (String prediction in zodiacPredictions)
            {
                predictionsLabel.Text += prediction + "\n\n";
            }

            if (zodiacCombo.Items.Contains(lastSelectedZodiac)) zodiacCombo.Items.Remove(lastSelectedZodiac);
            lastSelectedZodiac = zodiacName;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            PredictionsAddForm predictionsAddForm = new PredictionsAddForm();
            predictionsAddForm.ShowDialog();

            //refresh predictions
            fileHandling.readPredictions();
            predictions.init(fileHandling.Predictions);


            zodiacCombo.Items.Clear();
            zodiacCombo.Items.AddRange(zodiacs); 
        }
    }
}

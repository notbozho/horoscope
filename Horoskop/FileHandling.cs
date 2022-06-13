using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoskop
{
    internal class FileHandling
    {
        private const String fileName = "data.txt";
        private List<String> predictions = new List<String>();

        public List<String> Predictions
        {
            get
            {
                return predictions;
            }
        }

        public String getPath(String fileName)
        {
            String currentDirectory = Directory.GetCurrentDirectory();
            String fullPath = Path.Combine(currentDirectory, fileName);

            return fullPath;
        }

        public String getImagePath(String fileName)
        {
            String currentDirectory = Directory.GetCurrentDirectory();

            switch(fileName)
            {
                case "Овен":
                    fileName = "Aries";
                    break;
                case "Телец":
                    fileName = "Taurus";
                    break;
                case "Близнаци":
                    fileName = "Gemini";
                    break;
                case "Рак":
                    fileName = "Cancer";
                    break;
                case "Лъв":
                    fileName = "Leo";
                    break;
                case "Дева":
                    fileName = "Virgo";
                    break;
                case "Везни":
                    fileName = "Libra";
                    break;
                case "Скорпион":
                    fileName = "Scorpio";
                    break;
                case "Стрелец":
                    fileName = "Sagittarius";
                    break;
                case "Козирог":
                    fileName = "Capricorn";
                    break;
                case "Водолей":
                    fileName = "Aquarius";
                    break;
                case "Риби":
                    fileName = "Pisces";
                    break;
                default:
                    break;
            }
            String fullPath = Path.Combine(currentDirectory, "icons", fileName + ".png");

            return fullPath;
        }

        public void readPredictions()
        {
            String path = getPath(fileName);

            String[] texts = File.ReadAllLines(path);
            predictions = texts.ToList();
        }

        public void writePredictions()
        {
            String[] lines = predictions.ToArray();
            String path = getPath(fileName);

            File.WriteAllLines(path, lines);
        }

    }       
}

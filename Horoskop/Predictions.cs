using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoskop
{
    internal class Predictions
    {
        private List<String> predictions = new List<String>();
        private List<String> unusedPredictions = new List<String>();
        private Dictionary<String, List<String>> zodiacPredictions = new Dictionary<string, List<string>>();
        private Random rnd = new Random();

        public Predictions(List<String> predictions)
        {
            init(predictions);
        }

        public void init(List<String> predictions)
        {
            this.predictions = predictions;
            zodiacPredictions.Clear();
            copyPredictions();
        }

        private void copyPredictions()
        {
            unusedPredictions.Clear();
            foreach (String prediction in predictions)
            {
                unusedPredictions.Add(prediction);
            }
        }

        private List<String> getRandomPrediction()
        {
            return unusedPredictions.OrderBy(x => rnd.Next()).Take(2).ToList();
        }

        public List<String> getZodiacPredictions(String zodiacName)
        {
            if (zodiacPredictions.ContainsKey(zodiacName))
            {
                return zodiacPredictions[zodiacName];
            }

            List<String> result = getRandomPrediction();
            foreach(String randomPrediction in result)
            {
                unusedPredictions.Remove(randomPrediction);
            }

            zodiacPredictions.Add(zodiacName, result);
            return result;
        }
    }
}

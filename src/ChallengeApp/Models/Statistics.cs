using System;

namespace ChallengeApp.Models
{
    public class Statistics
    {
        public double HighScore;
        public double LowScore;
        public double Sum;
        public int Count;

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            HighScore = double.MinValue;
            LowScore = double.MaxValue;
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            LowScore = Math.Min(number, LowScore);
            HighScore = Math.Max(number, HighScore);
        }

    }
}
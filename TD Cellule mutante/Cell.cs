using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Cellule_mutante
{
    public class Cell
    {
        public int size;
        public Color color;
        public string genetic;

        private Random random = new Random();

        // Letters
        private const char A = 'A';
        private const char T = 'T';
        private const char C = 'C';
        private const char G = 'G';

        // Patterns
        private const string TGT = "TGT";
        private const string ATT = "ATT";
        private const string CTC = "CTC";
        private const string ACT = "ACT";
        private const string GTC = "GTC";
        private const string GAA = "GAA";

        public Cell(int size, Color color, string genetic)
        {
            this.size = size;
            this.color = color;
            this.genetic = genetic;
        }

        public Cell()
        {

        }

        public void Mutation()
        {
            string newGenetic = string.Empty;

            foreach (var letter in genetic)
            {
                // Character changing
                switch (letter)
                {
                    default:
                        break;
                    case A:
                        if (GetProbability(15))
                            newGenetic += T;
                        break;
                    case T:
                        if (GetProbability(7))
                            newGenetic += A+A;
                        break;
                    case C:
                        if (GetProbability(21))
                            newGenetic += G;
                        break;
                    case G:
                        if (GetProbability(4))
                            newGenetic += C+G;
                        break;
                }

                // Character addition
                if (GetProbability(5))
                {
                    switch (random.Next(1, 5))
                    {
                        default:
                        case 1:
                            newGenetic += A;
                            break;
                        case 2:
                            newGenetic += T;
                            break;
                        case 3:
                            newGenetic += C;
                            break;
                        case 4:
                            newGenetic += G;
                            break;
                    }

                }
            }

            genetic = newGenetic;

            UpdateColor();
            UpdateSize();
        }

        public void UpdateSize()
        {
            var newColor = Color.Black;

            Dictionary<string, int> recurrence = new Dictionary<string, int>();

            for (int i = 0; i < genetic.Length - 2; i++)
            {
                string pattern = genetic.Substring(i, 3);

                switch (pattern)
                {
                    default:
                        break;
                    case TGT:
                    case ATT:
                    case CTC:
                    case ACT:
                    case GTC:
                    case GAA:
                        if (recurrence.ContainsKey(pattern))
                            recurrence[pattern]++;
                        else
                            recurrence.Add(pattern, 1);
                        break;
                }
            }

            if (recurrence.Count <= 0)
                return;

            string mostRecurrent = recurrence.OrderByDescending(x => x.Value)
                .FirstOrDefault().Key;

            switch (mostRecurrent)
            {
                default:
                    break;
                case TGT:
                    newColor = Color.Black;
                    break;
                case ATT:
                    newColor = Color.Blue;
                    break;
                case CTC:
                    newColor = Color.Yellow;
                    break;
                case ACT:
                    newColor = Color.Violet;
                    break;
                case GTC:
                    newColor = Color.Orange;
                    break;
                case GAA:
                    newColor = Color.Green;
                    break;
            }

            // Update visual
        }

        public void UpdateColor()
        {

        }

        private bool GetProbability(float probabilityInPercent)
        {
            return random.Next(1, 101) <= probabilityInPercent;
        }

        public override string ToString()
        {
            // inutile
            return base.ToString();
        }
    }
}

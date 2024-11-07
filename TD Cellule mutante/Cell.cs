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

        }

        public void UpdateSize()
        {

        }

        public void UpdateColor()
        {

        }

        private bool GetProbability(float probability)
        {
            return random.Next(1, 101) <= probability;
        }

        public override string ToString()
        {
            // inutile
            return base.ToString();
        }
    }
}

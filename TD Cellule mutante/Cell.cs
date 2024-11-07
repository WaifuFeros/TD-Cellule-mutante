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

        public override string ToString()
        {
            // inutile
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace L_HareketiOyunu
{
    public class Bolge : Button             //Koordinatların tutulduğu bölge sınıfı
    {
        private int koordinatX;

        public int KoordinatX { get { return koordinatX; } }

        private int koordinatY;

        public int KoordinatY { get { return koordinatY; } }

        public Bolge(Point p,int koorX,int koorY)
        {
            this.Width = 30;
            this.Height = 30;
            this.Location = p;
            this.FlatStyle = FlatStyle.Flat;
            this.Margin = new Padding(0);
            koordinatX = koorX;
            koordinatY = koorY;
        }
    }
}

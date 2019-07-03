using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekiller
{
    public class Dikdortgen
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Genislik { get; set; }

        public int Yukseklik { get; set; }

        public Color DolguRenk { get; set; }

        public double Alan()
        {
            return Genislik * Yukseklik;
        }

        public double Cevre()
        {
            return 2 * (Genislik + Yukseklik);
        }

        public Point MerkezNokta()
        {
            return new Point(X + Genislik / 2, Y + Yukseklik / 2);
        }

        public double Kosegen()
        {
            return Math.Sqrt(Math.Pow(Genislik,2) + Math.Pow(Yukseklik,2));
        }

        public bool IcindeMi(int x, int y)
        {
            return (x >= X && x < X + Genislik) && (y >= Y && y < Y + Yukseklik);
        }
    }
}

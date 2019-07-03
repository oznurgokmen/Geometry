using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekiller
{
    public class Ucgen
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Genislik { get; set; }

        public int Yukseklik { get; set; }

        public Color DolguRenk { get; set; }


        public double Hipotenus()
        {
            return Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
        }

        public double Alan()
        {
            return (Genislik * Yukseklik) / 2;
        }

        public double Cevre()
        {
            return (Genislik + Yukseklik + Hipotenus());
        }

        public bool IcindeMi(int x, int y)
        {
            return (x >= X && x < X + Genislik) && (y >= Y && y < Y + Yukseklik);
        }

    }
}

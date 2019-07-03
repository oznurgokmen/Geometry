using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrikSekiller
{
    public partial class Form1 : Form
    {
        int suruklenenIndex = -1;

        int suruklenenIndex1 = -1;

        int surukleSol = 0;

        int surukleUst = 0;

        int surukleSol1 = 0;

        int surukleUst1 = 0;

        BindingList<Dikdortgen> dikdortgens = new BindingList<Dikdortgen>();

        BindingList<Ucgen> ucgens = new BindingList<Ucgen>();


        public Form1()
        {
            InitializeComponent();

            dgvDikdortgens.AutoGenerateColumns = false;

            dgvDikdortgens.DataSource = dikdortgens;

            dikdortgens.ListChanged += ListeDegisti;

            dgvUcgens.DataSource = ucgens;

            ucgens.ListChanged += ListeDegisti;
        }

        private void ListeDegisti(object sender, ListChangedEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            Dikdortgen d = new Dikdortgen();
            d.X = (int)nudX.Value;
            d.Y = (int)nudY.Value;
            d.Genislik = (int)nudGenislik.Value;
            d.Yukseklik = (int)nudYukseklik.Value;
            d.DolguRenk = cdiCizim.Color;
            dikdortgens.Add(d);
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            Ucgen u = new Ucgen
            {
              X = (int)nudX.Value,
              Y = (int)nudY.Value,
              Genislik = (int)nudGenislik.Value,
              Yukseklik = (int)nudYukseklik.Value,
              DolguRenk = cdiCizim.Color
            };
            u.Hipotenus();
            ucgens.Add(u);
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush sb;
            
            foreach (Ucgen u in ucgens)
            {
                sb = new SolidBrush(u.DolguRenk);

                Point point1 = new Point(u.X, u.Y);
                Point point2 = new Point(u.X, u.Y + u.Yukseklik);
                Point point3 = new Point(u.X + u.Genislik, u.Y + u.Yukseklik);
                Point[] ucgenCiz = { point1, point2, point3 };

                g.FillPolygon(sb, ucgenCiz);

            }

            foreach (Dikdortgen d in dikdortgens)
            {
                sb = new SolidBrush(d.DolguRenk);

                g.FillRectangle(sb, d.X, d.Y, d.Genislik, d.Yukseklik);
            }

        }

        private void dgvDikdortgens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void pboDolguRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = cdiCizim.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pboDolguRenk.BackColor = cdiCizim.Color;
            }
        }

        private int IcerenSekilIndexBul(int x, int y)
        {
            for (int i = 0; i < dikdortgens.Count; i++)
            {
                if (dikdortgens[i].IcindeMi(x, y))
                {
                    return i;
                }
            }

            return -1;
        }

        private int IcerenSekilIndexBul1(int x, int y)
        {
            for (int i = ucgens.Count - 1; i >= 0; i--)
            {
                if (ucgens[i].IcindeMi(x, y))
                {
                    return i;
                }
            }

            return -1;
        }    

        private void pnlCizim_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenenIndex = IcerenSekilIndexBul(e.X, e.Y);
            suruklenenIndex1 = IcerenSekilIndexBul1(e.X, e.Y);

            if (suruklenenIndex != -1)
            {
                surukleSol = e.X - dikdortgens[suruklenenIndex].X;

                surukleUst = e.Y - dikdortgens[suruklenenIndex].Y;              
            }
            else if (suruklenenIndex1 != -1)
            {
                surukleSol1 = e.X - ucgens[suruklenenIndex1].X;

                surukleUst1 = e.Y - ucgens[suruklenenIndex1].Y;
            }
           
        }

        private void pnlCizim_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenenIndex != -1)
            {
                Dikdortgen suruklenen = dikdortgens[suruklenenIndex];

                suruklenen.X = e.X - surukleSol;

                suruklenen.Y = e.Y - surukleUst;

                pnlCizim.Refresh();
            }

            else if (suruklenenIndex1 != -1)
            {

                Ucgen suruklenen1 = ucgens[suruklenenIndex1];

                suruklenen1.X = e.X - surukleSol1;

                suruklenen1.Y = e.Y - surukleUst1;

                pnlCizim.Refresh();

            }
        }

        private void pnlCizim_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenenIndex = -1;
            suruklenenIndex1 = -1;

            dikdortgens.ResetBindings();
            ucgens.ResetBindings();
        }

        private void pnlCizim_MouseClick(object sender, MouseEventArgs e)
        {
            int index = IcerenSekilIndexBul(e.X, e.Y);
            int index1 = IcerenSekilIndexBul1(e.X, e.Y);

            if (index != -1)
            {
                MessageBox.Show("Dikdörtgenin Alanı: " + dikdortgens[suruklenenIndex].Alan() + "\nDikdörtgenin Çevresi: " + dikdortgens[suruklenenIndex].Cevre() + "\nDikdörtgenin Köşegen Uzunluğu: " + dikdortgens[suruklenenIndex].Kosegen() + "/nDikdörtgenin Merkez Noktası: " + dikdortgens[suruklenenIndex].MerkezNokta());
            }
            else if (index1 != -1)
            {
                MessageBox.Show("Üçgenin Alanı: " + ucgens[suruklenenIndex1].Alan() + "\nÜçgenin Çevresi: " + ucgens[suruklenenIndex1].Cevre() + "\nÜçgenin Hipotenüs Uzunluğu: " + ucgens[suruklenenIndex1].Hipotenus());
            }
            else
            {
                MessageBox.Show("Tıklanan yerde şekil yoktur!");
            }

        }
  
    }

}


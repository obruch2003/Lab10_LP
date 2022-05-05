using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen B = new Pen(Color.Black);
            SolidBrush g1 = new SolidBrush(Color.FromArgb(14,166,6));
            SolidBrush g2 = new SolidBrush(Color.FromArgb(147, 210, 140));
            SolidBrush g3 = new SolidBrush(Color.FromArgb(66, 177, 56));
            SolidBrush g4 = new SolidBrush(Color.FromArgb(148, 206, 138));
            SolidBrush g5 = new SolidBrush(Color.FromArgb(197, 224, 187));
            SolidBrush g6 = new SolidBrush(Color.FromArgb(122, 223, 105));
            SolidBrush g7 = new SolidBrush(Color.FromArgb(116, 207, 90));
            SolidBrush g8 = new SolidBrush(Color.FromArgb(65, 150, 56));
            SolidBrush g9 = new SolidBrush(Color.FromArgb(147, 210, 139));
            SolidBrush g10 = new SolidBrush(Color.FromArgb(0, 0, 0));
            g.Clear(Color.White);
            //1
            e.Graphics.FillRectangle(g1, 50, 50, 20, 20);
            e.Graphics.FillRectangle(g2, 70, 50, 20, 20);
            e.Graphics.FillRectangle(g1, 90, 50, 20, 20);
            e.Graphics.FillRectangle(g3, 110, 50, 20, 20);
            e.Graphics.FillRectangle(g4, 130, 50, 20, 20);
            e.Graphics.FillRectangle(g5, 150, 50, 20, 20);
            e.Graphics.FillRectangle(g6, 170, 50, 20, 20);
            e.Graphics.FillRectangle(g7, 190, 50, 20, 20);
            e.Graphics.FillRectangle(g8, 210, 50, 20, 20);
            e.Graphics.FillRectangle(g9, 230, 50, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 50 , 20, 20);
            //2
            e.Graphics.FillRectangle(g5, 50, 70, 20, 20);
            e.Graphics.FillRectangle(g8, 70, 70, 20, 20);
            e.Graphics.FillRectangle(g3, 90, 70, 20, 20);
            e.Graphics.FillRectangle(g4, 110, 70, 20, 20);
            e.Graphics.FillRectangle(g1, 130, 70, 20, 20);
            e.Graphics.FillRectangle(g2, 150, 70, 20, 20);
            e.Graphics.FillRectangle(g6, 170, 70, 20, 20);
            e.Graphics.FillRectangle(g3, 190, 70, 20, 20);
            e.Graphics.FillRectangle(g7, 210, 70, 20, 20);
            e.Graphics.FillRectangle(g2, 230, 70, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 70, 20, 20);
            //3
            e.Graphics.FillRectangle(g3, 50, 90, 20, 20);
            e.Graphics.FillRectangle(g4, 70, 90, 20, 20);
            e.Graphics.FillRectangle(g10, 90, 90, 20, 20);
            e.Graphics.FillRectangle(g10, 110, 90, 20, 20);
            e.Graphics.FillRectangle(g4, 130, 90, 20, 20);
            e.Graphics.FillRectangle(g3, 150, 90, 20, 20);
            e.Graphics.FillRectangle(g10, 170, 90, 20, 20);
            e.Graphics.FillRectangle(g10, 190, 90, 20, 20);
            e.Graphics.FillRectangle(g4, 210, 90, 20, 20);
            e.Graphics.FillRectangle(g3, 230, 90, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 90, 20, 20);
            //4
            e.Graphics.FillRectangle(g9, 50, 110, 20, 20);
            e.Graphics.FillRectangle(g6, 70, 110, 20, 20);
            e.Graphics.FillRectangle(g10, 90, 110, 20, 20);
            e.Graphics.FillRectangle(g10, 110, 110, 20, 20);
            e.Graphics.FillRectangle(g5, 130, 110, 20, 20);
            e.Graphics.FillRectangle(g4, 150, 110, 20, 20);
            e.Graphics.FillRectangle(g10, 170, 110, 20, 20);
            e.Graphics.FillRectangle(g10, 190, 110, 20, 20);
            e.Graphics.FillRectangle(g1, 210, 110, 20, 20);
            e.Graphics.FillRectangle(g7, 230, 110, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 110, 20, 20);
            //5
            e.Graphics.FillRectangle(g6, 50, 130, 20, 20);
            e.Graphics.FillRectangle(g9, 70, 130, 20, 20);
            e.Graphics.FillRectangle(g4, 90, 130, 20, 20);
            e.Graphics.FillRectangle(g3, 110, 130, 20, 20);
            e.Graphics.FillRectangle(g10, 130, 130, 20, 20);
            e.Graphics.FillRectangle(g10, 150, 130, 20, 20);
            e.Graphics.FillRectangle(g4, 170, 130, 20, 20);
            e.Graphics.FillRectangle(g2, 190, 130, 20, 20);
            e.Graphics.FillRectangle(g1, 210, 130, 20, 20);
            e.Graphics.FillRectangle(g8, 230, 130, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 130, 20, 20);
            //6
            e.Graphics.FillRectangle(g6, 50, 150, 20, 20);
            e.Graphics.FillRectangle(g7, 70, 150, 20, 20);
            e.Graphics.FillRectangle(g8, 90, 150, 20, 20);
            e.Graphics.FillRectangle(g10, 110, 150, 20, 20);
            e.Graphics.FillRectangle(g10, 130, 150, 20, 20);
            e.Graphics.FillRectangle(g10, 150, 150, 20, 20);
            e.Graphics.FillRectangle(g10, 170, 150, 20, 20);
            e.Graphics.FillRectangle(g5, 190, 150, 20, 20);
            e.Graphics.FillRectangle(g6, 210, 150, 20, 20);
            e.Graphics.FillRectangle(g7, 230, 150, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 150, 20, 20);
            //7
            e.Graphics.FillRectangle(g8, 50, 170, 20, 20);
            e.Graphics.FillRectangle(g9, 70, 170, 20, 20);
            e.Graphics.FillRectangle(g1, 90, 170, 20, 20);
            e.Graphics.FillRectangle(g10, 110, 170, 20, 20);
            e.Graphics.FillRectangle(g10, 130, 170, 20, 20);
            e.Graphics.FillRectangle(g10, 150, 170, 20, 20);
            e.Graphics.FillRectangle(g10, 170, 170, 20, 20);
            e.Graphics.FillRectangle(g6, 190, 170, 20, 20);
            e.Graphics.FillRectangle(g7, 210, 170, 20, 20);
            e.Graphics.FillRectangle(g8, 230, 170, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 170, 20, 20);
            //8
            e.Graphics.FillRectangle(g9, 50, 190, 20, 20);
            e.Graphics.FillRectangle(g1, 70, 190, 20, 20);
            e.Graphics.FillRectangle(g2, 90, 190, 20, 20);
            e.Graphics.FillRectangle(g10, 110, 190, 20, 20);
            e.Graphics.FillRectangle(g4, 130, 190, 20, 20);
            e.Graphics.FillRectangle(g5, 150, 190, 20, 20);
            e.Graphics.FillRectangle(g10, 170, 190, 20, 20);
            e.Graphics.FillRectangle(g7, 190, 190, 20, 20);
            e.Graphics.FillRectangle(g8, 210, 190, 20, 20);
            e.Graphics.FillRectangle(g9, 230, 190, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 190, 20, 20);
            //9
            e.Graphics.FillRectangle(g9, 50, 210, 20, 20);
            e.Graphics.FillRectangle(g3, 70, 210, 20, 20);
            e.Graphics.FillRectangle(g7, 90, 210, 20, 20);
            e.Graphics.FillRectangle(g6, 110, 210, 20, 20);
            e.Graphics.FillRectangle(g5, 130, 210, 20, 20);
            e.Graphics.FillRectangle(g4, 150, 210, 20, 20);
            e.Graphics.FillRectangle(g3, 170, 210, 20, 20);
            e.Graphics.FillRectangle(g2, 190, 210, 20, 20);
            e.Graphics.FillRectangle(g1, 210, 210, 20, 20);
            e.Graphics.FillRectangle(g6, 230, 210, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 210, 20, 20);
            //10
            e.Graphics.FillRectangle(g5, 50, 230, 20, 20);
            e.Graphics.FillRectangle(g7, 70, 230, 20, 20);
            e.Graphics.FillRectangle(g3, 90, 230, 20, 20);
            e.Graphics.FillRectangle(g4, 110, 230, 20, 20);
            e.Graphics.FillRectangle(g1, 130, 230, 20, 20);
            e.Graphics.FillRectangle(g2, 150, 230, 20, 20);
            e.Graphics.FillRectangle(g6, 170, 230, 20, 20);
            e.Graphics.FillRectangle(g3, 190, 230, 20, 20);
            e.Graphics.FillRectangle(g7, 210, 230, 20, 20);
            e.Graphics.FillRectangle(g2, 230, 230, 20, 20);
            for (int i = 0; i < 190; i += 20)
                e.Graphics.DrawRectangle(B, 50 + i, 230, 20, 20);

        }

    }
}

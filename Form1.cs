using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SW2202WeeklySales
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
            

        }

        
       
        public static Pen toDrawPen = new Pen(Brushes.Black);
        public static Point toDrawPoint1;
        public static Point toDrawPoint2;
        public static Point groundLine1;
        private static Point groundLine2;
        public static int[] increase = new int[5];
        public static byte days = 0;
        public static SolidBrush fillRecBrush = new SolidBrush(Color.Red);




        private void drawGroundLine()
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            groundLine1.X = tbxMonday.Location.X;
            groundLine1.Y = this.ClientSize.Height - 20;
            groundLine2.X = tbxFriday.Location.X + tbxFriday.Size.Width;
            groundLine2.Y = this.ClientSize.Height - 20;

            base.OnPaint(e);
            Rectangle diagramm = new Rectangle();
            //Grundlinie wird immer gezeichnet
            e.Graphics.DrawLine(toDrawPen, groundLine1,groundLine2);
            for (int i = 0; i < 5; i++)
            {
                
                switch (days)
                {
                    case 0:
                        //Die Zahl increase [0] muss umgedreht werden
                        
                        diagramm.X = tbxMonday.Location.X;
                        diagramm.Y = groundLine1.Y - increase[0];
                        diagramm.Width = tbxMonday.Width;
                        diagramm.Height = increase[0];
                        fillRecBrush.Color = Color.Red;

                        
                        e.Graphics.DrawRectangle(toDrawPen, diagramm);
                        e.Graphics.FillRectangle(fillRecBrush, diagramm);
                        break;

                    case 1:

                        diagramm.X = tbxTuesday.Location.X;
                        diagramm.Y = groundLine1.Y;
                        diagramm.Width = tbxTuesday.Width;
                        diagramm.Height = increase[1];
                        fillRecBrush.Color = Color.Blue;


                        e.Graphics.DrawRectangle(toDrawPen, diagramm);
                        e.Graphics.FillRectangle(fillRecBrush, diagramm);
                        break;

                    case 2:

                        diagramm.X = tbxWednesday.Location.X;
                        diagramm.Y = groundLine1.Y;
                        diagramm.Width = tbxWednesday.Width;
                        diagramm.Height = increase[2];
                        fillRecBrush.Color = Color.Purple;


                        e.Graphics.DrawRectangle(toDrawPen, diagramm);
                        e.Graphics.FillRectangle(fillRecBrush, diagramm);
                        break;

                    case 3:

                        diagramm.X = tbxThursday.Location.X;
                        diagramm.Y = groundLine1.Y;
                        diagramm.Width = tbxThursday.Width;
                        diagramm.Height = increase[3];
                        fillRecBrush.Color = Color.DarkRed;


                        e.Graphics.DrawRectangle(toDrawPen, diagramm);
                        e.Graphics.FillRectangle(fillRecBrush, diagramm);
                        break;

                    case 4:
                        diagramm.X = tbxFriday.Location.X;
                        diagramm.Y = groundLine1.Y;
                        diagramm.Width = tbxFriday.Width;
                        diagramm.Height = increase[4];
                        fillRecBrush.Color = Color.Turquoise;


                        e.Graphics.DrawRectangle(toDrawPen, diagramm);
                        e.Graphics.FillRectangle(fillRecBrush, diagramm);
                        break;

                }
                days++;
                
            }
            days = 0;
            

            





        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            increase[0] = Convert.ToInt32(tbxMonday.Text);
            increase[1] = Convert.ToInt32(tbxTuesday.Text);
            increase[2] = Convert.ToInt32(tbxWednesday.Text);
            increase[3] = Convert.ToInt32(tbxThursday.Text);
            increase[4] = Convert.ToInt32(tbxFriday.Text);

            for (int i = 0; i < increase.Length; i++)
            {
                increase[i] = increase[i] / 100;
            } 

            Invalidate();
        }

        private void tbxMonday_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Исследование_операций_Лаб7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
				double p1, p2, p3, p4, p5, p6, s0, s1, s2, s3, s4, s5, cena122,cena2, cena3, cena4, cena5,cena6,cena7,cena8,cena9,cena10, M1, M2, M3, M4, M5,M6,M7,M8,M9,M10;

				p1 = 0.6;
				p2 = 0.2;
				p3 = 0.1;
				p4 = 0.05;
				p5 = 0.00002;
				p6 = 0.04998;
				s0 = 0;
				s1 = 10;
				s2 = 20;
				s3 = 100;
				s4 = 1000;
				s5 = +1;


			/*	double cena = double.Parse(textBox1.Text.Replace(".", ","));

				double cena1 = double.Parse(textBox4.Text.Replace(".", ","));

				double cena22 = double.Parse(textBox6.Text.Replace(".", ","));
				double cena33 = double.Parse(textBox8.Text.Replace(".", ","));
				double cena44 = double.Parse(textBox10.Text.Replace(".", ","));


			double cena55 = double.Parse(textBox17.Text.Replace(".", ","));

			double cena66 = double.Parse(textBox19.Text.Replace(".", ","));

			double cena77 = double.Parse(textBox21.Text.Replace(".", ","));
			double cena88 = double.Parse(textBox23.Text.Replace(".", ","));
			double cena99 = double.Parse(textBox25.Text.Replace(".", ","));*/


			double cena = 9;

			double cena1 = 8;

			double cena22 = 7;
			double cena33 = 6;
			double cena44 = 5;


			double cena55 = 4;

			double cena66 = 7;

			double cena77 = 5;
			double cena88 = 4;
			double cena99 =3;


			cena122 = (cena - ((cena / 100) * 10)) + cena;
			M1 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena122;



				cena2 = (cena - ((cena / 100) * 10)) + cena1;
				M2 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena2;



				cena3 = (cena - ((cena / 100) * 15)) + cena22;
				M3 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena3;


				cena4 = (cena - ((cena / 100) * 20)) + cena33;
				M4 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena4;



				cena5 = (cena - ((cena / 100) * 25)) + cena44;
				M5 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena5;


			cena6 = (cena - ((cena / 100) * 30)) + cena55;
			M6 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena6;

			cena7 = (cena - ((cena / 100) * 35)) + cena66;
			M7 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena66;

			cena8 = (cena - ((cena / 100) * 40)) + cena77;
			M8 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena77;

			cena9 = (cena - ((cena / 100) * 45)) + cena88;
			M9 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena88;

			cena10 = (cena - ((cena / 100) * 50)) + cena99;
			M10 = (p1 * s0 + p2 * s1 + p3 * s2 + p4 * s3 + p5 * s4 + p6 * s5) - cena99;


			textBox11.Text = M1.ToString("0.000");
				textBox12.Text = M2.ToString("0.000");
				textBox13.Text = M3.ToString("0.000");
				textBox14.Text = M4.ToString("0.000");
				textBox15.Text = M5.ToString("0.000");


			textBox26.Text = M6.ToString("0.000");
			textBox27.Text = M7.ToString("0.000");
			textBox28.Text = M8.ToString("0.000");
			textBox29.Text = M9.ToString("0.000");
			textBox30.Text = M10.ToString("0.000");

			double a = -100, b = 100, h = 0.1, x, y;
				chart1.Series[0].Points.Clear();
				x = a;

		
				if (x <= b)
				{
					y = M1;
					chart1.Series[0].Points.AddXY(1, y);
					x += h;

					y = M2;
					chart1.Series[0].Points.AddXY(2, y);
					x += h;
					y = M3;
					chart1.Series[0].Points.AddXY(3, y);
					x += h;
					y = M4;
					chart1.Series[0].Points.AddXY(4, y);
					x += h;
					y = M5;
				chart1.Series[0].Points.AddXY(5, y);
				x += h;



				y = M6;
				chart1.Series[0].Points.AddXY(6, y);
				x += h;

				y = M7;
				chart1.Series[0].Points.AddXY(7, y);
				x += h;
				y = M8;
				chart1.Series[0].Points.AddXY(8, y);
				x += h;
				y = M9;
				chart1.Series[0].Points.AddXY(9, y);
				x += h;
				y = M10;
				chart1.Series[0].Points.AddXY(10, y);
				x += h;
			}
				
				/*Graphics graphics = pictureBox1.CreateGraphics();
			Pen pen = new Pen(Color.Black, 3f);
			Point[] points = new Point[1000];


			for (int i = 0; i < points.Length; i++)
			{
				points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
			}
			graphics.DrawLines(pen, points);*/
		}

	}
}

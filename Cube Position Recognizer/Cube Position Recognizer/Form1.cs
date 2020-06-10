using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Reflection;

using Point = System.Drawing.Point;
using Accord;
using Accord.Imaging;

namespace Cube_Position_Recognizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Dodawanie przykładów do listy wyboru
            ImageList.Items.Add("CubePaint.png");
            ImageList.Items.Add("Cube.png");
            ImageList.Items.Add("Cube2.png");
            ImageList.Items.Add("3dCube.jpeg");
            ImageList.Items.Add("Cube2.jpg");
            ImageList.Items.Add("Cube4.png");
            ImageList.Items.Add("StockSample.jpg");

        }

        private void MakeCorners_Click(object sender, EventArgs e)
        {

            CornerListView.Items.Clear();

            // Zaciągnięcie pliku do bitmapy
            Bitmap image = Accord.Imaging.Image.FromFile("Samples/" + ImageList.Text);


            float kinput = float.Parse(k_Input.Text);
            float thresholdinput = float.Parse(Threshold_input.Text);
            float sigmainput = float.Parse(sigma_Input.Text);


            // Rozpoznawanie wierzchołków Harrisa (Lepiej się sprawdziło niż np. Suzan)
            HarrisCornersDetector target = new HarrisCornersDetector(kinput, thresholdinput, sigmainput);
            target.Suppression = 1;

            // Wyznaczenie wierzchołków do listy punktów
            List<Accord.IntPoint> actual = target.ProcessImage(image);

            for (int i = 0, n = actual.Count; i < n; i++)
            {

                // Listowanie punktów wierzchołków
                Console.WriteLine("Punkt: [" + actual[i].X + " , " + actual[i].Y + "]");

                CornerListView.Items.Add("Punkt " + (i + 1) + " : [" + actual[i].X + " , " + actual[i].Y + "]");

                try
                {
                    // Generowanie białych kwadratów w miejscu wierzchołków
                    for (int w = 0; w <= 10; w++)
                    {
                        for (int h = 0; h <= 10; h++)
                        {
                            image.SetPixel(actual[i].X + (w - 5), actual[i].Y + (h - 5), Color.White);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Piksel za burtą!");
                }
            }

 
            
            Preview_1.Image = image;


            
        }

    }
}

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
using Emgu.CV;
using Emgu.CV.Structure;
using Accord.Imaging.Filters;

namespace Cube_Position_Recognizer
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgGray;
        Image<Bgr, byte> imgRaw;

        Bitmap afterBinarization;
        Bitmap rgbd;
        public Form1()
        {
            InitializeComponent();

            // Dodawanie przykładów do listy wyboru
            ImageList.Items.Add("rosRGB_00000.bmp");
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
            Bitmap image = (Bitmap)Preview_1.Image; //Accord.Imaging.Image.FromFile("Samples/" + ImageList.Text);


            float kinput = float.Parse(k_Input.Text);
            float thresholdinput = float.Parse(Threshold_input.Text);
            float sigmainput = float.Parse(sigma_Input.Text);


            // Rozpoznawanie wierzchołków Harrisa (Lepiej się sprawdziło niż np. Suzan)
            HarrisCornersDetector target = new HarrisCornersDetector(kinput, thresholdinput, sigmainput);
            target.Suppression = (int)float.Parse(suppressionTarget.Text); ;

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

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Obrazki (*.tif; *.dcm; *.jpg; *.jpeg; *.bmp)|*.tif; *.dcm; *.jpg; *.jpeg; *.bmp";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imgGray = new Image<Gray, Byte>(ofd.FileName);

                string rgbdPath = ofd.FileName.Replace("RGB", "Depth");

                rgbd = Accord.Imaging.Image.FromFile(rgbdPath);

                Preview_1.Image = imgInput.ToBitmap<Bgr, byte>();





            }
        }

        private void binaryzujToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /* Kolorowa binaryzacj
               
                imgBinarize = imgInput.ThresholdBinary(
                  new Bgr(float.Parse(BthresholdValue.Text), float.Parse(GthresholdValue.Text), float.Parse(RthresholdValue.Text)), new Bgr(255, 255, 255));
                
            
            Preview_1.Image = imgBinarize.ToBitmap(); */

            Preview_1.Image = imgGray.ToBitmap(); //Display if you want
            imgGray = imgGray.ThresholdBinary(new Gray(float.Parse(kThresholdValue.Text)), new Gray(255));
            //Image<Gray,Byte> Binary_Image = img.ThresholdBinary(new Gray(threshold_value),
            //   new Gray(255)); // to get it saved in seperate variable 
            Preview_1.Image = imgGray.ToBitmap(); //display results in different picturebox

            // create and configure the filter
            FillHoles filter = new FillHoles();
            filter.MaxHoleHeight = 200;
            filter.MaxHoleWidth = 200;
            filter.CoupledSizeFiltering = true;
            // apply the filter
            Bitmap result = filter.Apply(imgGray.ToBitmap());

            Invert filter2 = new Invert();
            // apply the filter
            filter2.ApplyInPlace(result);


            // create and configure the filter
            FillHoles filter3 = new FillHoles();
            filter3.MaxHoleHeight = 200;
            filter3.MaxHoleWidth = 200;
            filter3.CoupledSizeFiltering = true;
            // apply the filter
            Bitmap result2 = filter3.Apply(result);

            Preview_1.Image = result2;


            // create filter
            GrayscaleToRGB filter4 = new GrayscaleToRGB();
            // apply the filter
            afterBinarization = filter4.Apply(result2);



        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap ss = (Bitmap)Preview_1.Image;
                ss.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void znajdźWierzchołkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CornerListView.Items.Clear();

            // Zaciągnięcie pliku do bitmapy
            Bitmap image = afterBinarization;

            float kinput = float.Parse(k_Input.Text);
            float thresholdinput = float.Parse(Threshold_input.Text);
            float sigmainput = float.Parse(sigma_Input.Text);


            // Rozpoznawanie wierzchołków Harrisa (Lepiej się sprawdziło niż np. Suzan)
            HarrisCornersDetector target = new HarrisCornersDetector(kinput, thresholdinput, sigmainput);
            target.Suppression = (int)float.Parse(suppressionTarget.Text);

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
                            image.SetPixel(actual[i].X + (w - 5), actual[i].Y + (h - 5), Color.Red);
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

        private void mAGICBUTTONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Obrazki (*.tif; *.dcm; *.jpg; *.jpeg; *.bmp)|*.tif; *.dcm; *.jpg; *.jpeg; *.bmp";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imgGray = new Image<Gray, Byte>(ofd.FileName);

                imgRaw = new Image<Bgr, byte>(ofd.FileName);

                string rgbdPath = ofd.FileName.Replace("RGB", "Depth");

                rgbd = Accord.Imaging.Image.FromFile(rgbdPath);

                Preview_1.Image = imgInput.ToBitmap<Bgr, byte>();





            }


            Preview_1.Image = imgGray.ToBitmap(); //Display if you want
            imgGray = imgGray.ThresholdBinary(new Gray(float.Parse(kThresholdValue.Text)), new Gray(255));
            //Image<Gray,Byte> Binary_Image = img.ThresholdBinary(new Gray(threshold_value),
            //   new Gray(255)); // to get it saved in seperate variable 
            Preview_1.Image = imgGray.ToBitmap(); //display results in different picturebox

            // create and configure the filter
            FillHoles filter = new FillHoles();
            filter.MaxHoleHeight = 200;
            filter.MaxHoleWidth = 200;
            filter.CoupledSizeFiltering = true;
            // apply the filter
            Bitmap result = filter.Apply(imgGray.ToBitmap());

            Invert filter2 = new Invert();
            // apply the filter
            filter2.ApplyInPlace(result);


            // create and configure the filter
            FillHoles filter3 = new FillHoles();
            filter3.MaxHoleHeight = 200;
            filter3.MaxHoleWidth = 200;
            filter3.CoupledSizeFiltering = true;
            // apply the filter
            Bitmap result2 = filter3.Apply(result);

            Preview_1.Image = result2;


            // create filter
            GrayscaleToRGB filter4 = new GrayscaleToRGB();
            // apply the filter
            afterBinarization = filter4.Apply(result2);

            CornerListView.Items.Clear();

            // Zaciągnięcie pliku do bitmapy
            Bitmap image = afterBinarization;

            float kinput = float.Parse(k_Input.Text);
            float thresholdinput = float.Parse(Threshold_input.Text);
            float sigmainput = float.Parse(sigma_Input.Text);


            // Rozpoznawanie wierzchołków Harrisa (Lepiej się sprawdziło niż np. Suzan)
            HarrisCornersDetector target = new HarrisCornersDetector(kinput, thresholdinput, sigmainput);
            target.Suppression = (int)float.Parse(suppressionTarget.Text);

            // Wyznaczenie wierzchołków do listy punktów
            List<Accord.IntPoint> actual = target.ProcessImage(image);

            int PointNum = 0;
            int DistNum = 0;

            for (int i = 0, n = actual.Count; i < n; i++)
            {
                float calculateDepth = (rgbd.GetPixel(actual[i].X, actual[i].Y).R + rgbd.GetPixel(actual[i].X, actual[i].Y).G + rgbd.GetPixel(actual[i].X, actual[i].Y).B) / 3;


                if ((actual[i].X > 400) && (actual[i].X < 900) && (calculateDepth > 70))
                {
                    PointNum++;

                    // Listowanie punktów wierzchołków
                    Console.WriteLine("Punkt: [" + actual[i].X + " , " + actual[i].Y + " , " + calculateDepth + "]");

                    CornerListView.Items.Add("Punkt " + (DistNum + 1) + " : [" + actual[i].X + " , " + actual[i].Y + " , " + calculateDepth + "]");

                    try
                    {
                        // Generowanie białych kwadratów w miejscu wierzchołków
                        for (int w = 0; w <= 10; w++)
                        {
                            for (int h = 0; h <= 10; h++)
                            {
                                image.SetPixel(actual[i].X + (w - 5), actual[i].Y + (h - 5), Color.Red);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Piksel za burtą!");
                    }


                    try
                    {
                        // Draw line using Point structure
                        Pen greenPen = new Pen(Color.Green, 3);
                        Point p1 = new Point(actual[i].X, actual[i].Y);
                        for (int it = 0, nt = actual.Count; it < nt; it++)
                        {
                            if ((Math.Abs(actual[i].X - actual[it].X) < 20) || (Math.Abs(actual[i].Y - actual[it].Y) < 20))
                            {
                                Point p2 = new Point(actual[it].X, actual[it].Y);
                                
                                float calculateDepth2 = (rgbd.GetPixel(actual[it].X, actual[it].Y).R + rgbd.GetPixel(actual[it].X, actual[it].Y).G + rgbd.GetPixel(actual[it].X, actual[it].Y).B) / 3;

                                double distance = Math.Sqrt((((long)Math.Pow((actual[it].X - actual[i].X), 2)) + ((long)Math.Pow((actual[it].Y - actual[i].Y), 2)) + ((long)Math.Pow((calculateDepth - calculateDepth2), 2))));

                                if ((distance > 130) && (distance < 180))
                                {
                                    DistanceListView.Items.Add("Odcinek " + PointNum + " : [" + actual[i].X + " , " + actual[i].Y + " | " + actual[it].X + " , " + actual[it].Y +  "] = " + distance);
                                    
                                    
                                    Console.WriteLine("Distance: " + distance);

                                    for (int w = 0; w <= 10; w++)
                                    {
                                        for (int h = 0; h <= 10; h++)
                                        {
                                            image.SetPixel(actual[i].X + (w - 5), actual[i].Y + (h - 5), Color.Blue);
                                        }
                                    }

                                    using (var graphics = Graphics.FromImage(image))
                                    {
                                        graphics.DrawLine(greenPen, p1, p2);

                                        Bitmap cubeLines = new Bitmap(image.Width, image.Height, graphics);
                                        Preview_1.Image = cubeLines;
                                    }

                                }

                            }

                        }
                    }
                    catch
                    {

                    }

                }
            }



            Preview_1.Image = image;

        }
    }
}

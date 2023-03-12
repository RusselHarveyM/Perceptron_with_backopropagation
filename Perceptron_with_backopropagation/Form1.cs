using Backprop;
using System;

namespace Perceptron_with_backopropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        FileStream ifsLabels, ifsImages;
        BinaryReader brLabels, brImages;
        Bitmap testNumber;
        private Image activeNeuron;
        private double[] output;

        private void button2_Click(object sender, EventArgs e)
        {
            using (testNumber = new Bitmap(@"C:\Users\Lenovo\Pictures\perceptron\testNumber.png"))
            {

            testNumber = new Bitmap(testNumber, 28, 28);


            byte[] pixels = new byte[28 * 28];
            int index = 0;

                using (var ms = new MemoryStream())
                {
                    var bitmap = new Bitmap(28, 28);
                    for (int x = 0; x < 28; x++)
                    {
                        for (int y = 0; y < 28; y++)
                        {
                            Color pixelColor = testNumber.GetPixel(y, x);
                            byte pixelValue = (byte)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                            pixels[index++] = pixelValue;
                            bitmap.SetPixel(y, x, pixelColor);
                        }
                    }
                    pictureBox1.Image = bitmap;

                    setNeuralNetwork(pixels, 2);
                }
            }
        }

        private void loadWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nn.loadWeights(@"C:\Users\Lenovo\Documents\perceptron_weights\weights.txt");
            loadWeightsToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nn = new NeuralNet(784, 32, 10);
            button2.Enabled = false;
            output = new double[10];
            saveWeightsToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            loadWeightsToolStripMenuItem.Enabled = false;
            /*for (int epoch = 0; epoch <= 2;epoch++)
            {*/
            int epoch = 0;
            epochCount.Text = Convert.ToString(epoch);
            while (nn.countgood())
            {
                ifsLabels?.Close();
                ifsImages?.Close();
                brImages?.Close();
                brLabels?.Close();

                try
                {
                ifsLabels =
                    new FileStream(@"C:\Users\Lenovo\source\repos\Perceptron_with_backopropagation\Perceptron_with_backopropagation\t10k-labels.idx1-ubyte",
                    FileMode.Open); // test labels
                ifsImages =
                    new FileStream(@"C:\Users\Lenovo\source\repos\Perceptron_with_backopropagation\Perceptron_with_backopropagation\t10k-images.idx3-ubyte",
                    FileMode.Open); // test images

                brLabels =
                    new BinaryReader(ifsLabels);
                brImages =
                    new BinaryReader(ifsImages);

                int magic1 = brImages.ReadInt32(); // discard
                int numImages = brImages.ReadInt32();
                int numRows = brImages.ReadInt32();
                int numCols = brImages.ReadInt32();

                int magic2 = brLabels.ReadInt32();
                int numLabels = brLabels.ReadInt32();

                byte[][] pixels = new byte[28][];
                for (int i = 0; i < pixels.Length; ++i)
                    pixels[i] = new byte[28];

                // each test image
                for (int di = 0; di < numImages; ++di)
                {
                    for (int i = 0; i < 28; ++i)
                    {
                        for (int j = 0; j < 28; ++j)
                        {
                            if (brImages.BaseStream.Position < brImages.BaseStream.Length)
                            {
                                byte b = brImages.ReadByte();
                                pixels[i][j] = b;
                            }
                            else
                            {
                                    break;
                                // Handle end of stream gracefully
                            }

                        }
                    }

                    byte lbl = brLabels.ReadByte();
                    DigitImage dImage = new DigitImage(pixels, lbl);

                    using (var ms = new MemoryStream())
                    {
                        var bitmap = new Bitmap(28, 28);
                        for (int x = 0; x < 28; x++)
                        {
                            for (int y = 0; y < 28; y++)
                            {
                                Color color = Color.FromArgb(pixels[x][y], pixels[x][y], pixels[x][y]);
                                bitmap.SetPixel(y, x, color);
                            }
                        }
                        pictureBox1.Image = bitmap;
                        pictureBox1.Refresh();
                        }
                        setNeuralNetwork(dImage.Flatten(), Convert.ToInt32(lbl));
                        Application.DoEvents();
                    } // each image

                    /*Console.WriteLine("\nEnd\n");
                    Console.ReadLine();*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
                epochCount.Text = Convert.ToString(++epoch);
            }
            
            button2.Enabled = true;
            saveWeightsToolStripMenuItem.Enabled = true;
        } 
        private void setNeuralNetwork(byte[] pixels, int label)
        {

            label2.Text = label.ToString();


            for (int i = 0; i < pixels.Length; i++)
            {
                nn.setInputs(i, pixels[i]);
            }

            switch (label)
            {
                case 0:
                    nn.setDesiredOutput(0, 1);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 1:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 1);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 2:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 1);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 3:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 1);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 4:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 1);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 5:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 1);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 6:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 1);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 7:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 1);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 0);
                    break;
                case 8:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 1);
                    nn.setDesiredOutput(9, 0);
                   break;
                case 9:
                    nn.setDesiredOutput(0, 0);
                    nn.setDesiredOutput(1, 0);
                    nn.setDesiredOutput(2, 0);
                    nn.setDesiredOutput(3, 0);
                    nn.setDesiredOutput(4, 0);
                    nn.setDesiredOutput(5, 0);
                    nn.setDesiredOutput(6, 0);
                    nn.setDesiredOutput(7, 0);
                    nn.setDesiredOutput(8, 0);
                    nn.setDesiredOutput(9, 1);
                    break;
            }

            nn.learn();


            guessOutput();

            /*output0.Refresh();
            output1.Refresh();
            output2.Refresh();
            output3.Refresh();
            output4.Refresh();
            output5.Refresh();
            output6.Refresh();
            output7.Refresh();
            output8.Refresh();
            output9.Refresh();*/

           
        }

        private void guessOutput()
        {
            for (int i = 0; i < 10; i++)
            {
                output[i] = nn.getOuputData(i);
            }

            int active = output.ToList().IndexOf(output.Max());

            switch (active)
            {
                case 0:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(1).png");
                    output0.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.Orange;
                    break;
                case 1:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2.png");
                    output1.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.Orange;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 2:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(2).png");
                    output2.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.Orange;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 3:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(3).png");
                    output3.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.Orange;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 4:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(4).png");
                    output4.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.Orange;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 5:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(5).png");
                    output5.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.Orange;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 6:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(6).png");
                    output6.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.Orange;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 7:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(7).png");
                    output7.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.Orange;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 8:
                    activeNeuron = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(8).png");
                    output8.BackgroundImage = activeNeuron;
                    output9.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(9).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.Orange;
                    label4.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 9:
                    activeNeuron = new Bitmap("c:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\2(9).png");
                    output9.BackgroundImage = activeNeuron;
                    output8.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(8).png"); ;
                    output7.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(7).png"); ;
                    output6.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(6).png"); ;
                    output5.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(5).png"); ;
                    output4.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(4).png"); ;
                    output3.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(3).png"); ;
                    output2.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(2).png"); ;
                    output1.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1.png"); ;
                    output0.BackgroundImage = new Bitmap("C:\\Users\\Lenovo\\source\\repos\\Perceptron_with_backopropagation\\Perceptron_with_backopropagation\\images\\1(1).png"); ;
                    label12.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label4.ForeColor = Color.Orange;
                    label3.ForeColor = Color.White;
                    break;
            }
            label12.Text = Convert.ToString(output[1]);
            label11.Text = Convert.ToString(output[2]);
            label10.Text = Convert.ToString(output[3]);
            label9.Text = Convert.ToString(output[4]);
            label8.Text = Convert.ToString(output[5]);
            label7.Text = Convert.ToString(output[6]);
            label6.Text = Convert.ToString(output[7]);
            label5.Text = Convert.ToString(output[8]);
            label4.Text = Convert.ToString(output[9]);
            label3.Text = Convert.ToString(output[0]);
        }

        private void saveWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nn.saveWeights(@"C:\Users\Lenovo\Documents\perceptron_weights\weights.txt");
        }
    }
}
using Backprop;

namespace Perceptron_with_backopropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for (int epoch = 0; epoch < 17;epoch++)
            {

            try
            {
                FileStream ifsLabels =
                    new FileStream(@"C:\Users\Lenovo\source\repos\Perceptron_with_backopropagation\t10k-labels.idx1-ubyte",
                    FileMode.Open); // test labels
                FileStream ifsImages =
                    new FileStream(@"C:\Users\Lenovo\source\repos\Perceptron_with_backopropagation\t10k-images.idx3-ubyte",
                    FileMode.Open); // test images

                BinaryReader brLabels =
                    new BinaryReader(ifsLabels);
                BinaryReader brImages =
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
                        label2.Text = lbl.ToString();
                        pictureBox1.Refresh();
                        Application.DoEvents();
                    }
                    setNeuralNetwork(dImage.Flatten());
                } // each image

                ifsImages.Close();
                brImages.Close();
                ifsLabels.Close();
                brLabels.Close();

                /*Console.WriteLine("\nEnd\n");
                Console.ReadLine();*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            }

        }

        private void setNeuralNetwork(byte[] pixels)
        {
            nn = new NeuralNet(784,16, 10);
            for(int i = 0; i < pixels.Length; i++)
            {
                nn.setInputs(i, pixels[i]);
            }
            for(int i = 0; i < 10; i++)
                nn.setDesiredOutput(i, i);


            nn.learn();

            label12.Text = Convert.ToString(nn.getOuputData(1));
            label11.Text = Convert.ToString(nn.getOuputData(2));
            label10.Text = Convert.ToString(nn.getOuputData(3));
            label9.Text = Convert.ToString(nn.getOuputData(4));
            label8.Text = Convert.ToString(nn.getOuputData(5));
            label7.Text = Convert.ToString(nn.getOuputData(6));
            label6.Text = Convert.ToString(nn.getOuputData(7));
            label5.Text = Convert.ToString(nn.getOuputData(8));
            label4.Text = Convert.ToString(nn.getOuputData(9));
            label3.Text = Convert.ToString(nn.getOuputData(0));
        }
    }
}
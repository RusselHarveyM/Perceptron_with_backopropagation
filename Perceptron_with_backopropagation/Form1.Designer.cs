namespace Perceptron_with_backopropagation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.o2 = new System.Windows.Forms.Label();
            this.o3 = new System.Windows.Forms.Label();
            this.o4 = new System.Windows.Forms.Label();
            this.o5 = new System.Windows.Forms.Label();
            this.o6 = new System.Windows.Forms.Label();
            this.o7 = new System.Windows.Forms.Label();
            this.o8 = new System.Windows.Forms.Label();
            this.o9 = new System.Windows.Forms.Label();
            this.o0 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.epochCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.output3 = new System.Windows.Forms.PictureBox();
            this.output2 = new System.Windows.Forms.PictureBox();
            this.output1 = new System.Windows.Forms.PictureBox();
            this.output0 = new System.Windows.Forms.PictureBox();
            this.output7 = new System.Windows.Forms.PictureBox();
            this.output6 = new System.Windows.Forms.PictureBox();
            this.output5 = new System.Windows.Forms.PictureBox();
            this.output4 = new System.Windows.Forms.PictureBox();
            this.output9 = new System.Windows.Forms.PictureBox();
            this.output8 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output8)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveWeightsToolStripMenuItem,
            this.loadWeightsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveWeightsToolStripMenuItem
            // 
            this.saveWeightsToolStripMenuItem.Name = "saveWeightsToolStripMenuItem";
            this.saveWeightsToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.saveWeightsToolStripMenuItem.Text = "Save Weights";
            this.saveWeightsToolStripMenuItem.Click += new System.EventHandler(this.saveWeightsToolStripMenuItem_Click);
            // 
            // loadWeightsToolStripMenuItem
            // 
            this.loadWeightsToolStripMenuItem.Name = "loadWeightsToolStripMenuItem";
            this.loadWeightsToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.loadWeightsToolStripMenuItem.Text = "Load Weights";
            this.loadWeightsToolStripMenuItem.Click += new System.EventHandler(this.loadWeightsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(475, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(518, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(409, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o1.ForeColor = System.Drawing.Color.White;
            this.o1.Location = new System.Drawing.Point(52, 29);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(72, 20);
            this.o1.TabIndex = 9;
            this.o1.Text = "Output 1";
            // 
            // o2
            // 
            this.o2.AutoSize = true;
            this.o2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o2.ForeColor = System.Drawing.Color.White;
            this.o2.Location = new System.Drawing.Point(52, 62);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(72, 20);
            this.o2.TabIndex = 10;
            this.o2.Text = "Output 2";
            // 
            // o3
            // 
            this.o3.AutoSize = true;
            this.o3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o3.ForeColor = System.Drawing.Color.White;
            this.o3.Location = new System.Drawing.Point(52, 95);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(72, 20);
            this.o3.TabIndex = 11;
            this.o3.Text = "Output 3";
            // 
            // o4
            // 
            this.o4.AutoSize = true;
            this.o4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o4.ForeColor = System.Drawing.Color.White;
            this.o4.Location = new System.Drawing.Point(52, 128);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(72, 20);
            this.o4.TabIndex = 12;
            this.o4.Text = "Output 4";
            // 
            // o5
            // 
            this.o5.AutoSize = true;
            this.o5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o5.ForeColor = System.Drawing.Color.White;
            this.o5.Location = new System.Drawing.Point(52, 161);
            this.o5.Name = "o5";
            this.o5.Size = new System.Drawing.Size(72, 20);
            this.o5.TabIndex = 13;
            this.o5.Text = "Output 5";
            // 
            // o6
            // 
            this.o6.AutoSize = true;
            this.o6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o6.ForeColor = System.Drawing.Color.White;
            this.o6.Location = new System.Drawing.Point(52, 194);
            this.o6.Name = "o6";
            this.o6.Size = new System.Drawing.Size(72, 20);
            this.o6.TabIndex = 14;
            this.o6.Text = "Output 6";
            // 
            // o7
            // 
            this.o7.AutoSize = true;
            this.o7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o7.ForeColor = System.Drawing.Color.White;
            this.o7.Location = new System.Drawing.Point(52, 225);
            this.o7.Name = "o7";
            this.o7.Size = new System.Drawing.Size(72, 20);
            this.o7.TabIndex = 15;
            this.o7.Text = "Output 7";
            // 
            // o8
            // 
            this.o8.AutoSize = true;
            this.o8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o8.ForeColor = System.Drawing.Color.White;
            this.o8.Location = new System.Drawing.Point(52, 258);
            this.o8.Name = "o8";
            this.o8.Size = new System.Drawing.Size(72, 20);
            this.o8.TabIndex = 16;
            this.o8.Text = "Output 8";
            // 
            // o9
            // 
            this.o9.AutoSize = true;
            this.o9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o9.ForeColor = System.Drawing.Color.White;
            this.o9.Location = new System.Drawing.Point(52, 291);
            this.o9.Name = "o9";
            this.o9.Size = new System.Drawing.Size(72, 20);
            this.o9.TabIndex = 17;
            this.o9.Text = "Output 9";
            // 
            // o0
            // 
            this.o0.AutoSize = true;
            this.o0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.o0.ForeColor = System.Drawing.Color.White;
            this.o0.Location = new System.Drawing.Point(52, 324);
            this.o0.Name = "o0";
            this.o0.Size = new System.Drawing.Size(72, 20);
            this.o0.TabIndex = 18;
            this.o0.Text = "Output 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(125, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(125, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(125, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(125, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(125, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(125, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(125, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(358, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Epoch";
            // 
            // epochCount
            // 
            this.epochCount.AutoSize = true;
            this.epochCount.ForeColor = System.Drawing.Color.White;
            this.epochCount.Location = new System.Drawing.Point(410, 59);
            this.epochCount.Name = "epochCount";
            this.epochCount.Size = new System.Drawing.Size(0, 20);
            this.epochCount.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.epochCount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.o0);
            this.groupBox1.Controls.Add(this.o9);
            this.groupBox1.Controls.Add(this.o8);
            this.groupBox1.Controls.Add(this.o7);
            this.groupBox1.Controls.Add(this.o6);
            this.groupBox1.Controls.Add(this.o5);
            this.groupBox1.Controls.Add(this.o4);
            this.groupBox1.Controls.Add(this.o3);
            this.groupBox1.Controls.Add(this.o2);
            this.groupBox1.Controls.Add(this.o1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 365);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(684, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 57);
            this.button2.TabIndex = 32;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // output3
            // 
            this.output3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output3.BackgroundImage")));
            this.output3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output3.Location = new System.Drawing.Point(283, 453);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(82, 74);
            this.output3.TabIndex = 40;
            this.output3.TabStop = false;
            // 
            // output2
            // 
            this.output2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output2.BackgroundImage")));
            this.output2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output2.Location = new System.Drawing.Point(196, 505);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(82, 74);
            this.output2.TabIndex = 39;
            this.output2.TabStop = false;
            // 
            // output1
            // 
            this.output1.BackgroundImage = global::Perceptron_with_backopropagation.Properties.Resources._1;
            this.output1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output1.Location = new System.Drawing.Point(108, 453);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(82, 74);
            this.output1.TabIndex = 38;
            this.output1.TabStop = false;
            // 
            // output0
            // 
            this.output0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output0.BackgroundImage")));
            this.output0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output0.Location = new System.Drawing.Point(18, 505);
            this.output0.Name = "output0";
            this.output0.Size = new System.Drawing.Size(82, 74);
            this.output0.TabIndex = 37;
            this.output0.TabStop = false;
            // 
            // output7
            // 
            this.output7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output7.BackgroundImage")));
            this.output7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output7.Location = new System.Drawing.Point(636, 453);
            this.output7.Name = "output7";
            this.output7.Size = new System.Drawing.Size(82, 74);
            this.output7.TabIndex = 44;
            this.output7.TabStop = false;
            // 
            // output6
            // 
            this.output6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output6.BackgroundImage")));
            this.output6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output6.Location = new System.Drawing.Point(548, 505);
            this.output6.Name = "output6";
            this.output6.Size = new System.Drawing.Size(82, 74);
            this.output6.TabIndex = 43;
            this.output6.TabStop = false;
            // 
            // output5
            // 
            this.output5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output5.BackgroundImage")));
            this.output5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output5.Location = new System.Drawing.Point(459, 453);
            this.output5.Name = "output5";
            this.output5.Size = new System.Drawing.Size(82, 74);
            this.output5.TabIndex = 42;
            this.output5.TabStop = false;
            // 
            // output4
            // 
            this.output4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output4.BackgroundImage")));
            this.output4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output4.Location = new System.Drawing.Point(371, 505);
            this.output4.Name = "output4";
            this.output4.Size = new System.Drawing.Size(82, 74);
            this.output4.TabIndex = 41;
            this.output4.TabStop = false;
            // 
            // output9
            // 
            this.output9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output9.BackgroundImage")));
            this.output9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output9.Location = new System.Drawing.Point(811, 453);
            this.output9.Name = "output9";
            this.output9.Size = new System.Drawing.Size(82, 74);
            this.output9.TabIndex = 46;
            this.output9.TabStop = false;
            // 
            // output8
            // 
            this.output8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output8.BackgroundImage")));
            this.output8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output8.Location = new System.Drawing.Point(723, 505);
            this.output8.Name = "output8";
            this.output8.Size = new System.Drawing.Size(82, 74);
            this.output8.TabIndex = 45;
            this.output8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(909, 644);
            this.Controls.Add(this.output9);
            this.Controls.Add(this.output8);
            this.Controls.Add(this.output7);
            this.Controls.Add(this.output6);
            this.Controls.Add(this.output5);
            this.Controls.Add(this.output4);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.output0);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveWeightsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label o1;
        private Label o2;
        private Label o3;
        private Label o4;
        private Label o5;
        private Label o6;
        private Label o7;
        private Label o8;
        private Label o9;
        private Label o0;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label epochCount;
        private GroupBox groupBox1;
        private PictureBox output3;
        private PictureBox output2;
        private PictureBox output1;
        private PictureBox output0;
        private PictureBox output7;
        private PictureBox output6;
        private PictureBox output5;
        private PictureBox output4;
        private PictureBox output9;
        private PictureBox output8;
        private Button button2;
        private ToolStripMenuItem loadWeightsToolStripMenuItem;
    }
}
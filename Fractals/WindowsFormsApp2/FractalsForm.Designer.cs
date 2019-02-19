namespace WindowsFormsApp2
{
    partial class Fractals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mandelbrot = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.ButtonSaveMF = new System.Windows.Forms.Button();
            this.ButtonGenerateMF = new System.Windows.Forms.Button();
            this.TextBoxMoveY_1 = new System.Windows.Forms.TextBox();
            this.TextBoxMoveX_1 = new System.Windows.Forms.TextBox();
            this.TextBoxIterations_1 = new System.Windows.Forms.TextBox();
            this.TextBoxZoom_1 = new System.Windows.Forms.TextBox();
            this.TextBoxHeight_1 = new System.Windows.Forms.TextBox();
            this.TextBoxWidth_1 = new System.Windows.Forms.TextBox();
            this.TextBoxB_1 = new System.Windows.Forms.TextBox();
            this.TextBoxG_1 = new System.Windows.Forms.TextBox();
            this.TextBoxR_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxMandelbrot = new System.Windows.Forms.PictureBox();
            this.Julia = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.TextBoxC_Im_2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBoxC_Re_2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TextBoxMoveY_2 = new System.Windows.Forms.TextBox();
            this.TextBoxMoveX_2 = new System.Windows.Forms.TextBox();
            this.TextBoxIterations_2 = new System.Windows.Forms.TextBox();
            this.TextBoxZoom_2 = new System.Windows.Forms.TextBox();
            this.TextBoxHeight_2 = new System.Windows.Forms.TextBox();
            this.TextBoxWidth_2 = new System.Windows.Forms.TextBox();
            this.TextBoxB_2 = new System.Windows.Forms.TextBox();
            this.TextBoxG_2 = new System.Windows.Forms.TextBox();
            this.TextBoxR_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PictureBoxJulia = new System.Windows.Forms.PictureBox();
            this.ButtonSaveJF = new System.Windows.Forms.Button();
            this.ButtonGenerateJF = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Mandelbrot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).BeginInit();
            this.Julia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJulia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mandelbrot);
            this.tabControl1.Controls.Add(this.Julia);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 588);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Mandelbrot
            // 
            this.Mandelbrot.Controls.Add(this.label22);
            this.Mandelbrot.Controls.Add(this.ButtonSaveMF);
            this.Mandelbrot.Controls.Add(this.ButtonGenerateMF);
            this.Mandelbrot.Controls.Add(this.TextBoxMoveY_1);
            this.Mandelbrot.Controls.Add(this.TextBoxMoveX_1);
            this.Mandelbrot.Controls.Add(this.TextBoxIterations_1);
            this.Mandelbrot.Controls.Add(this.TextBoxZoom_1);
            this.Mandelbrot.Controls.Add(this.TextBoxHeight_1);
            this.Mandelbrot.Controls.Add(this.TextBoxWidth_1);
            this.Mandelbrot.Controls.Add(this.TextBoxB_1);
            this.Mandelbrot.Controls.Add(this.TextBoxG_1);
            this.Mandelbrot.Controls.Add(this.TextBoxR_1);
            this.Mandelbrot.Controls.Add(this.label9);
            this.Mandelbrot.Controls.Add(this.label8);
            this.Mandelbrot.Controls.Add(this.label7);
            this.Mandelbrot.Controls.Add(this.label6);
            this.Mandelbrot.Controls.Add(this.label5);
            this.Mandelbrot.Controls.Add(this.label4);
            this.Mandelbrot.Controls.Add(this.label3);
            this.Mandelbrot.Controls.Add(this.label2);
            this.Mandelbrot.Controls.Add(this.label1);
            this.Mandelbrot.Controls.Add(this.PictureBoxMandelbrot);
            this.Mandelbrot.Location = new System.Drawing.Point(4, 22);
            this.Mandelbrot.Name = "Mandelbrot";
            this.Mandelbrot.Padding = new System.Windows.Forms.Padding(3);
            this.Mandelbrot.Size = new System.Drawing.Size(844, 562);
            this.Mandelbrot.TabIndex = 0;
            this.Mandelbrot.Text = "Mandelbrot";
            this.Mandelbrot.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(560, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(258, 31);
            this.label22.TabIndex = 21;
            this.label22.Text = "Mandelbrot Fractal";
            // 
            // ButtonSaveMF
            // 
            this.ButtonSaveMF.Location = new System.Drawing.Point(687, 355);
            this.ButtonSaveMF.Name = "ButtonSaveMF";
            this.ButtonSaveMF.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveMF.TabIndex = 20;
            this.ButtonSaveMF.Text = "Save";
            this.ButtonSaveMF.UseVisualStyleBackColor = true;
            this.ButtonSaveMF.Click += new System.EventHandler(this.ButtonSaveMF_Click);
            // 
            // ButtonGenerateMF
            // 
            this.ButtonGenerateMF.Location = new System.Drawing.Point(600, 355);
            this.ButtonGenerateMF.Name = "ButtonGenerateMF";
            this.ButtonGenerateMF.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateMF.TabIndex = 19;
            this.ButtonGenerateMF.Text = "Generate";
            this.ButtonGenerateMF.UseVisualStyleBackColor = true;
            this.ButtonGenerateMF.Click += new System.EventHandler(this.ButtonGenerateMF_Click);
            // 
            // TextBoxMoveY_1
            // 
            this.TextBoxMoveY_1.Location = new System.Drawing.Point(662, 288);
            this.TextBoxMoveY_1.Name = "TextBoxMoveY_1";
            this.TextBoxMoveY_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveY_1.TabIndex = 18;
            this.TextBoxMoveY_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveY_1_KeyPress);
            // 
            // TextBoxMoveX_1
            // 
            this.TextBoxMoveX_1.Location = new System.Drawing.Point(662, 262);
            this.TextBoxMoveX_1.Name = "TextBoxMoveX_1";
            this.TextBoxMoveX_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveX_1.TabIndex = 17;
            this.TextBoxMoveX_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveX_1_KeyPress);
            // 
            // TextBoxIterations_1
            // 
            this.TextBoxIterations_1.Location = new System.Drawing.Point(662, 234);
            this.TextBoxIterations_1.Name = "TextBoxIterations_1";
            this.TextBoxIterations_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIterations_1.TabIndex = 16;
            this.TextBoxIterations_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIterations_1_KeyPress);
            // 
            // TextBoxZoom_1
            // 
            this.TextBoxZoom_1.Location = new System.Drawing.Point(662, 206);
            this.TextBoxZoom_1.Name = "TextBoxZoom_1";
            this.TextBoxZoom_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZoom_1.TabIndex = 15;
            this.TextBoxZoom_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxZoom_1_KeyPress);
            // 
            // TextBoxHeight_1
            // 
            this.TextBoxHeight_1.Location = new System.Drawing.Point(662, 177);
            this.TextBoxHeight_1.Name = "TextBoxHeight_1";
            this.TextBoxHeight_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight_1.TabIndex = 14;
            this.TextBoxHeight_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHeight_1_KeyPress);
            // 
            // TextBoxWidth_1
            // 
            this.TextBoxWidth_1.Location = new System.Drawing.Point(662, 144);
            this.TextBoxWidth_1.Name = "TextBoxWidth_1";
            this.TextBoxWidth_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidth_1.TabIndex = 13;
            this.TextBoxWidth_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWidth_1_KeyPress);
            // 
            // TextBoxB_1
            // 
            this.TextBoxB_1.Location = new System.Drawing.Point(662, 115);
            this.TextBoxB_1.Name = "TextBoxB_1";
            this.TextBoxB_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxB_1.TabIndex = 12;
            this.TextBoxB_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxB_1_KeyPress);
            // 
            // TextBoxG_1
            // 
            this.TextBoxG_1.Location = new System.Drawing.Point(662, 87);
            this.TextBoxG_1.Name = "TextBoxG_1";
            this.TextBoxG_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxG_1.TabIndex = 11;
            this.TextBoxG_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxG_1_KeyPress);
            // 
            // TextBoxR_1
            // 
            this.TextBoxR_1.Location = new System.Drawing.Point(662, 60);
            this.TextBoxR_1.Name = "TextBoxR_1";
            this.TextBoxR_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxR_1.TabIndex = 10;
            this.TextBoxR_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxR_1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "MoveY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MoveX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Iterations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zoom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // PictureBoxMandelbrot
            // 
            this.PictureBoxMandelbrot.Location = new System.Drawing.Point(6, 6);
            this.PictureBoxMandelbrot.Name = "PictureBoxMandelbrot";
            this.PictureBoxMandelbrot.Size = new System.Drawing.Size(548, 500);
            this.PictureBoxMandelbrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMandelbrot.TabIndex = 0;
            this.PictureBoxMandelbrot.TabStop = false;
            // 
            // Julia
            // 
            this.Julia.Controls.Add(this.label23);
            this.Julia.Controls.Add(this.TextBoxC_Im_2);
            this.Julia.Controls.Add(this.label21);
            this.Julia.Controls.Add(this.TextBoxC_Re_2);
            this.Julia.Controls.Add(this.label20);
            this.Julia.Controls.Add(this.label19);
            this.Julia.Controls.Add(this.TextBoxMoveY_2);
            this.Julia.Controls.Add(this.TextBoxMoveX_2);
            this.Julia.Controls.Add(this.TextBoxIterations_2);
            this.Julia.Controls.Add(this.TextBoxZoom_2);
            this.Julia.Controls.Add(this.TextBoxHeight_2);
            this.Julia.Controls.Add(this.TextBoxWidth_2);
            this.Julia.Controls.Add(this.TextBoxB_2);
            this.Julia.Controls.Add(this.TextBoxG_2);
            this.Julia.Controls.Add(this.TextBoxR_2);
            this.Julia.Controls.Add(this.label10);
            this.Julia.Controls.Add(this.label11);
            this.Julia.Controls.Add(this.label12);
            this.Julia.Controls.Add(this.label13);
            this.Julia.Controls.Add(this.label14);
            this.Julia.Controls.Add(this.label15);
            this.Julia.Controls.Add(this.label16);
            this.Julia.Controls.Add(this.label17);
            this.Julia.Controls.Add(this.label18);
            this.Julia.Controls.Add(this.PictureBoxJulia);
            this.Julia.Controls.Add(this.ButtonSaveJF);
            this.Julia.Controls.Add(this.ButtonGenerateJF);
            this.Julia.Location = new System.Drawing.Point(4, 22);
            this.Julia.Name = "Julia";
            this.Julia.Padding = new System.Windows.Forms.Padding(3);
            this.Julia.Size = new System.Drawing.Size(844, 562);
            this.Julia.TabIndex = 1;
            this.Julia.Text = "Julia";
            this.Julia.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(616, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 31);
            this.label23.TabIndex = 42;
            this.label23.Text = "Julia Fractal";
            // 
            // TextBoxC_Im_2
            // 
            this.TextBoxC_Im_2.Location = new System.Drawing.Point(734, 329);
            this.TextBoxC_Im_2.Name = "TextBoxC_Im_2";
            this.TextBoxC_Im_2.Size = new System.Drawing.Size(58, 20);
            this.TextBoxC_Im_2.TabIndex = 41;
            this.TextBoxC_Im_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxC_Im_2_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(710, 332);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Im";
            // 
            // TextBoxC_Re_2
            // 
            this.TextBoxC_Re_2.Location = new System.Drawing.Point(646, 329);
            this.TextBoxC_Re_2.Name = "TextBoxC_Re_2";
            this.TextBoxC_Re_2.Size = new System.Drawing.Size(58, 20);
            this.TextBoxC_Re_2.TabIndex = 39;
            this.TextBoxC_Re_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxC_Re_2_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(619, 332);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Re";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(599, 332);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "C";
            // 
            // TextBoxMoveY_2
            // 
            this.TextBoxMoveY_2.Location = new System.Drawing.Point(678, 286);
            this.TextBoxMoveY_2.Name = "TextBoxMoveY_2";
            this.TextBoxMoveY_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveY_2.TabIndex = 36;
            this.TextBoxMoveY_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveY_1_KeyPress);
            // 
            // TextBoxMoveX_2
            // 
            this.TextBoxMoveX_2.Location = new System.Drawing.Point(678, 260);
            this.TextBoxMoveX_2.Name = "TextBoxMoveX_2";
            this.TextBoxMoveX_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveX_2.TabIndex = 35;
            this.TextBoxMoveX_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveX_1_KeyPress);
            // 
            // TextBoxIterations_2
            // 
            this.TextBoxIterations_2.Location = new System.Drawing.Point(678, 232);
            this.TextBoxIterations_2.Name = "TextBoxIterations_2";
            this.TextBoxIterations_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIterations_2.TabIndex = 34;
            this.TextBoxIterations_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIterations_1_KeyPress);
            // 
            // TextBoxZoom_2
            // 
            this.TextBoxZoom_2.Location = new System.Drawing.Point(678, 204);
            this.TextBoxZoom_2.Name = "TextBoxZoom_2";
            this.TextBoxZoom_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZoom_2.TabIndex = 33;
            this.TextBoxZoom_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxZoom_1_KeyPress);
            // 
            // TextBoxHeight_2
            // 
            this.TextBoxHeight_2.Location = new System.Drawing.Point(678, 175);
            this.TextBoxHeight_2.Name = "TextBoxHeight_2";
            this.TextBoxHeight_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight_2.TabIndex = 32;
            this.TextBoxHeight_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHeight_1_KeyPress);
            // 
            // TextBoxWidth_2
            // 
            this.TextBoxWidth_2.Location = new System.Drawing.Point(678, 142);
            this.TextBoxWidth_2.Name = "TextBoxWidth_2";
            this.TextBoxWidth_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidth_2.TabIndex = 31;
            this.TextBoxWidth_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWidth_1_KeyPress);
            // 
            // TextBoxB_2
            // 
            this.TextBoxB_2.Location = new System.Drawing.Point(678, 113);
            this.TextBoxB_2.Name = "TextBoxB_2";
            this.TextBoxB_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxB_2.TabIndex = 30;
            this.TextBoxB_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxB_1_KeyPress);
            // 
            // TextBoxG_2
            // 
            this.TextBoxG_2.Location = new System.Drawing.Point(678, 85);
            this.TextBoxG_2.Name = "TextBoxG_2";
            this.TextBoxG_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxG_2.TabIndex = 29;
            this.TextBoxG_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxG_1_KeyPress);
            // 
            // TextBoxR_2
            // 
            this.TextBoxR_2.Location = new System.Drawing.Point(678, 58);
            this.TextBoxR_2.Name = "TextBoxR_2";
            this.TextBoxR_2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxR_2.TabIndex = 28;
            this.TextBoxR_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxR_1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "MoveY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(624, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "MoveX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Iterations";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(625, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Zoom";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(624, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Height";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(624, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Width";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(633, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "B";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(633, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "G";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(633, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "R";
            // 
            // PictureBoxJulia
            // 
            this.PictureBoxJulia.Location = new System.Drawing.Point(8, 6);
            this.PictureBoxJulia.Name = "PictureBoxJulia";
            this.PictureBoxJulia.Size = new System.Drawing.Size(555, 495);
            this.PictureBoxJulia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxJulia.TabIndex = 2;
            this.PictureBoxJulia.TabStop = false;
            // 
            // ButtonSaveJF
            // 
            this.ButtonSaveJF.Location = new System.Drawing.Point(734, 382);
            this.ButtonSaveJF.Name = "ButtonSaveJF";
            this.ButtonSaveJF.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveJF.TabIndex = 1;
            this.ButtonSaveJF.Text = "Save";
            this.ButtonSaveJF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSaveJF.UseVisualStyleBackColor = true;
            this.ButtonSaveJF.Click += new System.EventHandler(this.ButtonSaveJF_Click);
            // 
            // ButtonGenerateJF
            // 
            this.ButtonGenerateJF.Location = new System.Drawing.Point(636, 382);
            this.ButtonGenerateJF.Name = "ButtonGenerateJF";
            this.ButtonGenerateJF.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateJF.TabIndex = 0;
            this.ButtonGenerateJF.Text = "Generate";
            this.ButtonGenerateJF.UseVisualStyleBackColor = true;
            this.ButtonGenerateJF.Click += new System.EventHandler(this.ButtonGenerateJF_Click);
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(860, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "Fractals";
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Mandelbrot.ResumeLayout(false);
            this.Mandelbrot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).EndInit();
            this.Julia.ResumeLayout(false);
            this.Julia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJulia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mandelbrot;
        private System.Windows.Forms.TabPage Julia;
        private System.Windows.Forms.PictureBox PictureBoxMandelbrot;
        private System.Windows.Forms.Button ButtonSaveMF;
        private System.Windows.Forms.Button ButtonGenerateMF;
        private System.Windows.Forms.TextBox TextBoxMoveY_1;
        private System.Windows.Forms.TextBox TextBoxMoveX_1;
        private System.Windows.Forms.TextBox TextBoxIterations_1;
        private System.Windows.Forms.TextBox TextBoxZoom_1;
        private System.Windows.Forms.TextBox TextBoxHeight_1;
        private System.Windows.Forms.TextBox TextBoxWidth_1;
        private System.Windows.Forms.TextBox TextBoxB_1;
        private System.Windows.Forms.TextBox TextBoxG_1;
        private System.Windows.Forms.TextBox TextBoxR_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMoveY_2;
        private System.Windows.Forms.TextBox TextBoxMoveX_2;
        private System.Windows.Forms.TextBox TextBoxIterations_2;
        private System.Windows.Forms.TextBox TextBoxZoom_2;
        private System.Windows.Forms.TextBox TextBoxHeight_2;
        private System.Windows.Forms.TextBox TextBoxWidth_2;
        private System.Windows.Forms.TextBox TextBoxB_2;
        private System.Windows.Forms.TextBox TextBoxG_2;
        private System.Windows.Forms.TextBox TextBoxR_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox PictureBoxJulia;
        private System.Windows.Forms.Button ButtonSaveJF;
        private System.Windows.Forms.Button ButtonGenerateJF;
        private System.Windows.Forms.TextBox TextBoxC_Im_2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TextBoxC_Re_2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}


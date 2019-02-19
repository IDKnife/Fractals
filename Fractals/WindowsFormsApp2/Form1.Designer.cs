namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonGenerate_2 = new System.Windows.Forms.Button();
            this.ButtonSave_2 = new System.Windows.Forms.Button();
            this.PictureBoxJulia = new System.Windows.Forms.PictureBox();
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
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TextBoxC_Re_2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBoxC_Im_2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJulia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 552);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonSave);
            this.tabPage1.Controls.Add(this.ButtonGenerate);
            this.tabPage1.Controls.Add(this.TextBoxMoveY_1);
            this.tabPage1.Controls.Add(this.TextBoxMoveX_1);
            this.tabPage1.Controls.Add(this.TextBoxIterations_1);
            this.tabPage1.Controls.Add(this.TextBoxZoom_1);
            this.tabPage1.Controls.Add(this.TextBoxHeight_1);
            this.tabPage1.Controls.Add(this.TextBoxWidth_1);
            this.tabPage1.Controls.Add(this.TextBoxB_1);
            this.tabPage1.Controls.Add(this.TextBoxG_1);
            this.tabPage1.Controls.Add(this.TextBoxR_1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PictureBoxMandelbrot);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(676, 353);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 20;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(589, 353);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 19;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // TextBoxMoveY_1
            // 
            this.TextBoxMoveY_1.Location = new System.Drawing.Point(651, 286);
            this.TextBoxMoveY_1.Name = "TextBoxMoveY_1";
            this.TextBoxMoveY_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveY_1.TabIndex = 18;
            this.TextBoxMoveY_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveY_1_KeyPress);
            // 
            // TextBoxMoveX_1
            // 
            this.TextBoxMoveX_1.Location = new System.Drawing.Point(651, 260);
            this.TextBoxMoveX_1.Name = "TextBoxMoveX_1";
            this.TextBoxMoveX_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveX_1.TabIndex = 17;
            this.TextBoxMoveX_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoveX_1_KeyPress);
            // 
            // TextBoxIterations_1
            // 
            this.TextBoxIterations_1.Location = new System.Drawing.Point(651, 232);
            this.TextBoxIterations_1.Name = "TextBoxIterations_1";
            this.TextBoxIterations_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIterations_1.TabIndex = 16;
            this.TextBoxIterations_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIterations_1_KeyPress);
            // 
            // TextBoxZoom_1
            // 
            this.TextBoxZoom_1.Location = new System.Drawing.Point(651, 204);
            this.TextBoxZoom_1.Name = "TextBoxZoom_1";
            this.TextBoxZoom_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZoom_1.TabIndex = 15;
            this.TextBoxZoom_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxZoom_1_KeyPress);
            // 
            // TextBoxHeight_1
            // 
            this.TextBoxHeight_1.Location = new System.Drawing.Point(651, 175);
            this.TextBoxHeight_1.Name = "TextBoxHeight_1";
            this.TextBoxHeight_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight_1.TabIndex = 14;
            this.TextBoxHeight_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHeight_1_KeyPress);
            // 
            // TextBoxWidth_1
            // 
            this.TextBoxWidth_1.Location = new System.Drawing.Point(651, 142);
            this.TextBoxWidth_1.Name = "TextBoxWidth_1";
            this.TextBoxWidth_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidth_1.TabIndex = 13;
            this.TextBoxWidth_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWidth_1_KeyPress);
            // 
            // TextBoxB_1
            // 
            this.TextBoxB_1.Location = new System.Drawing.Point(651, 113);
            this.TextBoxB_1.Name = "TextBoxB_1";
            this.TextBoxB_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxB_1.TabIndex = 12;
            this.TextBoxB_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxB_1_KeyPress);
            // 
            // TextBoxG_1
            // 
            this.TextBoxG_1.Location = new System.Drawing.Point(651, 85);
            this.TextBoxG_1.Name = "TextBoxG_1";
            this.TextBoxG_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxG_1.TabIndex = 11;
            this.TextBoxG_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxG_1_KeyPress);
            // 
            // TextBoxR_1
            // 
            this.TextBoxR_1.Location = new System.Drawing.Point(651, 58);
            this.TextBoxR_1.Name = "TextBoxR_1";
            this.TextBoxR_1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxR_1.TabIndex = 10;
            this.TextBoxR_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxR_1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "MoveY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MoveX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Iterations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zoom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // PictureBoxMandelbrot
            // 
            this.PictureBoxMandelbrot.Location = new System.Drawing.Point(8, 6);
            this.PictureBoxMandelbrot.Name = "PictureBoxMandelbrot";
            this.PictureBoxMandelbrot.Size = new System.Drawing.Size(548, 500);
            this.PictureBoxMandelbrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMandelbrot.TabIndex = 0;
            this.PictureBoxMandelbrot.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBoxC_Im_2);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.TextBoxC_Re_2);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.TextBoxMoveY_2);
            this.tabPage2.Controls.Add(this.TextBoxMoveX_2);
            this.tabPage2.Controls.Add(this.TextBoxIterations_2);
            this.tabPage2.Controls.Add(this.TextBoxZoom_2);
            this.tabPage2.Controls.Add(this.TextBoxHeight_2);
            this.tabPage2.Controls.Add(this.TextBoxWidth_2);
            this.tabPage2.Controls.Add(this.TextBoxB_2);
            this.tabPage2.Controls.Add(this.TextBoxG_2);
            this.tabPage2.Controls.Add(this.TextBoxR_2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.PictureBoxJulia);
            this.tabPage2.Controls.Add(this.ButtonSave_2);
            this.tabPage2.Controls.Add(this.ButtonGenerate_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate_2
            // 
            this.ButtonGenerate_2.Location = new System.Drawing.Point(636, 382);
            this.ButtonGenerate_2.Name = "ButtonGenerate_2";
            this.ButtonGenerate_2.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate_2.TabIndex = 0;
            this.ButtonGenerate_2.Text = "Generate";
            this.ButtonGenerate_2.UseVisualStyleBackColor = true;
            this.ButtonGenerate_2.Click += new System.EventHandler(this.ButtonGenerate_2_Click);
            // 
            // ButtonSave_2
            // 
            this.ButtonSave_2.Location = new System.Drawing.Point(734, 382);
            this.ButtonSave_2.Name = "ButtonSave_2";
            this.ButtonSave_2.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave_2.TabIndex = 1;
            this.ButtonSave_2.Text = "Save";
            this.ButtonSave_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave_2.UseVisualStyleBackColor = true;
            this.ButtonSave_2.Click += new System.EventHandler(this.ButtonSave_2_Click);
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(599, 332);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "C";
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
            // TextBoxC_Re_2
            // 
            this.TextBoxC_Re_2.Location = new System.Drawing.Point(646, 329);
            this.TextBoxC_Re_2.Name = "TextBoxC_Re_2";
            this.TextBoxC_Re_2.Size = new System.Drawing.Size(58, 20);
            this.TextBoxC_Re_2.TabIndex = 39;
            this.TextBoxC_Re_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxC_Re_2_KeyPress);
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
            // TextBoxC_Im_2
            // 
            this.TextBoxC_Im_2.Location = new System.Drawing.Point(734, 329);
            this.TextBoxC_Im_2.Name = "TextBoxC_Im_2";
            this.TextBoxC_Im_2.Size = new System.Drawing.Size(58, 20);
            this.TextBoxC_Im_2.TabIndex = 41;
            this.TextBoxC_Im_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxC_Im_2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(860, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJulia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PictureBoxMandelbrot;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonGenerate;
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
        private System.Windows.Forms.Button ButtonSave_2;
        private System.Windows.Forms.Button ButtonGenerate_2;
        private System.Windows.Forms.TextBox TextBoxC_Im_2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TextBoxC_Re_2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}


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
            this.TextBoxMoveY = new System.Windows.Forms.TextBox();
            this.TextBoxMoveX = new System.Windows.Forms.TextBox();
            this.TextBoxIterations = new System.Windows.Forms.TextBox();
            this.TextBoxZoom = new System.Windows.Forms.TextBox();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxG = new System.Windows.Forms.TextBox();
            this.TextBoxR = new System.Windows.Forms.TextBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).BeginInit();
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
            this.tabPage1.Controls.Add(this.TextBoxMoveY);
            this.tabPage1.Controls.Add(this.TextBoxMoveX);
            this.tabPage1.Controls.Add(this.TextBoxIterations);
            this.tabPage1.Controls.Add(this.TextBoxZoom);
            this.tabPage1.Controls.Add(this.TextBoxHeight);
            this.tabPage1.Controls.Add(this.TextBoxWidth);
            this.tabPage1.Controls.Add(this.TextBoxB);
            this.tabPage1.Controls.Add(this.TextBoxG);
            this.tabPage1.Controls.Add(this.TextBoxR);
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
            // TextBoxMoveY
            // 
            this.TextBoxMoveY.Location = new System.Drawing.Point(651, 286);
            this.TextBoxMoveY.Name = "TextBoxMoveY";
            this.TextBoxMoveY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveY.TabIndex = 18;
            // 
            // TextBoxMoveX
            // 
            this.TextBoxMoveX.Location = new System.Drawing.Point(651, 260);
            this.TextBoxMoveX.Name = "TextBoxMoveX";
            this.TextBoxMoveX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMoveX.TabIndex = 17;
            // 
            // TextBoxIterations
            // 
            this.TextBoxIterations.Location = new System.Drawing.Point(651, 232);
            this.TextBoxIterations.Name = "TextBoxIterations";
            this.TextBoxIterations.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIterations.TabIndex = 16;
            // 
            // TextBoxZoom
            // 
            this.TextBoxZoom.Location = new System.Drawing.Point(651, 204);
            this.TextBoxZoom.Name = "TextBoxZoom";
            this.TextBoxZoom.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZoom.TabIndex = 15;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(651, 175);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight.TabIndex = 14;
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Location = new System.Drawing.Point(651, 142);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidth.TabIndex = 13;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(651, 113);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(100, 20);
            this.TextBoxB.TabIndex = 12;
            // 
            // TextBoxG
            // 
            this.TextBoxG.Location = new System.Drawing.Point(651, 85);
            this.TextBoxG.Name = "TextBoxG";
            this.TextBoxG.Size = new System.Drawing.Size(100, 20);
            this.TextBoxG.TabIndex = 11;
            // 
            // TextBoxR
            // 
            this.TextBoxR.Location = new System.Drawing.Point(651, 58);
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.Size = new System.Drawing.Size(100, 20);
            this.TextBoxR.TabIndex = 10;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PictureBoxMandelbrot;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.TextBox TextBoxMoveY;
        private System.Windows.Forms.TextBox TextBoxMoveX;
        private System.Windows.Forms.TextBox TextBoxIterations;
        private System.Windows.Forms.TextBox TextBoxZoom;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxG;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


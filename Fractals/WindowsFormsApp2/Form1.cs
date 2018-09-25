using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fractals;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        IFractalBase fb;

        public Form1()
        {
            // ToDo: Знаечния по умолчанию при открытии формы (FormLoad)
            InitializeComponent();
            //tabControl1.SelectedIndex = 0;
            fb = new MandelbrotFractal();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var mf = fb as MandelbrotFractal;
            if (mf == null)
            { }
            // ToDo: Проверки на входные данные
            mf.R = Convert.ToInt32(TextBoxR.Text);
            mf.B = Convert.ToInt32(TextBoxB.Text);
            mf.G = Convert.ToInt32(TextBoxG.Text);
            mf.Width = Convert.ToInt32(TextBoxWidth.Text);
            mf.Height = Convert.ToInt32(TextBoxHeight.Text);
            mf.Zoom = Convert.ToDouble(TextBoxZoom.Text);
            mf.Iterations = Convert.ToInt32(TextBoxIterations.Text);
            mf.MoveX = Convert.ToDouble(TextBoxMoveX.Text);
            mf.MoveY = Convert.ToDouble(TextBoxMoveY.Text);
            PictureBoxMandelbrot.Image = mf.Draw();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            PictureBoxMandelbrot.Image.Save("MF.jpg");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ToDo: Кэшировать фракталы
            if (tabControl1.SelectedIndex == 0)
            {
                fb = new MandelbrotFractal();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                fb = new JuliaFractal();
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Fractals;

namespace WindowsFormsApp2
{
    public partial class Fractals : Form
    {
        private Dictionary<int, FractalViewModel> _fractalviewmodels = new Dictionary<int, FractalViewModel>();
        private IFractalBase _selectedFractal;

        public Fractals()
        {
            // ToDo: Значения по умолчанию при открытии формы (FormLoad)
            InitializeComponent();

            // ToDo: загружать словарь фракталов извне
            _fractalviewmodels.Add(0, new FractalViewModel { Fractal = new MandelbrotFractal() });
            _fractalviewmodels.Add(1, new FractalViewModel { Fractal = new JuliaFractal() });
            _fractalviewmodels.Add(2, new FractalViewModel { Fractal = new MandelbrotFractalModernized() });
            _fractalviewmodels.Add(3, new FractalViewModel { Fractal = new Tricorn() });
            _selectedFractal = _fractalviewmodels[0].Fractal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            TextBoxRMF.Text = _fractalviewmodels[0].Fractal.R.ToString();
            TextBoxRJF.Text = _fractalviewmodels[1].Fractal.R.ToString();
            TextBoxRMMF.Text = _fractalviewmodels[2].Fractal.R.ToString();
            TextBoxRTF.Text = _fractalviewmodels[3].Fractal.R.ToString();

            TextBoxBMF.Text = _fractalviewmodels[0].Fractal.B.ToString();
            TextBoxBJF.Text = _fractalviewmodels[1].Fractal.B.ToString();
            TextBoxBMMF.Text = _fractalviewmodels[2].Fractal.B.ToString();
            TextBoxBTF.Text = _fractalviewmodels[3].Fractal.B.ToString();


            TextBoxGMF.Text = _fractalviewmodels[0].Fractal.G.ToString();
            TextBoxGJF.Text = _fractalviewmodels[1].Fractal.G.ToString();
            TextBoxGMMF.Text = _fractalviewmodels[2].Fractal.G.ToString();
            TextBoxGTF.Text = _fractalviewmodels[3].Fractal.G.ToString();

            TextBoxWidthMF.Text = _fractalviewmodels[0].Fractal.Width.ToString();
            TextBoxWidthJF.Text = _fractalviewmodels[1].Fractal.Width.ToString();
            TextBoxWidthMMF.Text = _fractalviewmodels[2].Fractal.Width.ToString();
            TextBoxWidthTF.Text = _fractalviewmodels[3].Fractal.Width.ToString();

            TextBoxHeightMF.Text = _fractalviewmodels[0].Fractal.Height.ToString();
            TextBoxHeightJF.Text = _fractalviewmodels[1].Fractal.Height.ToString();
            TextBoxHeightMMF.Text = _fractalviewmodels[2].Fractal.Height.ToString();
            TextBoxHeightTF.Text = _fractalviewmodels[3].Fractal.Height.ToString();

            TextBoxZoomMF.Text = _fractalviewmodels[0].Fractal.Zoom.ToString();
            TextBoxZoomJF.Text = _fractalviewmodels[1].Fractal.Zoom.ToString();
            TextBoxZoomMMF.Text = _fractalviewmodels[2].Fractal.Zoom.ToString();
            TextBoxZoomTF.Text = _fractalviewmodels[3].Fractal.Zoom.ToString();

            TextBoxIterationsMF.Text = _fractalviewmodels[0].Fractal.Iterations.ToString();
            TextBoxIterationsJF.Text = _fractalviewmodels[1].Fractal.Iterations.ToString();
            TextBoxIterationsMMF.Text = _fractalviewmodels[2].Fractal.Iterations.ToString();
            TextBoxIterationsTF.Text = _fractalviewmodels[3].Fractal.Iterations.ToString();

            TextBoxMoveXMF.Text = _fractalviewmodels[0].Fractal.MoveX.ToString();
            TextBoxMoveXJF.Text = _fractalviewmodels[1].Fractal.MoveX.ToString();
            TextBoxMoveXMMF.Text = _fractalviewmodels[2].Fractal.MoveX.ToString();
            TextBoxMoveXTF.Text = _fractalviewmodels[3].Fractal.MoveX.ToString();

            TextBoxMoveYMF.Text = _fractalviewmodels[0].Fractal.MoveY.ToString();
            TextBoxMoveYJF.Text = _fractalviewmodels[1].Fractal.MoveY.ToString();
            TextBoxMoveYMMF.Text = _fractalviewmodels[2].Fractal.MoveY.ToString();
            TextBoxMoveYTF.Text = _fractalviewmodels[3].Fractal.MoveY.ToString();

            var temp = _fractalviewmodels[1].Fractal as JuliaFractal;
            TextBoxC_ReJF.Text = temp.C.Real.ToString();
            TextBoxC_ImJF.Text = temp.C.Imaginary.ToString();
        }

        private void ButtonGenerateMF_Click(object sender, EventArgs e)
        {
            var mf = _selectedFractal as MandelbrotFractal;
            if (mf == null)
                return;
            int temp1;
            double temp2;
            mf.R = int.TryParse(TextBoxRMF.Text, out temp1) ? temp1 % 256 : mf.R;
            mf.B = int.TryParse(TextBoxBMF.Text, out temp1) ? temp1 % 256 : mf.B;
            mf.G = int.TryParse(TextBoxGMF.Text, out temp1) ? temp1 % 256 : mf.G;
            mf.Width = int.TryParse(TextBoxWidthMF.Text, out temp1) ? temp1 : mf.Width;
            mf.Height = int.TryParse(TextBoxHeightMF.Text, out temp1) ? temp1 : mf.Height;
            mf.Zoom = double.TryParse(TextBoxZoomMF.Text, out temp2) ? temp2 : mf.Zoom;
            mf.Iterations = int.TryParse(TextBoxIterationsMF.Text, out temp1) ? temp1 : mf.Iterations;
            mf.MoveX = double.TryParse(TextBoxMoveXMF.Text, out temp2) ? temp2 : mf.MoveX;
            mf.MoveY = double.TryParse(TextBoxMoveYMF.Text, out temp2) ? temp2 : mf.MoveY;
            _fractalviewmodels[0].Image = mf.Draw();
            PictureBoxMandelbrot.Image = _fractalviewmodels[0].Image;
        }

        private void ButtonSaveMF_Click(object sender, EventArgs e)
        {
            _fractalviewmodels[0].Image.Save("MF.jpg");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_fractalviewmodels.ContainsKey(tabControl1.SelectedIndex))
                _selectedFractal = _fractalviewmodels[tabControl1.SelectedIndex].Fractal;
        }

        #region KeyPress
        private void TextBoxG_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }


        private void TextBoxR_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxB_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxWidth_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxHeight_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxIterations_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxZoom_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMoveX_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-') || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMoveY_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-') || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxC_Re_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-') || (key == 8)))
            {
                e.Handled = true;
            }
        }

        private void TextBoxC_Im_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-') || (key == 8)))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void ButtonSaveJF_Click(object sender, EventArgs e)
        {
            _fractalviewmodels[1].Image.Save("JF.jpg");
        }

        private void ButtonGenerateJF_Click(object sender, EventArgs e)
        {
            var jf = _selectedFractal as JuliaFractal;
            if (jf == null)
                return;
            int temp1;
            double temp2, tempR, tempI;
            jf.R = int.TryParse(TextBoxRJF.Text, out temp1) ? temp1 % 256 : jf.R;
            jf.B = int.TryParse(TextBoxBJF.Text, out temp1) ? temp1 % 256 : jf.B;
            jf.G = int.TryParse(TextBoxGJF.Text, out temp1) ? temp1 % 256 : jf.G;
            jf.Width = int.TryParse(TextBoxWidthJF.Text, out temp1) ? temp1 : jf.Width;
            jf.Height = int.TryParse(TextBoxHeightJF.Text, out temp1) ? temp1 : jf.Height;
            jf.Zoom = double.TryParse(TextBoxZoomJF.Text, out temp2) ? temp2 : jf.Zoom;
            jf.Iterations = int.TryParse(TextBoxIterationsJF.Text, out temp1) ? temp1 : jf.Iterations;
            jf.MoveX = double.TryParse(TextBoxMoveXJF.Text, out temp2) ? temp2 : jf.MoveX;
            jf.MoveY = double.TryParse(TextBoxMoveYJF.Text, out temp2) ? temp2 : jf.MoveY;
            tempR = double.TryParse(TextBoxC_ReJF.Text, out temp2) ? temp2 : jf.C.Real;
            tempI = double.TryParse(TextBoxC_ImJF.Text, out temp2) ? temp2 : jf.C.Imaginary;
            jf.C = new System.Numerics.Complex(tempR, tempI);
            _fractalviewmodels[1].Image = jf.Draw();
            PictureBoxJulia.Image = _fractalviewmodels[1].Image;
        }

        private void ButtonGenerateMMF_Click(object sender, EventArgs e)
        {
            var mmf = _selectedFractal as MandelbrotFractalModernized;
            if (mmf == null)
                return;
            int temp1;
            double temp2;
            mmf.R = int.TryParse(TextBoxRMMF.Text, out temp1) ? temp1 % 256 : mmf.R;
            mmf.B = int.TryParse(TextBoxBMMF.Text, out temp1) ? temp1 % 256 : mmf.B;
            mmf.G = int.TryParse(TextBoxGMMF.Text, out temp1) ? temp1 % 256 : mmf.G;
            mmf.Width = int.TryParse(TextBoxWidthMMF.Text, out temp1) ? temp1 : mmf.Width;
            mmf.Height = int.TryParse(TextBoxHeightMMF.Text, out temp1) ? temp1 : mmf.Height;
            mmf.Zoom = double.TryParse(TextBoxZoomMMF.Text, out temp2) ? temp2 : mmf.Zoom;
            mmf.Iterations = int.TryParse(TextBoxIterationsMMF.Text, out temp1) ? temp1 : mmf.Iterations;
            mmf.MoveX = double.TryParse(TextBoxMoveXMMF.Text, out temp2) ? temp2 : mmf.MoveX;
            mmf.MoveY = double.TryParse(TextBoxMoveYMMF.Text, out temp2) ? temp2 : mmf.MoveY;
            _fractalviewmodels[2].Image = mmf.Draw();
            PictureBoxMandelbrotModernized.Image = _fractalviewmodels[2].Image;
        }

        private void ButtonSaveMMF_Click(object sender, EventArgs e)
        {
            _fractalviewmodels[2].Image.Save("MMF.jpg");
        }

        private void ButtonGenerateTF_Click(object sender, EventArgs e)
        {
            var tf = _selectedFractal as Tricorn;
            if (tf == null)
                return;
            int temp1;
            double temp2;
            tf.R = int.TryParse(TextBoxRTF.Text, out temp1) ? temp1 % 256 : tf.R;
            tf.B = int.TryParse(TextBoxBTF.Text, out temp1) ? temp1 % 256 : tf.B;
            tf.G = int.TryParse(TextBoxGTF.Text, out temp1) ? temp1 % 256 : tf.G;
            tf.Width = int.TryParse(TextBoxWidthTF.Text, out temp1) ? temp1 : tf.Width;
            tf.Height = int.TryParse(TextBoxHeightTF.Text, out temp1) ? temp1 : tf.Height;
            tf.Zoom = double.TryParse(TextBoxZoomTF.Text, out temp2) ? temp2 : tf.Zoom;
            tf.Iterations = int.TryParse(TextBoxIterationsTF.Text, out temp1) ? temp1 : tf.Iterations;
            tf.MoveX = double.TryParse(TextBoxMoveXTF.Text, out temp2) ? temp2 : tf.MoveX;
            tf.MoveY = double.TryParse(TextBoxMoveYTF.Text, out temp2) ? temp2 : tf.MoveY;
            _fractalviewmodels[3].Image = tf.Draw();
            PictureBoxTricorn.Image = _fractalviewmodels[3].Image;
        }

        private void ButtonSaveTF_Click(object sender, EventArgs e)
        {
            _fractalviewmodels[3].Image.Save("TF.jpg");
        }
    }
}


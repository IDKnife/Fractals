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
        private Dictionary<int, IFractalBase> _fractals = new Dictionary<int, IFractalBase>();
        private IFractalBase _selectedFractal;
        private Bitmap _image;

        public Form1()
        {
            // ToDo: Значения по умолчанию при открытии формы (FormLoad)
            InitializeComponent();

            // ToDo: загружать словарь фракталов извне
            _fractals.Add(0, new MandelbrotFractal());
            _fractals.Add(1, new JuliaFractal());
            _selectedFractal = _fractals[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            TextBoxR_1.Text = _fractals[0].R.ToString();
            TextBoxR_2.Text = _fractals[1].R.ToString();
            TextBoxB_1.Text = _fractals[0].B.ToString();
            TextBoxB_2.Text = _fractals[1].B.ToString();
            TextBoxG_1.Text = _fractals[0].G.ToString();
            TextBoxG_2.Text = _fractals[1].G.ToString();
            TextBoxWidth_1.Text = _fractals[0].Width.ToString();
            TextBoxWidth_2.Text = _fractals[1].Width.ToString();
            TextBoxHeight_1.Text = _fractals[0].Height.ToString();
            TextBoxHeight_2.Text = _fractals[1].Height.ToString();
            TextBoxZoom_1.Text = _fractals[0].Zoom.ToString();
            TextBoxZoom_2.Text = _fractals[1].Zoom.ToString();
            TextBoxIterations_1.Text = _fractals[0].Iterations.ToString();
            TextBoxIterations_2.Text = _fractals[1].Iterations.ToString();
            TextBoxMoveX_1.Text = _fractals[0].MoveX.ToString();
            TextBoxMoveX_2.Text = _fractals[1].MoveX.ToString();
            TextBoxMoveY_1.Text = _fractals[0].MoveY.ToString();
            TextBoxMoveY_2.Text = _fractals[1].MoveY.ToString();
            var temp = _fractals[1] as JuliaFractal;
            TextBoxC_Re_2.Text = temp.C.Real.ToString();
            TextBoxC_Im_2.Text = temp.C.Imaginary.ToString();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var mf = _selectedFractal as MandelbrotFractal;
            if (mf == null)
                return;
            // ToDo: Проверки на входные данные
            int temp1;
            double temp2;
            mf.R = int.TryParse(TextBoxR_1.Text, out temp1) ? temp1 % 256 : mf.R;
            mf.B = int.TryParse(TextBoxB_1.Text, out temp1) ? temp1 % 256 : mf.B;
            mf.G = int.TryParse(TextBoxG_1.Text, out temp1) ? temp1 % 256 : mf.G;
            mf.Width = int.TryParse(TextBoxWidth_1.Text, out temp1) ? temp1 : mf.Width;
            mf.Height = int.TryParse(TextBoxHeight_1.Text, out temp1) ? temp1 : mf.Height;
            mf.Zoom = double.TryParse(TextBoxZoom_1.Text, out temp2) ? temp2 : mf.Zoom;
            mf.Iterations = int.TryParse(TextBoxIterations_1.Text, out temp1) ? temp1 : mf.Iterations;
            mf.MoveX = double.TryParse(TextBoxMoveX_1.Text, out temp2) ? temp2 : mf.MoveX;
            mf.MoveY = double.TryParse(TextBoxMoveY_1.Text, out temp2) ? temp2 : mf.MoveY;
            _image = mf.Draw();
            PictureBoxMandelbrot.Image = _image;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _image.Save("MF.jpg");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_fractals.ContainsKey(tabControl1.SelectedIndex))
                _selectedFractal = _fractals[tabControl1.SelectedIndex];
        }
        // ToDo: написать методы проверки корректности текстбокса 

        private void TextBoxG_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }


        private void TextBoxR_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void TextBoxB_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void TextBoxWidth_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void TextBoxHeight_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void TextBoxIterations_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void TextBoxZoom_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',')))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMoveX_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-')))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMoveY_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-')))
            {
                e.Handled = true;
            }
        }

        private void TextBoxC_Re_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-')))
            {
                e.Handled = true;
            }
        }

        private void TextBoxC_Im_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            var key = e.KeyChar;
            if (!(char.IsDigit(key) || (key == ',') || (key == '-')))
            {
                e.Handled = true;
            }
        }

        private void ButtonSave_2_Click(object sender, EventArgs e)
        {
            _image.Save("JF.jpg");
        }

        private void ButtonGenerate_2_Click(object sender, EventArgs e)
        {
            var jf = _selectedFractal as JuliaFractal;
            if (jf == null)
                return;
            // ToDo: Проверки на входные данные
            int temp1;
            double temp2, tempR, tempI;
            jf.R = int.TryParse(TextBoxR_2.Text, out temp1) ? temp1 % 256 : jf.R;
            jf.B = int.TryParse(TextBoxB_2.Text, out temp1) ? temp1 % 256 : jf.B;
            jf.G = int.TryParse(TextBoxG_2.Text, out temp1) ? temp1 % 256 : jf.G;
            jf.Width = int.TryParse(TextBoxWidth_2.Text, out temp1) ? temp1 : jf.Width;
            jf.Height = int.TryParse(TextBoxHeight_2.Text, out temp1) ? temp1 : jf.Height;
            jf.Zoom = double.TryParse(TextBoxZoom_2.Text, out temp2) ? temp2 : jf.Zoom;
            jf.Iterations = int.TryParse(TextBoxIterations_2.Text, out temp1) ? temp1 : jf.Iterations;
            jf.MoveX = double.TryParse(TextBoxMoveX_2.Text, out temp2) ? temp2 : jf.MoveX;
            jf.MoveY = double.TryParse(TextBoxMoveY_2.Text, out temp2) ? temp2 : jf.MoveY;
            tempR = double.TryParse(TextBoxC_Re_2.Text, out temp2) ? temp2 : jf.C.Real;
            tempI = double.TryParse(TextBoxC_Im_2.Text, out temp2) ? temp2 : jf.C.Imaginary;
            jf.C = new System.Numerics.Complex(tempR, tempI);
            _image = jf.Draw();
            PictureBoxJulia.Image = _image;
        }
    }
}


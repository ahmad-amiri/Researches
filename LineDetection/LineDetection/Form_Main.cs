using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Regression
{
    public partial class Form_Main : Form
    {
        private Graphics _graphics;
        public Hsv MinSample;
        public Hsv MaxSample;
        private Image<Hsv, byte> _originalImage;
        private Brush _dataBrush = new SolidBrush(Color.LightSlateGray);
        private List<Point> _dataSet;
        public Form_Main()
        {
            InitializeComponent();
            _dataSet = new List<Point>();
            _graphics = panel_graphics.CreateGraphics();
        }

        private void panel_graphics_MouseClick(object sender, MouseEventArgs e)
        {
            _graphics.FillRectangle(_dataBrush, e.X, e.Y, 3, 3);
            _dataSet.Add(e.Location);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _dataSet.Clear();
            _graphics.Clear(Color.White);
        }

        private void button_LeastSquared_Click(object sender, EventArgs e)
        {

            var lls = new LinearLeastSquare();
            lls.Fit(_dataSet);

            DrawModel(lls, panel_graphics.Width,Brushes.Red);
        }

        private void DrawModel(LinearLeastSquare model, int width, Brush brush)
        {
            var y0 = model.A1 * 0 + model.A0;
            var y1 = model.A1 * width + model.A0;

            _graphics.DrawLine(new Pen(brush), 0, (float)y0, width, (float)y1);
        }

        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Image.ShowDialog() == DialogResult.OK)
            {
                var image = new Image<Hsv, byte>(openFileDialog_Image.FileName);
                image = image.Resize(320, 240, INTER.CV_INTER_LINEAR);
                imageBox_SampleImage.Image = image;
                _originalImage = image;
            }
        }

        //Hsv _maskPixel = new Hsv(127, 127, 127);
        Hsv _maskPixel = new Hsv(0, 0, 255);
        Hsv _binaryPixel = new Hsv(0, 0, 0);
        private Image<Hsv, byte> _binaryImage;
        private void button_IterateImage_Click(object sender, EventArgs e)
        {
            _dataSet = new List<Point>();
            var maskedImage = _originalImage.Clone();
            _binaryImage = new Image<Hsv, byte>(_originalImage.Width, _originalImage.Height, _maskPixel);

            for (int i = 0; i < maskedImage.Cols; i++)
            {
                for (int j = 0; j < maskedImage.Rows; j++)
                {
                    if (!maskedImage[j, i].Equals(_grabbedPixel))
                    {
                        maskedImage[j, i] = _maskPixel;
                    }
                    else
                    {
                        _binaryImage[j, i] = _binaryPixel;
                        _dataSet.Add(new Point(i, j));
                        break;
                    }
                }
            }
            imageBox_Masked.Image = maskedImage;
            imageBox_binary.Image = _binaryImage;
        }

        private void button_RANSAC_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox_N.Text);
            var k = Convert.ToInt32(textBox_K.Text);
            var t = Convert.ToDouble(textBox_T.Text);
            var d = Convert.ToInt32(textBox_D.Text);

            var fittedModel = RANSAC.Fit(_dataSet, n, k, t, d);
            if (fittedModel != null)
            {
                DrawModel(fittedModel, panel_graphics.Width,Brushes.Green);
            }
            else
            {
                MessageBox.Show("No Model Fitted");
            }
        }

        private void button_ColorPicker_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }


        private Hsv _grabbedPixel = new Hsv(0, 0, 0);
        private void imageBox_SampleImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog_Image == null)
            {
                return;
            }

            if (Cursor == Cursors.Hand)
            {
                _grabbedPixel = _originalImage[e.Y, e.X];
                var grabbedimage = new Image<Hsv, byte>(imageBox_grabbedColor.Width, imageBox_grabbedColor.Height, _grabbedPixel);
                imageBox_grabbedColor.Image = grabbedimage;
                Cursor = DefaultCursor;
                label_grabbed_detail.Text = string.Format("H:{0} S:{1} V:{2} ", _grabbedPixel.Hue,
                    _grabbedPixel.Satuation, _grabbedPixel.Value);
            }
        }

        private void button_LLS_Image_Click(object sender, EventArgs e)
        {
            var lls = new LinearLeastSquare();
            lls.Fit(_dataSet);

            DrawModelOnImage(lls, _binaryImage.Width, _red);
        }

        private void DrawModelOnImage(LinearLeastSquare model, int width, Hsv color)
        {
            var y0 = model.A1 * 0 + model.A0;
            var y1 = model.A1 * width + model.A0;
            _binaryImage.Draw(new LineSegment2D(new Point(0, (int)y0), new Point(width, (int)y1)), color, 3);
            imageBox_linedetectedImage.Image = _binaryImage;
        }

        private readonly Hsv _green = new Hsv(70, 200, 180);
        private readonly Hsv _red = new Hsv(180, 225, 230);

        private void button_RANSAC_Image_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox_N_image.Text);
            var k = Convert.ToInt32(textBox_K_image.Text);
            var t = Convert.ToDouble(textBox_T_image.Text);
            var d = Convert.ToInt32(textBox_D_image.Text);

            var fittedModel = RANSAC.Fit(_dataSet, n, k, t, d);
            if (fittedModel != null)
            {
                DrawModelOnImage(fittedModel, _binaryImage.Width, _green);
            }
            else
            {
                MessageBox.Show("No Model Fitted");
            }
        }
    }
}

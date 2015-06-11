namespace Regression
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog_Image = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_Arbitrary = new System.Windows.Forms.TabPage();
            this.tabPage_ImageProcessing = new System.Windows.Forms.TabPage();
            this.button_ProcessImage = new System.Windows.Forms.Button();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.imageBox_SampleImage = new Emgu.CV.UI.ImageBox();
            this.label_D = new System.Windows.Forms.Label();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label_T = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.label_K = new System.Windows.Forms.Label();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.button_RANSAC = new System.Windows.Forms.Button();
            this.panel_graphics = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_LeastSquared = new System.Windows.Forms.Button();
            this.button_ColorPicker = new System.Windows.Forms.Button();
            this.imageBox_Masked = new Emgu.CV.UI.ImageBox();
            this.imageBox_grabbedColor = new Emgu.CV.UI.ImageBox();
            this.imageBox_linedetectedImage = new Emgu.CV.UI.ImageBox();
            this.button_RANSAC_Image = new System.Windows.Forms.Button();
            this.button_LLS_Image = new System.Windows.Forms.Button();
            this.label_Image_D = new System.Windows.Forms.Label();
            this.textBox_D_image = new System.Windows.Forms.TextBox();
            this.label_Image_T = new System.Windows.Forms.Label();
            this.textBox_T_image = new System.Windows.Forms.TextBox();
            this.label_Image_K = new System.Windows.Forms.Label();
            this.textBox_K_image = new System.Windows.Forms.TextBox();
            this.label_Image_N = new System.Windows.Forms.Label();
            this.textBox_N_image = new System.Windows.Forms.TextBox();
            this.label_grabbed_detail = new System.Windows.Forms.Label();
            this.imageBox_binary = new Emgu.CV.UI.ImageBox();
            this.tabControl_main.SuspendLayout();
            this.tabPage_Arbitrary.SuspendLayout();
            this.tabPage_ImageProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_SampleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Masked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_grabbedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_linedetectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_binary)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_Image
            // 
            this.openFileDialog_Image.FileName = "openFileDialog_Image";
            // 
            // tabControl_main
            // 
            this.tabControl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_main.Controls.Add(this.tabPage_Arbitrary);
            this.tabControl_main.Controls.Add(this.tabPage_ImageProcessing);
            this.tabControl_main.Location = new System.Drawing.Point(3, 12);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(830, 531);
            this.tabControl_main.TabIndex = 30;
            // 
            // tabPage_Arbitrary
            // 
            this.tabPage_Arbitrary.Controls.Add(this.label_D);
            this.tabPage_Arbitrary.Controls.Add(this.textBox_D);
            this.tabPage_Arbitrary.Controls.Add(this.label_T);
            this.tabPage_Arbitrary.Controls.Add(this.textBox_T);
            this.tabPage_Arbitrary.Controls.Add(this.label_K);
            this.tabPage_Arbitrary.Controls.Add(this.textBox_K);
            this.tabPage_Arbitrary.Controls.Add(this.label_N);
            this.tabPage_Arbitrary.Controls.Add(this.textBox_N);
            this.tabPage_Arbitrary.Controls.Add(this.button_RANSAC);
            this.tabPage_Arbitrary.Controls.Add(this.panel_graphics);
            this.tabPage_Arbitrary.Controls.Add(this.button_Clear);
            this.tabPage_Arbitrary.Controls.Add(this.button_LeastSquared);
            this.tabPage_Arbitrary.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Arbitrary.Name = "tabPage_Arbitrary";
            this.tabPage_Arbitrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Arbitrary.Size = new System.Drawing.Size(822, 505);
            this.tabPage_Arbitrary.TabIndex = 0;
            this.tabPage_Arbitrary.Text = "Arbitrary Dataset";
            this.tabPage_Arbitrary.UseVisualStyleBackColor = true;
            // 
            // tabPage_ImageProcessing
            // 
            this.tabPage_ImageProcessing.Controls.Add(this.imageBox_binary);
            this.tabPage_ImageProcessing.Controls.Add(this.label_grabbed_detail);
            this.tabPage_ImageProcessing.Controls.Add(this.label_Image_D);
            this.tabPage_ImageProcessing.Controls.Add(this.textBox_D_image);
            this.tabPage_ImageProcessing.Controls.Add(this.label_Image_T);
            this.tabPage_ImageProcessing.Controls.Add(this.textBox_T_image);
            this.tabPage_ImageProcessing.Controls.Add(this.label_Image_K);
            this.tabPage_ImageProcessing.Controls.Add(this.textBox_K_image);
            this.tabPage_ImageProcessing.Controls.Add(this.label_Image_N);
            this.tabPage_ImageProcessing.Controls.Add(this.textBox_N_image);
            this.tabPage_ImageProcessing.Controls.Add(this.button_RANSAC_Image);
            this.tabPage_ImageProcessing.Controls.Add(this.button_LLS_Image);
            this.tabPage_ImageProcessing.Controls.Add(this.imageBox_linedetectedImage);
            this.tabPage_ImageProcessing.Controls.Add(this.imageBox_grabbedColor);
            this.tabPage_ImageProcessing.Controls.Add(this.imageBox_Masked);
            this.tabPage_ImageProcessing.Controls.Add(this.button_ColorPicker);
            this.tabPage_ImageProcessing.Controls.Add(this.button_ProcessImage);
            this.tabPage_ImageProcessing.Controls.Add(this.button_LoadImage);
            this.tabPage_ImageProcessing.Controls.Add(this.imageBox_SampleImage);
            this.tabPage_ImageProcessing.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ImageProcessing.Name = "tabPage_ImageProcessing";
            this.tabPage_ImageProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ImageProcessing.Size = new System.Drawing.Size(822, 505);
            this.tabPage_ImageProcessing.TabIndex = 1;
            this.tabPage_ImageProcessing.Text = "Image Processing";
            this.tabPage_ImageProcessing.UseVisualStyleBackColor = true;
            // 
            // button_ProcessImage
            // 
            this.button_ProcessImage.Location = new System.Drawing.Point(16, 103);
            this.button_ProcessImage.Name = "button_ProcessImage";
            this.button_ProcessImage.Size = new System.Drawing.Size(128, 23);
            this.button_ProcessImage.TabIndex = 35;
            this.button_ProcessImage.Text = "Process Image";
            this.button_ProcessImage.UseVisualStyleBackColor = true;
            this.button_ProcessImage.Click += new System.EventHandler(this.button_IterateImage_Click);
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(13, 6);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.button_LoadImage.TabIndex = 34;
            this.button_LoadImage.Text = "Load Image";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // imageBox_SampleImage
            // 
            this.imageBox_SampleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_SampleImage.Location = new System.Drawing.Point(166, 6);
            this.imageBox_SampleImage.Name = "imageBox_SampleImage";
            this.imageBox_SampleImage.Size = new System.Drawing.Size(320, 240);
            this.imageBox_SampleImage.TabIndex = 30;
            this.imageBox_SampleImage.TabStop = false;
            this.imageBox_SampleImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox_SampleImage_MouseClick);
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(789, 198);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(15, 13);
            this.label_D.TabIndex = 26;
            this.label_D.Text = "D";
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(732, 195);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(51, 20);
            this.textBox_D.TabIndex = 25;
            this.textBox_D.Text = "30";
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Location = new System.Drawing.Point(790, 170);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(14, 13);
            this.label_T.TabIndex = 24;
            this.label_T.Text = "T";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(733, 167);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(51, 20);
            this.textBox_T.TabIndex = 23;
            this.textBox_T.Text = "10";
            // 
            // label_K
            // 
            this.label_K.AutoSize = true;
            this.label_K.Location = new System.Drawing.Point(790, 144);
            this.label_K.Name = "label_K";
            this.label_K.Size = new System.Drawing.Size(14, 13);
            this.label_K.TabIndex = 22;
            this.label_K.Text = "K";
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(733, 141);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(51, 20);
            this.textBox_K.TabIndex = 21;
            this.textBox_K.Text = "100";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(790, 116);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(15, 13);
            this.label_N.TabIndex = 20;
            this.label_N.Text = "N";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(733, 113);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(51, 20);
            this.textBox_N.TabIndex = 19;
            this.textBox_N.Text = "2";
            // 
            // button_RANSAC
            // 
            this.button_RANSAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_RANSAC.Location = new System.Drawing.Point(656, 84);
            this.button_RANSAC.Name = "button_RANSAC";
            this.button_RANSAC.Size = new System.Drawing.Size(151, 23);
            this.button_RANSAC.TabIndex = 18;
            this.button_RANSAC.Text = "RANSAC";
            this.button_RANSAC.UseVisualStyleBackColor = false;
            this.button_RANSAC.Click += new System.EventHandler(this.button_RANSAC_Click);
            // 
            // panel_graphics
            // 
            this.panel_graphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_graphics.Location = new System.Drawing.Point(20, 22);
            this.panel_graphics.Name = "panel_graphics";
            this.panel_graphics.Size = new System.Drawing.Size(630, 477);
            this.panel_graphics.TabIndex = 15;
            this.panel_graphics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_graphics_MouseClick);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(656, 22);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(151, 23);
            this.button_Clear.TabIndex = 17;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_LeastSquared
            // 
            this.button_LeastSquared.BackColor = System.Drawing.Color.Red;
            this.button_LeastSquared.Location = new System.Drawing.Point(656, 51);
            this.button_LeastSquared.Name = "button_LeastSquared";
            this.button_LeastSquared.Size = new System.Drawing.Size(149, 27);
            this.button_LeastSquared.TabIndex = 16;
            this.button_LeastSquared.Text = "Linear Least Square";
            this.button_LeastSquared.UseVisualStyleBackColor = false;
            this.button_LeastSquared.Click += new System.EventHandler(this.button_LeastSquared_Click);
            // 
            // button_ColorPicker
            // 
            this.button_ColorPicker.Location = new System.Drawing.Point(13, 33);
            this.button_ColorPicker.Name = "button_ColorPicker";
            this.button_ColorPicker.Size = new System.Drawing.Size(75, 23);
            this.button_ColorPicker.TabIndex = 36;
            this.button_ColorPicker.Text = "Color Picker";
            this.button_ColorPicker.UseVisualStyleBackColor = true;
            this.button_ColorPicker.Click += new System.EventHandler(this.button_ColorPicker_Click);
            // 
            // imageBox_Masked
            // 
            this.imageBox_Masked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_Masked.Location = new System.Drawing.Point(496, 6);
            this.imageBox_Masked.Name = "imageBox_Masked";
            this.imageBox_Masked.Size = new System.Drawing.Size(320, 240);
            this.imageBox_Masked.TabIndex = 37;
            this.imageBox_Masked.TabStop = false;
            // 
            // imageBox_grabbedColor
            // 
            this.imageBox_grabbedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_grabbedColor.Location = new System.Drawing.Point(94, 6);
            this.imageBox_grabbedColor.Name = "imageBox_grabbedColor";
            this.imageBox_grabbedColor.Size = new System.Drawing.Size(50, 50);
            this.imageBox_grabbedColor.TabIndex = 38;
            this.imageBox_grabbedColor.TabStop = false;
            // 
            // imageBox_linedetectedImage
            // 
            this.imageBox_linedetectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_linedetectedImage.Location = new System.Drawing.Point(496, 252);
            this.imageBox_linedetectedImage.Name = "imageBox_linedetectedImage";
            this.imageBox_linedetectedImage.Size = new System.Drawing.Size(320, 240);
            this.imageBox_linedetectedImage.TabIndex = 39;
            this.imageBox_linedetectedImage.TabStop = false;
            // 
            // button_RANSAC_Image
            // 
            this.button_RANSAC_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_RANSAC_Image.Location = new System.Drawing.Point(16, 161);
            this.button_RANSAC_Image.Name = "button_RANSAC_Image";
            this.button_RANSAC_Image.Size = new System.Drawing.Size(128, 23);
            this.button_RANSAC_Image.TabIndex = 41;
            this.button_RANSAC_Image.Text = "RANSAC";
            this.button_RANSAC_Image.UseVisualStyleBackColor = false;
            this.button_RANSAC_Image.Click += new System.EventHandler(this.button_RANSAC_Image_Click);
            // 
            // button_LLS_Image
            // 
            this.button_LLS_Image.BackColor = System.Drawing.Color.Red;
            this.button_LLS_Image.Location = new System.Drawing.Point(17, 132);
            this.button_LLS_Image.Name = "button_LLS_Image";
            this.button_LLS_Image.Size = new System.Drawing.Size(129, 23);
            this.button_LLS_Image.TabIndex = 40;
            this.button_LLS_Image.Text = "Linear Least Square";
            this.button_LLS_Image.UseVisualStyleBackColor = false;
            this.button_LLS_Image.Click += new System.EventHandler(this.button_LLS_Image_Click);
            // 
            // label_Image_D
            // 
            this.label_Image_D.AutoSize = true;
            this.label_Image_D.Location = new System.Drawing.Point(72, 285);
            this.label_Image_D.Name = "label_Image_D";
            this.label_Image_D.Size = new System.Drawing.Size(15, 13);
            this.label_Image_D.TabIndex = 49;
            this.label_Image_D.Text = "D";
            // 
            // textBox_D_image
            // 
            this.textBox_D_image.Location = new System.Drawing.Point(15, 282);
            this.textBox_D_image.Name = "textBox_D_image";
            this.textBox_D_image.Size = new System.Drawing.Size(51, 20);
            this.textBox_D_image.TabIndex = 48;
            this.textBox_D_image.Text = "70";
            // 
            // label_Image_T
            // 
            this.label_Image_T.AutoSize = true;
            this.label_Image_T.Location = new System.Drawing.Point(73, 257);
            this.label_Image_T.Name = "label_Image_T";
            this.label_Image_T.Size = new System.Drawing.Size(14, 13);
            this.label_Image_T.TabIndex = 47;
            this.label_Image_T.Text = "T";
            // 
            // textBox_T_image
            // 
            this.textBox_T_image.Location = new System.Drawing.Point(16, 254);
            this.textBox_T_image.Name = "textBox_T_image";
            this.textBox_T_image.Size = new System.Drawing.Size(51, 20);
            this.textBox_T_image.TabIndex = 46;
            this.textBox_T_image.Text = "5";
            // 
            // label_Image_K
            // 
            this.label_Image_K.AutoSize = true;
            this.label_Image_K.Location = new System.Drawing.Point(73, 231);
            this.label_Image_K.Name = "label_Image_K";
            this.label_Image_K.Size = new System.Drawing.Size(14, 13);
            this.label_Image_K.TabIndex = 45;
            this.label_Image_K.Text = "K";
            // 
            // textBox_K_image
            // 
            this.textBox_K_image.Location = new System.Drawing.Point(16, 228);
            this.textBox_K_image.Name = "textBox_K_image";
            this.textBox_K_image.Size = new System.Drawing.Size(51, 20);
            this.textBox_K_image.TabIndex = 44;
            this.textBox_K_image.Text = "500";
            // 
            // label_Image_N
            // 
            this.label_Image_N.AutoSize = true;
            this.label_Image_N.Location = new System.Drawing.Point(73, 203);
            this.label_Image_N.Name = "label_Image_N";
            this.label_Image_N.Size = new System.Drawing.Size(15, 13);
            this.label_Image_N.TabIndex = 43;
            this.label_Image_N.Text = "N";
            // 
            // textBox_N_image
            // 
            this.textBox_N_image.Location = new System.Drawing.Point(16, 200);
            this.textBox_N_image.Name = "textBox_N_image";
            this.textBox_N_image.Size = new System.Drawing.Size(51, 20);
            this.textBox_N_image.TabIndex = 42;
            this.textBox_N_image.Text = "2";
            // 
            // label_grabbed_detail
            // 
            this.label_grabbed_detail.AutoSize = true;
            this.label_grabbed_detail.Location = new System.Drawing.Point(14, 71);
            this.label_grabbed_detail.Name = "label_grabbed_detail";
            this.label_grabbed_detail.Size = new System.Drawing.Size(44, 13);
            this.label_grabbed_detail.TabIndex = 50;
            this.label_grabbed_detail.Text = "H: S: V:";
            // 
            // imageBox_binary
            // 
            this.imageBox_binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_binary.Location = new System.Drawing.Point(166, 252);
            this.imageBox_binary.Name = "imageBox_binary";
            this.imageBox_binary.Size = new System.Drawing.Size(320, 240);
            this.imageBox_binary.TabIndex = 51;
            this.imageBox_binary.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 555);
            this.Controls.Add(this.tabControl_main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Introduction to Line Detection - www.amiri.probotix.ir ";
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_Arbitrary.ResumeLayout(false);
            this.tabPage_Arbitrary.PerformLayout();
            this.tabPage_ImageProcessing.ResumeLayout(false);
            this.tabPage_ImageProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_SampleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Masked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_grabbedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_linedetectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_binary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_Image;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_Arbitrary;
        private System.Windows.Forms.TabPage tabPage_ImageProcessing;
        private System.Windows.Forms.Button button_ProcessImage;
        private System.Windows.Forms.Button button_LoadImage;
        private Emgu.CV.UI.ImageBox imageBox_SampleImage;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.Label label_K;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Button button_RANSAC;
        private System.Windows.Forms.Panel panel_graphics;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_LeastSquared;
        private System.Windows.Forms.Button button_ColorPicker;
        private Emgu.CV.UI.ImageBox imageBox_Masked;
        private Emgu.CV.UI.ImageBox imageBox_grabbedColor;
        private Emgu.CV.UI.ImageBox imageBox_linedetectedImage;
        private System.Windows.Forms.Button button_RANSAC_Image;
        private System.Windows.Forms.Button button_LLS_Image;
        private System.Windows.Forms.Label label_Image_D;
        private System.Windows.Forms.TextBox textBox_D_image;
        private System.Windows.Forms.Label label_Image_T;
        private System.Windows.Forms.TextBox textBox_T_image;
        private System.Windows.Forms.Label label_Image_K;
        private System.Windows.Forms.TextBox textBox_K_image;
        private System.Windows.Forms.Label label_Image_N;
        private System.Windows.Forms.TextBox textBox_N_image;
        private System.Windows.Forms.Label label_grabbed_detail;
        private Emgu.CV.UI.ImageBox imageBox_binary;
    }
}


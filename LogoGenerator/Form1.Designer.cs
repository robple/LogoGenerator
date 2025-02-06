namespace LogoGenerator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnApple = new System.Windows.Forms.Button();
            this.btnAndroid = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(101, 274);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(145, 34);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose 2048 Logo";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnApple
            // 
            this.btnApple.Enabled = false;
            this.btnApple.Location = new System.Drawing.Point(12, 350);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(140, 32);
            this.btnApple.TabIndex = 2;
            this.btnApple.Text = "Create Apple Logos";
            this.btnApple.UseVisualStyleBackColor = true;
            this.btnApple.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // btnAndroid
            // 
            this.btnAndroid.Enabled = false;
            this.btnAndroid.Location = new System.Drawing.Point(192, 350);
            this.btnAndroid.Name = "btnAndroid";
            this.btnAndroid.Size = new System.Drawing.Size(140, 32);
            this.btnAndroid.TabIndex = 3;
            this.btnAndroid.Text = "Create Android Logos";
            this.btnAndroid.UseVisualStyleBackColor = true;
            this.btnAndroid.Click += new System.EventHandler(this.btnAndroid_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "PNG|*.png";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\RobWork\\Dropbox\\Software\\Resources\\";
            this.openFileDialog1.Title = "Select PNG 1024 in size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 390);
            this.Controls.Add(this.btnAndroid);
            this.Controls.Add(this.btnApple);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnApple;
        private System.Windows.Forms.Button btnAndroid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


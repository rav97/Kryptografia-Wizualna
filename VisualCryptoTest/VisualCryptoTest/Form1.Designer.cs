namespace VisualCryptoTest
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.ReadImage = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SaveImages = new System.Windows.Forms.Button();
            this.U1Image = new System.Windows.Forms.PictureBox();
            this.U2Image = new System.Windows.Forms.PictureBox();
            this.SourceImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadImages = new System.Windows.Forms.Button();
            this.Split = new System.Windows.Forms.CheckBox();
            this.Merge = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.U1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(269, 12);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Size = new System.Drawing.Size(365, 20);
            this.ImagePath.TabIndex = 3;
            this.ImagePath.TextChanged += new System.EventHandler(this.ImagePath_TextChanged);
            // 
            // ReadImage
            // 
            this.ReadImage.Location = new System.Drawing.Point(181, 10);
            this.ReadImage.Name = "ReadImage";
            this.ReadImage.Size = new System.Drawing.Size(82, 23);
            this.ReadImage.TabIndex = 4;
            this.ReadImage.Text = "Wczytaj obraz";
            this.ReadImage.UseVisualStyleBackColor = true;
            this.ReadImage.Click += new System.EventHandler(this.ReadImage_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(632, 228);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(171, 48);
            this.Start.TabIndex = 5;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SaveImages
            // 
            this.SaveImages.Location = new System.Drawing.Point(702, 522);
            this.SaveImages.Name = "SaveImages";
            this.SaveImages.Size = new System.Drawing.Size(101, 23);
            this.SaveImages.TabIndex = 6;
            this.SaveImages.Text = "Zapisz udziały";
            this.SaveImages.UseVisualStyleBackColor = true;
            this.SaveImages.Click += new System.EventHandler(this.SaveImages_Click);
            // 
            // U1Image
            // 
            this.U1Image.Location = new System.Drawing.Point(12, 300);
            this.U1Image.Name = "U1Image";
            this.U1Image.Size = new System.Drawing.Size(384, 216);
            this.U1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.U1Image.TabIndex = 7;
            this.U1Image.TabStop = false;
            this.U1Image.Click += new System.EventHandler(this.U1Image_Click);
            // 
            // U2Image
            // 
            this.U2Image.Location = new System.Drawing.Point(419, 300);
            this.U2Image.Name = "U2Image";
            this.U2Image.Size = new System.Drawing.Size(384, 216);
            this.U2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.U2Image.TabIndex = 8;
            this.U2Image.TabStop = false;
            this.U2Image.Click += new System.EventHandler(this.U2Image_Click);
            // 
            // SourceImage
            // 
            this.SourceImage.Location = new System.Drawing.Point(216, 60);
            this.SourceImage.Name = "SourceImage";
            this.SourceImage.Size = new System.Drawing.Size(384, 216);
            this.SourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceImage.TabIndex = 9;
            this.SourceImage.TabStop = false;
            this.SourceImage.Click += new System.EventHandler(this.SourceImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Udział1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Udział2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Obraz źródłowy:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReadImages
            // 
            this.ReadImages.Location = new System.Drawing.Point(12, 522);
            this.ReadImages.Name = "ReadImages";
            this.ReadImages.Size = new System.Drawing.Size(91, 23);
            this.ReadImages.TabIndex = 13;
            this.ReadImages.Text = "Wczytaj udziały";
            this.ReadImages.UseVisualStyleBackColor = true;
            this.ReadImages.Click += new System.EventHandler(this.ReadImages_Click);
            // 
            // Split
            // 
            this.Split.AutoSize = true;
            this.Split.Checked = true;
            this.Split.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Split.Location = new System.Drawing.Point(632, 169);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(95, 17);
            this.Split.TabIndex = 14;
            this.Split.Text = "Rozdziel obraz";
            this.Split.UseVisualStyleBackColor = true;
            this.Split.CheckedChanged += new System.EventHandler(this.Split_CheckedChanged);
            // 
            // Merge
            // 
            this.Merge.AutoSize = true;
            this.Merge.Location = new System.Drawing.Point(632, 192);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(81, 17);
            this.Merge.TabIndex = 15;
            this.Merge.Text = "Scal obrazy";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.CheckedChanged += new System.EventHandler(this.Merge_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 557);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.ReadImages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceImage);
            this.Controls.Add(this.U2Image);
            this.Controls.Add(this.U1Image);
            this.Controls.Add(this.SaveImages);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ReadImage);
            this.Controls.Add(this.ImagePath);
            this.Name = "Form";
            this.Text = "Kryptografia Wizualna";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.U1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.U2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.Button ReadImage;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button SaveImages;
        private System.Windows.Forms.PictureBox U1Image;
        private System.Windows.Forms.PictureBox U2Image;
        private System.Windows.Forms.PictureBox SourceImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadImages;
        private System.Windows.Forms.CheckBox Split;
        private System.Windows.Forms.CheckBox Merge;
    }
}


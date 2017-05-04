namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.Sobel3x3Btn = new System.Windows.Forms.Button();
            this.BlackWhiteCB = new System.Windows.Forms.CheckBox();
            this.GaussianCB = new System.Windows.Forms.CheckBox();
            this.Prewitt = new System.Windows.Forms.Button();
            this.Laplacian3x3Btn = new System.Windows.Forms.Button();
            this.Kirsch = new System.Windows.Forms.Button();
            this.Laplacian5x5Btn = new System.Windows.Forms.Button();
            this.Sobel5x5Btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResultPicture = new System.Windows.Forms.PictureBox();
            this.StartPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Location = new System.Drawing.Point(12, 254);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(236, 23);
            this.ChooseFileBtn.TabIndex = 3;
            this.ChooseFileBtn.Text = "Выберите файл. . .";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sobel3x3Btn
            // 
            this.Sobel3x3Btn.Location = new System.Drawing.Point(12, 311);
            this.Sobel3x3Btn.Name = "Sobel3x3Btn";
            this.Sobel3x3Btn.Size = new System.Drawing.Size(115, 23);
            this.Sobel3x3Btn.TabIndex = 4;
            this.Sobel3x3Btn.Text = "Собель (3х3)";
            this.Sobel3x3Btn.UseVisualStyleBackColor = true;
            this.Sobel3x3Btn.Click += new System.EventHandler(this.SobelBtn_Click);
            // 
            // BlackWhiteCB
            // 
            this.BlackWhiteCB.AutoSize = true;
            this.BlackWhiteCB.Location = new System.Drawing.Point(12, 288);
            this.BlackWhiteCB.Name = "BlackWhiteCB";
            this.BlackWhiteCB.Size = new System.Drawing.Size(46, 17);
            this.BlackWhiteCB.TabIndex = 9;
            this.BlackWhiteCB.Text = "Ч/Б";
            this.BlackWhiteCB.UseVisualStyleBackColor = true;
            // 
            // GaussianCB
            // 
            this.GaussianCB.AutoSize = true;
            this.GaussianCB.Location = new System.Drawing.Point(105, 288);
            this.GaussianCB.Name = "GaussianCB";
            this.GaussianCB.Size = new System.Drawing.Size(143, 17);
            this.GaussianCB.TabIndex = 10;
            this.GaussianCB.Text = "Размыть по гаусу (3х3)";
            this.GaussianCB.UseVisualStyleBackColor = true;
            // 
            // Prewitt
            // 
            this.Prewitt.Location = new System.Drawing.Point(133, 340);
            this.Prewitt.Name = "Prewitt";
            this.Prewitt.Size = new System.Drawing.Size(115, 23);
            this.Prewitt.TabIndex = 11;
            this.Prewitt.Text = "Превитт ";
            this.Prewitt.UseVisualStyleBackColor = true;
            this.Prewitt.Click += new System.EventHandler(this.Prewitt_Click);
            // 
            // Laplacian3x3Btn
            // 
            this.Laplacian3x3Btn.Location = new System.Drawing.Point(12, 368);
            this.Laplacian3x3Btn.Name = "Laplacian3x3Btn";
            this.Laplacian3x3Btn.Size = new System.Drawing.Size(115, 23);
            this.Laplacian3x3Btn.TabIndex = 13;
            this.Laplacian3x3Btn.Text = "Лапласс (3х3)";
            this.Laplacian3x3Btn.UseVisualStyleBackColor = true;
            this.Laplacian3x3Btn.Click += new System.EventHandler(this.Laplacian3x3Btn_Click);
            // 
            // Kirsch
            // 
            this.Kirsch.Location = new System.Drawing.Point(12, 340);
            this.Kirsch.Name = "Kirsch";
            this.Kirsch.Size = new System.Drawing.Size(115, 23);
            this.Kirsch.TabIndex = 12;
            this.Kirsch.Text = "Кирш";
            this.Kirsch.UseVisualStyleBackColor = true;
            this.Kirsch.Click += new System.EventHandler(this.Kirsch_Click);
            // 
            // Laplacian5x5Btn
            // 
            this.Laplacian5x5Btn.Location = new System.Drawing.Point(133, 369);
            this.Laplacian5x5Btn.Name = "Laplacian5x5Btn";
            this.Laplacian5x5Btn.Size = new System.Drawing.Size(115, 23);
            this.Laplacian5x5Btn.TabIndex = 14;
            this.Laplacian5x5Btn.Text = "Лапласс (5х5)";
            this.Laplacian5x5Btn.UseVisualStyleBackColor = true;
            this.Laplacian5x5Btn.Click += new System.EventHandler(this.Laplacian5x5Btn_Click);
            // 
            // Sobel5x5Btn
            // 
            this.Sobel5x5Btn.Location = new System.Drawing.Point(133, 311);
            this.Sobel5x5Btn.Name = "Sobel5x5Btn";
            this.Sobel5x5Btn.Size = new System.Drawing.Size(115, 23);
            this.Sobel5x5Btn.TabIndex = 15;
            this.Sobel5x5Btn.Text = "Собель (5x5)";
            this.Sobel5x5Btn.UseVisualStyleBackColor = true;
            this.Sobel5x5Btn.Click += new System.EventHandler(this.Sobel5x5Btn_Click);
            // 
            // ResultPicture
            // 
            this.ResultPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPicture.Image = global::ImageEditor.Properties.Resources.loading_throbber_time_loader_512;
            this.ResultPicture.Location = new System.Drawing.Point(254, 12);
            this.ResultPicture.Name = "ResultPicture";
            this.ResultPicture.Size = new System.Drawing.Size(495, 380);
            this.ResultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultPicture.TabIndex = 2;
            this.ResultPicture.TabStop = false;
            // 
            // StartPicture
            // 
            this.StartPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPicture.Image = global::ImageEditor.Properties.Resources.Download_Document_128;
            this.StartPicture.InitialImage = null;
            this.StartPicture.Location = new System.Drawing.Point(12, 12);
            this.StartPicture.Name = "StartPicture";
            this.StartPicture.Size = new System.Drawing.Size(236, 236);
            this.StartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartPicture.TabIndex = 0;
            this.StartPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 403);
            this.Controls.Add(this.Sobel5x5Btn);
            this.Controls.Add(this.Laplacian5x5Btn);
            this.Controls.Add(this.Laplacian3x3Btn);
            this.Controls.Add(this.Kirsch);
            this.Controls.Add(this.Prewitt);
            this.Controls.Add(this.GaussianCB);
            this.Controls.Add(this.BlackWhiteCB);
            this.Controls.Add(this.Sobel3x3Btn);
            this.Controls.Add(this.ChooseFileBtn);
            this.Controls.Add(this.ResultPicture);
            this.Controls.Add(this.StartPicture);
            this.Name = "Form1";
            this.Text = "Выделение контуров";
            ((System.ComponentModel.ISupportInitialize)(this.ResultPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPicture;
        private System.Windows.Forms.PictureBox ResultPicture;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.Button Sobel3x3Btn;
        private System.Windows.Forms.CheckBox BlackWhiteCB;
        private System.Windows.Forms.CheckBox GaussianCB;
        private System.Windows.Forms.Button Prewitt;
        private System.Windows.Forms.Button Laplacian3x3Btn;
        private System.Windows.Forms.Button Kirsch;
        private System.Windows.Forms.Button Laplacian5x5Btn;
        private System.Windows.Forms.Button Sobel5x5Btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


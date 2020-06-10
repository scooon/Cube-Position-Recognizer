namespace Cube_Position_Recognizer
{
    partial class Form1
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
            this.MakeCorners = new System.Windows.Forms.Button();
            this.Preview_1 = new System.Windows.Forms.PictureBox();
            this.Threshold_input = new System.Windows.Forms.TextBox();
            this.k_Input = new System.Windows.Forms.TextBox();
            this.sigma_Input = new System.Windows.Forms.TextBox();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.SigmaLabel = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ComboBox();
            this.ObrazLabel = new System.Windows.Forms.Label();
            this.cornersLabel = new System.Windows.Forms.Label();
            this.CornerListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Preview_1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeCorners
            // 
            this.MakeCorners.Location = new System.Drawing.Point(595, 200);
            this.MakeCorners.Name = "MakeCorners";
            this.MakeCorners.Size = new System.Drawing.Size(158, 23);
            this.MakeCorners.TabIndex = 0;
            this.MakeCorners.Text = "Znajdź wierzchołki";
            this.MakeCorners.UseVisualStyleBackColor = true;
            this.MakeCorners.Click += new System.EventHandler(this.MakeCorners_Click);
            // 
            // Preview_1
            // 
            this.Preview_1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Preview_1.Location = new System.Drawing.Point(191, 12);
            this.Preview_1.Name = "Preview_1";
            this.Preview_1.Size = new System.Drawing.Size(374, 341);
            this.Preview_1.TabIndex = 1;
            this.Preview_1.TabStop = false;
            // 
            // Threshold_input
            // 
            this.Threshold_input.Location = new System.Drawing.Point(628, 41);
            this.Threshold_input.Name = "Threshold_input";
            this.Threshold_input.Size = new System.Drawing.Size(100, 20);
            this.Threshold_input.TabIndex = 2;
            this.Threshold_input.Text = "1000";
            // 
            // k_Input
            // 
            this.k_Input.Location = new System.Drawing.Point(628, 90);
            this.k_Input.Name = "k_Input";
            this.k_Input.Size = new System.Drawing.Size(100, 20);
            this.k_Input.TabIndex = 3;
            this.k_Input.Text = "0,055";
            // 
            // sigma_Input
            // 
            this.sigma_Input.Location = new System.Drawing.Point(628, 147);
            this.sigma_Input.Name = "sigma_Input";
            this.sigma_Input.Size = new System.Drawing.Size(100, 20);
            this.sigma_Input.TabIndex = 4;
            this.sigma_Input.Text = "1,4";
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(625, 25);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.ThresholdLabel.TabIndex = 5;
            this.ThresholdLabel.Text = "Threshold:";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(625, 74);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(16, 13);
            this.kLabel.TabIndex = 6;
            this.kLabel.Text = "k:";
            // 
            // SigmaLabel
            // 
            this.SigmaLabel.AutoSize = true;
            this.SigmaLabel.Location = new System.Drawing.Point(625, 131);
            this.SigmaLabel.Name = "SigmaLabel";
            this.SigmaLabel.Size = new System.Drawing.Size(39, 13);
            this.SigmaLabel.TabIndex = 7;
            this.SigmaLabel.Text = "Sigma:";
            // 
            // ImageList
            // 
            this.ImageList.FormattingEnabled = true;
            this.ImageList.Location = new System.Drawing.Point(26, 40);
            this.ImageList.Name = "ImageList";
            this.ImageList.Size = new System.Drawing.Size(121, 21);
            this.ImageList.TabIndex = 8;
            this.ImageList.Text = "CubePaint.png";
            // 
            // ObrazLabel
            // 
            this.ObrazLabel.AutoSize = true;
            this.ObrazLabel.Location = new System.Drawing.Point(23, 25);
            this.ObrazLabel.Name = "ObrazLabel";
            this.ObrazLabel.Size = new System.Drawing.Size(38, 13);
            this.ObrazLabel.TabIndex = 9;
            this.ObrazLabel.Text = "Obraz:";
            // 
            // cornersLabel
            // 
            this.cornersLabel.AutoSize = true;
            this.cornersLabel.Location = new System.Drawing.Point(23, 131);
            this.cornersLabel.Name = "cornersLabel";
            this.cornersLabel.Size = new System.Drawing.Size(67, 13);
            this.cornersLabel.TabIndex = 11;
            this.cornersLabel.Text = "Wierzchołki:";
            // 
            // CornerListView
            // 
            this.CornerListView.HideSelection = false;
            this.CornerListView.Location = new System.Drawing.Point(26, 147);
            this.CornerListView.Name = "CornerListView";
            this.CornerListView.Size = new System.Drawing.Size(150, 206);
            this.CornerListView.TabIndex = 12;
            this.CornerListView.UseCompatibleStateImageBehavior = false;
            this.CornerListView.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CornerListView);
            this.Controls.Add(this.cornersLabel);
            this.Controls.Add(this.ObrazLabel);
            this.Controls.Add(this.ImageList);
            this.Controls.Add(this.SigmaLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.ThresholdLabel);
            this.Controls.Add(this.sigma_Input);
            this.Controls.Add(this.k_Input);
            this.Controls.Add(this.Threshold_input);
            this.Controls.Add(this.Preview_1);
            this.Controls.Add(this.MakeCorners);
            this.Name = "Form1";
            this.Text = "Corner Position Detector";
            ((System.ComponentModel.ISupportInitialize)(this.Preview_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeCorners;
        private System.Windows.Forms.PictureBox Preview_1;
        private System.Windows.Forms.TextBox Threshold_input;
        private System.Windows.Forms.TextBox k_Input;
        private System.Windows.Forms.TextBox sigma_Input;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label SigmaLabel;
        private System.Windows.Forms.ComboBox ImageList;
        private System.Windows.Forms.Label ObrazLabel;
        private System.Windows.Forms.Label cornersLabel;
        private System.Windows.Forms.ListView CornerListView;
    }
}


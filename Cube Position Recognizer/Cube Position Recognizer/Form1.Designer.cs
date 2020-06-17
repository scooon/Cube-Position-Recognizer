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
            this.suppressionTargetLabel = new System.Windows.Forms.Label();
            this.suppressionTarget = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryzujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźWierzchołkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAGICBUTTONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RthresholdValue = new System.Windows.Forms.TextBox();
            this.Rthreshold = new System.Windows.Forms.Label();
            this.Gthreshold = new System.Windows.Forms.Label();
            this.GthresholdValue = new System.Windows.Forms.TextBox();
            this.Bthreshold = new System.Windows.Forms.Label();
            this.BthresholdValue = new System.Windows.Forms.TextBox();
            this.Kthreshold = new System.Windows.Forms.Label();
            this.kThresholdValue = new System.Windows.Forms.TextBox();
            this.DistanceListView = new System.Windows.Forms.ListView();
            this.OdleglosciLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Preview_1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeCorners
            // 
            this.MakeCorners.Location = new System.Drawing.Point(739, 287);
            this.MakeCorners.Name = "MakeCorners";
            this.MakeCorners.Size = new System.Drawing.Size(158, 24);
            this.MakeCorners.TabIndex = 0;
            this.MakeCorners.Text = "Znajdź wierzchołki";
            this.MakeCorners.UseVisualStyleBackColor = true;
            this.MakeCorners.Click += new System.EventHandler(this.MakeCorners_Click);
            // 
            // Preview_1
            // 
            this.Preview_1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Preview_1.Location = new System.Drawing.Point(142, 57);
            this.Preview_1.Name = "Preview_1";
            this.Preview_1.Size = new System.Drawing.Size(567, 341);
            this.Preview_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preview_1.TabIndex = 1;
            this.Preview_1.TabStop = false;
            // 
            // Threshold_input
            // 
            this.Threshold_input.Location = new System.Drawing.Point(772, 87);
            this.Threshold_input.Name = "Threshold_input";
            this.Threshold_input.Size = new System.Drawing.Size(100, 20);
            this.Threshold_input.TabIndex = 2;
            this.Threshold_input.Text = "1000";
            // 
            // k_Input
            // 
            this.k_Input.Location = new System.Drawing.Point(772, 136);
            this.k_Input.Name = "k_Input";
            this.k_Input.Size = new System.Drawing.Size(100, 20);
            this.k_Input.TabIndex = 3;
            this.k_Input.Text = "0,2";
            // 
            // sigma_Input
            // 
            this.sigma_Input.Location = new System.Drawing.Point(772, 193);
            this.sigma_Input.Name = "sigma_Input";
            this.sigma_Input.Size = new System.Drawing.Size(100, 20);
            this.sigma_Input.TabIndex = 4;
            this.sigma_Input.Text = "1,4";
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(769, 71);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.ThresholdLabel.TabIndex = 5;
            this.ThresholdLabel.Text = "Threshold:";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(769, 120);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(16, 13);
            this.kLabel.TabIndex = 6;
            this.kLabel.Text = "k:";
            // 
            // SigmaLabel
            // 
            this.SigmaLabel.AutoSize = true;
            this.SigmaLabel.Location = new System.Drawing.Point(769, 177);
            this.SigmaLabel.Name = "SigmaLabel";
            this.SigmaLabel.Size = new System.Drawing.Size(39, 13);
            this.SigmaLabel.TabIndex = 7;
            this.SigmaLabel.Text = "Sigma:";
            // 
            // ImageList
            // 
            this.ImageList.FormattingEnabled = true;
            this.ImageList.Location = new System.Drawing.Point(15, 72);
            this.ImageList.Name = "ImageList";
            this.ImageList.Size = new System.Drawing.Size(121, 21);
            this.ImageList.TabIndex = 8;
            this.ImageList.Text = "CubePaint.png";
            // 
            // ObrazLabel
            // 
            this.ObrazLabel.AutoSize = true;
            this.ObrazLabel.Location = new System.Drawing.Point(12, 57);
            this.ObrazLabel.Name = "ObrazLabel";
            this.ObrazLabel.Size = new System.Drawing.Size(38, 13);
            this.ObrazLabel.TabIndex = 9;
            this.ObrazLabel.Text = "Obraz:";
            // 
            // cornersLabel
            // 
            this.cornersLabel.AutoSize = true;
            this.cornersLabel.Location = new System.Drawing.Point(23, 425);
            this.cornersLabel.Name = "cornersLabel";
            this.cornersLabel.Size = new System.Drawing.Size(67, 13);
            this.cornersLabel.TabIndex = 11;
            this.cornersLabel.Text = "Wierzchołki:";
            // 
            // CornerListView
            // 
            this.CornerListView.HideSelection = false;
            this.CornerListView.Location = new System.Drawing.Point(23, 440);
            this.CornerListView.Name = "CornerListView";
            this.CornerListView.Size = new System.Drawing.Size(308, 206);
            this.CornerListView.TabIndex = 12;
            this.CornerListView.UseCompatibleStateImageBehavior = false;
            this.CornerListView.View = System.Windows.Forms.View.List;
            // 
            // suppressionTargetLabel
            // 
            this.suppressionTargetLabel.AutoSize = true;
            this.suppressionTargetLabel.Location = new System.Drawing.Point(769, 230);
            this.suppressionTargetLabel.Name = "suppressionTargetLabel";
            this.suppressionTargetLabel.Size = new System.Drawing.Size(98, 13);
            this.suppressionTargetLabel.TabIndex = 14;
            this.suppressionTargetLabel.Text = "Suppression target:";
            // 
            // suppressionTarget
            // 
            this.suppressionTarget.Location = new System.Drawing.Point(772, 246);
            this.suppressionTarget.Name = "suppressionTarget";
            this.suppressionTarget.Size = new System.Drawing.Size(100, 20);
            this.suppressionTarget.TabIndex = 13;
            this.suppressionTarget.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.binaryzujToolStripMenuItem,
            this.znajdźWierzchołkiToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.mAGICBUTTONToolStripMenuItem});
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrazToolStripMenuItem.Text = "Obraz";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // binaryzujToolStripMenuItem
            // 
            this.binaryzujToolStripMenuItem.Name = "binaryzujToolStripMenuItem";
            this.binaryzujToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.binaryzujToolStripMenuItem.Text = "Binaryzuj";
            this.binaryzujToolStripMenuItem.Click += new System.EventHandler(this.binaryzujToolStripMenuItem_Click);
            // 
            // znajdźWierzchołkiToolStripMenuItem
            // 
            this.znajdźWierzchołkiToolStripMenuItem.Name = "znajdźWierzchołkiToolStripMenuItem";
            this.znajdźWierzchołkiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.znajdźWierzchołkiToolStripMenuItem.Text = "Znajdź wierzchołki";
            this.znajdźWierzchołkiToolStripMenuItem.Click += new System.EventHandler(this.znajdźWierzchołkiToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // mAGICBUTTONToolStripMenuItem
            // 
            this.mAGICBUTTONToolStripMenuItem.Name = "mAGICBUTTONToolStripMenuItem";
            this.mAGICBUTTONToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mAGICBUTTONToolStripMenuItem.Text = "MAGIC BUTTON";
            this.mAGICBUTTONToolStripMenuItem.Click += new System.EventHandler(this.mAGICBUTTONToolStripMenuItem_Click);
            // 
            // RthresholdValue
            // 
            this.RthresholdValue.Location = new System.Drawing.Point(772, 340);
            this.RthresholdValue.Name = "RthresholdValue";
            this.RthresholdValue.Size = new System.Drawing.Size(100, 20);
            this.RthresholdValue.TabIndex = 16;
            this.RthresholdValue.Text = "255";
            // 
            // Rthreshold
            // 
            this.Rthreshold.AutoSize = true;
            this.Rthreshold.Location = new System.Drawing.Point(769, 324);
            this.Rthreshold.Name = "Rthreshold";
            this.Rthreshold.Size = new System.Drawing.Size(65, 13);
            this.Rthreshold.TabIndex = 17;
            this.Rthreshold.Text = "R Threshold";
            // 
            // Gthreshold
            // 
            this.Gthreshold.AutoSize = true;
            this.Gthreshold.Location = new System.Drawing.Point(769, 368);
            this.Gthreshold.Name = "Gthreshold";
            this.Gthreshold.Size = new System.Drawing.Size(65, 13);
            this.Gthreshold.TabIndex = 19;
            this.Gthreshold.Text = "G Threshold";
            // 
            // GthresholdValue
            // 
            this.GthresholdValue.Location = new System.Drawing.Point(772, 384);
            this.GthresholdValue.Name = "GthresholdValue";
            this.GthresholdValue.Size = new System.Drawing.Size(100, 20);
            this.GthresholdValue.TabIndex = 18;
            this.GthresholdValue.Text = "255";
            // 
            // Bthreshold
            // 
            this.Bthreshold.AutoSize = true;
            this.Bthreshold.Location = new System.Drawing.Point(769, 409);
            this.Bthreshold.Name = "Bthreshold";
            this.Bthreshold.Size = new System.Drawing.Size(64, 13);
            this.Bthreshold.TabIndex = 21;
            this.Bthreshold.Text = "B Threshold";
            // 
            // BthresholdValue
            // 
            this.BthresholdValue.Location = new System.Drawing.Point(772, 425);
            this.BthresholdValue.Name = "BthresholdValue";
            this.BthresholdValue.Size = new System.Drawing.Size(100, 20);
            this.BthresholdValue.TabIndex = 20;
            this.BthresholdValue.Text = "255";
            // 
            // Kthreshold
            // 
            this.Kthreshold.AutoSize = true;
            this.Kthreshold.Location = new System.Drawing.Point(769, 457);
            this.Kthreshold.Name = "Kthreshold";
            this.Kthreshold.Size = new System.Drawing.Size(64, 13);
            this.Kthreshold.TabIndex = 23;
            this.Kthreshold.Text = "K Threshold";
            // 
            // kThresholdValue
            // 
            this.kThresholdValue.Location = new System.Drawing.Point(772, 473);
            this.kThresholdValue.Name = "kThresholdValue";
            this.kThresholdValue.Size = new System.Drawing.Size(100, 20);
            this.kThresholdValue.TabIndex = 22;
            this.kThresholdValue.Text = "70";
            // 
            // DistanceListView
            // 
            this.DistanceListView.HideSelection = false;
            this.DistanceListView.Location = new System.Drawing.Point(371, 440);
            this.DistanceListView.Name = "DistanceListView";
            this.DistanceListView.Size = new System.Drawing.Size(308, 206);
            this.DistanceListView.TabIndex = 24;
            this.DistanceListView.UseCompatibleStateImageBehavior = false;
            this.DistanceListView.View = System.Windows.Forms.View.List;
            // 
            // OdleglosciLabel
            // 
            this.OdleglosciLabel.AutoSize = true;
            this.OdleglosciLabel.Location = new System.Drawing.Point(368, 424);
            this.OdleglosciLabel.Name = "OdleglosciLabel";
            this.OdleglosciLabel.Size = new System.Drawing.Size(61, 13);
            this.OdleglosciLabel.TabIndex = 25;
            this.OdleglosciLabel.Text = "Odległości:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 670);
            this.Controls.Add(this.OdleglosciLabel);
            this.Controls.Add(this.DistanceListView);
            this.Controls.Add(this.Kthreshold);
            this.Controls.Add(this.kThresholdValue);
            this.Controls.Add(this.Bthreshold);
            this.Controls.Add(this.BthresholdValue);
            this.Controls.Add(this.Gthreshold);
            this.Controls.Add(this.GthresholdValue);
            this.Controls.Add(this.Rthreshold);
            this.Controls.Add(this.RthresholdValue);
            this.Controls.Add(this.suppressionTargetLabel);
            this.Controls.Add(this.suppressionTarget);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Corner Position Detector";
            ((System.ComponentModel.ISupportInitialize)(this.Preview_1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label suppressionTargetLabel;
        private System.Windows.Forms.TextBox suppressionTarget;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryzujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźWierzchołkiToolStripMenuItem;
        private System.Windows.Forms.TextBox RthresholdValue;
        private System.Windows.Forms.Label Rthreshold;
        private System.Windows.Forms.Label Gthreshold;
        private System.Windows.Forms.TextBox GthresholdValue;
        private System.Windows.Forms.Label Bthreshold;
        private System.Windows.Forms.TextBox BthresholdValue;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAGICBUTTONToolStripMenuItem;
        private System.Windows.Forms.Label Kthreshold;
        private System.Windows.Forms.TextBox kThresholdValue;
        private System.Windows.Forms.ListView DistanceListView;
        private System.Windows.Forms.Label OdleglosciLabel;
    }
}


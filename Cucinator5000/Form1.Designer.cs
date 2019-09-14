namespace Cucinator5000
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
            this.cuceSilver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuceSilver)).BeginInit();
            this.SuspendLayout();
            // 
            // cuceSilver
            // 
            this.cuceSilver.Image = global::Cucinator5000.Properties.Resources.cuce;
            this.cuceSilver.Location = new System.Drawing.Point(190, 136);
            this.cuceSilver.Name = "cuceSilver";
            this.cuceSilver.Size = new System.Drawing.Size(231, 114);
            this.cuceSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuceSilver.TabIndex = 0;
            this.cuceSilver.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use Arrow Keys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuceSilver);
            this.Name = "Form1";
            this.Text = "Cucinator 5000";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cuceSilver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cuceSilver;
        private System.Windows.Forms.Label label1;
    }
}


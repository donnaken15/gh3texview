namespace gh3texview
{
    partial class scoremeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scoremeter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.streaklights = new System.Windows.Forms.NumericUpDown();
            this.multi = new System.Windows.Forms.NumericUpDown();
            this.streak = new System.Windows.Forms.NumericUpDown();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streaklights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::gh3texview.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::gh3texview.Properties.Resources.base5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 310);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // streaklights
            // 
            this.streaklights.Location = new System.Drawing.Point(12, 278);
            this.streaklights.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.streaklights.Name = "streaklights";
            this.streaklights.Size = new System.Drawing.Size(32, 20);
            this.streaklights.TabIndex = 1;
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(51, 278);
            this.multi.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.multi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(26, 20);
            this.multi.TabIndex = 2;
            this.multi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.multi.ValueChanged += new System.EventHandler(this.multi_ValueChanged);
            // 
            // streak
            // 
            this.streak.Location = new System.Drawing.Point(84, 278);
            this.streak.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.streak.Name = "streak";
            this.streak.Size = new System.Drawing.Size(45, 20);
            this.streak.TabIndex = 3;
            this.streak.ValueChanged += new System.EventHandler(this.streak_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 50;
            this.vScrollBar1.Location = new System.Drawing.Point(12, 40);
            this.vScrollBar1.Maximum = 99999999;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 33);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(194, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::gh3texview.Properties.Resources.bg1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::gh3texview.Properties.Resources.base6;
            this.pictureBox2.Location = new System.Drawing.Point(40, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 145);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(94, 202);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // scoremeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.streak);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.streaklights);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scoremeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Score Meter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streaklights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown streaklights;
        private System.Windows.Forms.NumericUpDown multi;
        private System.Windows.Forms.NumericUpDown streak;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
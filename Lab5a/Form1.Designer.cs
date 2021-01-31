namespace Lab5a
{
    partial class bucketFill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bucketFill));
            this.color_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.waterflow_trackbar = new System.Windows.Forms.TrackBar();
            this.tap = new System.Windows.Forms.PictureBox();
            this.bucket = new System.Windows.Forms.Panel();
            this.waterColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.waterflow_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tap)).BeginInit();
            this.SuspendLayout();
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(34, 12);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(75, 31);
            this.color_btn.TabIndex = 0;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(150, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 31);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // waterflow_trackbar
            // 
            this.waterflow_trackbar.Location = new System.Drawing.Point(34, 89);
            this.waterflow_trackbar.Name = "waterflow_trackbar";
            this.waterflow_trackbar.Size = new System.Drawing.Size(123, 56);
            this.waterflow_trackbar.TabIndex = 2;
            // 
            // tap
            // 
            this.tap.Image = ((System.Drawing.Image)(resources.GetObject("tap.Image")));
            this.tap.Location = new System.Drawing.Point(34, 168);
            this.tap.Name = "tap";
            this.tap.Size = new System.Drawing.Size(123, 83);
            this.tap.TabIndex = 3;
            this.tap.TabStop = false;
            // 
            // bucket
            // 
            this.bucket.ForeColor = System.Drawing.Color.Transparent;
            this.bucket.Location = new System.Drawing.Point(98, 236);
            this.bucket.Name = "bucket";
            this.bucket.Size = new System.Drawing.Size(280, 258);
            this.bucket.TabIndex = 4;
            this.bucket.Paint += new System.Windows.Forms.PaintEventHandler(this.Bucket_Paint);
            // 
            // bucketFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(430, 522);
            this.Controls.Add(this.bucket);
            this.Controls.Add(this.tap);
            this.Controls.Add(this.waterflow_trackbar);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.color_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bucketFill";
            this.Text = "A drop in the bucket";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.waterflow_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TrackBar waterflow_trackbar;
        private System.Windows.Forms.PictureBox tap;
        private System.Windows.Forms.Panel bucket;
        private System.Windows.Forms.ColorDialog waterColor;
    }
}


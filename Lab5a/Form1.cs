/* Name : Shashwat Kumar
 * Student No.: 000790494
 * I certify that this is my original work.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5a
{
    public partial class bucketFill : Form
    {
        Timer bucketFillTimer;
        Color color = Color.LightBlue;
        float completionPercentage = 100;
        bool bucketFull = false;
        /// <summary>
        /// Initializes component and creates a new timer
        /// </summary>
        public bucketFill()
        {
            InitializeComponent();
            bucketFillTimer = new Timer();
            bucketFillTimer.Interval = 1000 / 1000;
            bucketFillTimer.Tick += BucketFillTimer_Tick;
            
        }

        /// <summary>
        /// This calls update and draw method if the value of the trackbar > 0  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BucketFillTimer_Tick(object sender, EventArgs e)
        {
            if (waterflow_trackbar.Value != 0)
            {
                Update();
                Draw();

            }
            if (waterflow_trackbar.Value == 0 && completionPercentage!=100)
            {
                using (Graphics g = bucket.CreateGraphics())
                {
                    Brush b = new SolidBrush(Color.Black);
                    float y = (completionPercentage / 100) * (bucket.Height);
                    g.FillRectangle(b, 21, 0, 15, y);
                    
                }
            }

        }

        /// <summary>
        /// This creates a bucket and starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                Pen pen = new Pen(Color.White);
                
                g.DrawLine(pen, bucket.Location.X-1, bucket.Location.Y+90, bucket.Location.X-1, bucket.Location.Y+bucket.Height);
                g.DrawLine(pen, bucket.Location.X-1, bucket.Location.Y + bucket.Height, bucket.Location.X+bucket.Width, bucket.Location.Y + bucket.Height);
                g.DrawLine(pen, bucket.Location.X + bucket.Width, bucket.Location.Y + bucket.Height, bucket.Location.X + bucket.Width, bucket.Location.Y +90);
            }
            bucketFillTimer.Start();
            
        }

        /// <summary>
        /// This method draws water flow and increases the level water in the bucket 
        /// Manages the speed of the water flow as the value of the trackbar changes
        /// </summary>
        public void Update()
        {
            

            if (completionPercentage <= 48)
            {
                waterflow_trackbar.Value = 0;
                
                bucketFull = true;

                using (Graphics g = bucket.CreateGraphics())
                {
                    Brush b = new SolidBrush(Color.Black);
                    float y = (completionPercentage / 100) * (bucket.Height);
                    g.FillRectangle(b, 21, 0, 15, y);
                }
                completionPercentage = 100;
            }
            if (bucketFull && completionPercentage < 100)
            {
                using (Graphics g = bucket.CreateGraphics())
                {
                    g.Clear(Color.Black);
                    bucketFull = false;
                }
            }
            float percentageDelta = (float)waterflow_trackbar.Value/25;
            completionPercentage -= percentageDelta;
        }

        /// <summary>
        /// This method draws the water level and flowing water
        /// </summary>
        public void Draw()
        {
            using (Graphics g = bucket.CreateGraphics())
            { 
                Brush b = new SolidBrush(color);
                float x = 0;
                float width = bucket.Width;
                float height = 1;
                float y = (completionPercentage / 100) * (bucket.Height);
                
                g.FillRectangle(b, x, y, width, height);
                if (completionPercentage < 100)
                {                 
                    g.FillRectangle(b, 21, 0, 15,y);                   
                }
            }
        }

        /// <summary>
        /// Changes the color of the water according to what user selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if(waterColor.ShowDialog() == DialogResult.OK)
            {
                color = waterColor.Color;
            }
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bucket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

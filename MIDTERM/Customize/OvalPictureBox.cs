using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIDTERM.SubForms
{
    public class OvalPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Set the smoothing mode to make the edges smoother
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Define the border color and width
            Color borderColor = Color.Black;
            int borderWidth = 2;

            // Create a rectangle that fits within the control's client area
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            // Create a GraphicsPath object for the oval
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }

            // Draw the oval border
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pe.Graphics.DrawEllipse(pen, rect);
            }
        }
    }
}

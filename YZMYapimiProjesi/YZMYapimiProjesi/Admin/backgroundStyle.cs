using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZMYapimiProjesi.Admin
{
   public class backgroundStyle : Label
    {


        public Color topColor { get; set; }
        public Color bottomColor { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.topColor, this.bottomColor, this.Angle);

            Graphics g = e.Graphics;

            Label L = new Label();

            g.FillRectangle(brush, this.ClientRectangle);

            base.OnPaint(e);


        }
       





    }
}

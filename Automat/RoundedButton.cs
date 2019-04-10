using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    class RoundedButton : Button
    {
        private static GraphicsPath getRoundPath(RectangleF rectF, int radius)
        {
            rectF.Width = rectF.Width - 1;
            rectF.Height = rectF.Height - 1;
            float r2 = radius / 2f;
            GraphicsPath grp = new GraphicsPath();
            grp.StartFigure();
            grp.AddArc(rectF.X, rectF.Y, radius, radius, 180, 90);
            grp.AddLine(rectF.X + r2, rectF.Y, rectF.Width - r2, rectF.Y);
            grp.AddArc(rectF.X + rectF.Width - radius, rectF.Y, radius, radius, 270, 90);
            grp.AddLine(rectF.Width, rectF.Y + r2, rectF.Width, rectF.Height - r2);
            grp.AddArc(rectF.X + rectF.Width - radius, rectF.Y + rectF.Height - radius, radius, radius, 0, 90);
            grp.AddLine(rectF.Width - r2, rectF.Height, rectF.Width + r2, rectF.Height);
            grp.AddArc(rectF.X, rectF.Y + rectF.Height - radius, radius, radius, 90, 90);
            grp.AddLine(rectF.X, rectF.Height - r2, rectF.X, rectF.Y + r2);
            grp.CloseFigure();
            return grp;
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            pea.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RectangleF rectF = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath grRoundPath = getRoundPath(rectF, 10); //HIER MUSS GEÄNDERT WERDEN AN DER 1 FÜR UNTERSCHIEDLICHE RUNDUNGEN
            this.Region = new Region(grRoundPath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                pea.Graphics.DrawPath(pen, grRoundPath);
            }
            base.OnPaint(pea);
        }


    }
}

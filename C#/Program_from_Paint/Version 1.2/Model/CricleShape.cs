using System;
using System.Drawing;

namespace Draw {
    public class CricleShape : Shape {
        public CricleShape(RectangleF rect) : base(rect) {
        }

        public CricleShape(CricleShape cricle) : base(cricle) {

        }

        public override bool Contains(PointF point) {
            if (base.Contains(point))
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx) {
            base.DrawSelf(grfx); 
            grfx.FillEllipse(new SolidBrush(FillColor), X, Y, Width, Height);
            grfx.DrawEllipse(new Pen(Color, Convert.ToInt32(Line)), X, Y, Width, Height);
        }
    }
}

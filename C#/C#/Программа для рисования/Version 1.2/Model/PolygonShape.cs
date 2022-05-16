using System;
using System.Drawing;

namespace Draw {
    public class PolygonShape : Shape {
        public PolygonShape(RectangleF rect) : base(rect) {
        }

        public PolygonShape(PolygonShape polygon) : base(polygon) {
        }

        public override bool Contains(PointF point) {
            if (base.Contains(point))
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx) {
            base.DrawSelf(grfx);
            PointF[] curvePoints = { new PointF(75 + X + Convert.ToInt32(Scale) / 2, 0 + Y), new PointF(0 + X, 60 + Y + Convert.ToInt32(Scale) / 2), new PointF(30 + X, 150 + Y + Convert.ToInt32(Scale)), new PointF(125 + X + Convert.ToInt32(Scale), 150 + Y + Convert.ToInt32(Scale)), new PointF(150 + X + Convert.ToInt32(Scale), 60 + Y + Convert.ToInt32(Scale) / 2) };            
            grfx.FillPolygon(new SolidBrush(FillColor), curvePoints);
            grfx.DrawPolygon(new Pen(Color, Convert.ToInt32(Line)), curvePoints);
        }
    }
}
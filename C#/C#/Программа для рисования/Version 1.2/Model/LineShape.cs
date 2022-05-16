using System;
using System.Drawing;

namespace Draw {
    public class LineShape : Shape {
        public LineShape(RectangleF rect) : base(rect) {
        }

        public LineShape(LineShape line) : base(line) {
        }

        public override bool Contains(PointF point) {
            if (base.Contains(point))
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx) {
            base.DrawSelf(grfx);
            PointF[] curvePoints = { new PointF(95 + X - Convert.ToInt32(Scale) /20, 0 + Y ), new PointF(105 + X + Convert.ToInt32(Scale) /20, 0 + Y), new PointF(105 + X + Convert.ToInt32(Scale) /20, 200 + Convert.ToInt32(Scale) + Y), new PointF(95 + X - Convert.ToInt32(Scale) /20, 200 + Convert.ToInt32(Scale) + Y) };
            grfx.FillPolygon(new SolidBrush(FillColor), curvePoints);
            grfx.DrawPolygon(new Pen(Color, Convert.ToInt32(Line)), curvePoints);
        }
    }
}
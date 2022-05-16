using System;
using System.Drawing;

namespace Draw {
    public class RectangleShape : Shape {	
		public RectangleShape(RectangleF rect) : base(rect) {
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle) {
		}

        public override bool Contains(PointF point) {
			if (base.Contains(point))
                return true;
			else
                return false;
		}

        public override void DrawSelf(Graphics grfx) {
			base.DrawSelf(grfx);
            PointF[] curvePoints = { new PointF(0 + X, 0 + Y), new PointF(0 + X, 150 + Y + Convert.ToInt32(Scale)), new PointF(150 + X + Convert.ToInt32(Scale), 150 + Y + Convert.ToInt32(Scale)), new PointF(150 + X + Convert.ToInt32(Scale), 0 + Y) };
            grfx.FillPolygon(new SolidBrush(FillColor), curvePoints);
			grfx.DrawPolygon(new Pen(Color, Convert.ToInt32(Line)), curvePoints);
        }
    }
}

using System;
using System.Drawing;

namespace Draw
{
    public class NewShape : Shape
    {
        public NewShape(RectangleF rect) : base(rect)
        {
        }

        public NewShape(NewShape New) : base(New)
        {
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                return true;
            else
                return false;
        }
        //решение на задачата
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            PointF points1 =  new PointF(0 + X,0 + Y);
            PointF points2 = new PointF(125 + X + Convert.ToInt32(Scale)/2, 75 + Y + Convert.ToInt32(Scale) / 4);
            PointF points3 = new PointF(125 + X + Convert.ToInt32(Scale)/2, 75 + Y + Convert.ToInt32(Scale) / 4);
            PointF points4 = new PointF(250 + X + Convert.ToInt32(Scale), 0 + Y);
            PointF[] curvePoint = { new PointF(0 + X, 0 + Y), new PointF(0 + X, 150 + Y + Convert.ToInt32(Scale)/2), new PointF(250 + X + Convert.ToInt32(Scale), 150 + Y + Convert.ToInt32(Scale)/2), new PointF(250 + X + Convert.ToInt32(Scale), 0 + Y) };
            grfx.FillPolygon(new SolidBrush(FillColor), curvePoint);
            grfx.DrawPolygon(new Pen(Color, Convert.ToInt32(Line)), curvePoint);
            grfx.DrawLine(new Pen(Color, Convert.ToInt32(Line)), points1, points2);
            grfx.DrawLine(new Pen(Color, Convert.ToInt32(Line)), points3, points4);
        }
    }
}
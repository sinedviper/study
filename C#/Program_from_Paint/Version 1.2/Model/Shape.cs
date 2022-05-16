using System;
using System.Drawing;

namespace Draw {
    public abstract class Shape {
        public Shape(RectangleF rect) {
            RectangleF = rect;
        }

        public Shape(Shape shape) {
            this.RectangleF = shape.RectangleF;
            this.Location = shape.Location;
            this.Width = shape.Width;
            this.Height = shape.Height;
            this.X = shape.X;
            this.Y = shape.Y;
            this.FillColor = shape.FillColor;
            this.Color = shape.Color;
            this.Line = shape.Line;
            this.Copy = shape.Copy;
            this.scale = shape.scale;
            this.strings = shape.strings;
        }

        private RectangleF RectangleF;
        public virtual RectangleF Rectangle {
            get { return RectangleF; }
            set { RectangleF = value; }
        }
        //Променлива за копиране
        private Double copy;
        public virtual Double Copy {
            get { return copy; }
            set { copy = value; }
        }
        //Променлива за имената на групите
        private String strings;
        public virtual String Strings {
            get{return strings;}
            set {strings = value; }
        }
        //Променлива за увеличаване на фигурите
        private Double scale;
        public virtual Double Scale {
            get { return scale; }
            set { scale = value; }
        }
        //Променлива дебелина на линиите
        private Double line;
        public virtual Double Line {
            get { return line; }
            set { line = value; }
        }

        private Color fillColor;
        public virtual Color FillColor {
            get { return fillColor; }
            set { fillColor = value; }
        }
        //Променлива цвят линии
        private Color color;
        public virtual Color Color {
            get { return color; }
            set { color = value; }
        }

        public virtual float Width {
			get { return Rectangle.Width; }
			set { RectangleF.Width = value; }
		}

        public virtual float Height {
            get { return Rectangle.Height; }
            set { RectangleF.Height = value; }
        }

        public virtual float X {
            get { return Rectangle.X; }
            set { RectangleF.X = value; }
        }

        public virtual float Y {
            get { return Rectangle.Y; }
            set { RectangleF.Y = value; }
        }

        public virtual PointF Location {
			get { return Rectangle.Location; }
			set { RectangleF.Location = value; }
		}

        public virtual bool Contains(PointF point) {
			return Rectangle.Contains(point.X, point.Y);
		}

        public virtual void DrawSelf(Graphics grfx) {
			
		}
    }
}
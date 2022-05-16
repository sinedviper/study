using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace Draw {
    public class DisplayProcessor {
        public DisplayProcessor() {
		}

        private List<Shape> shapeList = new List<Shape>();
        public List<Shape> ShapeList {
			get { return shapeList; }
			set { shapeList = value; }
		}

        public void ReDraw(object sender, PaintEventArgs e) {
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}

        public virtual void Draw(Graphics grfx) {
			foreach (Shape item in ShapeList) {
				DrawShape(grfx, item);
			}
		}

        public virtual void DrawShape(Graphics grfx, Shape item) {
			item.DrawSelf(grfx);
		}

    }
}

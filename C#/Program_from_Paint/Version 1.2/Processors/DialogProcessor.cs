using System;
using System.Drawing;

namespace Draw {
    public class DialogProcessor : DisplayProcessor {
        public DialogProcessor() {
		}

        private Shape selection;
		public Shape Selection {
			get { return selection; }
			set { selection = value; }
		}

        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}

        private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
        //Добавяне на многоъгълник към платното
        public void AddRandomPolygon() {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);

            PolygonShape polygon = new PolygonShape(new RectangleF(x, y, 150, 150)) {
                FillColor = Color.White,
                Color = Color.Gray,
                Line = 2,
                Copy = 3
            };
            ShapeList.Add(polygon);
        }
        //Добавяне на линия към платно
        public void AddRandomLine() {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);
            LineShape line = new LineShape(new RectangleF(x, y, 200, 200)) {
                FillColor = Color.White,
                Color = Color.Gray,
                Line = 2,
                Copy = 4
            };
            ShapeList.Add(line);
        }
        //Добавяне на кръг към платното
        public void AddRandomCircle() {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);

            CricleShape cricle = new CricleShape(new Rectangle(x, y, 150, 150)) {
                FillColor = Color.White,
                Color = Color.Gray,
                Line = 2,
                Copy = 2
            };
            ShapeList.Add(cricle);
        }
        //Добавяне на квадрат към платно
        public void AddRandomRectangle() {
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,500);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 150, 150)) {
                FillColor = Color.White,
                Color = Color.Gray,
                Line = 2,
                Copy = 1
            };
            ShapeList.Add(rect);
		}
        //Добавяне на нова фигура към платно
        public void AddRandomNew()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);
            NewShape line = new NewShape(new RectangleF(x, y, 250, 150))
            {
                FillColor = Color.White,
                Color = Color.Gray,
                Line = 2,
                Copy = 5
            };
            ShapeList.Add(line);
        }
        //Премахване на фигура
        public Shape DeleteShape(PointF point) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                    ShapeList.Remove(ShapeList[i]);                   
                }
            }
            return null;
        }
        //Увелечение на фигурата
        public Shape PlusScale(PointF point) {         
            for (int i = ShapeList.Count - 1; i >= 0; i--) {    
                if (ShapeList[i].Contains(point)) {
                    ShapeList[i].Scale += 15;
                    ShapeList[i].Width += 15;
                    ShapeList[i].Height += 15;
                    return ShapeList[i];
                }
            }
            return null;
        }
        //Намаляване на фигурата
        public Shape MinusScale(PointF point) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                    ShapeList[i].Scale -= 15;
                    ShapeList[i].Width -= 15;
                    ShapeList[i].Height -= 15;
                    return ShapeList[i];
                }
            }
            return null;
        }
        //Промяна на цвета на фигурата
        public Shape RGB(PointF point, int R, int G, int B) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                        ShapeList[i].FillColor = Color.FromArgb(R, G, B);
                        return ShapeList[i];
                }
            }
            return null;
        }
        //Промяна на цвета на линията на фигурата, както и нейната дебелина
        public Shape LineChange(PointF point, int widthLine, int R, int G, int B) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                    float width, height, x, y;
                    x = ShapeList[i].X;
                    y = ShapeList[i].Y;
                    width = ShapeList[i].Width;
                    height = ShapeList[i].Height;
                    ShapeList[i].Line = widthLine;
                    ShapeList[i].Color = Color.FromArgb(R, G, B);
                    ShapeList[i].X = x;
                    ShapeList[i].Y = y;
                    ShapeList[i].Width = width;
                    ShapeList[i].Height = height;
                    return ShapeList[i];
                }
            }
            return null;
        }
        //Копиране на фигура
        public Shape Copy (PointF point) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Copy == 1) {
                    if (ShapeList[i].Contains(point)) {
                        double size = ShapeList[i].Scale;
                        RectangleShape rect = new RectangleShape(new RectangleF(ShapeList[i].X + 100, ShapeList[i].Y + 100, ShapeList[i].Width, ShapeList[i].Height)) {
                            FillColor = ShapeList[i].FillColor,
                            Color = ShapeList[i].Color,
                            Scale = size,
                            Line = ShapeList[i].Line
                        };                       
                        ShapeList.Add(rect);                     
                    }
                } else if (ShapeList[i].Copy == 2) {
                    if (ShapeList[i].Contains(point)) {
                        double size = ShapeList[i].Scale;
                        CricleShape cricle = new CricleShape(new RectangleF(ShapeList[i].X + 100, ShapeList[i].Y + 100, ShapeList[i].Width, ShapeList[i].Height)) {
                            FillColor = ShapeList[i].FillColor,
                            Color = ShapeList[i].Color,
                            Scale = size,
                            Line = ShapeList[i].Line
                        };
                        ShapeList.Add(cricle);          
                    }
                } else if (ShapeList[i].Copy == 3) {
                    if (ShapeList[i].Contains(point)) {
                        double size = ShapeList[i].Scale;
                        PolygonShape polygon = new PolygonShape(new RectangleF(ShapeList[i].X + 100, ShapeList[i].Y + 100, ShapeList[i].Width, ShapeList[i].Height)) {
                            FillColor = ShapeList[i].FillColor,
                            Color = ShapeList[i].Color,
                            Scale = size,
                            Line = ShapeList[i].Line
                        };
                        ShapeList.Add(polygon);         
                    }
                } else if (ShapeList[i].Copy == 4) {
                    if (ShapeList[i].Contains(point)) {
                        double size = ShapeList[i].Scale;
                        LineShape line = new LineShape(new RectangleF(ShapeList[i].X + 100, ShapeList[i].Y + 100, ShapeList[i].Width, ShapeList[i].Height)) {
                            FillColor = ShapeList[i].FillColor,
                            Color = ShapeList[i].Color,
                            Scale = size,
                            Line = ShapeList[i].Line
                        };
                        ShapeList.Add(line);  
                    }
                } else if (ShapeList[i].Copy == 5) {
                    if (ShapeList[i].Contains(point))
                    {
                        double size = ShapeList[i].Scale;
                        NewShape line = new NewShape(new RectangleF(ShapeList[i].X + 100, ShapeList[i].Y + 100, ShapeList[i].Width, ShapeList[i].Height))
                        {
                            FillColor = ShapeList[i].FillColor,
                            Color = ShapeList[i].Color,
                            Scale = size,
                            Line = ShapeList[i].Line
                        };
                        ShapeList.Add(line);
                    }
                }
            }
            return null;
        }
        //Добавяне на фигура към група
        public Shape AddGroupe (PointF point, string nameGroupe) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point))
                    ShapeList[i].Strings = nameGroupe;                   
            }            
            return null;
        }
        //Премахване на фигура от група
        public Shape DeleteGroupe(PointF point, string nameGroupe) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point))
                    ShapeList[i].Strings = null;
            }
            return null;
        }
        //Изтриване на група
        public Shape RemoveGroupe (string nameGroupe) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Strings == nameGroupe)
                    ShapeList[i].Strings = null;
            }     
            return null;
        }

        public Shape ContainsPoint(PointF point) {
			for(int i = ShapeList.Count - 1; i >= 0; i--) {
				if (ShapeList[i].Contains(point)){
					ShapeList[i].FillColor = Color.SteelBlue;
                    ShapeList[i].Color = Color.DarkSlateBlue;
                    ShapeList[i].Line = 5;
					return ShapeList[i];
				}	
			}
			return null;
		}
        //Преместване на фигура
        public Shape MovePoint(PointF point) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
               if (ShapeList[i].Contains(point)) {                
                    return ShapeList[i];
               }
            }
            return null;
        }
        
        public void TranslateTo(PointF p) {
            if (selection != null) {
                if (selection.Strings == null) {
                    selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
                    lastLocation = p;
                } else if (selection.Strings != null) {
                    foreach (Shape item in ShapeList) { 
                        if (item.Strings == selection.Strings) {
                            item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
                        }
                    }
                    lastLocation = p;
                }
            }
        }

    }
}
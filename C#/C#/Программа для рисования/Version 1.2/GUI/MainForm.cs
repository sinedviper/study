using System;
using System.Windows.Forms;

namespace Draw {
    public partial class MainForm : Form {

        private DialogProcessor dialogProcessor = new DialogProcessor();
        private DisplayProcessor displayProcessor = new DisplayProcessor();

        public MainForm() {
            InitializeComponent();
        }

        private void ViewPortPaint(object sender, PaintEventArgs e) {
            dialogProcessor.ReDraw(sender, e);
        }

        private void DrawRectangleSpeedButtonClick(object sender, EventArgs e) {
            dialogProcessor.AddRandomRectangle();
            viewPort.Invalidate();
        }

        private void DrawCircleSpeedButtonClick(object sender, EventArgs e) {
            dialogProcessor.AddRandomCircle();
            viewPort.Invalidate();
        }

        private void DrawPolygonSpeedButtonClick(object sender, EventArgs e) {
            dialogProcessor.AddRandomPolygon();
            viewPort.Invalidate();
        }

        private void DrawLineSpeedButtonClick(object sender, EventArgs e) {
            dialogProcessor.AddRandomLine();
            viewPort.Invalidate();
        }

        private void DrawNewSpeedButtonClick(object sender, EventArgs e) {
            dialogProcessor.AddRandomNew();
            viewPort.Invalidate();
        }

        private void ViewPortMouseDown(object sender, MouseEventArgs e) {
            
            if (pickUpSpeedButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null) {
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
            //Бутон за преместване на фигурата
            if (DrawMoveButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.MovePoint(e.Location);
                if (dialogProcessor.Selection != null) {
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
            //Бутон за изтриване на фигура
            if (DrawDeleteButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.DeleteShape(e.Location);
                viewPort.Invalidate();
            }
            //Бутон за увеличаване на фигурата
            if (DrawPlusButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.PlusScale(e.Location);
                viewPort.Invalidate();
            }
            //Бутон за намаляване на фигурата
            if (DrawMinusButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.MinusScale(e.Location);
                viewPort.Invalidate();
            }
            //Бутон за промяна на цвета на фигурата
            if (DrawButtonClick.Checked) {
                try {
                    if (Convert.ToInt32(RTextBox.Text) < 0 || Convert.ToInt32(RTextBox.Text) > 255) {
                        RTextBox.Text = "0";
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255");
                    } else if (Convert.ToInt32(GTextBox.Text) < 0 || Convert.ToInt32(GTextBox.Text) > 255) {
                        GTextBox.Text = "0";
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255");
                    } else if (Convert.ToInt32(BTextBox.Text) < 0 || Convert.ToInt32(BTextBox.Text) > 255) {  
                        BTextBox.Text = "0";
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255");
                    } else {
                        dialogProcessor.Selection = dialogProcessor.RGB(e.Location, Convert.ToInt32(RTextBox.Text), Convert.ToInt32(GTextBox.Text), Convert.ToInt32(BTextBox.Text));
                        viewPort.Invalidate();
                    }
                } catch {
                    RTextBox.Text = "0";
                    GTextBox.Text = "0";
                    BTextBox.Text = "0";
                    MessageBox.Show("You entered an invalid number, enter a number from 0 to 255");
                }
            }
            //Бутон за копиране на фигура
            if (DrawCopyShape.Checked) {
                dialogProcessor.Selection = dialogProcessor.Copy(e.Location);
                viewPort.Invalidate();
            }
            //Бутон за промяна на цвета на линията на фигурата
            if (DrawLineButton.Checked) {
                try {
                    if (Convert.ToInt32(RLTextBox.Text) < 0 || Convert.ToInt32(RLTextBox.Text) > 255 || Convert.ToInt32(LineTextBox.Text) < 0 || Convert.ToInt32(LineTextBox.Text) > 30) {
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255 and width line from 0 to 30");
                        RLTextBox.Text = "0";
                        LineTextBox.Text = "0";
                    } else if (Convert.ToInt32(GLTextBox.Text) < 0 || Convert.ToInt32(GLTextBox.Text) > 255 || Convert.ToInt32(LineTextBox.Text) < 0 || Convert.ToInt32(LineTextBox.Text) > 30) {
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255 and width line from 0 to 30");
                        GLTextBox.Text = "0";
                        LineTextBox.Text = "0";
                    } else if (Convert.ToInt32(BLTextBox.Text) < 0 || Convert.ToInt32(BLTextBox.Text) > 255 || Convert.ToInt32(LineTextBox.Text) < 0 || Convert.ToInt32(LineTextBox.Text) > 30) {
                        MessageBox.Show("You entered an invalid number, enter a number from 0 to 255 and width line from 0 to 30");
                        BLTextBox.Text = "0";
                        LineTextBox.Text = "0";
                    } else {
                        dialogProcessor.Selection = dialogProcessor.LineChange(e.Location, Convert.ToInt32(LineTextBox.Text), Convert.ToInt32(RLTextBox.Text), Convert.ToInt32(GLTextBox.Text), Convert.ToInt32(BLTextBox.Text));
                        viewPort.Invalidate();
                    }
                } catch {
                    LineTextBox.Text = "0";
                    RLTextBox.Text = "0";
                    GLTextBox.Text = "0";
                    BLTextBox.Text = "0";
                    MessageBox.Show("You entered an invalid number, enter a number from 0 to 255 and width line from 0 to 30");
                }
            }
            //Бутон за добавяне на фигура към група
            if (AddShapeButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.AddGroupe(e.Location, FirstTextBox.Text);
                viewPort.Invalidate();
            }
            //Бутон за изтриване на фигура от група
            if (DeleteShapeButton.Checked) {
                dialogProcessor.Selection = dialogProcessor.DeleteGroupe(e.Location, FirstTextBox.Text);
                viewPort.Invalidate();
            }
        }

        private void ViewPortMouseMove(object sender, MouseEventArgs e) {
            if (dialogProcessor.IsDragging) {
                if (dialogProcessor.Selection != null)
                    dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
        }

        private void ViewPortMouseUp(object sender, MouseEventArgs e) {
            dialogProcessor.IsDragging = false;
        }
        //Бутон за създателя
        private void AbouteClick(object sender, EventArgs e) {
            MessageBox.Show("This work was made in 2020, its creator is Denis Repyev.\nIts faculty number is 1801321108.");
        }
        //Бутон за създаване на група
        private void CreateGroupeButton_Click(object sender, EventArgs e) {
            if (FirstTextBox.Text == "") {
                MessageBox.Show("Please enter the group name");
            } else {
                ListBox.Items.Add(FirstTextBox.Text);
                viewPort.Invalidate();
            }
        }
        //Бутон за изтриване на група
        private void RemoveGroupeButton_Click(object sender, EventArgs e) {
            if (FirstTextBox.Text == "")
                MessageBox.Show("Please enter the group name");
            else {
                dialogProcessor.Selection = dialogProcessor.RemoveGroupe(FirstTextBox.Text);
                ListBox.Items.Remove(FirstTextBox.Text);
                FirstTextBox.Text = null;
                viewPort.Invalidate();
            }
        }

        
    }
}
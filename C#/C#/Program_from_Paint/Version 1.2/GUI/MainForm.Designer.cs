namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawPolygonSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawMoveButton = new System.Windows.Forms.ToolStripButton();
            this.DrawDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.DrawCopyShape = new System.Windows.Forms.ToolStripButton();
            this.DrawPlusButton = new System.Windows.Forms.ToolStripButton();
            this.DrawMinusButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Palette = new System.Windows.Forms.ToolStripSplitButton();
            this.LineTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.RLTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.GLTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.BLTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DrawLineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.RTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.GTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.BTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DrawButtonClick = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.CreateGroupeButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveGroupeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FirstTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.AddShapeButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteShapeButton = new System.Windows.Forms.ToolStripButton();
            this.DrawNewSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedMenu
            // 
            this.speedMenu.AllowDrop = true;
            this.speedMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedMenu.AutoSize = false;
            this.speedMenu.BackColor = System.Drawing.Color.White;
            this.speedMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.speedMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.speedMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.drawRectangleSpeedButton,
            this.DrawCircleSpeedButton,
            this.DrawPolygonSpeedButton,
            this.DrawLineSpeedButton,
            this.DrawNewSpeedButton,
            this.toolStripSeparator5,
            this.pickUpSpeedButton,
            this.DrawMoveButton,
            this.DrawDeleteButton,
            this.DrawCopyShape,
            this.DrawPlusButton,
            this.DrawMinusButton,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.Palette,
            this.DrawLineButton,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.DrawButtonClick,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.CreateGroupeButton,
            this.RemoveGroupeButton,
            this.toolStripButton1,
            this.FirstTextBox,
            this.AddShapeButton,
            this.DeleteShapeButton});
            this.speedMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.speedMenu.Location = new System.Drawing.Point(-1, 2);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.speedMenu.Size = new System.Drawing.Size(899, 28);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.White;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(24, 25);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.ToolTipText = "Draw rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // DrawCircleSpeedButton
            // 
            this.DrawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawCircleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawCircleSpeedButton.Image")));
            this.DrawCircleSpeedButton.ImageTransparentColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawCircleSpeedButton.Name = "DrawCircleSpeedButton";
            this.DrawCircleSpeedButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawCircleSpeedButton.Size = new System.Drawing.Size(24, 25);
            this.DrawCircleSpeedButton.Text = "DrawCircleButton";
            this.DrawCircleSpeedButton.ToolTipText = "Draw circle";
            this.DrawCircleSpeedButton.Click += new System.EventHandler(this.DrawCircleSpeedButtonClick);
            // 
            // DrawPolygonSpeedButton
            // 
            this.DrawPolygonSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawPolygonSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawPolygonSpeedButton.Image")));
            this.DrawPolygonSpeedButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawPolygonSpeedButton.Name = "DrawPolygonSpeedButton";
            this.DrawPolygonSpeedButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawPolygonSpeedButton.Size = new System.Drawing.Size(24, 25);
            this.DrawPolygonSpeedButton.Text = "DrawPolygonButton";
            this.DrawPolygonSpeedButton.ToolTipText = "Draw polygon";
            this.DrawPolygonSpeedButton.Click += new System.EventHandler(this.DrawPolygonSpeedButtonClick);
            // 
            // DrawLineSpeedButton
            // 
            this.DrawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineSpeedButton.Image")));
            this.DrawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawLineSpeedButton.Name = "DrawLineSpeedButton";
            this.DrawLineSpeedButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawLineSpeedButton.Size = new System.Drawing.Size(24, 25);
            this.DrawLineSpeedButton.Text = "DrawLineButton";
            this.DrawLineSpeedButton.ToolTipText = "Draw line";
            this.DrawLineSpeedButton.Click += new System.EventHandler(this.DrawLineSpeedButtonClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.White;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.pickUpSpeedButton.Size = new System.Drawing.Size(24, 25);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.ToolTipText = "Select shape";
            // 
            // DrawMoveButton
            // 
            this.DrawMoveButton.CheckOnClick = true;
            this.DrawMoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawMoveButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawMoveButton.Image")));
            this.DrawMoveButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawMoveButton.Name = "DrawMoveButton";
            this.DrawMoveButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawMoveButton.Size = new System.Drawing.Size(24, 25);
            this.DrawMoveButton.Text = "toolStripButton3";
            this.DrawMoveButton.ToolTipText = "Move shape";
            // 
            // DrawDeleteButton
            // 
            this.DrawDeleteButton.CheckOnClick = true;
            this.DrawDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawDeleteButton.Image")));
            this.DrawDeleteButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawDeleteButton.Name = "DrawDeleteButton";
            this.DrawDeleteButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawDeleteButton.Size = new System.Drawing.Size(24, 25);
            this.DrawDeleteButton.Text = "toolStripButton2";
            this.DrawDeleteButton.ToolTipText = "Remove shape";
            // 
            // DrawCopyShape
            // 
            this.DrawCopyShape.CheckOnClick = true;
            this.DrawCopyShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawCopyShape.Image = ((System.Drawing.Image)(resources.GetObject("DrawCopyShape.Image")));
            this.DrawCopyShape.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawCopyShape.Name = "DrawCopyShape";
            this.DrawCopyShape.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawCopyShape.Size = new System.Drawing.Size(24, 25);
            this.DrawCopyShape.Text = "DrawCopyShape";
            this.DrawCopyShape.ToolTipText = "Copy shape";
            // 
            // DrawPlusButton
            // 
            this.DrawPlusButton.CheckOnClick = true;
            this.DrawPlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawPlusButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawPlusButton.Image")));
            this.DrawPlusButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawPlusButton.Name = "DrawPlusButton";
            this.DrawPlusButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawPlusButton.Size = new System.Drawing.Size(24, 25);
            this.DrawPlusButton.Text = "toolStripButton2";
            this.DrawPlusButton.ToolTipText = "Shape plus scaling";
            // 
            // DrawMinusButton
            // 
            this.DrawMinusButton.CheckOnClick = true;
            this.DrawMinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawMinusButton.Image")));
            this.DrawMinusButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawMinusButton.Name = "DrawMinusButton";
            this.DrawMinusButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawMinusButton.Size = new System.Drawing.Size(24, 25);
            this.DrawMinusButton.Text = "toolStripButton3";
            this.DrawMinusButton.ToolTipText = "Shape minus scaling";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.BackColor = System.Drawing.Color.Gray;
            this.toolStripLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 20);
            this.toolStripLabel2.Text = "Color line";
            this.toolStripLabel2.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // Palette
            // 
            this.Palette.AutoSize = false;
            this.Palette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Palette.DropDownButtonWidth = 12;
            this.Palette.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineTextBox,
            this.RLTextBox,
            this.GLTextBox,
            this.BLTextBox});
            this.Palette.Image = ((System.Drawing.Image)(resources.GetObject("Palette.Image")));
            this.Palette.ImageTransparentColor = System.Drawing.Color.White;
            this.Palette.Name = "Palette";
            this.Palette.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Palette.Size = new System.Drawing.Size(37, 37);
            this.Palette.Text = "toolStripSplitButton1";
            this.Palette.ToolTipText = "Palette line";
            // 
            // LineTextBox
            // 
            this.LineTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.LineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineTextBox.Name = "LineTextBox";
            this.LineTextBox.Size = new System.Drawing.Size(40, 16);
            this.LineTextBox.Text = "0";
            this.LineTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RLTextBox
            // 
            this.RLTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RLTextBox.Name = "RLTextBox";
            this.RLTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RLTextBox.Size = new System.Drawing.Size(40, 16);
            this.RLTextBox.Text = "0";
            this.RLTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RLTextBox.ToolTipText = "Red color (0-255)";
            // 
            // GLTextBox
            // 
            this.GLTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GLTextBox.Name = "GLTextBox";
            this.GLTextBox.Size = new System.Drawing.Size(40, 16);
            this.GLTextBox.Text = "0";
            this.GLTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GLTextBox.ToolTipText = "Green color (0-255)";
            // 
            // BLTextBox
            // 
            this.BLTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BLTextBox.Name = "BLTextBox";
            this.BLTextBox.Size = new System.Drawing.Size(40, 16);
            this.BLTextBox.Text = "0";
            this.BLTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BLTextBox.ToolTipText = "Blue color (0-255)";
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.CheckOnClick = true;
            this.DrawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineButton.Image")));
            this.DrawLineButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawLineButton.Size = new System.Drawing.Size(24, 25);
            this.DrawLineButton.Text = "DrawButton";
            this.DrawLineButton.ToolTipText = "Change line color shape";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 20);
            this.toolStripLabel1.Text = "Color shape";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 12;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RTextBox,
            this.GTextBox,
            this.BTextBox});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(37, 37);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "Palette";
            // 
            // RTextBox
            // 
            this.RTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTextBox.Size = new System.Drawing.Size(40, 16);
            this.RTextBox.Text = "0";
            this.RTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RTextBox.ToolTipText = "Red color (0-255)";
            // 
            // GTextBox
            // 
            this.GTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(40, 16);
            this.GTextBox.Text = "0";
            this.GTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GTextBox.ToolTipText = "Green color (0-255)";
            // 
            // BTextBox
            // 
            this.BTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(40, 16);
            this.BTextBox.Text = "0";
            this.BTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTextBox.ToolTipText = "Blue color (0-255)";
            // 
            // DrawButtonClick
            // 
            this.DrawButtonClick.CheckOnClick = true;
            this.DrawButtonClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawButtonClick.Image = ((System.Drawing.Image)(resources.GetObject("DrawButtonClick.Image")));
            this.DrawButtonClick.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawButtonClick.Name = "DrawButtonClick";
            this.DrawButtonClick.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawButtonClick.Size = new System.Drawing.Size(24, 25);
            this.DrawButtonClick.Text = "DrawButton";
            this.DrawButtonClick.ToolTipText = "Change color shape";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Enabled = false;
            this.toolStripLabel3.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel3.Size = new System.Drawing.Size(40, 25);
            this.toolStripLabel3.Text = "Groupe";
            this.toolStripLabel3.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // CreateGroupeButton
            // 
            this.CreateGroupeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateGroupeButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateGroupeButton.Image")));
            this.CreateGroupeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.CreateGroupeButton.Name = "CreateGroupeButton";
            this.CreateGroupeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.CreateGroupeButton.Size = new System.Drawing.Size(24, 25);
            this.CreateGroupeButton.Text = "toolStripButton2";
            this.CreateGroupeButton.ToolTipText = "Create groupe";
            this.CreateGroupeButton.Click += new System.EventHandler(this.CreateGroupeButton_Click);
            // 
            // RemoveGroupeButton
            // 
            this.RemoveGroupeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveGroupeButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveGroupeButton.Image")));
            this.RemoveGroupeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.RemoveGroupeButton.Name = "RemoveGroupeButton";
            this.RemoveGroupeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.RemoveGroupeButton.Size = new System.Drawing.Size(24, 25);
            this.RemoveGroupeButton.Text = "toolStripButton3";
            this.RemoveGroupeButton.ToolTipText = "Remove groupe";
            this.RemoveGroupeButton.Click += new System.EventHandler(this.RemoveGroupeButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton1.Text = "Aboute";
            this.toolStripButton1.Click += new System.EventHandler(this.AbouteClick);
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.AutoSize = false;
            this.FirstTextBox.BackColor = System.Drawing.Color.Gray;
            this.FirstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.FirstTextBox.Size = new System.Drawing.Size(70, 20);
            this.FirstTextBox.ToolTipText = "Name groupe";
            // 
            // AddShapeButton
            // 
            this.AddShapeButton.CheckOnClick = true;
            this.AddShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("AddShapeButton.Image")));
            this.AddShapeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.AddShapeButton.Name = "AddShapeButton";
            this.AddShapeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.AddShapeButton.Size = new System.Drawing.Size(24, 25);
            this.AddShapeButton.Text = "toolStripButton4";
            this.AddShapeButton.ToolTipText = "Add shape in groupe";
            // 
            // DeleteShapeButton
            // 
            this.DeleteShapeButton.CheckOnClick = true;
            this.DeleteShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteShapeButton.Image")));
            this.DeleteShapeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DeleteShapeButton.Name = "DeleteShapeButton";
            this.DeleteShapeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DeleteShapeButton.Size = new System.Drawing.Size(24, 25);
            this.DeleteShapeButton.Text = "toolStripButton2";
            this.DeleteShapeButton.ToolTipText = "Delete shape in groupe";
            // 
            // DrawNewSpeedButton
            // 
            this.DrawNewSpeedButton.BackColor = System.Drawing.Color.DimGray;
            this.DrawNewSpeedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrawNewSpeedButton.CheckOnClick = true;
            this.DrawNewSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrawNewSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawNewSpeedButton.Image")));
            this.DrawNewSpeedButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DrawNewSpeedButton.Name = "DrawNewSpeedButton";
            this.DrawNewSpeedButton.Size = new System.Drawing.Size(34, 25);
            this.DrawNewSpeedButton.Text = "New";
            this.DrawNewSpeedButton.ToolTipText = "New";
            this.DrawNewSpeedButton.Click += new System.EventHandler(this.DrawNewSpeedButtonClick);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.Gray;
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(753, 2);
            this.ListBox.Name = "ListBox";
            this.ListBox.ScrollAlwaysVisible = true;
            this.ListBox.Size = new System.Drawing.Size(113, 28);
            this.ListBox.TabIndex = 6;
            // 
            // viewPort
            // 
            this.viewPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPort.AutoScroll = true;
            this.viewPort.BackColor = System.Drawing.Color.Silver;
            this.viewPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPort.Location = new System.Drawing.Point(-1, 36);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(899, 572);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(898, 612);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CreateLine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.ToolStrip speedMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawCircleSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawPolygonSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawLineSpeedButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawMoveButton;
        private System.Windows.Forms.ToolStripButton DrawDeleteButton;
        private System.Windows.Forms.ToolStripButton DrawCopyShape;
        private System.Windows.Forms.ToolStripButton DrawPlusButton;
        private System.Windows.Forms.ToolStripButton DrawMinusButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSplitButton Palette;
        private System.Windows.Forms.ToolStripTextBox LineTextBox;
        private System.Windows.Forms.ToolStripTextBox RLTextBox;
        private System.Windows.Forms.ToolStripTextBox GLTextBox;
        private System.Windows.Forms.ToolStripTextBox BLTextBox;
        private System.Windows.Forms.ToolStripButton DrawLineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripTextBox RTextBox;
        private System.Windows.Forms.ToolStripTextBox GTextBox;
        private System.Windows.Forms.ToolStripTextBox BTextBox;
        private System.Windows.Forms.ToolStripButton DrawButtonClick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DoubleBufferedPanel viewPort;
        private System.Windows.Forms.ToolStripButton CreateGroupeButton;
        private System.Windows.Forms.ToolStripButton RemoveGroupeButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox FirstTextBox;
        private System.Windows.Forms.ToolStripButton AddShapeButton;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ToolStripButton DeleteShapeButton;
        private System.Windows.Forms.ToolStripButton DrawNewSpeedButton;
    }
}

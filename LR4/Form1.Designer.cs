namespace LR4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dottedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereDrawTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dottedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(0, 28);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(779, 662);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.glControl1_KeyPress);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.fileToolStripMenuItem.Text = " Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twoDToolStripMenuItem,
            this.threeDToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // twoDToolStripMenuItem
            // 
            this.twoDToolStripMenuItem.Checked = true;
            this.twoDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.twoDToolStripMenuItem.Name = "twoDToolStripMenuItem";
            this.twoDToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.twoDToolStripMenuItem.Text = "2D";
            this.twoDToolStripMenuItem.Click += new System.EventHandler(this.twoDToolStripMenuItem_Click);
            // 
            // threeDToolStripMenuItem
            // 
            this.threeDToolStripMenuItem.Name = "threeDToolStripMenuItem";
            this.threeDToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.threeDToolStripMenuItem.Text = "3D";
            this.threeDToolStripMenuItem.Click += new System.EventHandler(this.threeDToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.objectsColorToolStripMenuItem,
            this.lineTypeToolStripMenuItem,
            this.lineWidthToolStripMenuItem,
            this.sphereDrawTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.editToolStripMenuItem.Text = "Редактирование";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.backgroundColorToolStripMenuItem.Text = "Цвет фона";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // objectsColorToolStripMenuItem
            // 
            this.objectsColorToolStripMenuItem.Name = "objectsColorToolStripMenuItem";
            this.objectsColorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.objectsColorToolStripMenuItem.Text = "Цвет линий";
            this.objectsColorToolStripMenuItem.Click += new System.EventHandler(this.objectsColorToolStripMenuItem_Click);
            // 
            // lineTypeToolStripMenuItem
            // 
            this.lineTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dottedToolStripMenuItem});
            this.lineTypeToolStripMenuItem.Name = "lineTypeToolStripMenuItem";
            this.lineTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.lineTypeToolStripMenuItem.Text = "Тип линий";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Checked = true;
            this.solidToolStripMenuItem.CheckOnClick = true;
            this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.solidToolStripMenuItem.Text = "Сплошная";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dottedToolStripMenuItem
            // 
            this.dottedToolStripMenuItem.Name = "dottedToolStripMenuItem";
            this.dottedToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.dottedToolStripMenuItem.Text = "Пунктирная";
            this.dottedToolStripMenuItem.Click += new System.EventHandler(this.dottedToolStripMenuItem_Click);
            // 
            // lineWidthToolStripMenuItem
            // 
            this.lineWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.twoToolStripMenuItem,
            this.threeToolStripMenuItem});
            this.lineWidthToolStripMenuItem.Name = "lineWidthToolStripMenuItem";
            this.lineWidthToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.lineWidthToolStripMenuItem.Text = "Толшина линий";
            // 
            // oneToolStripMenuItem
            // 
            this.oneToolStripMenuItem.Checked = true;
            this.oneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
            this.oneToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.oneToolStripMenuItem.Text = "1 px";
            this.oneToolStripMenuItem.Click += new System.EventHandler(this.oneToolStripMenuItem_Click);
            // 
            // twoToolStripMenuItem
            // 
            this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
            this.twoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.twoToolStripMenuItem.Text = "2 px";
            this.twoToolStripMenuItem.Click += new System.EventHandler(this.twoToolStripMenuItem_Click);
            // 
            // threeToolStripMenuItem
            // 
            this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
            this.threeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.threeToolStripMenuItem.Text = "3 px";
            this.threeToolStripMenuItem.Click += new System.EventHandler(this.threeToolStripMenuItem_Click);
            // 
            // sphereDrawTypeToolStripMenuItem
            // 
            this.sphereDrawTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.wiredToolStripMenuItem,
            this.dottedToolStripMenuItem1});
            this.sphereDrawTypeToolStripMenuItem.Name = "sphereDrawTypeToolStripMenuItem";
            this.sphereDrawTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.sphereDrawTypeToolStripMenuItem.Text = "Вид сферы";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Checked = true;
            this.solidToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.solidToolStripMenuItem1.Text = "Сплошная";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
            // 
            // wiredToolStripMenuItem
            // 
            this.wiredToolStripMenuItem.Name = "wiredToolStripMenuItem";
            this.wiredToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.wiredToolStripMenuItem.Text = "Каркасная";
            this.wiredToolStripMenuItem.Click += new System.EventHandler(this.wiredToolStripMenuItem_Click);
            // 
            // dottedToolStripMenuItem1
            // 
            this.dottedToolStripMenuItem1.Name = "dottedToolStripMenuItem1";
            this.dottedToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dottedToolStripMenuItem1.Text = "Точечная";
            this.dottedToolStripMenuItem1.Click += new System.EventHandler(this.dottedToolStripMenuItem1_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode1ToolStripMenuItem,
            this.mode2ToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.modeToolStripMenuItem.Text = "Режим";
            // 
            // mode1ToolStripMenuItem
            // 
            this.mode1ToolStripMenuItem.Checked = true;
            this.mode1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mode1ToolStripMenuItem.Name = "mode1ToolStripMenuItem";
            this.mode1ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.mode1ToolStripMenuItem.Text = "Добавление";
            this.mode1ToolStripMenuItem.Click += new System.EventHandler(this.mode1ToolStripMenuItem_Click);
            // 
            // mode2ToolStripMenuItem
            // 
            this.mode2ToolStripMenuItem.Name = "mode2ToolStripMenuItem";
            this.mode2ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.mode2ToolStripMenuItem.Text = "Редактирование";
            this.mode2ToolStripMenuItem.Click += new System.EventHandler(this.mode2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(661, 605);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereDrawTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wiredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem1;
    }
}


namespace Lesson7
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSavePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuCascad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTools,
            this.menuColor,
            this.menuWindow});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(800, 24);
            this.menuGeneral.TabIndex = 1;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewPicture,
            this.menuOpenPicture,
            this.menuSavePicture});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuNewPicture
            // 
            this.menuNewPicture.Name = "menuNewPicture";
            this.menuNewPicture.Size = new System.Drawing.Size(210, 22);
            this.menuNewPicture.Text = "Новое полотно";
            this.menuNewPicture.Click += new System.EventHandler(this.menuNewPicture_Click);
            // 
            // menuOpenPicture
            // 
            this.menuOpenPicture.Name = "menuOpenPicture";
            this.menuOpenPicture.Size = new System.Drawing.Size(210, 22);
            this.menuOpenPicture.Text = "Открыть изображение";
            this.menuOpenPicture.Click += new System.EventHandler(this.menuOpenPicture_Click);
            // 
            // menuSavePicture
            // 
            this.menuSavePicture.Name = "menuSavePicture";
            this.menuSavePicture.Size = new System.Drawing.Size(210, 22);
            this.menuSavePicture.Text = "Сохранить изображение";
            this.menuSavePicture.Click += new System.EventHandler(this.menuSavePicture_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(86, 20);
            this.menuTools.Text = "Инструмент";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Линии в центр";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Квадратики";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Треугольники";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(45, 20);
            this.menuColor.Text = "Цвет";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascad,
            this.menuVertical,
            this.menuHorizontal,
            this.menuIcons});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(48, 20);
            this.menuWindow.Text = "Окно";
            // 
            // menuCascad
            // 
            this.menuCascad.Name = "menuCascad";
            this.menuCascad.Size = new System.Drawing.Size(180, 22);
            this.menuCascad.Text = "Каскад";
            this.menuCascad.Click += new System.EventHandler(this.menuCascad_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(180, 22);
            this.menuVertical.Text = "Вертикально";
            this.menuVertical.Click += new System.EventHandler(this.menuVertical_Click);
            // 
            // menuHorizontal
            // 
            this.menuHorizontal.Name = "menuHorizontal";
            this.menuHorizontal.Size = new System.Drawing.Size(180, 22);
            this.menuHorizontal.Text = "Горизонтально";
            this.menuHorizontal.Click += new System.EventHandler(this.menuHorizontal_Click);
            // 
            // menuIcons
            // 
            this.menuIcons.Name = "menuIcons";
            this.menuIcons.Size = new System.Drawing.Size(180, 22);
            this.menuIcons.Text = "Иконки";
            this.menuIcons.Click += new System.EventHandler(this.menuIcons_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "MainForm";
            this.Text = "Графический редактор \"Художник 2.0\"";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuGeneral;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuTools;
        private ToolStripMenuItem menuColor;
        private ToolStripMenuItem menuWindow;
        private ColorDialog colorDialog;
        private ToolStripMenuItem menuNewPicture;
        private ToolStripMenuItem menuOpenPicture;
        private ToolStripMenuItem menuSavePicture;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem menuCascad;
        private ToolStripMenuItem menuVertical;
        private ToolStripMenuItem menuHorizontal;
        private ToolStripMenuItem menuIcons;
    }
}
namespace IRF_Beadando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leolvasásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törzsadatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.épületToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leolvasásiHelyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vízóraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vízóraTipusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.műszakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkakörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.belépésiJogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szervízToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jelszóMódosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leolvasásToolStripMenuItem,
            this.törzsadatokToolStripMenuItem,
            this.szervízToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leolvasásToolStripMenuItem
            // 
            this.leolvasásToolStripMenuItem.Name = "leolvasásToolStripMenuItem";
            this.leolvasásToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.leolvasásToolStripMenuItem.Text = "Leolvasás";
            // 
            // törzsadatokToolStripMenuItem
            // 
            this.törzsadatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolgozóToolStripMenuItem,
            this.épületToolStripMenuItem,
            this.leolvasásiHelyToolStripMenuItem,
            this.vízóraToolStripMenuItem,
            this.vízóraTipusToolStripMenuItem,
            this.műszakToolStripMenuItem,
            this.munkakörToolStripMenuItem,
            this.toolStripSeparator1,
            this.belépésiJogToolStripMenuItem});
            this.törzsadatokToolStripMenuItem.Name = "törzsadatokToolStripMenuItem";
            this.törzsadatokToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.törzsadatokToolStripMenuItem.Text = "Törzsadatok";
            // 
            // dolgozóToolStripMenuItem
            // 
            this.dolgozóToolStripMenuItem.Name = "dolgozóToolStripMenuItem";
            this.dolgozóToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dolgozóToolStripMenuItem.Text = "Dolgozó";
            this.dolgozóToolStripMenuItem.Click += new System.EventHandler(this.DolgozóToolStripMenuItem_Click);
            // 
            // épületToolStripMenuItem
            // 
            this.épületToolStripMenuItem.Name = "épületToolStripMenuItem";
            this.épületToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.épületToolStripMenuItem.Text = "Épület";
            // 
            // leolvasásiHelyToolStripMenuItem
            // 
            this.leolvasásiHelyToolStripMenuItem.Name = "leolvasásiHelyToolStripMenuItem";
            this.leolvasásiHelyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.leolvasásiHelyToolStripMenuItem.Text = "Leolvasási hely";
            // 
            // vízóraToolStripMenuItem
            // 
            this.vízóraToolStripMenuItem.Name = "vízóraToolStripMenuItem";
            this.vízóraToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.vízóraToolStripMenuItem.Text = "Vízóra";
            // 
            // vízóraTipusToolStripMenuItem
            // 
            this.vízóraTipusToolStripMenuItem.Name = "vízóraTipusToolStripMenuItem";
            this.vízóraTipusToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.vízóraTipusToolStripMenuItem.Text = "Vízóra típus";
            // 
            // műszakToolStripMenuItem
            // 
            this.műszakToolStripMenuItem.Name = "műszakToolStripMenuItem";
            this.műszakToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.műszakToolStripMenuItem.Text = "Műszak";
            // 
            // munkakörToolStripMenuItem
            // 
            this.munkakörToolStripMenuItem.Name = "munkakörToolStripMenuItem";
            this.munkakörToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.munkakörToolStripMenuItem.Text = "Munkakör";
            this.munkakörToolStripMenuItem.Click += new System.EventHandler(this.MunkakörToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // belépésiJogToolStripMenuItem
            // 
            this.belépésiJogToolStripMenuItem.Name = "belépésiJogToolStripMenuItem";
            this.belépésiJogToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.belépésiJogToolStripMenuItem.Text = "Belépési jog";
            // 
            // szervízToolStripMenuItem
            // 
            this.szervízToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jelszóMódosításToolStripMenuItem});
            this.szervízToolStripMenuItem.Name = "szervízToolStripMenuItem";
            this.szervízToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.szervízToolStripMenuItem.Text = "Szerviz";
            // 
            // jelszóMódosításToolStripMenuItem
            // 
            this.jelszóMódosításToolStripMenuItem.Name = "jelszóMódosításToolStripMenuItem";
            this.jelszóMódosításToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.jelszóMódosításToolStripMenuItem.Text = "Jelszó módosítás";
            this.jelszóMódosításToolStripMenuItem.Click += new System.EventHandler(this.JelszóMódosításToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 403);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 136);
            this.label1.TabIndex = 2;
            this.label1.Text = "Munkaidő nyilvántartó program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(621, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 136);
            this.label2.TabIndex = 3;
            this.label2.Text = "Készítette: Csatári Gergely TKTEGJ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TKTEGJ - Vízóra Leolvasó";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leolvasásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törzsadatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szervízToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolgozóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem épületToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leolvasásiHelyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vízóraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vízóraTipusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem műszakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkakörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jelszóMódosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belépésiJogToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


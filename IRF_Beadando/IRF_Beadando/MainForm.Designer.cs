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
            this.MunkavegzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törzsadatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkakörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tevékenységToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szervízToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jelszóMódosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MunkavegzesToolStripMenuItem,
            this.törzsadatokToolStripMenuItem,
            this.szervízToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MunkavegzesToolStripMenuItem
            // 
            this.MunkavegzesToolStripMenuItem.Name = "MunkavegzesToolStripMenuItem";
            this.MunkavegzesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.MunkavegzesToolStripMenuItem.Text = "Munkavégzés";
            this.MunkavegzesToolStripMenuItem.Click += new System.EventHandler(this.MunkavegzesToolStripMenuItem_Click);
            // 
            // törzsadatokToolStripMenuItem
            // 
            this.törzsadatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolgozóToolStripMenuItem,
            this.munkakörToolStripMenuItem,
            this.toolStripSeparator1,
            this.tevékenységToolStripMenuItem});
            this.törzsadatokToolStripMenuItem.Name = "törzsadatokToolStripMenuItem";
            this.törzsadatokToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.törzsadatokToolStripMenuItem.Text = "Törzsadatok";
            // 
            // dolgozóToolStripMenuItem
            // 
            this.dolgozóToolStripMenuItem.Name = "dolgozóToolStripMenuItem";
            this.dolgozóToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dolgozóToolStripMenuItem.Text = "Dolgozó";
            this.dolgozóToolStripMenuItem.Click += new System.EventHandler(this.DolgozóToolStripMenuItem_Click);
            // 
            // munkakörToolStripMenuItem
            // 
            this.munkakörToolStripMenuItem.Name = "munkakörToolStripMenuItem";
            this.munkakörToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.munkakörToolStripMenuItem.Text = "Munkakör";
            this.munkakörToolStripMenuItem.Click += new System.EventHandler(this.MunkakörToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // tevékenységToolStripMenuItem
            // 
            this.tevékenységToolStripMenuItem.Name = "tevékenységToolStripMenuItem";
            this.tevékenységToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tevékenységToolStripMenuItem.Text = "Tevékenység";
            this.tevékenységToolStripMenuItem.Click += new System.EventHandler(this.TevékenységToolStripMenuItem_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MunkavegzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törzsadatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szervízToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolgozóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkakörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jelszóMódosításToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tevékenységToolStripMenuItem;
    }
}


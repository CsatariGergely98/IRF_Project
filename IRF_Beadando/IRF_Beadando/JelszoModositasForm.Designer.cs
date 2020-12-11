namespace IRF_Beadando
{
    partial class JelszoModositasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JelszoModositasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regijelszotb = new System.Windows.Forms.TextBox();
            this.ujjelszotb = new System.Windows.Forms.TextBox();
            this.ujjelszotb2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jelszolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új jelszó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Új jelszó mégegyszer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Régi jelszó";
            // 
            // regijelszotb
            // 
            this.regijelszotb.Location = new System.Drawing.Point(174, 38);
            this.regijelszotb.Name = "regijelszotb";
            this.regijelszotb.PasswordChar = '*';
            this.regijelszotb.Size = new System.Drawing.Size(176, 20);
            this.regijelszotb.TabIndex = 3;
            // 
            // ujjelszotb
            // 
            this.ujjelszotb.Location = new System.Drawing.Point(174, 84);
            this.ujjelszotb.Name = "ujjelszotb";
            this.ujjelszotb.PasswordChar = '*';
            this.ujjelszotb.Size = new System.Drawing.Size(176, 20);
            this.ujjelszotb.TabIndex = 4;
            this.ujjelszotb.TextChanged += new System.EventHandler(this.Ujjelszotb_TextChanged);
            this.ujjelszotb.Validating += new System.ComponentModel.CancelEventHandler(this.Ujjelszotb_Validating);
            // 
            // ujjelszotb2
            // 
            this.ujjelszotb2.Location = new System.Drawing.Point(174, 112);
            this.ujjelszotb2.Name = "ujjelszotb2";
            this.ujjelszotb2.PasswordChar = '*';
            this.ujjelszotb2.Size = new System.Drawing.Size(176, 20);
            this.ujjelszotb2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Módosít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(243, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mégsem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // jelszolabel
            // 
            this.jelszolabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.jelszolabel.ForeColor = System.Drawing.Color.Crimson;
            this.jelszolabel.Location = new System.Drawing.Point(12, 147);
            this.jelszolabel.Name = "jelszolabel";
            this.jelszolabel.Size = new System.Drawing.Size(395, 43);
            this.jelszolabel.TabIndex = 8;
            // 
            // JelszoModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 247);
            this.Controls.Add(this.jelszolabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ujjelszotb2);
            this.Controls.Add(this.ujjelszotb);
            this.Controls.Add(this.regijelszotb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JelszoModositasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelszó módosítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regijelszotb;
        private System.Windows.Forms.TextBox ujjelszotb;
        private System.Windows.Forms.TextBox ujjelszotb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label jelszolabel;
    }
}
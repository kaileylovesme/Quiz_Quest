namespace Quiz_Quest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblNoQstns = new System.Windows.Forms.Label();
            this.btnQz = new System.Windows.Forms.Button();
            this.numQuestion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(286, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(320, 200);
            this.txbxName.Multiline = true;
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(185, 30);
            this.txbxName.TabIndex = 1;
            this.txbxName.TextChanged += new System.EventHandler(this.txbxName_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(358, 135);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 57);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNoQstns
            // 
            this.lblNoQstns.AutoSize = true;
            this.lblNoQstns.BackColor = System.Drawing.Color.Transparent;
            this.lblNoQstns.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQstns.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNoQstns.Location = new System.Drawing.Point(262, 235);
            this.lblNoQstns.Name = "lblNoQstns";
            this.lblNoQstns.Size = new System.Drawing.Size(343, 57);
            this.lblNoQstns.TabIndex = 3;
            this.lblNoQstns.Text = "Number of Questions:";
            // 
            // btnQz
            // 
            this.btnQz.BackColor = System.Drawing.SystemColors.Window;
            this.btnQz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQz.Location = new System.Drawing.Point(358, 355);
            this.btnQz.Name = "btnQz";
            this.btnQz.Size = new System.Drawing.Size(107, 39);
            this.btnQz.TabIndex = 5;
            this.btnQz.Text = "Start";
            this.btnQz.UseVisualStyleBackColor = false;
            this.btnQz.Click += new System.EventHandler(this.btnQz_Click);
            // 
            // numQuestion
            // 
            this.numQuestion.Location = new System.Drawing.Point(320, 306);
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(185, 20);
            this.numQuestion.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 473);
            this.Controls.Add(this.numQuestion);
            this.Controls.Add(this.btnQz);
            this.Controls.Add(this.lblNoQstns);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txbxName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblNoQstns;
        private System.Windows.Forms.Button btnQz;
        public System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.NumericUpDown numQuestion;
    }
}


namespace Quiz_Quest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.lblEqualSymbol = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numUserAns = new System.Windows.Forms.NumericUpDown();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThankUser = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUserAns)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeUser.Location = new System.Drawing.Point(176, 46);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(144, 33);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.BackColor = System.Drawing.Color.Transparent;
            this.lblNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.ForeColor = System.Drawing.Color.White;
            this.lblNumA.Location = new System.Drawing.Point(90, 154);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(24, 25);
            this.lblNumA.TabIndex = 3;
            this.lblNumA.Text = "0";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.White;
            this.lblOperation.Location = new System.Drawing.Point(160, 154);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(24, 25);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "+";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.BackColor = System.Drawing.Color.Transparent;
            this.lblNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.ForeColor = System.Drawing.Color.White;
            this.lblNumB.Location = new System.Drawing.Point(210, 154);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(24, 25);
            this.lblNumB.TabIndex = 5;
            this.lblNumB.Text = "0";
            // 
            // lblEqualSymbol
            // 
            this.lblEqualSymbol.AutoSize = true;
            this.lblEqualSymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblEqualSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualSymbol.ForeColor = System.Drawing.Color.White;
            this.lblEqualSymbol.Location = new System.Drawing.Point(267, 154);
            this.lblEqualSymbol.Name = "lblEqualSymbol";
            this.lblEqualSymbol.Size = new System.Drawing.Size(24, 25);
            this.lblEqualSymbol.TabIndex = 6;
            this.lblEqualSymbol.Text = "=";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Location = new System.Drawing.Point(180, 100);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(244, 33);
            this.lblQuestionNumber.TabIndex = 7;
            this.lblQuestionNumber.Text = "Question Number";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(446, 149);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(87, 30);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(443, 133);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // numUserAns
            // 
            this.numUserAns.Location = new System.Drawing.Point(297, 155);
            this.numUserAns.Maximum = new decimal(new int[] {
            201,
            0,
            0,
            0});
            this.numUserAns.Name = "numUserAns";
            this.numUserAns.Size = new System.Drawing.Size(128, 20);
            this.numUserAns.TabIndex = 10;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblResultTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTitle.ForeColor = System.Drawing.Color.White;
            this.lblResultTitle.Location = new System.Drawing.Point(60, 154);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(90, 25);
            this.lblResultTitle.TabIndex = 11;
            this.lblResultTitle.Text = "Results:";
            this.lblResultTitle.Click += new System.EventHandler(this.lblResultTitle_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(159, 154);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(284, 113);
            this.rtbResults.TabIndex = 12;
            this.rtbResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // lblThankUser
            // 
            this.lblThankUser.AutoSize = true;
            this.lblThankUser.BackColor = System.Drawing.Color.Transparent;
            this.lblThankUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankUser.ForeColor = System.Drawing.Color.White;
            this.lblThankUser.Location = new System.Drawing.Point(89, 79);
            this.lblThankUser.Name = "lblThankUser";
            this.lblThankUser.Size = new System.Drawing.Size(402, 31);
            this.lblThankUser.TabIndex = 14;
            this.lblThankUser.Text = "Thankyou For Using Quiz Quest";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(215, 274);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 28);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 339);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblThankUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.numUserAns);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblEqualSymbol);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblWelcomeUser);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numUserAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label lblEqualSymbol;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numUserAns;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThankUser;
        private System.Windows.Forms.Button btnReturn;
    }
}
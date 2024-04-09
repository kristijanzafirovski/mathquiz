namespace mathquiz
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
            this.questionsLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerBtn = new System.Windows.Forms.Button();
            this.statsTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionsLb
            // 
            this.questionsLb.FormattingEnabled = true;
            this.questionsLb.Location = new System.Drawing.Point(12, 35);
            this.questionsLb.Name = "questionsLb";
            this.questionsLb.Size = new System.Drawing.Size(245, 537);
            this.questionsLb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прашања";
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(278, 35);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(213, 52);
            this.answerBtn.TabIndex = 3;
            this.answerBtn.Text = "Одговори прашање";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // statsTb
            // 
            this.statsTb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.statsTb.Enabled = false;
            this.statsTb.Location = new System.Drawing.Point(278, 123);
            this.statsTb.Multiline = true;
            this.statsTb.Name = "statsTb";
            this.statsTb.Size = new System.Drawing.Size(213, 126);
            this.statsTb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 591);
            this.Controls.Add(this.statsTb);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox questionsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.TextBox statsTb;
    }
}


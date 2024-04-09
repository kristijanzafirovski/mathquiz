namespace mathquiz
{
    partial class QuestionForm
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
            this.AnswerTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.questionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerTb
            // 
            this.AnswerTb.Location = new System.Drawing.Point(12, 141);
            this.AnswerTb.Name = "AnswerTb";
            this.AnswerTb.Size = new System.Drawing.Size(285, 20);
            this.AnswerTb.TabIndex = 0;
            this.AnswerTb.TextChanged += new System.EventHandler(this.AnswerTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Одговор";
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(12, 212);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(124, 32);
            this.AnswerBtn.TabIndex = 2;
            this.AnswerBtn.Text = "Одговори";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(219, 212);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(124, 32);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Откажи";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlabel.Location = new System.Drawing.Point(20, 47);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(220, 46);
            this.questionlabel.TabIndex = 4;
            this.questionlabel.Text = "42 + 12 = ?";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 256);
            this.Controls.Add(this.questionlabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerTb);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label questionlabel;
    }
}
namespace WindowsFormsApp8
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
            this.PRESStoSTART = new System.Windows.Forms.Button();
            this.OutA = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PRESStoSTART
            // 
            this.PRESStoSTART.BackColor = System.Drawing.Color.DarkRed;
            this.PRESStoSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRESStoSTART.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PRESStoSTART.Location = new System.Drawing.Point(553, 12);
            this.PRESStoSTART.Name = "PRESStoSTART";
            this.PRESStoSTART.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PRESStoSTART.Size = new System.Drawing.Size(235, 435);
            this.PRESStoSTART.TabIndex = 0;
            this.PRESStoSTART.Text = "PRESS TO START";
            this.PRESStoSTART.UseVisualStyleBackColor = false;
            this.PRESStoSTART.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutA
            // 
            this.OutA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutA.Location = new System.Drawing.Point(12, 12);
            this.OutA.Name = "OutA";
            this.OutA.Size = new System.Drawing.Size(535, 435);
            this.OutA.TabIndex = 1;
            this.OutA.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutA);
            this.Controls.Add(this.PRESStoSTART);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PRESStoSTART;
        private System.Windows.Forms.RichTextBox OutA;
    }
}


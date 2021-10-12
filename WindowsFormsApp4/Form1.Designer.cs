
namespace WindowsFormsApp4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioSegment = new System.Windows.Forms.RadioButton();
            this.radioPoint = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioRectangle);
            this.panel2.Controls.Add(this.radioSegment);
            this.panel2.Controls.Add(this.radioPoint);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(693, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 124);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 30);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Location = new System.Drawing.Point(2, 100);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioRectangle.TabIndex = 2;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // radioSegment
            // 
            this.radioSegment.AutoSize = true;
            this.radioSegment.Location = new System.Drawing.Point(2, 77);
            this.radioSegment.Name = "radioSegment";
            this.radioSegment.Size = new System.Drawing.Size(67, 17);
            this.radioSegment.TabIndex = 1;
            this.radioSegment.TabStop = true;
            this.radioSegment.Text = "Segment";
            this.radioSegment.UseVisualStyleBackColor = true;
            // 
            // radioPoint
            // 
            this.radioPoint.AutoSize = true;
            this.radioPoint.Location = new System.Drawing.Point(2, 54);
            this.radioPoint.Name = "radioPoint";
            this.radioPoint.Size = new System.Drawing.Size(49, 17);
            this.radioPoint.TabIndex = 0;
            this.radioPoint.TabStop = true;
            this.radioPoint.Text = "Point";
            this.radioPoint.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(24, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 30);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioSegment;
        private System.Windows.Forms.RadioButton radioPoint;
        private System.Windows.Forms.Panel panel4;
    }
}


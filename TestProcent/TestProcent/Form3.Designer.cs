
namespace TestProcent
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtj = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Процентная ставка";
            // 
            // txtj
            // 
            this.txtj.Location = new System.Drawing.Point(180, 65);
            this.txtj.Name = "txtj";
            this.txtj.Size = new System.Drawing.Size(122, 20);
            this.txtj.TabIndex = 2;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(180, 114);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(122, 20);
            this.txtm.TabIndex = 3;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(180, 171);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(122, 20);
            this.txtn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество лет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число периодов начиселния";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исходная сумма";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(180, 12);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(122, 20);
            this.txtP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Наращенная сумма";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(193, 243);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 13);
            this.lblS.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 332);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtj;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblS;
    }
}
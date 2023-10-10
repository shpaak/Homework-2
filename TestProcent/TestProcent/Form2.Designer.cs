
namespace TestProcent
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.txti = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходная сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процентная ставка в долях";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число периодов начисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Исходная сумма с процентами";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(220, 232);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 13);
            this.lblS.TabIndex = 5;
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(190, 115);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(129, 20);
            this.txti.TabIndex = 6;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(190, 181);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(129, 20);
            this.txtn.TabIndex = 7;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(190, 50);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(129, 20);
            this.txtP.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 305);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txti);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtP;
    }
}
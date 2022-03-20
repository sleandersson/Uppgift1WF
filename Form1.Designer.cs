namespace Uppgift1WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAttBetala = new System.Windows.Forms.TextBox();
            this.tbFrKund = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rTBResultat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVäxel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Totalt att betala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Erhållit från kund:";
            // 
            // tbAttBetala
            // 
            this.tbAttBetala.Location = new System.Drawing.Point(159, 21);
            this.tbAttBetala.Name = "tbAttBetala";
            this.tbAttBetala.Size = new System.Drawing.Size(100, 23);
            this.tbAttBetala.TabIndex = 2;
            // 
            // tbFrKund
            // 
            this.tbFrKund.Location = new System.Drawing.Point(159, 68);
            this.tbFrKund.Name = "tbFrKund";
            this.tbFrKund.Size = new System.Drawing.Size(100, 23);
            this.tbFrKund.TabIndex = 3;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(42, 105);
            this.lblResultat.MinimumSize = new System.Drawing.Size(42, 18);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(83, 18);
            this.lblResultat.TabIndex = 4;
            this.lblResultat.Text = "Växel till kund:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(42, 358);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 43);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Beräkna";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(159, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Avsluta";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rTBResultat
            // 
            this.rTBResultat.Location = new System.Drawing.Point(42, 126);
            this.rTBResultat.Name = "rTBResultat";
            this.rTBResultat.ReadOnly = true;
            this.rTBResultat.Size = new System.Drawing.Size(217, 211);
            this.rTBResultat.TabIndex = 7;
            this.rTBResultat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Staffan Leandersson, sleandersson@yahoo.se, L0002B, Uppgift 1 WF-variant";
            // 
            // lblVäxel
            // 
            this.lblVäxel.AutoSize = true;
            this.lblVäxel.Location = new System.Drawing.Point(131, 105);
            this.lblVäxel.Name = "lblVäxel";
            this.lblVäxel.Size = new System.Drawing.Size(0, 15);
            this.lblVäxel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 418);
            this.Controls.Add(this.lblVäxel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTBResultat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.tbFrKund);
            this.Controls.Add(this.tbAttBetala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kassa1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbAttBetala;
        private TextBox tbFrKund;
        private Label lblResultat;
        private Button btnCalculate;
        private Button btnClose;
        private RichTextBox rTBResultat;
        private Label label3;
        private Label lblVäxel;
    }
}
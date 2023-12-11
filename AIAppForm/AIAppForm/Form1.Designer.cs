namespace AIAppForm
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.heading = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInput.Location = new System.Drawing.Point(88, 134);
            this.lblInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(164, 29);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Chất đầu vào";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInput.Location = new System.Drawing.Point(417, 131);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(304, 29);
            this.txtInput.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heading.Location = new System.Drawing.Point(-2, 0);
            this.heading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1447, 82);
            this.heading.TabIndex = 2;
            this.heading.Text = "Suy diễn tiến";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOutput.Location = new System.Drawing.Point(88, 211);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(146, 29);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Chất đầu ra";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(417, 208);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(304, 32);
            this.txtOutput.TabIndex = 4;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKQ.Location = new System.Drawing.Point(88, 297);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(102, 29);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(417, 297);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(304, 121);
            this.txtKQ.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(333, 447);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(136, 35);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Điều chế";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(480, 447);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(134, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(629, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1443, 805);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "AI App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
    }
}


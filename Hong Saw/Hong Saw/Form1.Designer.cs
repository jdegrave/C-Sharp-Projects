namespace Hong_Saw
{
    partial class frmHongSaw
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
            this.lblStartNumber = new System.Windows.Forms.Label();
            this.lblEndNumber = new System.Windows.Forms.Label();
            this.textStartNumber = new System.Windows.Forms.TextBox();
            this.textEndNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblStartNumber
            // 
            this.lblStartNumber.AutoSize = true;
            this.lblStartNumber.Location = new System.Drawing.Point(27, 36);
            this.lblStartNumber.Name = "lblStartNumber";
            this.lblStartNumber.Size = new System.Drawing.Size(85, 13);
            this.lblStartNumber.TabIndex = 0;
            this.lblStartNumber.Text = "Start Number:";
            // 
            // lblEndNumber
            // 
            this.lblEndNumber.AutoSize = true;
            this.lblEndNumber.Location = new System.Drawing.Point(27, 70);
            this.lblEndNumber.Name = "lblEndNumber";
            this.lblEndNumber.Size = new System.Drawing.Size(80, 13);
            this.lblEndNumber.TabIndex = 1;
            this.lblEndNumber.Text = "End Number:";
            // 
            // textStartNumber
            // 
            this.textStartNumber.Location = new System.Drawing.Point(118, 33);
            this.textStartNumber.Name = "textStartNumber";
            this.textStartNumber.Size = new System.Drawing.Size(100, 20);
            this.textStartNumber.TabIndex = 2;
            // 
            // textEndNumber
            // 
            this.textEndNumber.Location = new System.Drawing.Point(118, 67);
            this.textEndNumber.Name = "textEndNumber";
            this.textEndNumber.Size = new System.Drawing.Size(100, 20);
            this.textEndNumber.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(248, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 56);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(30, 119);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(397, 110);
            this.textOutput.TabIndex = 7;
            this.textOutput.Text = "";
            // 
            // frmHongSaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textEndNumber);
            this.Controls.Add(this.textStartNumber);
            this.Controls.Add(this.lblEndNumber);
            this.Controls.Add(this.lblStartNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "frmHongSaw";
            this.Text = "Hong Saw Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartNumber;
        private System.Windows.Forms.Label lblEndNumber;
        private System.Windows.Forms.TextBox textStartNumber;
        private System.Windows.Forms.TextBox textEndNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox textOutput;
    }
}


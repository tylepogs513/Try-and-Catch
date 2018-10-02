namespace Try_and_Catch
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterButt = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(25, 38);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(147, 16);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Please Enter a Number";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(178, 37);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(72, 20);
            this.inputBox.TabIndex = 1;
            // 
            // enterButt
            // 
            this.enterButt.Location = new System.Drawing.Point(256, 36);
            this.enterButt.Name = "enterButt";
            this.enterButt.Size = new System.Drawing.Size(80, 20);
            this.enterButt.TabIndex = 2;
            this.enterButt.Text = "Enter";
            this.enterButt.UseVisualStyleBackColor = true;
            this.enterButt.Click += new System.EventHandler(this.enterButt_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(34, 90);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 149);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enterButt);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButt;
        private System.Windows.Forms.Label outputLabel;
    }
}


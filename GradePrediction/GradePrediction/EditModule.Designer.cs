namespace GradePrediction
{
    partial class EditModule
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
            this.moduleCodeTxt = new System.Windows.Forms.TextBox();
            this.moduleNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox40 = new System.Windows.Forms.RadioButton();
            this.checkbox20 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moduleCodeTxt
            // 
            this.moduleCodeTxt.Location = new System.Drawing.Point(195, 99);
            this.moduleCodeTxt.Name = "moduleCodeTxt";
            this.moduleCodeTxt.Size = new System.Drawing.Size(192, 20);
            this.moduleCodeTxt.TabIndex = 14;
            // 
            // moduleNameTxt
            // 
            this.moduleNameTxt.Location = new System.Drawing.Point(195, 34);
            this.moduleNameTxt.Name = "moduleNameTxt";
            this.moduleNameTxt.Size = new System.Drawing.Size(192, 20);
            this.moduleNameTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Module Credits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Module Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Module Name:";
            // 
            // checkbox40
            // 
            this.checkbox40.AutoSize = true;
            this.checkbox40.Location = new System.Drawing.Point(314, 155);
            this.checkbox40.Name = "checkbox40";
            this.checkbox40.Size = new System.Drawing.Size(37, 17);
            this.checkbox40.TabIndex = 18;
            this.checkbox40.TabStop = true;
            this.checkbox40.Text = "40";
            this.checkbox40.UseVisualStyleBackColor = true;
            // 
            // checkbox20
            // 
            this.checkbox20.AutoSize = true;
            this.checkbox20.Location = new System.Drawing.Point(220, 155);
            this.checkbox20.Name = "checkbox20";
            this.checkbox20.Size = new System.Drawing.Size(37, 17);
            this.checkbox20.TabIndex = 17;
            this.checkbox20.TabStop = true;
            this.checkbox20.Text = "20";
            this.checkbox20.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit Assessments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkbox40);
            this.Controls.Add(this.checkbox20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moduleCodeTxt);
            this.Controls.Add(this.moduleNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditModule";
            this.Text = "EditModule";
            this.Load += new System.EventHandler(this.EditModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox moduleCodeTxt;
        private System.Windows.Forms.TextBox moduleNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton checkbox40;
        private System.Windows.Forms.RadioButton checkbox20;
        private System.Windows.Forms.Button button2;
    }
}
namespace GradePrediction
{
    partial class EditAssessment
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
            this.label3 = new System.Windows.Forms.Label();
            this.addAssessmentBtn = new System.Windows.Forms.Button();
            this.assessmentNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assessmentMarkTxt = new System.Windows.Forms.NumericUpDown();
            this.assessmentWeightingTxt = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarkTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentWeightingTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Assessment Mark:";
            // 
            // addAssessmentBtn
            // 
            this.addAssessmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssessmentBtn.Location = new System.Drawing.Point(238, 167);
            this.addAssessmentBtn.Name = "addAssessmentBtn";
            this.addAssessmentBtn.Size = new System.Drawing.Size(146, 38);
            this.addAssessmentBtn.TabIndex = 11;
            this.addAssessmentBtn.Text = "Update Assessment";
            this.addAssessmentBtn.UseVisualStyleBackColor = true;
            this.addAssessmentBtn.Click += new System.EventHandler(this.addAssessmentBtn_Click);
            // 
            // assessmentNameTxt
            // 
            this.assessmentNameTxt.Location = new System.Drawing.Point(227, 41);
            this.assessmentNameTxt.Name = "assessmentNameTxt";
            this.assessmentNameTxt.Size = new System.Drawing.Size(157, 20);
            this.assessmentNameTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assessment Weighting:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Assessment Name:";
            // 
            // assessmentMarkTxt
            // 
            this.assessmentMarkTxt.Location = new System.Drawing.Point(227, 123);
            this.assessmentMarkTxt.Name = "assessmentMarkTxt";
            this.assessmentMarkTxt.Size = new System.Drawing.Size(161, 20);
            this.assessmentMarkTxt.TabIndex = 14;
            // 
            // assessmentWeightingTxt
            // 
            this.assessmentWeightingTxt.Location = new System.Drawing.Point(227, 86);
            this.assessmentWeightingTxt.Name = "assessmentWeightingTxt";
            this.assessmentWeightingTxt.Size = new System.Drawing.Size(161, 20);
            this.assessmentWeightingTxt.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 230);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.assessmentMarkTxt);
            this.Controls.Add(this.assessmentWeightingTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addAssessmentBtn);
            this.Controls.Add(this.assessmentNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAssessment";
            this.Text = "EditAssessment";
            this.Load += new System.EventHandler(this.EditAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarkTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentWeightingTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAssessmentBtn;
        private System.Windows.Forms.TextBox assessmentNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown assessmentMarkTxt;
        private System.Windows.Forms.NumericUpDown assessmentWeightingTxt;
        private System.Windows.Forms.Button button1;
    }
}
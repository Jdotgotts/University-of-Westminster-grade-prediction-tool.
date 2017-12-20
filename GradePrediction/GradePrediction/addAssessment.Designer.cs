namespace GradePrediction
{
    partial class addAssessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assessmentNameTxt = new System.Windows.Forms.TextBox();
            this.addAssessmentBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.remainWeighting = new System.Windows.Forms.Label();
            this.assessmentWeightingTxt = new System.Windows.Forms.NumericUpDown();
            this.assessmentMarkTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentWeightingTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarkTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Weighting:";
            // 
            // assessmentNameTxt
            // 
            this.assessmentNameTxt.Location = new System.Drawing.Point(229, 57);
            this.assessmentNameTxt.Name = "assessmentNameTxt";
            this.assessmentNameTxt.Size = new System.Drawing.Size(157, 20);
            this.assessmentNameTxt.TabIndex = 2;
            // 
            // addAssessmentBtn
            // 
            this.addAssessmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssessmentBtn.Location = new System.Drawing.Point(263, 177);
            this.addAssessmentBtn.Name = "addAssessmentBtn";
            this.addAssessmentBtn.Size = new System.Drawing.Size(146, 38);
            this.addAssessmentBtn.TabIndex = 4;
            this.addAssessmentBtn.Text = "Submit";
            this.addAssessmentBtn.UseVisualStyleBackColor = true;
            this.addAssessmentBtn.Click += new System.EventHandler(this.addAssessmentBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assessment Mark:";
            // 
            // remainWeighting
            // 
            this.remainWeighting.AutoSize = true;
            this.remainWeighting.Location = new System.Drawing.Point(16, 213);
            this.remainWeighting.Name = "remainWeighting";
            this.remainWeighting.Size = new System.Drawing.Size(35, 13);
            this.remainWeighting.TabIndex = 7;
            this.remainWeighting.Text = "label4";
            // 
            // assessmentWeightingTxt
            // 
            this.assessmentWeightingTxt.Location = new System.Drawing.Point(229, 100);
            this.assessmentWeightingTxt.Name = "assessmentWeightingTxt";
            this.assessmentWeightingTxt.Size = new System.Drawing.Size(161, 20);
            this.assessmentWeightingTxt.TabIndex = 8;
            // 
            // assessmentMarkTxt
            // 
            this.assessmentMarkTxt.Location = new System.Drawing.Point(229, 137);
            this.assessmentMarkTxt.Name = "assessmentMarkTxt";
            this.assessmentMarkTxt.Size = new System.Drawing.Size(161, 20);
            this.assessmentMarkTxt.TabIndex = 9;
            // 
            // addAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 262);
            this.Controls.Add(this.assessmentMarkTxt);
            this.Controls.Add(this.assessmentWeightingTxt);
            this.Controls.Add(this.remainWeighting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addAssessmentBtn);
            this.Controls.Add(this.assessmentNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addAssessment";
            this.Text = "addAssessment";
            this.Load += new System.EventHandler(this.addAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentWeightingTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarkTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assessmentNameTxt;
        private System.Windows.Forms.Button addAssessmentBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainWeighting;
        private System.Windows.Forms.NumericUpDown assessmentWeightingTxt;
        private System.Windows.Forms.NumericUpDown assessmentMarkTxt;
    }
}
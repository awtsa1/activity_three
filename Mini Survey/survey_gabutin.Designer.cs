﻿namespace WindowsFormsApplication1
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
            this.philippines = new System.Windows.Forms.CheckBox();
            this.survey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.japan = new System.Windows.Forms.CheckBox();
            this.russia = new System.Windows.Forms.CheckBox();
            this.korea = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.othersBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.othersLabel = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // philippines
            // 
            this.philippines.AutoSize = true;
            this.philippines.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philippines.Location = new System.Drawing.Point(36, 104);
            this.philippines.Name = "philippines";
            this.philippines.Size = new System.Drawing.Size(106, 22);
            this.philippines.TabIndex = 0;
            this.philippines.Text = "Philippines";
            this.philippines.UseVisualStyleBackColor = true;
            this.philippines.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Futura Maxi CG Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(167, 31);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(147, 28);
            this.survey.TabIndex = 1;
            this.survey.Text = "Mini Survey";
            this.survey.Click += new System.EventHandler(this.survey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Maxi CG Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "What country do you want to visit?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // japan
            // 
            this.japan.AutoSize = true;
            this.japan.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.japan.Location = new System.Drawing.Point(36, 132);
            this.japan.Name = "japan";
            this.japan.Size = new System.Drawing.Size(73, 22);
            this.japan.TabIndex = 3;
            this.japan.Text = "Japan";
            this.japan.UseVisualStyleBackColor = true;
            this.japan.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // russia
            // 
            this.russia.AutoSize = true;
            this.russia.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.russia.Location = new System.Drawing.Point(172, 104);
            this.russia.Name = "russia";
            this.russia.Size = new System.Drawing.Size(73, 22);
            this.russia.TabIndex = 4;
            this.russia.Text = "Russia";
            this.russia.UseVisualStyleBackColor = true;
            this.russia.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // korea
            // 
            this.korea.AutoSize = true;
            this.korea.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korea.Location = new System.Drawing.Point(172, 132);
            this.korea.Name = "korea";
            this.korea.Size = new System.Drawing.Size(72, 22);
            this.korea.TabIndex = 5;
            this.korea.Text = "Korea";
            this.korea.UseVisualStyleBackColor = true;
            this.korea.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Maxi CG Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "If others, please specifiy.";
            this.label1.Visible = false;
            // 
            // othersBox
            // 
            this.othersBox.Location = new System.Drawing.Point(36, 212);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(224, 20);
            this.othersBox.TabIndex = 7;
            this.othersBox.Visible = false;
            this.othersBox.TextChanged += new System.EventHandler(this.othersBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Futura Maxi CG Bold", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(215, 294);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.Location = new System.Drawing.Point(36, 160);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(75, 22);
            this.othersLabel.TabIndex = 9;
            this.othersLabel.Text = "Others";
            this.othersLabel.UseVisualStyleBackColor = true;
            this.othersLabel.CheckedChanged += new System.EventHandler(this.othersLabel_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Futura Maxi CG Bold", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(215, 323);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korea);
            this.Controls.Add(this.russia);
            this.Controls.Add(this.japan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.philippines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox philippines;
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox japan;
        private System.Windows.Forms.CheckBox russia;
        private System.Windows.Forms.CheckBox korea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox othersBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox othersLabel;
        private System.Windows.Forms.Button closeButton;
    }
}


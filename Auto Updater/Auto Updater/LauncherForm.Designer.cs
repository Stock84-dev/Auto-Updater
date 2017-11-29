// Copyright(c) 2017 Stock84-dev
// https://github.com/Stock84-dev/Auto-Updater

namespace Launcher
{
    partial class LauncherForm
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(32, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(382, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "New version is avalible, do you want to update program ?";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 62);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(440, 65);
            this.txtBox.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Changelog:";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(12, 133);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(377, 133);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 175);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbl);
            this.Name = "LauncherForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}


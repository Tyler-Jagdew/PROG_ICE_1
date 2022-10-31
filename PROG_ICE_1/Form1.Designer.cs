namespace PROG_ICE_1
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
            this.ButtonAppend = new System.Windows.Forms.Button();
            this.ButtonPrepend = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonReplace = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.FindTextbox = new System.Windows.Forms.TextBox();
            this.GetterTextBox = new System.Windows.Forms.TextBox();
            this.SetterTextBox = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAppend
            // 
            this.ButtonAppend.Location = new System.Drawing.Point(249, 123);
            this.ButtonAppend.Name = "ButtonAppend";
            this.ButtonAppend.Size = new System.Drawing.Size(118, 33);
            this.ButtonAppend.TabIndex = 0;
            this.ButtonAppend.Text = "APPEND";
            this.ButtonAppend.UseVisualStyleBackColor = true;
            this.ButtonAppend.Click += new System.EventHandler(this.ButtonAppend_Click);
            // 
            // ButtonPrepend
            // 
            this.ButtonPrepend.Location = new System.Drawing.Point(382, 123);
            this.ButtonPrepend.Name = "ButtonPrepend";
            this.ButtonPrepend.Size = new System.Drawing.Size(118, 33);
            this.ButtonPrepend.TabIndex = 1;
            this.ButtonPrepend.Text = "PREPEND";
            this.ButtonPrepend.UseVisualStyleBackColor = true;
            this.ButtonPrepend.Click += new System.EventHandler(this.ButtonPrepend_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(515, 123);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(118, 33);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonReplace
            // 
            this.ButtonReplace.Location = new System.Drawing.Point(372, 250);
            this.ButtonReplace.Name = "ButtonReplace";
            this.ButtonReplace.Size = new System.Drawing.Size(118, 33);
            this.ButtonReplace.TabIndex = 3;
            this.ButtonReplace.Text = "REPLACE";
            this.ButtonReplace.UseVisualStyleBackColor = true;
            this.ButtonReplace.Click += new System.EventHandler(this.ButtonReplace_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(497, 250);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(118, 33);
            this.ButtonInsert.TabIndex = 4;
            this.ButtonInsert.Text = "INSERT";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonStart.Location = new System.Drawing.Point(32, 460);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(118, 33);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "START";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClear.Location = new System.Drawing.Point(169, 460);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(118, 33);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // outputBox
            // 
            this.outputBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.outputBox.Location = new System.Drawing.Point(637, 176);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(336, 260);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // FindTextbox
            // 
            this.FindTextbox.ForeColor = System.Drawing.Color.Firebrick;
            this.FindTextbox.Location = new System.Drawing.Point(13, 126);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(208, 30);
            this.FindTextbox.TabIndex = 8;
            // 
            // GetterTextBox
            // 
            this.GetterTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.GetterTextBox.Location = new System.Drawing.Point(13, 250);
            this.GetterTextBox.Name = "GetterTextBox";
            this.GetterTextBox.Size = new System.Drawing.Size(155, 30);
            this.GetterTextBox.TabIndex = 9;
            // 
            // SetterTextBox
            // 
            this.SetterTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SetterTextBox.Location = new System.Drawing.Point(191, 250);
            this.SetterTextBox.Name = "SetterTextBox";
            this.SetterTextBox.Size = new System.Drawing.Size(155, 30);
            this.SetterTextBox.TabIndex = 10;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelHeader.Location = new System.Drawing.Point(13, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(428, 42);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "KARAOKE MACHINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "FOR APPEND, PREPEND, DELETE. TYPE BELOW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "TYPE WHAT TO GET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(191, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "TYPE WHAT TO SET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.SetterTextBox);
            this.Controls.Add(this.GetterTextBox);
            this.Controls.Add(this.FindTextbox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.ButtonReplace);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonPrepend);
            this.Controls.Add(this.ButtonAppend);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAppend;
        private System.Windows.Forms.Button ButtonPrepend;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonReplace;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.TextBox FindTextbox;
        private System.Windows.Forms.TextBox GetterTextBox;
        private System.Windows.Forms.TextBox SetterTextBox;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

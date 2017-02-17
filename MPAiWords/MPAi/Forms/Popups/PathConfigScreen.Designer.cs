﻿using MPAi.Components;

namespace MPAi.Forms.Popups
{
    partial class SystemConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemConfig));
            this.audioFolderTextBox = new System.Windows.Forms.TextBox();
            this.audioFolderLabel = new System.Windows.Forms.Label();
            this.audioFolderSelectButton = new MPAi.Components.MPAiButton(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveButton = new MPAi.Components.MPAiButton(this.components);
            this.cancelButton = new MPAi.Components.MPAiButton(this.components);
            this.reportFolderSelectButton = new MPAi.Components.MPAiButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reportFolderTextBox = new System.Windows.Forms.TextBox();
            this.recordingFolderSelectButton = new MPAi.Components.MPAiButton(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.recordingFolderTextBox = new System.Windows.Forms.TextBox();
            this.HTKFolderSelectButton = new MPAi.Components.MPAiButton(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.HTKFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // audioFolderTextBox
            // 
            this.audioFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.audioFolderTextBox.Enabled = false;
            this.audioFolderTextBox.Location = new System.Drawing.Point(252, 138);
            this.audioFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.audioFolderTextBox.Name = "audioFolderTextBox";
            this.audioFolderTextBox.Size = new System.Drawing.Size(660, 31);
            this.audioFolderTextBox.TabIndex = 0;
            // 
            // audioFolderLabel
            // 
            this.audioFolderLabel.AutoSize = true;
            this.audioFolderLabel.Location = new System.Drawing.Point(38, 144);
            this.audioFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.audioFolderLabel.Name = "audioFolderLabel";
            this.audioFolderLabel.Size = new System.Drawing.Size(134, 25);
            this.audioFolderLabel.TabIndex = 1;
            this.audioFolderLabel.Text = "Audio Folder";
            // 
            // audioFolderSelectButton
            // 
            this.audioFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.audioFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.audioFolderSelectButton.Location = new System.Drawing.Point(928, 138);
            this.audioFolderSelectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.audioFolderSelectButton.Name = "audioFolderSelectButton";
            this.audioFolderSelectButton.Size = new System.Drawing.Size(66, 48);
            this.audioFolderSelectButton.TabIndex = 2;
            this.audioFolderSelectButton.Text = "...";
            this.audioFolderSelectButton.UseVisualStyleBackColor = true;
            this.audioFolderSelectButton.Click += new System.EventHandler(this.audioFolderSelectButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(773, 432);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 48);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(887, 432);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 48);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reportFolderSelectButton
            // 
            this.reportFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.reportFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.reportFolderSelectButton.Location = new System.Drawing.Point(928, 263);
            this.reportFolderSelectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reportFolderSelectButton.Name = "reportFolderSelectButton";
            this.reportFolderSelectButton.Size = new System.Drawing.Size(66, 48);
            this.reportFolderSelectButton.TabIndex = 13;
            this.reportFolderSelectButton.Text = "...";
            this.reportFolderSelectButton.UseVisualStyleBackColor = true;
            this.reportFolderSelectButton.Click += new System.EventHandler(this.reportFolderSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Report Folder";
            // 
            // reportFolderTextBox
            // 
            this.reportFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportFolderTextBox.Enabled = false;
            this.reportFolderTextBox.Location = new System.Drawing.Point(252, 263);
            this.reportFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reportFolderTextBox.Name = "reportFolderTextBox";
            this.reportFolderTextBox.Size = new System.Drawing.Size(660, 31);
            this.reportFolderTextBox.TabIndex = 11;
            // 
            // recordingFolderSelectButton
            // 
            this.recordingFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.recordingFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordingFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.recordingFolderSelectButton.Location = new System.Drawing.Point(928, 199);
            this.recordingFolderSelectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recordingFolderSelectButton.Name = "recordingFolderSelectButton";
            this.recordingFolderSelectButton.Size = new System.Drawing.Size(66, 48);
            this.recordingFolderSelectButton.TabIndex = 10;
            this.recordingFolderSelectButton.Text = "...";
            this.recordingFolderSelectButton.UseVisualStyleBackColor = true;
            this.recordingFolderSelectButton.Click += new System.EventHandler(this.recordingFolderSelectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recording Folder";
            // 
            // recordingFolderTextBox
            // 
            this.recordingFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recordingFolderTextBox.Enabled = false;
            this.recordingFolderTextBox.Location = new System.Drawing.Point(252, 199);
            this.recordingFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recordingFolderTextBox.Name = "recordingFolderTextBox";
            this.recordingFolderTextBox.Size = new System.Drawing.Size(660, 31);
            this.recordingFolderTextBox.TabIndex = 8;
            // 
            // HTKFolderSelectButton
            // 
            this.HTKFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.HTKFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTKFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.HTKFolderSelectButton.Location = new System.Drawing.Point(928, 326);
            this.HTKFolderSelectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HTKFolderSelectButton.Name = "HTKFolderSelectButton";
            this.HTKFolderSelectButton.Size = new System.Drawing.Size(66, 48);
            this.HTKFolderSelectButton.TabIndex = 16;
            this.HTKFolderSelectButton.Text = "...";
            this.HTKFolderSelectButton.UseVisualStyleBackColor = true;
            this.HTKFolderSelectButton.Click += new System.EventHandler(this.HTKFolderSelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "HTK Folder";
            // 
            // HTKFolderTextBox
            // 
            this.HTKFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HTKFolderTextBox.Enabled = false;
            this.HTKFolderTextBox.Location = new System.Drawing.Point(252, 326);
            this.HTKFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HTKFolderTextBox.Name = "HTKFolderTextBox";
            this.HTKFolderTextBox.Size = new System.Drawing.Size(660, 31);
            this.HTKFolderTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.MaximumSize = new System.Drawing.Size(800, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(741, 50);
            this.label5.TabIndex = 20;
            this.label5.Text = "This allows you to set the file locations used by the system. Note that MPAi depe" +
    "nds on files it finds in these locations; it is advised not to change these.";
            // 
            // SystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HTKFolderSelectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HTKFolderTextBox);
            this.Controls.Add(this.reportFolderSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportFolderTextBox);
            this.Controls.Add(this.recordingFolderSelectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordingFolderTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.audioFolderSelectButton);
            this.Controls.Add(this.audioFolderLabel);
            this.Controls.Add(this.audioFolderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set System Paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox audioFolderTextBox;
        private System.Windows.Forms.Label audioFolderLabel;
        private MPAiButton audioFolderSelectButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MPAiButton saveButton;
        private MPAiButton cancelButton;
        private MPAiButton reportFolderSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportFolderTextBox;
        private MPAiButton recordingFolderSelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recordingFolderTextBox;
        private MPAiButton HTKFolderSelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HTKFolderTextBox;
        private System.Windows.Forms.Label label5;
    }
}
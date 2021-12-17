﻿
namespace DSM
{
    partial class MainForm
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
            this.applicationIdField = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stateField = new System.Windows.Forms.TextBox();
            this.updatePresenceBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.largeImageKeyField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.largeImageTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application ID: ";
            // 
            // applicationIdField
            // 
            this.applicationIdField.Location = new System.Drawing.Point(98, 10);
            this.applicationIdField.Name = "applicationIdField";
            this.applicationIdField.Size = new System.Drawing.Size(255, 20);
            this.applicationIdField.TabIndex = 1;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(359, 8);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(96, 23);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "State: ";
            // 
            // stateField
            // 
            this.stateField.Location = new System.Drawing.Point(63, 80);
            this.stateField.Name = "stateField";
            this.stateField.Size = new System.Drawing.Size(290, 20);
            this.stateField.TabIndex = 4;
            this.stateField.Text = "Doing nothing";
            // 
            // updatePresenceBtn
            // 
            this.updatePresenceBtn.Location = new System.Drawing.Point(234, 183);
            this.updatePresenceBtn.Name = "updatePresenceBtn";
            this.updatePresenceBtn.Size = new System.Drawing.Size(119, 23);
            this.updatePresenceBtn.TabIndex = 5;
            this.updatePresenceBtn.Text = "Update Presence";
            this.updatePresenceBtn.UseVisualStyleBackColor = true;
            this.updatePresenceBtn.Click += new System.EventHandler(this.updatePresenceBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Large image key: ";
            // 
            // largeImageKeyField
            // 
            this.largeImageKeyField.Location = new System.Drawing.Point(116, 115);
            this.largeImageKeyField.Name = "largeImageKeyField";
            this.largeImageKeyField.Size = new System.Drawing.Size(237, 20);
            this.largeImageKeyField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Large image text: ";
            // 
            // largeImageTextField
            // 
            this.largeImageTextField.Location = new System.Drawing.Point(116, 148);
            this.largeImageTextField.Name = "largeImageTextField";
            this.largeImageTextField.Size = new System.Drawing.Size(237, 20);
            this.largeImageTextField.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 217);
            this.Controls.Add(this.largeImageTextField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.largeImageKeyField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatePresenceBtn);
            this.Controls.Add(this.stateField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.applicationIdField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Discord Status Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox applicationIdField;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stateField;
        private System.Windows.Forms.Button updatePresenceBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox largeImageKeyField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox largeImageTextField;
    }
}
﻿namespace FacepunchTestCSharp
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MemoEdit1 = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnGetSubscribedWorkshop = new System.Windows.Forms.Button();
            this.btnGetWorkshopItemInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MemoEdit1
            // 
            this.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MemoEdit1.Location = new System.Drawing.Point(0, 136);
            this.MemoEdit1.Multiline = true;
            this.MemoEdit1.Name = "MemoEdit1";
            this.MemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MemoEdit1.Size = new System.Drawing.Size(800, 314);
            this.MemoEdit1.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(87, 55);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload to Workshop";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // btnGetSubscribedWorkshop
            // 
            this.btnGetSubscribedWorkshop.Location = new System.Drawing.Point(232, 13);
            this.btnGetSubscribedWorkshop.Name = "btnGetSubscribedWorkshop";
            this.btnGetSubscribedWorkshop.Size = new System.Drawing.Size(115, 48);
            this.btnGetSubscribedWorkshop.TabIndex = 4;
            this.btnGetSubscribedWorkshop.Text = "Get Subscribed Workshop";
            this.btnGetSubscribedWorkshop.UseVisualStyleBackColor = true;
            this.btnGetSubscribedWorkshop.Click += new System.EventHandler(this.btnGetSubscribedWorkshop_Click);
            // 
            // btnGetWorkshopItemInfo
            // 
            this.btnGetWorkshopItemInfo.Location = new System.Drawing.Point(353, 12);
            this.btnGetWorkshopItemInfo.Name = "btnGetWorkshopItemInfo";
            this.btnGetWorkshopItemInfo.Size = new System.Drawing.Size(75, 48);
            this.btnGetWorkshopItemInfo.TabIndex = 5;
            this.btnGetWorkshopItemInfo.Text = "Get Workshop Item Info";
            this.btnGetWorkshopItemInfo.UseVisualStyleBackColor = true;
            this.btnGetWorkshopItemInfo.Click += new System.EventHandler(this.btnGetWorkshopItemInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetWorkshopItemInfo);
            this.Controls.Add(this.btnGetSubscribedWorkshop);
            this.Controls.Add(this.MemoEdit1);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.TextBox MemoEdit1;
        internal System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnGetSubscribedWorkshop;
        private System.Windows.Forms.Button btnGetWorkshopItemInfo;
    }
}


﻿namespace ASE_Assignment
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.picboxCanvas = new System.Windows.Forms.PictureBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.richtxtCommandArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCommandArea = new System.Windows.Forms.Label();
            this.lblCanvas = new System.Windows.Forms.Label();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblCoordinatesInfo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCanvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxCanvas
            // 
            this.picboxCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picboxCanvas.Location = new System.Drawing.Point(541, 86);
            this.picboxCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxCanvas.Name = "picboxCanvas";
            this.picboxCanvas.Size = new System.Drawing.Size(900, 500);
            this.picboxCanvas.TabIndex = 0;
            this.picboxCanvas.TabStop = false;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandLine.Font = new System.Drawing.Font("FiraCode NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandLine.Location = new System.Drawing.Point(23, 527);
            this.txtCommandLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(481, 27);
            this.txtCommandLine.TabIndex = 1;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("FiraCode NF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.btnRun.Location = new System.Drawing.Point(23, 564);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(112, 33);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("FiraCode NF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.btnClear.Location = new System.Drawing.Point(143, 564);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // richtxtCommandArea
            // 
            this.richtxtCommandArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtCommandArea.Font = new System.Drawing.Font("FiraCode NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtCommandArea.Location = new System.Drawing.Point(23, 86);
            this.richtxtCommandArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richtxtCommandArea.Name = "richtxtCommandArea";
            this.richtxtCommandArea.Size = new System.Drawing.Size(482, 370);
            this.richtxtCommandArea.TabIndex = 4;
            this.richtxtCommandArea.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripHelp,
            this.menuStripAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1460, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.Font = new System.Drawing.Font("FiraCode NF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(47, 20);
            this.menuStripFile.Text = "File";
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.Font = new System.Drawing.Font("FiraCode NF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(47, 20);
            this.menuStripHelp.Text = "Help";
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.Font = new System.Drawing.Font("FiraCode NF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(54, 20);
            this.menuStripAbout.Text = "About";
            // 
            // lblCommandArea
            // 
            this.lblCommandArea.AutoSize = true;
            this.lblCommandArea.Font = new System.Drawing.Font("FiraCode NF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblCommandArea.Location = new System.Drawing.Point(18, 56);
            this.lblCommandArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandArea.Name = "lblCommandArea";
            this.lblCommandArea.Size = new System.Drawing.Size(348, 25);
            this.lblCommandArea.TabIndex = 6;
            this.lblCommandArea.Text = "enter big commands here:";
            // 
            // lblCanvas
            // 
            this.lblCanvas.AutoSize = true;
            this.lblCanvas.Font = new System.Drawing.Font("FiraCode NF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanvas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblCanvas.Location = new System.Drawing.Point(536, 56);
            this.lblCanvas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanvas.Name = "lblCanvas";
            this.lblCanvas.Size = new System.Drawing.Size(194, 25);
            this.lblCanvas.TabIndex = 7;
            this.lblCanvas.Text = "drawing area:";
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Font = new System.Drawing.Font("FiraCode NF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblCommandLine.Location = new System.Drawing.Point(18, 497);
            this.lblCommandLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(390, 25);
            this.lblCommandLine.TabIndex = 8;
            this.lblCommandLine.Text = "enter little commands here:";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Font = new System.Drawing.Font("FiraCode NF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblCoordinates.Location = new System.Drawing.Point(536, 621);
            this.lblCoordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(264, 25);
            this.lblCoordinates.TabIndex = 9;
            this.lblCoordinates.Text = "X:0, Y:0 (default)";
            // 
            // lblCoordinatesInfo
            // 
            this.lblCoordinatesInfo.AutoSize = true;
            this.lblCoordinatesInfo.Font = new System.Drawing.Font("FiraCode NF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinatesInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblCoordinatesInfo.Location = new System.Drawing.Point(537, 600);
            this.lblCoordinatesInfo.Name = "lblCoordinatesInfo";
            this.lblCoordinatesInfo.Size = new System.Drawing.Size(229, 20);
            this.lblCoordinatesInfo.TabIndex = 10;
            this.lblCoordinatesInfo.Text = "current coordinates:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Font = new System.Drawing.Font("FiraCode NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(107)))));
            this.lblError.Location = new System.Drawing.Point(23, 621);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 22);
            this.lblError.TabIndex = 11;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1460, 770);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCoordinatesInfo);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.lblCommandLine);
            this.Controls.Add(this.lblCanvas);
            this.Controls.Add(this.lblCommandArea);
            this.Controls.Add(this.richtxtCommandArea);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCommandLine);
            this.Controls.Add(this.picboxCanvas);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form";
            this.Text = "Graphical Programming Language";
            ((System.ComponentModel.ISupportInitialize)(this.picboxCanvas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxCanvas;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox richtxtCommandArea;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem menuStripAbout;
        private System.Windows.Forms.Label lblCommandArea;
        private System.Windows.Forms.Label lblCanvas;
        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblCoordinatesInfo;
        private System.Windows.Forms.Label lblError;
    }
}

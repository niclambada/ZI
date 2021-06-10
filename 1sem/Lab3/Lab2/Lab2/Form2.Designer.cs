namespace Lab2
{
    partial class Form2
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
            this.textBoxUTF = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxBytes = new System.Windows.Forms.TextBox();
            this.textBoxASCII = new System.Windows.Forms.TextBox();
            this.textBoxBs64 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUTF
            // 
            this.textBoxUTF.Location = new System.Drawing.Point(13, 48);
            this.textBoxUTF.Multiline = true;
            this.textBoxUTF.Name = "textBoxUTF";
            this.textBoxUTF.Size = new System.Drawing.Size(390, 117);
            this.textBoxUTF.TabIndex = 0;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(409, 47);
            this.textBoxBase.Multiline = true;
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(379, 118);
            this.textBoxBase.TabIndex = 1;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(136, 178);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(529, 178);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 3;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uncodingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uncodingToolStripMenuItem
            // 
            this.uncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8ToolStripMenuItem,
            this.aNCIIToolStripMenuItem,
            this.unicodeToolStripMenuItem});
            this.uncodingToolStripMenuItem.Name = "uncodingToolStripMenuItem";
            this.uncodingToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.uncodingToolStripMenuItem.Text = "Uncoding";
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.uTF8ToolStripMenuItem.Text = "UTF8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // aNCIIToolStripMenuItem
            // 
            this.aNCIIToolStripMenuItem.Name = "aNCIIToolStripMenuItem";
            this.aNCIIToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.aNCIIToolStripMenuItem.Text = "ASCII";
            this.aNCIIToolStripMenuItem.Click += new System.EventHandler(this.aNCIIToolStripMenuItem_Click);
            // 
            // unicodeToolStripMenuItem
            // 
            this.unicodeToolStripMenuItem.Name = "unicodeToolStripMenuItem";
            this.unicodeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.unicodeToolStripMenuItem.Text = "Unicode";
            this.unicodeToolStripMenuItem.Click += new System.EventHandler(this.unicodeToolStripMenuItem_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(80, 244);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(248, 22);
            this.textBoxA.TabIndex = 5;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(80, 286);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(248, 22);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.Location = new System.Drawing.Point(540, 225);
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(248, 22);
            this.textBoxBytes.TabIndex = 7;
            // 
            // textBoxASCII
            // 
            this.textBoxASCII.Location = new System.Drawing.Point(540, 269);
            this.textBoxASCII.Name = "textBoxASCII";
            this.textBoxASCII.Size = new System.Drawing.Size(248, 22);
            this.textBoxASCII.TabIndex = 8;
            // 
            // textBoxBs64
            // 
            this.textBoxBs64.Location = new System.Drawing.Point(540, 314);
            this.textBoxBs64.Name = "textBoxBs64";
            this.textBoxBs64.Size = new System.Drawing.Size(248, 22);
            this.textBoxBs64.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bytes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ASCII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Base64";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBs64);
            this.Controls.Add(this.textBoxASCII);
            this.Controls.Add(this.textBoxBytes);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.textBoxUTF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Lab3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUTF;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicodeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxBytes;
        private System.Windows.Forms.TextBox textBoxASCII;
        private System.Windows.Forms.TextBox textBoxBs64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
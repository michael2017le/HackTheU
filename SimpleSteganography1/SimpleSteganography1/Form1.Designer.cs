namespace SimpleSteganography
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.OriginalFilePath = new System.Windows.Forms.TextBox();
            this.EnterMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StenFilePath = new System.Windows.Forms.TextBox();
            this.OpenStenFile = new System.Windows.Forms.Button();
            this.ReturnMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.EncryptMultiple = new System.Windows.Forms.Button();
            this.FolderFinder = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 431);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(140, 201);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(171, 42);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open Original File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(157, 251);
            this.buttonEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(100, 28);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(856, 583);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(100, 28);
            this.buttonDecode.TabIndex = 3;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // OriginalFilePath
            // 
            this.OriginalFilePath.Location = new System.Drawing.Point(319, 211);
            this.OriginalFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OriginalFilePath.Name = "OriginalFilePath";
            this.OriginalFilePath.ReadOnly = true;
            this.OriginalFilePath.Size = new System.Drawing.Size(257, 22);
            this.OriginalFilePath.TabIndex = 4;
            // 
            // EnterMessage
            // 
            this.EnterMessage.Location = new System.Drawing.Point(289, 118);
            this.EnterMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterMessage.Name = "EnterMessage";
            this.EnterMessage.Size = new System.Drawing.Size(257, 22);
            this.EnterMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Message :";
            // 
            // StenFilePath
            // 
            this.StenFilePath.Location = new System.Drawing.Point(319, 316);
            this.StenFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StenFilePath.Name = "StenFilePath";
            this.StenFilePath.ReadOnly = true;
            this.StenFilePath.Size = new System.Drawing.Size(257, 22);
            this.StenFilePath.TabIndex = 8;
            // 
            // OpenStenFile
            // 
            this.OpenStenFile.Location = new System.Drawing.Point(140, 306);
            this.OpenStenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenStenFile.Name = "OpenStenFile";
            this.OpenStenFile.Size = new System.Drawing.Size(171, 42);
            this.OpenStenFile.TabIndex = 7;
            this.OpenStenFile.Text = "Open Sten File";
            this.OpenStenFile.UseVisualStyleBackColor = true;
            this.OpenStenFile.Click += new System.EventHandler(this.OpenStenFile_Click);
            // 
            // ReturnMessage
            // 
            this.ReturnMessage.Location = new System.Drawing.Point(777, 553);
            this.ReturnMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnMessage.Name = "ReturnMessage";
            this.ReturnMessage.Size = new System.Drawing.Size(257, 22);
            this.ReturnMessage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 558);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Returned Message:";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.Control;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Error.Location = new System.Drawing.Point(16, 618);
            this.Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 29);
            this.Error.TabIndex = 11;
            // 
            // EncryptMultiple
            // 
            this.EncryptMultiple.Location = new System.Drawing.Point(772, 177);
            this.EncryptMultiple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncryptMultiple.Name = "EncryptMultiple";
            this.EncryptMultiple.Size = new System.Drawing.Size(163, 46);
            this.EncryptMultiple.TabIndex = 12;
            this.EncryptMultiple.Text = "Encode Multiple With Entered String";
            this.EncryptMultiple.UseVisualStyleBackColor = true;
            this.EncryptMultiple.Click += new System.EventHandler(this.EncryptMultiple_Click);
            // 
            // FolderFinder
            // 
            this.FolderFinder.Location = new System.Drawing.Point(723, 231);
            this.FolderFinder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderFinder.Name = "FolderFinder";
            this.FolderFinder.ReadOnly = true;
            this.FolderFinder.Size = new System.Drawing.Size(257, 22);
            this.FolderFinder.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(374, 431);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 161);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOT WORKING";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FolderFinder);
            this.Controls.Add(this.EncryptMultiple);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnMessage);
            this.Controls.Add(this.StenFilePath);
            this.Controls.Add(this.OpenStenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterMessage);
            this.Controls.Add(this.OriginalFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox OriginalFilePath;
        private System.Windows.Forms.TextBox EnterMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StenFilePath;
        private System.Windows.Forms.Button OpenStenFile;
        private System.Windows.Forms.TextBox ReturnMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button EncryptMultiple;
        private System.Windows.Forms.TextBox FolderFinder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}


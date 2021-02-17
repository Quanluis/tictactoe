
namespace tictactoe
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
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.PictureBox();
            this.a3 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.c1 = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.a1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-tac-toe";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(364, 81);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(662, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // a2
            // 
            this.a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2.Location = new System.Drawing.Point(353, 142);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(86, 76);
            this.a2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a2.TabIndex = 4;
            this.a2.TabStop = false;
            this.a2.Click += new System.EventHandler(this.pic_click);
            // 
            // a3
            // 
            this.a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a3.Location = new System.Drawing.Point(470, 142);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(86, 76);
            this.a3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a3.TabIndex = 5;
            this.a3.TabStop = false;
            this.a3.Click += new System.EventHandler(this.pic_click);
            // 
            // b1
            // 
            this.b1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b1.Location = new System.Drawing.Point(240, 245);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(86, 76);
            this.b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b1.TabIndex = 6;
            this.b1.TabStop = false;
            this.b1.Click += new System.EventHandler(this.pic_click);
            // 
            // b2
            // 
            this.b2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b2.Location = new System.Drawing.Point(353, 245);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(86, 76);
            this.b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b2.TabIndex = 7;
            this.b2.TabStop = false;
            this.b2.Click += new System.EventHandler(this.pic_click);
            // 
            // c1
            // 
            this.c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1.Location = new System.Drawing.Point(240, 353);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(86, 76);
            this.c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c1.TabIndex = 9;
            this.c1.TabStop = false;
            this.c1.Click += new System.EventHandler(this.pic_click);
            // 
            // c2
            // 
            this.c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c2.Location = new System.Drawing.Point(353, 353);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(86, 76);
            this.c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c2.TabIndex = 10;
            this.c2.TabStop = false;
            this.c2.Click += new System.EventHandler(this.pic_click);
            // 
            // c3
            // 
            this.c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c3.Location = new System.Drawing.Point(470, 353);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(86, 76);
            this.c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c3.TabIndex = 11;
            this.c3.TabStop = false;
            this.c3.Click += new System.EventHandler(this.pic_click);
            // 
            // b3
            // 
            this.b3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b3.Location = new System.Drawing.Point(470, 245);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(86, 76);
            this.b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b3.TabIndex = 12;
            this.b3.TabStop = false;
            this.b3.Click += new System.EventHandler(this.pic_click);
            // 
            // a1
            // 
            this.a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1.Location = new System.Drawing.Point(240, 142);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(86, 76);
            this.a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a1.TabIndex = 13;
            this.a1.TabStop = false;
            this.a1.Click += new System.EventHandler(this.pic_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox a2;
        private System.Windows.Forms.PictureBox a3;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox c1;
        private System.Windows.Forms.PictureBox c2;
        private System.Windows.Forms.PictureBox c3;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox a1;
    }
}


namespace BakaTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnSwitchHiragana = new System.Windows.Forms.Button();
            this.btnSwitchKatakana = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wrong:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.Location = new System.Drawing.Point(57, 25);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(55, 23);
            this.lblCorrect.TabIndex = 2;
            this.lblCorrect.Text = "0";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWrong
            // 
            this.lblWrong.Location = new System.Drawing.Point(57, 54);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(55, 23);
            this.lblWrong.TabIndex = 3;
            this.lblWrong.Text = "0";
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharacter
            // 
            this.lblCharacter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCharacter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharacter.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacter.Location = new System.Drawing.Point(182, 14);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(160, 115);
            this.lblCharacter.TabIndex = 4;
            this.lblCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer1.Location = new System.Drawing.Point(123, 150);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(132, 97);
            this.btnAnswer1.TabIndex = 5;
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer2.Location = new System.Drawing.Point(261, 150);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(132, 97);
            this.btnAnswer2.TabIndex = 6;
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer3.Location = new System.Drawing.Point(123, 253);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(132, 97);
            this.btnAnswer3.TabIndex = 7;
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer4.Location = new System.Drawing.Point(261, 253);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(132, 97);
            this.btnAnswer4.TabIndex = 8;
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // btnSwitchHiragana
            // 
            this.btnSwitchHiragana.Location = new System.Drawing.Point(425, 14);
            this.btnSwitchHiragana.Name = "btnSwitchHiragana";
            this.btnSwitchHiragana.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchHiragana.TabIndex = 9;
            this.btnSwitchHiragana.Text = "あ";
            this.btnSwitchHiragana.UseVisualStyleBackColor = true;
            this.btnSwitchHiragana.Click += new System.EventHandler(this.btnSwitchHiragana_Click);
            // 
            // btnSwitchKatakana
            // 
            this.btnSwitchKatakana.Location = new System.Drawing.Point(425, 43);
            this.btnSwitchKatakana.Name = "btnSwitchKatakana";
            this.btnSwitchKatakana.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchKatakana.TabIndex = 10;
            this.btnSwitchKatakana.Text = "ア";
            this.btnSwitchKatakana.UseVisualStyleBackColor = true;
            this.btnSwitchKatakana.Click += new System.EventHandler(this.btnSwitchKatakana_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lblWrong);
            this.groupBox1.Controls.Add(this.lblCorrect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(504, 367);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSwitchKatakana);
            this.Controls.Add(this.btnSwitchHiragana);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "epic untitled project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCorrect;
        private Label lblWrong;
        private Label lblCharacter;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private Button btnSwitchHiragana;
        private Button btnSwitchKatakana;
        private GroupBox groupBox1;
        private Button button1;
    }
}
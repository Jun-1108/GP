namespace p2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSensor1_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor1_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor2_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor2_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor3_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor3_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor4_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor4_2 = new System.Windows.Forms.CheckBox();
            this.btnConveyor1 = new System.Windows.Forms.Button();
            this.btnConveyor2 = new System.Windows.Forms.Button();
            this.btnConveyor3 = new System.Windows.Forms.Button();
            this.btnConveyor4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSensor1_1
            // 
            this.cbSensor1_1.AutoSize = true;
            this.cbSensor1_1.Location = new System.Drawing.Point(50, 50);
            this.cbSensor1_1.Name = "cbSensor1_1";
            this.cbSensor1_1.Size = new System.Drawing.Size(53, 19);
            this.cbSensor1_1.TabIndex = 0;
            this.cbSensor1_1.Text = "1-1";
            this.cbSensor1_1.UseVisualStyleBackColor = true;
            // 
            // cbSensor1_2
            // 
            this.cbSensor1_2.AutoSize = true;
            this.cbSensor1_2.Location = new System.Drawing.Point(50, 100);
            this.cbSensor1_2.Name = "cbSensor1_2";
            this.cbSensor1_2.Size = new System.Drawing.Size(53, 19);
            this.cbSensor1_2.TabIndex = 1;
            this.cbSensor1_2.Text = "1-2";
            this.cbSensor1_2.UseVisualStyleBackColor = true;
            this.cbSensor1_2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbSensor2_1
            // 
            this.cbSensor2_1.AutoSize = true;
            this.cbSensor2_1.Location = new System.Drawing.Point(50, 200);
            this.cbSensor2_1.Name = "cbSensor2_1";
            this.cbSensor2_1.Size = new System.Drawing.Size(53, 19);
            this.cbSensor2_1.TabIndex = 2;
            this.cbSensor2_1.Text = "2-1";
            this.cbSensor2_1.UseVisualStyleBackColor = true;
            // 
            // cbSensor2_2
            // 
            this.cbSensor2_2.AutoSize = true;
            this.cbSensor2_2.Location = new System.Drawing.Point(50, 250);
            this.cbSensor2_2.Name = "cbSensor2_2";
            this.cbSensor2_2.Size = new System.Drawing.Size(53, 19);
            this.cbSensor2_2.TabIndex = 3;
            this.cbSensor2_2.Text = "2-2";
            this.cbSensor2_2.UseVisualStyleBackColor = true;
            this.cbSensor2_2.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbSensor3_1
            // 
            this.cbSensor3_1.AutoSize = true;
            this.cbSensor3_1.Location = new System.Drawing.Point(300, 50);
            this.cbSensor3_1.Name = "cbSensor3_1";
            this.cbSensor3_1.Size = new System.Drawing.Size(53, 19);
            this.cbSensor3_1.TabIndex = 4;
            this.cbSensor3_1.Text = "3-1";
            this.cbSensor3_1.UseVisualStyleBackColor = true;
            this.cbSensor3_1.CheckedChanged += new System.EventHandler(this.cbSensor3_1_CheckedChanged);
            // 
            // cbSensor3_2
            // 
            this.cbSensor3_2.AutoSize = true;
            this.cbSensor3_2.Location = new System.Drawing.Point(300, 100);
            this.cbSensor3_2.Name = "cbSensor3_2";
            this.cbSensor3_2.Size = new System.Drawing.Size(53, 19);
            this.cbSensor3_2.TabIndex = 5;
            this.cbSensor3_2.Text = "3-2";
            this.cbSensor3_2.UseVisualStyleBackColor = true;
            this.cbSensor3_2.CheckedChanged += new System.EventHandler(this.cbSensor3_2_CheckedChanged);
            // 
            // cbSensor4_1
            // 
            this.cbSensor4_1.AutoSize = true;
            this.cbSensor4_1.Location = new System.Drawing.Point(300, 200);
            this.cbSensor4_1.Name = "cbSensor4_1";
            this.cbSensor4_1.Size = new System.Drawing.Size(53, 19);
            this.cbSensor4_1.TabIndex = 6;
            this.cbSensor4_1.Text = "4-1";
            this.cbSensor4_1.UseVisualStyleBackColor = true;
            // 
            // cbSensor4_2
            // 
            this.cbSensor4_2.AutoSize = true;
            this.cbSensor4_2.Location = new System.Drawing.Point(300, 250);
            this.cbSensor4_2.Name = "cbSensor4_2";
            this.cbSensor4_2.Size = new System.Drawing.Size(53, 19);
            this.cbSensor4_2.TabIndex = 7;
            this.cbSensor4_2.Text = "4-2";
            this.cbSensor4_2.UseVisualStyleBackColor = true;
            this.cbSensor4_2.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // btnConveyor1
            // 
            this.btnConveyor1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConveyor1.Location = new System.Drawing.Point(109, 50);
            this.btnConveyor1.Name = "btnConveyor1";
            this.btnConveyor1.Size = new System.Drawing.Size(160, 80);
            this.btnConveyor1.TabIndex = 8;
            this.btnConveyor1.UseVisualStyleBackColor = false;
            // 
            // btnConveyor2
            // 
            this.btnConveyor2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConveyor2.Location = new System.Drawing.Point(109, 200);
            this.btnConveyor2.Name = "btnConveyor2";
            this.btnConveyor2.Size = new System.Drawing.Size(160, 80);
            this.btnConveyor2.TabIndex = 9;
            this.btnConveyor2.UseVisualStyleBackColor = false;
            // 
            // btnConveyor3
            // 
            this.btnConveyor3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConveyor3.Location = new System.Drawing.Point(359, 50);
            this.btnConveyor3.Name = "btnConveyor3";
            this.btnConveyor3.Size = new System.Drawing.Size(160, 80);
            this.btnConveyor3.TabIndex = 10;
            this.btnConveyor3.Text = "\r\n";
            this.btnConveyor3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConveyor3.UseVisualStyleBackColor = false;
            // 
            // btnConveyor4
            // 
            this.btnConveyor4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConveyor4.Location = new System.Drawing.Point(359, 200);
            this.btnConveyor4.Name = "btnConveyor4";
            this.btnConveyor4.Size = new System.Drawing.Size(160, 80);
            this.btnConveyor4.TabIndex = 11;
            this.btnConveyor4.UseVisualStyleBackColor = false;
            this.btnConveyor4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 12;
            this.button1.Text = "자동";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 80);
            this.button2.TabIndex = 13;
            this.button2.Text = "반출";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 80);
            this.button3.TabIndex = 14;
            this.button3.Text = "정지";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 80);
            this.button4.TabIndex = 15;
            this.button4.Text = "입고";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConveyor4);
            this.Controls.Add(this.btnConveyor3);
            this.Controls.Add(this.btnConveyor2);
            this.Controls.Add(this.btnConveyor1);
            this.Controls.Add(this.cbSensor4_2);
            this.Controls.Add(this.cbSensor4_1);
            this.Controls.Add(this.cbSensor3_2);
            this.Controls.Add(this.cbSensor3_1);
            this.Controls.Add(this.cbSensor2_2);
            this.Controls.Add(this.cbSensor2_1);
            this.Controls.Add(this.cbSensor1_2);
            this.Controls.Add(this.cbSensor1_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSensor1_1;
        private System.Windows.Forms.CheckBox cbSensor1_2;
        private System.Windows.Forms.CheckBox cbSensor2_1;
        private System.Windows.Forms.CheckBox cbSensor2_2;
        private System.Windows.Forms.CheckBox cbSensor3_1;
        private System.Windows.Forms.CheckBox cbSensor3_2;
        private System.Windows.Forms.CheckBox cbSensor4_1;
        private System.Windows.Forms.CheckBox cbSensor4_2;
        private System.Windows.Forms.Button btnConveyor1;
        private System.Windows.Forms.Button btnConveyor2;
        private System.Windows.Forms.Button btnConveyor3;
        private System.Windows.Forms.Button btnConveyor4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


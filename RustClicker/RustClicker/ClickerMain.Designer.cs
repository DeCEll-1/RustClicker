namespace RustClicker
{
    partial class ClickerMain
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
            this.pb_Rustman12 = new System.Windows.Forms.ProgressBar();
            this.btn_Money = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_EverySecond = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_EverySecondCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "rustman12";
            // 
            // pb_Rustman12
            // 
            this.pb_Rustman12.AccessibleDescription = "s";
            this.pb_Rustman12.Location = new System.Drawing.Point(18, 121);
            this.pb_Rustman12.MarqueeAnimationSpeed = 200;
            this.pb_Rustman12.Maximum = 110;
            this.pb_Rustman12.Name = "pb_Rustman12";
            this.pb_Rustman12.Size = new System.Drawing.Size(136, 23);
            this.pb_Rustman12.TabIndex = 3;
            // 
            // btn_Money
            // 
            this.btn_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Money.Location = new System.Drawing.Point(12, 9);
            this.btn_Money.Name = "btn_Money";
            this.btn_Money.Size = new System.Drawing.Size(776, 75);
            this.btn_Money.TabIndex = 4;
            this.btn_Money.Text = "s";
            this.btn_Money.UseVisualStyleBackColor = true;
            this.btn_Money.Click += new System.EventHandler(this.btn_Money_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(713, 415);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_EverySecond
            // 
            this.btn_EverySecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_EverySecond.Location = new System.Drawing.Point(18, 150);
            this.btn_EverySecond.Name = "btn_EverySecond";
            this.btn_EverySecond.Size = new System.Drawing.Size(136, 54);
            this.btn_EverySecond.TabIndex = 6;
            this.btn_EverySecond.Text = "Buy rustman12 for: \r\n";
            this.btn_EverySecond.UseVisualStyleBackColor = true;
            this.btn_EverySecond.Click += new System.EventHandler(this.btn_EverySecond_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(160, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "x/s";
            // 
            // lbl_EverySecondCount
            // 
            this.lbl_EverySecondCount.AutoSize = true;
            this.lbl_EverySecondCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_EverySecondCount.Location = new System.Drawing.Point(160, 118);
            this.lbl_EverySecondCount.Name = "lbl_EverySecondCount";
            this.lbl_EverySecondCount.Size = new System.Drawing.Size(60, 24);
            this.lbl_EverySecondCount.TabIndex = 9;
            this.lbl_EverySecondCount.Text = "label3";
            // 
            // ClickerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_EverySecondCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EverySecond);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Money);
            this.Controls.Add(this.pb_Rustman12);
            this.Controls.Add(this.label1);
            this.Name = "ClickerMain";
            this.Text = "ClickerMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickerMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_Rustman12;
        private System.Windows.Forms.Button btn_Money;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_EverySecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_EverySecondCount;
    }
}
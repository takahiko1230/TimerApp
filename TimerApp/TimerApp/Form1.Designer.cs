namespace TimerApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radio30 = new System.Windows.Forms.RadioButton();
            this.radio60 = new System.Windows.Forms.RadioButton();
            this.radio120 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DisplayTime
            // 
            this.DisplayTime.AutoSize = true;
            this.DisplayTime.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayTime.Location = new System.Drawing.Point(43, 50);
            this.DisplayTime.Name = "DisplayTime";
            this.DisplayTime.Size = new System.Drawing.Size(583, 107);
            this.DisplayTime.TabIndex = 0;
            this.DisplayTime.Text = "DisplayTime";
            this.DisplayTime.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "タイマー開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio30
            // 
            this.radio30.AutoSize = true;
            this.radio30.Location = new System.Drawing.Point(61, 226);
            this.radio30.Name = "radio30";
            this.radio30.Size = new System.Drawing.Size(89, 28);
            this.radio30.TabIndex = 5;
            this.radio30.TabStop = true;
            this.radio30.Text = "30分";
            this.radio30.UseVisualStyleBackColor = true;
            // 
            // radio60
            // 
            this.radio60.AutoSize = true;
            this.radio60.Location = new System.Drawing.Point(61, 281);
            this.radio60.Name = "radio60";
            this.radio60.Size = new System.Drawing.Size(89, 28);
            this.radio60.TabIndex = 6;
            this.radio60.TabStop = true;
            this.radio60.Text = "60分";
            this.radio60.UseVisualStyleBackColor = true;
            // 
            // radio120
            // 
            this.radio120.AutoSize = true;
            this.radio120.Location = new System.Drawing.Point(61, 338);
            this.radio120.Name = "radio120";
            this.radio120.Size = new System.Drawing.Size(101, 28);
            this.radio120.TabIndex = 7;
            this.radio120.TabStop = true;
            this.radio120.Text = "120分";
            this.radio120.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radio120);
            this.Controls.Add(this.radio60);
            this.Controls.Add(this.radio30);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayTime);
            this.Name = "Form1";
            this.Text = "タイマー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio30;
        private System.Windows.Forms.RadioButton radio60;
        private System.Windows.Forms.RadioButton radio120;
    }
}


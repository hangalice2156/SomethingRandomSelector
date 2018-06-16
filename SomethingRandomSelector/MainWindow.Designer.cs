namespace SomethingRandomSelector
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.button_gnerate = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Ink Free", 16F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(332, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Something Random Selector";
            // 
            // button_gnerate
            // 
            this.button_gnerate.BackColor = System.Drawing.SystemColors.Info;
            this.button_gnerate.Font = new System.Drawing.Font("華康中黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_gnerate.Location = new System.Drawing.Point(18, 84);
            this.button_gnerate.Name = "button_gnerate";
            this.button_gnerate.Size = new System.Drawing.Size(202, 43);
            this.button_gnerate.TabIndex = 1;
            this.button_gnerate.Text = "開始產生";
            this.button_gnerate.UseVisualStyleBackColor = false;
            this.button_gnerate.Click += new System.EventHandler(this.Button_What_to_eat_Click);
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.SystemColors.Info;
            this.button_setting.Font = new System.Drawing.Font("華康中黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_setting.Location = new System.Drawing.Point(18, 175);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(202, 43);
            this.button_setting.TabIndex = 2;
            this.button_setting.Text = "設定資料";
            this.button_setting.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 446);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_gnerate);
            this.Controls.Add(this.Title);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_gnerate;
        private System.Windows.Forms.Button button_setting;
    }
}


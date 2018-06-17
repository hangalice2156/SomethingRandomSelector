namespace SomethingRandomGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SomethingRandomGenerator";
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.Lime;
            this.button_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_generate.Font = new System.Drawing.Font("華康中黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_generate.Location = new System.Drawing.Point(18, 96);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(193, 57);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "開始產生";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.Color.Lime;
            this.button_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_setting.Font = new System.Drawing.Font("華康中黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_setting.Location = new System.Drawing.Point(18, 201);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(193, 57);
            this.button_setting.TabIndex = 2;
            this.button_setting.Text = "設定資料";
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_setting;
    }
}


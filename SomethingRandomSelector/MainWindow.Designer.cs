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
            this.button_What_to_eat = new System.Windows.Forms.Button();
            this.button_Play_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Ink Free", 16F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(93, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(332, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Something Random Selector";
            // 
            // button_What_to_eat
            // 
            this.button_What_to_eat.BackColor = System.Drawing.SystemColors.Info;
            this.button_What_to_eat.Font = new System.Drawing.Font("華康中黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_What_to_eat.Location = new System.Drawing.Point(156, 112);
            this.button_What_to_eat.Name = "button_What_to_eat";
            this.button_What_to_eat.Size = new System.Drawing.Size(202, 43);
            this.button_What_to_eat.TabIndex = 1;
            this.button_What_to_eat.Text = "接下來吃啥";
            this.button_What_to_eat.UseVisualStyleBackColor = false;
            this.button_What_to_eat.Click += new System.EventHandler(this.Button_What_to_eat_Click);
            // 
            // button_Play_game
            // 
            this.button_Play_game.BackColor = System.Drawing.SystemColors.Info;
            this.button_Play_game.Font = new System.Drawing.Font("華康中黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Play_game.Location = new System.Drawing.Point(156, 200);
            this.button_Play_game.Name = "button_Play_game";
            this.button_Play_game.Size = new System.Drawing.Size(202, 43);
            this.button_Play_game.TabIndex = 2;
            this.button_Play_game.Text = "我想玩遊戲";
            this.button_Play_game.UseVisualStyleBackColor = false;
            this.button_Play_game.Click += new System.EventHandler(this.Button_Play_game_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 443);
            this.Controls.Add(this.button_Play_game);
            this.Controls.Add(this.button_What_to_eat);
            this.Controls.Add(this.Title);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_What_to_eat;
        private System.Windows.Forms.Button button_Play_game;
    }
}


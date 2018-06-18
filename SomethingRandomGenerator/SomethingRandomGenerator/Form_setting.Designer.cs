namespace SomethingRandomGenerator
{
    partial class Form_setting
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new SomethingRandomGenerator.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainControlTableAdapter = new SomethingRandomGenerator.Database1DataSetTableAdapters.MainControlTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_main = new System.Windows.Forms.Label();
            this.label_content = new System.Windows.Forms.Label();
            this.textBox_add_table_id = new System.Windows.Forms.TextBox();
            this.button_add_table = new System.Windows.Forms.Button();
            this.textBox_add_content = new System.Windows.Forms.TextBox();
            this.button_add_content = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_id_table = new System.Windows.Forms.Label();
            this.label_name_table = new System.Windows.Forms.Label();
            this.textBox_add_table_name = new System.Windows.Forms.TextBox();
            this.label_count_table = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_content1 = new System.Windows.Forms.Label();
            this.label_content2 = new System.Windows.Forms.Label();
            this.label_content3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(495, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(542, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(495, 191);
            this.dataGridView2.TabIndex = 1;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // mainControlBindingSource
            // 
            this.mainControlBindingSource.DataMember = "MainControl";
            this.mainControlBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // mainControlTableAdapter
            // 
            this.mainControlTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(469, 9);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(67, 15);
            this.label_main.TabIndex = 2;
            this.label_main.Text = "現有表單";
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Location = new System.Drawing.Point(469, 203);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(67, 15);
            this.label_content.TabIndex = 3;
            this.label_content.Text = "表單內容";
            // 
            // textBox_add_table_id
            // 
            this.textBox_add_table_id.Location = new System.Drawing.Point(93, 12);
            this.textBox_add_table_id.Name = "textBox_add_table_id";
            this.textBox_add_table_id.Size = new System.Drawing.Size(165, 25);
            this.textBox_add_table_id.TabIndex = 4;
            // 
            // button_add_table
            // 
            this.button_add_table.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_table.Location = new System.Drawing.Point(93, 161);
            this.button_add_table.Name = "button_add_table";
            this.button_add_table.Size = new System.Drawing.Size(95, 23);
            this.button_add_table.TabIndex = 5;
            this.button_add_table.Text = "新增表單";
            this.button_add_table.UseVisualStyleBackColor = false;
            // 
            // textBox_add_content
            // 
            this.textBox_add_content.Location = new System.Drawing.Point(93, 206);
            this.textBox_add_content.Name = "textBox_add_content";
            this.textBox_add_content.Size = new System.Drawing.Size(165, 25);
            this.textBox_add_content.TabIndex = 6;
            // 
            // button_add_content
            // 
            this.button_add_content.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_content.Location = new System.Drawing.Point(93, 371);
            this.button_add_content.Name = "button_add_content";
            this.button_add_content.Size = new System.Drawing.Size(95, 23);
            this.button_add_content.TabIndex = 7;
            this.button_add_content.Text = "添加項目";
            this.button_add_content.UseVisualStyleBackColor = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 206);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 15);
            this.label_id.TabIndex = 8;
            this.label_id.Text = "編號";
            // 
            // label_id_table
            // 
            this.label_id_table.AutoSize = true;
            this.label_id_table.Location = new System.Drawing.Point(12, 12);
            this.label_id_table.Name = "label_id_table";
            this.label_id_table.Size = new System.Drawing.Size(37, 15);
            this.label_id_table.TabIndex = 9;
            this.label_id_table.Text = "編號";
            // 
            // label_name_table
            // 
            this.label_name_table.AutoSize = true;
            this.label_name_table.Location = new System.Drawing.Point(12, 59);
            this.label_name_table.Name = "label_name_table";
            this.label_name_table.Size = new System.Drawing.Size(37, 15);
            this.label_name_table.TabIndex = 10;
            this.label_name_table.Text = "名稱";
            // 
            // textBox_add_table_name
            // 
            this.textBox_add_table_name.Location = new System.Drawing.Point(93, 59);
            this.textBox_add_table_name.Name = "textBox_add_table_name";
            this.textBox_add_table_name.Size = new System.Drawing.Size(165, 25);
            this.textBox_add_table_name.TabIndex = 11;
            // 
            // label_count_table
            // 
            this.label_count_table.AutoSize = true;
            this.label_count_table.Location = new System.Drawing.Point(12, 106);
            this.label_count_table.Name = "label_count_table";
            this.label_count_table.Size = new System.Drawing.Size(67, 15);
            this.label_count_table.TabIndex = 12;
            this.label_count_table.Text = "項目數量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 25);
            this.textBox1.TabIndex = 13;
            // 
            // label_content1
            // 
            this.label_content1.AutoSize = true;
            this.label_content1.Location = new System.Drawing.Point(12, 248);
            this.label_content1.Name = "label_content1";
            this.label_content1.Size = new System.Drawing.Size(52, 15);
            this.label_content1.TabIndex = 14;
            this.label_content1.Text = "項目一";
            // 
            // label_content2
            // 
            this.label_content2.AutoSize = true;
            this.label_content2.Location = new System.Drawing.Point(12, 290);
            this.label_content2.Name = "label_content2";
            this.label_content2.Size = new System.Drawing.Size(52, 15);
            this.label_content2.TabIndex = 15;
            this.label_content2.Text = "項目二";
            // 
            // label_content3
            // 
            this.label_content3.AutoSize = true;
            this.label_content3.Location = new System.Drawing.Point(12, 332);
            this.label_content3.Name = "label_content3";
            this.label_content3.Size = new System.Drawing.Size(52, 15);
            this.label_content3.TabIndex = 16;
            this.label_content3.Text = "項目三";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 25);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 25);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 25);
            this.textBox4.TabIndex = 19;
            // 
            // button_modify
            // 
            this.button_modify.BackColor = System.Drawing.SystemColors.Control;
            this.button_modify.Location = new System.Drawing.Point(239, 371);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(95, 23);
            this.button_modify.TabIndex = 20;
            this.button_modify.Text = "修改項目";
            this.button_modify.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete.Location = new System.Drawing.Point(385, 371);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(95, 23);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "移除項目";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // Form_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 464);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_content3);
            this.Controls.Add(this.label_content2);
            this.Controls.Add(this.label_content1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_count_table);
            this.Controls.Add(this.textBox_add_table_name);
            this.Controls.Add(this.label_name_table);
            this.Controls.Add(this.label_id_table);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_add_content);
            this.Controls.Add(this.textBox_add_content);
            this.Controls.Add(this.button_add_table);
            this.Controls.Add(this.textBox_add_table_id);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_setting";
            this.Text = "Form_setting";
            this.Load += new System.EventHandler(this.Form_setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource mainControlBindingSource;
        private Database1DataSetTableAdapters.MainControlTableAdapter mainControlTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.TextBox textBox_add_table_id;
        private System.Windows.Forms.Button button_add_table;
        private System.Windows.Forms.TextBox textBox_add_content;
        private System.Windows.Forms.Button button_add_content;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_id_table;
        private System.Windows.Forms.Label label_name_table;
        private System.Windows.Forms.TextBox textBox_add_table_name;
        private System.Windows.Forms.Label label_count_table;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_content1;
        private System.Windows.Forms.Label label_content2;
        private System.Windows.Forms.Label label_content3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_delete;
    }
}
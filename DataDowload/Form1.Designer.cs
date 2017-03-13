namespace DataDowload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_dowload = new System.Windows.Forms.Button();
            this.tbx_query = new System.Windows.Forms.TextBox();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_file = new System.Windows.Forms.Button();
            this.path_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置保存文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_queryCity = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dowload
            // 
            this.btn_dowload.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dowload.Location = new System.Drawing.Point(617, 77);
            this.btn_dowload.Name = "btn_dowload";
            this.btn_dowload.Size = new System.Drawing.Size(103, 38);
            this.btn_dowload.TabIndex = 0;
            this.btn_dowload.Text = "下载";
            this.btn_dowload.UseVisualStyleBackColor = true;
            this.btn_dowload.Click += new System.EventHandler(this.btn_dowload_Click);
            // 
            // tbx_query
            // 
            this.tbx_query.Location = new System.Drawing.Point(240, 54);
            this.tbx_query.Name = "tbx_query";
            this.tbx_query.Size = new System.Drawing.Size(289, 28);
            this.tbx_query.TabIndex = 1;
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(49, 261);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(707, 165);
            this.rtb_result.TabIndex = 2;
            this.rtb_result.Text = "";
            this.rtb_result.TextChanged += new System.EventHandler(this.rtb_result_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置保存文件夹ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入查询内容";
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_file.Location = new System.Drawing.Point(581, 154);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(175, 39);
            this.btn_file.TabIndex = 5;
            this.btn_file.Text = "设置保存文件夹";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // path_text
            // 
            this.path_text.Location = new System.Drawing.Point(240, 160);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(289, 28);
            this.path_text.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "搜索结果";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 设置保存文件夹ToolStripMenuItem
            // 
            this.设置保存文件夹ToolStripMenuItem.Name = "设置保存文件夹ToolStripMenuItem";
            this.设置保存文件夹ToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.设置保存文件夹ToolStripMenuItem.Text = "设置保存文件夹";
            this.设置保存文件夹ToolStripMenuItem.Click += new System.EventHandler(this.设置保存文件夹ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "文件夹路径";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(44, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "输入查询城市";
            // 
            // tbx_queryCity
            // 
            this.tbx_queryCity.Location = new System.Drawing.Point(240, 107);
            this.tbx_queryCity.Name = "tbx_queryCity";
            this.tbx_queryCity.Size = new System.Drawing.Size(289, 28);
            this.tbx_queryCity.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_queryCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path_text);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.tbx_query);
            this.Controls.Add(this.btn_dowload);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "坐标爬取";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dowload;
        private System.Windows.Forms.TextBox tbx_query;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox path_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置保存文件夹ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_queryCity;
    }
}


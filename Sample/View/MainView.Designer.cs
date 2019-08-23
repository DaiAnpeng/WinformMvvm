namespace Sample.View
{
    partial class MainView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Page1 = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Page1
            // 
            this.Page1.Location = new System.Drawing.Point(75, 342);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(75, 23);
            this.Page1.TabIndex = 1;
            this.Page1.Text = "页面1";
            this.Page1.UseVisualStyleBackColor = true;
            this.Page1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(426, 342);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(75, 23);
            this.Page2.TabIndex = 2;
            this.Page2.Text = "页面2";
            this.Page2.UseVisualStyleBackColor = true;
            this.Page2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 309);
            this.panel1.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Page2);
            this.Controls.Add(this.Page1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(603, 388);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Page1;
        private System.Windows.Forms.Button Page2;
        private System.Windows.Forms.Panel panel1;
    }
}

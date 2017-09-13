namespace FormsDotNet2
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
            this.Demo = new System.Windows.Forms.Button();
            this.storeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Demo
            // 
            this.Demo.Location = new System.Drawing.Point(12, 88);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(75, 23);
            this.Demo.TabIndex = 0;
            this.Demo.Text = "Demo";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // storeID
            // 
            this.storeID.Location = new System.Drawing.Point(13, 52);
            this.storeID.Name = "storeID";
            this.storeID.Size = new System.Drawing.Size(100, 21);
            this.storeID.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.storeID);
            this.Controls.Add(this.Demo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.TextBox storeID;
    }
}


namespace cefSharp
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowDebug = new System.Windows.Forms.Button();
            this.btnLoadLocalHtml = new System.Windows.Forms.Button();
            this.txtTargetUrl = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "调用页面JS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "下一页";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "上一页";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowDebug
            // 
            this.btnShowDebug.Location = new System.Drawing.Point(825, 12);
            this.btnShowDebug.Name = "btnShowDebug";
            this.btnShowDebug.Size = new System.Drawing.Size(100, 28);
            this.btnShowDebug.TabIndex = 11;
            this.btnShowDebug.Text = "显示调试";
            this.btnShowDebug.UseVisualStyleBackColor = true;
            this.btnShowDebug.Click += new System.EventHandler(this.btnShowDebug_Click);
            // 
            // btnLoadLocalHtml
            // 
            this.btnLoadLocalHtml.Location = new System.Drawing.Point(261, 12);
            this.btnLoadLocalHtml.Name = "btnLoadLocalHtml";
            this.btnLoadLocalHtml.Size = new System.Drawing.Size(141, 28);
            this.btnLoadLocalHtml.TabIndex = 10;
            this.btnLoadLocalHtml.Text = "加载本地页面";
            this.btnLoadLocalHtml.UseVisualStyleBackColor = true;
            this.btnLoadLocalHtml.Click += new System.EventHandler(this.btnLoadLocalHtml_Click);
            // 
            // txtTargetUrl
            // 
            this.txtTargetUrl.Location = new System.Drawing.Point(93, 12);
            this.txtTargetUrl.Name = "txtTargetUrl";
            this.txtTargetUrl.Size = new System.Drawing.Size(148, 28);
            this.txtTargetUrl.TabIndex = 9;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(12, 12);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(75, 28);
            this.btnTarget.TabIndex = 8;
            this.btnTarget.Text = "跳转";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 572);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowDebug);
            this.Controls.Add(this.btnLoadLocalHtml);
            this.Controls.Add(this.txtTargetUrl);
            this.Controls.Add(this.btnTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowDebug;
        private System.Windows.Forms.Button btnLoadLocalHtml;
        private System.Windows.Forms.TextBox txtTargetUrl;
        private System.Windows.Forms.Button btnTarget;
    }
}


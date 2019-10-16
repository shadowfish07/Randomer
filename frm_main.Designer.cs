namespace 随机器_new
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btn_command = new System.Windows.Forms.Button();
            this.txt_min_num = new System.Windows.Forms.TextBox();
            this.txt_max_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_num.Location = new System.Drawing.Point(93, 58);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(288, 154);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "00";
            this.lbl_num.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_command
            // 
            this.btn_command.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_command.Location = new System.Drawing.Point(136, 234);
            this.btn_command.Name = "btn_command";
            this.btn_command.Size = new System.Drawing.Size(185, 44);
            this.btn_command.TabIndex = 1;
            this.btn_command.Text = "开始";
            this.btn_command.UseVisualStyleBackColor = true;
            this.btn_command.Click += new System.EventHandler(this.btn_command_Click);
            // 
            // txt_min_num
            // 
            this.txt_min_num.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_min_num.Location = new System.Drawing.Point(142, 21);
            this.txt_min_num.Name = "txt_min_num";
            this.txt_min_num.Size = new System.Drawing.Size(60, 34);
            this.txt_min_num.TabIndex = 2;
            this.txt_min_num.Text = "1";
            this.txt_min_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_min_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_min_num_KeyPress);
            // 
            // txt_max_num
            // 
            this.txt_max_num.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_max_num.Location = new System.Drawing.Point(288, 21);
            this.txt_max_num.Name = "txt_max_num";
            this.txt_max_num.Size = new System.Drawing.Size(60, 34);
            this.txt_max_num.TabIndex = 3;
            this.txt_max_num.Text = "40";
            this.txt_max_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_max_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_max_num_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "MAX";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_max_num);
            this.Controls.Add(this.txt_min_num);
            this.Controls.Add(this.btn_command);
            this.Controls.Add(this.lbl_num);
            this.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_main";
            this.Text = "随机器";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btn_command;
        private System.Windows.Forms.TextBox txt_min_num;
        private System.Windows.Forms.TextBox txt_max_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}


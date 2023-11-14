namespace UserControlBase
{
    partial class ADDTool
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
            tb_Num1 = new TextBox();
            label1 = new Label();
            tb_Num2 = new TextBox();
            label2 = new Label();
            tb_Total = new TextBox();
            btn_Cal = new Button();
            SuspendLayout();
            // 
            // tb_Num1
            // 
            tb_Num1.BorderStyle = BorderStyle.FixedSingle;
            tb_Num1.Location = new Point(14, 11);
            tb_Num1.Name = "tb_Num1";
            tb_Num1.Size = new Size(112, 30);
            tb_Num1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 13);
            label1.Name = "label1";
            label1.Size = new Size(23, 24);
            label1.TabIndex = 1;
            label1.Text = "+";
            // 
            // tb_Num2
            // 
            tb_Num2.BorderStyle = BorderStyle.FixedSingle;
            tb_Num2.Location = new Point(161, 11);
            tb_Num2.Name = "tb_Num2";
            tb_Num2.Size = new Size(112, 30);
            tb_Num2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 13);
            label2.Name = "label2";
            label2.Size = new Size(23, 24);
            label2.TabIndex = 3;
            label2.Text = "=";
            // 
            // tb_Total
            // 
            tb_Total.BorderStyle = BorderStyle.FixedSingle;
            tb_Total.Location = new Point(308, 11);
            tb_Total.Name = "tb_Total";
            tb_Total.ReadOnly = true;
            tb_Total.Size = new Size(150, 30);
            tb_Total.TabIndex = 4;
            // 
            // btn_Cal
            // 
            btn_Cal.Location = new Point(322, 47);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(112, 34);
            btn_Cal.TabIndex = 5;
            btn_Cal.Text = "Cal";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // ADDTool
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Cal);
            Controls.Add(tb_Total);
            Controls.Add(label2);
            Controls.Add(tb_Num2);
            Controls.Add(label1);
            Controls.Add(tb_Num1);
            Name = "ADDTool";
            Size = new Size(464, 90);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Num1;
        private Label label1;
        private TextBox tb_Num2;
        private Label label2;
        private TextBox tb_Total;
        private Button btn_Cal;
    }
}

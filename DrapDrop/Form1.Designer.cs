namespace DrapDrop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Add = new Label();
            lb_Sub = new Label();
            panelBase1 = new UserControlBase.PanelBase();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lb_Add
            // 
            lb_Add.AutoSize = true;
            lb_Add.Location = new Point(33, 472);
            lb_Add.Name = "lb_Add";
            lb_Add.Size = new Size(88, 24);
            lb_Add.TabIndex = 4;
            lb_Add.Text = "ADDTool";
            // 
            // lb_Sub
            // 
            lb_Sub.AutoSize = true;
            lb_Sub.Location = new Point(157, 472);
            lb_Sub.Name = "lb_Sub";
            lb_Sub.Size = new Size(81, 24);
            lb_Sub.TabIndex = 5;
            lb_Sub.Text = "SUBTool";
            // 
            // panelBase1
            // 
            panelBase1.AllowDrop = true;
            panelBase1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelBase1.AutoScroll = true;
            panelBase1.BorderStyle = BorderStyle.FixedSingle;
            panelBase1.Location = new Point(294, 0);
            panelBase1.Name = "panelBase1";
            panelBase1.Size = new Size(678, 595);
            panelBase1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(978, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 595);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 596);
            Controls.Add(panel1);
            Controls.Add(panelBase1);
            Controls.Add(lb_Sub);
            Controls.Add(lb_Add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Add;
        private Label lb_Sub;
        private UserControlBase.PanelBase panelBase1;
        private Panel panel1;
    }
}
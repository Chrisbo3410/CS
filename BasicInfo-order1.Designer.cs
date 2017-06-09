namespace bishe
{
    partial class BasicInfo_order1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1月");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2月");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3月");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4月");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("5月");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2017年", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1月");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2月");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("3月");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("4月");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("5月");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("6月");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("7月");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("8月");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("9月");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("10月");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("11月");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("12月");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("2016年", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("订单日期", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode19});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "1月";
            treeNode2.Name = "节点4";
            treeNode2.Text = "2月";
            treeNode3.Name = "节点5";
            treeNode3.Text = "3月";
            treeNode4.Name = "节点6";
            treeNode4.Text = "4月";
            treeNode5.Name = "节点7";
            treeNode5.Text = "5月";
            treeNode6.Name = "节点1";
            treeNode6.Text = "2017年";
            treeNode7.Name = "节点15";
            treeNode7.Text = "1月";
            treeNode8.Name = "节点16";
            treeNode8.Text = "2月";
            treeNode9.Name = "节点17";
            treeNode9.Text = "3月";
            treeNode10.Name = "节点18";
            treeNode10.Text = "4月";
            treeNode11.Name = "节点19";
            treeNode11.Text = "5月";
            treeNode12.Name = "节点8";
            treeNode12.Text = "6月";
            treeNode13.Name = "节点9";
            treeNode13.Text = "7月";
            treeNode14.Name = "节点10";
            treeNode14.Text = "8月";
            treeNode15.Name = "节点11";
            treeNode15.Text = "9月";
            treeNode16.Name = "节点12";
            treeNode16.Text = "10月";
            treeNode17.Name = "节点13";
            treeNode17.Text = "11月";
            treeNode18.Name = "节点14";
            treeNode18.Text = "12月";
            treeNode19.Name = "节点2";
            treeNode19.Text = "2016年";
            treeNode20.Name = "节点0";
            treeNode20.Text = "订单日期";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(258, 637);
            this.treeView1.TabIndex = 0;
            // 
            // BasicInfo_order1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 661);
            this.Controls.Add(this.treeView1);
            this.Name = "BasicInfo_order1";
            this.Text = "BasicInfo_order1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
namespace bishe
{
    partial class Gantt1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("生产线1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("生产线2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("装配1车间", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("生产线1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("生产线2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("装配2车间", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("总装线");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("总装车间", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("安徽流体传动股份有限公司", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点4";
            treeNode1.Text = "生产线1";
            treeNode2.Name = "节点5";
            treeNode2.Text = "生产线2";
            treeNode3.Name = "节点1";
            treeNode3.Text = "装配1车间";
            treeNode4.Name = "节点6";
            treeNode4.Text = "生产线1";
            treeNode5.Name = "节点7";
            treeNode5.Text = "生产线2";
            treeNode6.Name = "节点2";
            treeNode6.Text = "装配2车间";
            treeNode7.Name = "节点8";
            treeNode7.Text = "总装线";
            treeNode8.Name = "节点3";
            treeNode8.Text = "总装车间";
            treeNode9.Name = "节点0";
            treeNode9.Text = "安徽流体传动股份有限公司";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(258, 604);
            this.treeView1.TabIndex = 0;
            // 
            // Gantt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 628);
            this.Controls.Add(this.treeView1);
            this.Name = "Gantt1";
            this.Text = "Gantt1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
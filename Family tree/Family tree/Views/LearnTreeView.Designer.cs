namespace Family_tree.Views
{
    partial class LearnTreeView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditNode = new System.Windows.Forms.Button();
            this.buttonDeleteNode = new System.Windows.Forms.Button();
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.textBoxNodeName = new System.Windows.Forms.TextBox();
            this.labelNodeName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditNode);
            this.panel1.Controls.Add(this.buttonDeleteNode);
            this.panel1.Controls.Add(this.buttonAddNode);
            this.panel1.Controls.Add(this.textBoxNodeName);
            this.panel1.Controls.Add(this.labelNodeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 444);
            this.panel1.TabIndex = 0;
            // 
            // buttonEditNode
            // 
            this.buttonEditNode.Location = new System.Drawing.Point(194, 102);
            this.buttonEditNode.Name = "buttonEditNode";
            this.buttonEditNode.Size = new System.Drawing.Size(75, 23);
            this.buttonEditNode.TabIndex = 5;
            this.buttonEditNode.Text = "Edit Node";
            this.buttonEditNode.UseVisualStyleBackColor = true;
            this.buttonEditNode.Click += new System.EventHandler(this.buttonEditNode_Click);
            // 
            // buttonDeleteNode
            // 
            this.buttonDeleteNode.Location = new System.Drawing.Point(98, 102);
            this.buttonDeleteNode.Name = "buttonDeleteNode";
            this.buttonDeleteNode.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteNode.TabIndex = 4;
            this.buttonDeleteNode.Text = "Delete Node";
            this.buttonDeleteNode.UseVisualStyleBackColor = true;
            this.buttonDeleteNode.Click += new System.EventHandler(this.buttonDeleteNode_Click);
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(17, 102);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNode.TabIndex = 3;
            this.buttonAddNode.Text = "Add Node";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // textBoxNodeName
            // 
            this.textBoxNodeName.Location = new System.Drawing.Point(98, 43);
            this.textBoxNodeName.Name = "textBoxNodeName";
            this.textBoxNodeName.Size = new System.Drawing.Size(200, 23);
            this.textBoxNodeName.TabIndex = 2;
            // 
            // labelNodeName
            // 
            this.labelNodeName.AutoSize = true;
            this.labelNodeName.Location = new System.Drawing.Point(21, 46);
            this.labelNodeName.Name = "labelNodeName";
            this.labelNodeName.Size = new System.Drawing.Size(71, 15);
            this.labelNodeName.TabIndex = 0;
            this.labelNodeName.Text = "Node Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(323, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 444);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(474, 444);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // LearnTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LearnTreeView";
            this.Text = "LearnTreeView";
            this.Load += new System.EventHandler(this.LearnTreeView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonEditNode;
        private Button buttonDeleteNode;
        private Button buttonAddNode;
        private TextBox textBoxNodeName;
        private Label labelNodeName;
        private Panel panel2;
        private TreeView treeView1;
    }
}
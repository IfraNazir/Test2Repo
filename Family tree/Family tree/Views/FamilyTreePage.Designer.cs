namespace Family_tree.Views
{
    partial class FamilyTreePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyTreePage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSaveDescription = new System.Windows.Forms.Button();
            this.richTextBoxFamilyDescription = new System.Windows.Forms.RichTextBox();
            this.labelFamilyDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewFamilyTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(396, 514);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 88);
            this.panel5.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(376, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Add Nodes";
            this.toolStripButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "toolStripButton2";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton4";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.buttonSaveDescription);
            this.panel4.Controls.Add(this.richTextBoxFamilyDescription);
            this.panel4.Controls.Add(this.labelFamilyDescription);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(10, 97);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(376, 407);
            this.panel4.TabIndex = 1;
            // 
            // buttonSaveDescription
            // 
            this.buttonSaveDescription.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveDescription.Location = new System.Drawing.Point(271, 267);
            this.buttonSaveDescription.Name = "buttonSaveDescription";
            this.buttonSaveDescription.Size = new System.Drawing.Size(92, 36);
            this.buttonSaveDescription.TabIndex = 0;
            this.buttonSaveDescription.Text = "SAVE";
            this.buttonSaveDescription.UseVisualStyleBackColor = true;
            this.buttonSaveDescription.Click += new System.EventHandler(this.buttonSaveDescription_Click);
            // 
            // richTextBoxFamilyDescription
            // 
            this.richTextBoxFamilyDescription.Location = new System.Drawing.Point(27, 96);
            this.richTextBoxFamilyDescription.Name = "richTextBoxFamilyDescription";
            this.richTextBoxFamilyDescription.Size = new System.Drawing.Size(320, 134);
            this.richTextBoxFamilyDescription.TabIndex = 1;
            this.richTextBoxFamilyDescription.Text = "";
            // 
            // labelFamilyDescription
            // 
            this.labelFamilyDescription.AutoSize = true;
            this.labelFamilyDescription.Location = new System.Drawing.Point(22, 60);
            this.labelFamilyDescription.Name = "labelFamilyDescription";
            this.labelFamilyDescription.Size = new System.Drawing.Size(188, 23);
            this.labelFamilyDescription.TabIndex = 0;
            this.labelFamilyDescription.Text = "Family Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 87);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TREE VIEW";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeViewFamilyTree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(396, 514);
            this.panel2.TabIndex = 1;
            // 
            // treeViewFamilyTree
            // 
            this.treeViewFamilyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFamilyTree.Location = new System.Drawing.Point(10, 10);
            this.treeViewFamilyTree.Name = "treeViewFamilyTree";
            this.treeViewFamilyTree.Size = new System.Drawing.Size(376, 494);
            this.treeViewFamilyTree.TabIndex = 0;
            this.treeViewFamilyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFamilyTree_AfterSelect);
            this.treeViewFamilyTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFamilyTree_NodeMouseClick);
            // 
            // FamilyTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FamilyTreeView";
            this.Text = "FamilyTreeView";
            this.Load += new System.EventHandler(this.FamilyTreeView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TreeView treeViewFamilyTree;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label labelFamilyDescription;
        private RichTextBox richTextBoxFamilyDescription;
        private Button buttonSaveDescription;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonDelete;
    }
}
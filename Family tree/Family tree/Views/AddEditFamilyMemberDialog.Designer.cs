namespace Family_tree.Views
{
    partial class AddEditFamilyMemberDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEditNodeName = new System.Windows.Forms.Button();
            this.buttonAddNodeName = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Nodes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNodeName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 169);
            this.panel2.TabIndex = 2;
            // 
            // textBoxNodeName
            // 
            this.textBoxNodeName.Location = new System.Drawing.Point(27, 54);
            this.textBoxNodeName.Name = "textBoxNodeName";
            this.textBoxNodeName.Size = new System.Drawing.Size(275, 23);
            this.textBoxNodeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Node Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonEditNodeName);
            this.panel3.Controls.Add(this.buttonAddNodeName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 59);
            this.panel3.TabIndex = 3;
            // 
            // buttonEditNodeName
            // 
            this.buttonEditNodeName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditNodeName.Location = new System.Drawing.Point(144, 15);
            this.buttonEditNodeName.Name = "buttonEditNodeName";
            this.buttonEditNodeName.Size = new System.Drawing.Size(85, 32);
            this.buttonEditNodeName.TabIndex = 1;
            this.buttonEditNodeName.Text = "Edit";
            this.buttonEditNodeName.UseVisualStyleBackColor = true;
            this.buttonEditNodeName.Click += new System.EventHandler(this.buttonEditNodeName_Click);
            // 
            // buttonAddNodeName
            // 
            this.buttonAddNodeName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNodeName.Location = new System.Drawing.Point(235, 15);
            this.buttonAddNodeName.Name = "buttonAddNodeName";
            this.buttonAddNodeName.Size = new System.Drawing.Size(88, 32);
            this.buttonAddNodeName.TabIndex = 0;
            this.buttonAddNodeName.Text = "Save";
            this.buttonAddNodeName.UseVisualStyleBackColor = true;
            this.buttonAddNodeName.Click += new System.EventHandler(this.buttonAddNodeName_Click);
            // 
            // AddEditFamilyMemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 224);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(342, 263);
            this.Name = "AddEditFamilyMemberDialog";
            this.Text = "AddNodes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textBoxNodeName;
        private Button buttonAddNodeName;
        private Button buttonEditNodeName;
    }
}
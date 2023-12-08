namespace Family_tree
{
    partial class FamilyTitlePage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxFamilyTitle = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFamilyTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewFamilyName = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilyName)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
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
            this.panel1.Size = new System.Drawing.Size(394, 444);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 54);
            this.panel5.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(286, 14);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 37);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxAddress);
            this.panel4.Controls.Add(this.textBoxFamilyTitle);
            this.panel4.Controls.Add(this.labelAddress);
            this.panel4.Controls.Add(this.labelFamilyTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(10, 66);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(374, 368);
            this.panel4.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(13, 219);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(348, 30);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxFamilyTitle
            // 
            this.textBoxFamilyTitle.Location = new System.Drawing.Point(13, 109);
            this.textBoxFamilyTitle.Name = "textBoxFamilyTitle";
            this.textBoxFamilyTitle.Size = new System.Drawing.Size(348, 30);
            this.textBoxFamilyTitle.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(27, 172);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(86, 23);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelFamilyTitle
            // 
            this.labelFamilyTitle.AutoSize = true;
            this.labelFamilyTitle.Location = new System.Drawing.Point(27, 63);
            this.labelFamilyTitle.Name = "labelFamilyTitle";
            this.labelFamilyTitle.Size = new System.Drawing.Size(122, 23);
            this.labelFamilyTitle.TabIndex = 1;
            this.labelFamilyTitle.Text = "Family Title";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelHeading);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 56);
            this.panel3.TabIndex = 0;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeading.Location = new System.Drawing.Point(119, 21);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(73, 23);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "INDEX";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFamilyName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(403, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(394, 444);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewFamilyName
            // 
            this.dataGridViewFamilyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFamilyName.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewFamilyName.Name = "dataGridViewFamilyName";
            this.dataGridViewFamilyName.RowTemplate.Height = 25;
            this.dataGridViewFamilyName.Size = new System.Drawing.Size(374, 424);
            this.dataGridViewFamilyName.TabIndex = 0;
            this.dataGridViewFamilyName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFamilyName_CellDoubleClick);
            // 
            // FamilyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FamilyName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FamilyName_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewFamilyName;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label labelHeading;
        private TextBox textBoxAddress;
        private TextBox textBoxFamilyTitle;
        private Label labelAddress;
        private Label labelFamilyTitle;
        private Button buttonSave;
    }
}
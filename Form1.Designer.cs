namespace ConvertPDFToText
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uxButtonGet = new System.Windows.Forms.Button();
            this.uxGBSource = new System.Windows.Forms.GroupBox();
            this.uxLabelFileLocation = new System.Windows.Forms.Label();
            this.uxTextBoxFileLocation = new System.Windows.Forms.TextBox();
            this.uxRadioButtonLocalFile = new System.Windows.Forms.RadioButton();
            this.uxRadioButtonWeb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxLabelDestination = new System.Windows.Forms.Label();
            this.uxTextBoxDestination = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uxGBSource.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxButtonGet
            // 
            this.uxButtonGet.Location = new System.Drawing.Point(359, 192);
            this.uxButtonGet.Name = "uxButtonGet";
            this.uxButtonGet.Size = new System.Drawing.Size(75, 23);
            this.uxButtonGet.TabIndex = 0;
            this.uxButtonGet.Text = "Get";
            this.uxButtonGet.UseVisualStyleBackColor = true;
            this.uxButtonGet.Click += new System.EventHandler(this.uxButtonGet_Click);
            // 
            // uxGBSource
            // 
            this.uxGBSource.Controls.Add(this.uxLabelFileLocation);
            this.uxGBSource.Controls.Add(this.uxTextBoxFileLocation);
            this.uxGBSource.Controls.Add(this.uxRadioButtonLocalFile);
            this.uxGBSource.Controls.Add(this.uxRadioButtonWeb);
            this.uxGBSource.Location = new System.Drawing.Point(12, 28);
            this.uxGBSource.Name = "uxGBSource";
            this.uxGBSource.Size = new System.Drawing.Size(422, 69);
            this.uxGBSource.TabIndex = 1;
            this.uxGBSource.TabStop = false;
            this.uxGBSource.Text = "Source";
            // 
            // uxLabelFileLocation
            // 
            this.uxLabelFileLocation.AutoSize = true;
            this.uxLabelFileLocation.Location = new System.Drawing.Point(92, 23);
            this.uxLabelFileLocation.Name = "uxLabelFileLocation";
            this.uxLabelFileLocation.Size = new System.Drawing.Size(67, 13);
            this.uxLabelFileLocation.TabIndex = 3;
            this.uxLabelFileLocation.Text = "File Location";
            // 
            // uxTextBoxFileLocation
            // 
            this.uxTextBoxFileLocation.Location = new System.Drawing.Point(92, 42);
            this.uxTextBoxFileLocation.Name = "uxTextBoxFileLocation";
            this.uxTextBoxFileLocation.Size = new System.Drawing.Size(324, 20);
            this.uxTextBoxFileLocation.TabIndex = 2;
            this.uxTextBoxFileLocation.DoubleClick += new System.EventHandler(this.uxTextBoxFileLocation_DoubleClick);
            // 
            // uxRadioButtonLocalFile
            // 
            this.uxRadioButtonLocalFile.AutoSize = true;
            this.uxRadioButtonLocalFile.Location = new System.Drawing.Point(7, 42);
            this.uxRadioButtonLocalFile.Name = "uxRadioButtonLocalFile";
            this.uxRadioButtonLocalFile.Size = new System.Drawing.Size(70, 17);
            this.uxRadioButtonLocalFile.TabIndex = 1;
            this.uxRadioButtonLocalFile.Text = "Local File";
            this.uxRadioButtonLocalFile.UseVisualStyleBackColor = true;
            // 
            // uxRadioButtonWeb
            // 
            this.uxRadioButtonWeb.AutoSize = true;
            this.uxRadioButtonWeb.Checked = true;
            this.uxRadioButtonWeb.Location = new System.Drawing.Point(7, 19);
            this.uxRadioButtonWeb.Name = "uxRadioButtonWeb";
            this.uxRadioButtonWeb.Size = new System.Drawing.Size(48, 17);
            this.uxRadioButtonWeb.TabIndex = 0;
            this.uxRadioButtonWeb.TabStop = true;
            this.uxRadioButtonWeb.Text = "Web";
            this.uxRadioButtonWeb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxLabelDestination);
            this.groupBox1.Controls.Add(this.uxTextBoxDestination);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination";
            // 
            // uxLabelDestination
            // 
            this.uxLabelDestination.AutoSize = true;
            this.uxLabelDestination.Location = new System.Drawing.Point(6, 31);
            this.uxLabelDestination.Name = "uxLabelDestination";
            this.uxLabelDestination.Size = new System.Drawing.Size(104, 13);
            this.uxLabelDestination.TabIndex = 1;
            this.uxLabelDestination.Text = "Destination Location";
            // 
            // uxTextBoxDestination
            // 
            this.uxTextBoxDestination.Location = new System.Drawing.Point(116, 31);
            this.uxTextBoxDestination.Name = "uxTextBoxDestination";
            this.uxTextBoxDestination.Size = new System.Drawing.Size(300, 20);
            this.uxTextBoxDestination.TabIndex = 0;
            this.uxTextBoxDestination.DoubleClick += new System.EventHandler(this.uxTextBoxDestination_DoubleClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pdf";
            this.openFileDialog.Filter = "PDF (*.pdf)|*.pdf|All Files (*.*)|*.*";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(446, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 227);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxGBSource);
            this.Controls.Add(this.uxButtonGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF To Text";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.uxGBSource.ResumeLayout(false);
            this.uxGBSource.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButtonGet;
        private System.Windows.Forms.GroupBox uxGBSource;
        private System.Windows.Forms.RadioButton uxRadioButtonLocalFile;
        private System.Windows.Forms.RadioButton uxRadioButtonWeb;
        private System.Windows.Forms.TextBox uxTextBoxFileLocation;
        private System.Windows.Forms.Label uxLabelFileLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label uxLabelDestination;
        private System.Windows.Forms.TextBox uxTextBoxDestination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}


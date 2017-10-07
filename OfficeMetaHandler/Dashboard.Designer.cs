namespace OfficeMetaHandler
{
    partial class Dashboard
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
            this.gbFormFields = new System.Windows.Forms.GroupBox();
            this.btnExtractFormFields = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExtraction = new System.Windows.Forms.TabPage();
            this.gbContentControls = new System.Windows.Forms.GroupBox();
            this.btnExtractContentControls = new System.Windows.Forms.Button();
            this.tabFill = new System.Windows.Forms.TabPage();
            this.dgwFill = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbCurrentFileTitle = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbFormFields.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabExtraction.SuspendLayout();
            this.gbContentControls.SuspendLayout();
            this.tabFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFill)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFormFields
            // 
            this.gbFormFields.Controls.Add(this.btnExtractFormFields);
            this.gbFormFields.Location = new System.Drawing.Point(6, 17);
            this.gbFormFields.Name = "gbFormFields";
            this.gbFormFields.Size = new System.Drawing.Size(730, 122);
            this.gbFormFields.TabIndex = 0;
            this.gbFormFields.TabStop = false;
            this.gbFormFields.Text = "Form Fields";
            // 
            // btnExtractFormFields
            // 
            this.btnExtractFormFields.Enabled = false;
            this.btnExtractFormFields.Location = new System.Drawing.Point(29, 43);
            this.btnExtractFormFields.Name = "btnExtractFormFields";
            this.btnExtractFormFields.Size = new System.Drawing.Size(187, 48);
            this.btnExtractFormFields.TabIndex = 0;
            this.btnExtractFormFields.Text = "Extract";
            this.btnExtractFormFields.UseVisualStyleBackColor = true;
            this.btnExtractFormFields.Click += new System.EventHandler(this.BtnExtractFormFields_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExtraction);
            this.tabControl1.Controls.Add(this.tabFill);
            this.tabControl1.Location = new System.Drawing.Point(12, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 487);
            this.tabControl1.TabIndex = 1;
            // 
            // tabExtraction
            // 
            this.tabExtraction.Controls.Add(this.gbContentControls);
            this.tabExtraction.Controls.Add(this.gbFormFields);
            this.tabExtraction.Location = new System.Drawing.Point(8, 39);
            this.tabExtraction.Name = "tabExtraction";
            this.tabExtraction.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtraction.Size = new System.Drawing.Size(752, 392);
            this.tabExtraction.TabIndex = 0;
            this.tabExtraction.Text = "Extraction";
            this.tabExtraction.UseVisualStyleBackColor = true;
            // 
            // gbContentControls
            // 
            this.gbContentControls.Controls.Add(this.btnExtractContentControls);
            this.gbContentControls.Location = new System.Drawing.Point(11, 135);
            this.gbContentControls.Name = "gbContentControls";
            this.gbContentControls.Size = new System.Drawing.Size(730, 122);
            this.gbContentControls.TabIndex = 1;
            this.gbContentControls.TabStop = false;
            this.gbContentControls.Text = "Content Controls";
            // 
            // btnExtractContentControls
            // 
            this.btnExtractContentControls.Enabled = false;
            this.btnExtractContentControls.Location = new System.Drawing.Point(29, 43);
            this.btnExtractContentControls.Name = "btnExtractContentControls";
            this.btnExtractContentControls.Size = new System.Drawing.Size(187, 48);
            this.btnExtractContentControls.TabIndex = 0;
            this.btnExtractContentControls.Text = "Extract";
            this.btnExtractContentControls.UseVisualStyleBackColor = true;
            this.btnExtractContentControls.Click += new System.EventHandler(this.BtnExtractContentControls_Click);
            // 
            // tabFill
            // 
            this.tabFill.Controls.Add(this.btnGenerate);
            this.tabFill.Controls.Add(this.dgwFill);
            this.tabFill.Location = new System.Drawing.Point(8, 39);
            this.tabFill.Name = "tabFill";
            this.tabFill.Padding = new System.Windows.Forms.Padding(3);
            this.tabFill.Size = new System.Drawing.Size(752, 440);
            this.tabFill.TabIndex = 1;
            this.tabFill.Text = "Fill";
            this.tabFill.UseVisualStyleBackColor = true;
            // 
            // dgwFill
            // 
            this.dgwFill.AllowUserToAddRows = false;
            this.dgwFill.AllowUserToDeleteRows = false;
            this.dgwFill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFill.Location = new System.Drawing.Point(7, 7);
            this.dgwFill.Name = "dgwFill";
            this.dgwFill.RowTemplate.Height = 33;
            this.dgwFill.Size = new System.Drawing.Size(739, 349);
            this.dgwFill.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(187, 48);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lbCurrentFileTitle
            // 
            this.lbCurrentFileTitle.AutoSize = true;
            this.lbCurrentFileTitle.Location = new System.Drawing.Point(218, 38);
            this.lbCurrentFileTitle.Name = "lbCurrentFileTitle";
            this.lbCurrentFileTitle.Size = new System.Drawing.Size(129, 25);
            this.lbCurrentFileTitle.TabIndex = 4;
            this.lbCurrentFileTitle.Text = "Current file: ";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(342, 38);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(47, 25);
            this.lblCurrentFile.TabIndex = 5;
            this.lblCurrentFile.Text = "N.A";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(550, 374);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(187, 48);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 579);
            this.Controls.Add(this.lblCurrentFile);
            this.Controls.Add(this.lbCurrentFileTitle);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.gbFormFields.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabExtraction.ResumeLayout(false);
            this.gbContentControls.ResumeLayout(false);
            this.tabFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormFields;
        private System.Windows.Forms.Button btnExtractFormFields;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExtraction;
        private System.Windows.Forms.TabPage tabFill;
        private System.Windows.Forms.DataGridView dgwFill;
        private System.Windows.Forms.GroupBox gbContentControls;
        private System.Windows.Forms.Button btnExtractContentControls;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbCurrentFileTitle;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Button btnGenerate;
    }
}
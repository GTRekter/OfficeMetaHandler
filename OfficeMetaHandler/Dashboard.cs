using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using OfficeMetaHandler.Models;

namespace OfficeMetaHandler
{
    public partial class Dashboard : Form
    {

        #region Private Variables

        Document document;

        List<FillColumns> fillColumns;

        ExtractionType extractionType;

        #endregion

        #region Constructor

        public Dashboard()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Functions

        private void BtnExtractFormFields_Click(object sender, EventArgs e)
        {
            document.ExtractFormFields();
            extractionType = ExtractionType.FormFields;

            var source = new BindingSource();
            fillColumns = document.FormFields.Select(ff => new FillColumns() { Name = ff }).ToList();
            source.DataSource = fillColumns;
            dgwFill.DataSource = source;

            btnGenerate.Enabled = true;
            MessageBox.Show("The form fields has been extracted", "Extraction completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExtractContentControls_Click(object sender, EventArgs e)
        {
            document.ExtractContentControls();
            extractionType = ExtractionType.ContentControls;

            var source = new BindingSource();
            fillColumns = document.ContentControls.Select(cc => new FillColumns() { Name = cc }).ToList();
            source.DataSource = fillColumns;
            dgwFill.DataSource = source;

            btnGenerate.Enabled = true;
            MessageBox.Show("The content controls has been extracted", "Extraction completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the open file dialog box.
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set filter options and filter index.
                openFileDialog.Filter = "Text Files (.docx)|*.docx|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                // Process the selected file
                if (dialogResult == DialogResult.OK)
                {
                    // Open the selected file to read.
                    string filePath = openFileDialog.FileName;
                    document = new Document(filePath);

                    lblCurrentFile.Text = document.Filename;

                    // enable the actions
                    btnExtractContentControls.Enabled = true;
                    btnExtractFormFields.Enabled = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Loading incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            document.Fill(fillColumns, extractionType);
            MessageBox.Show("The document has been generated", "Generation completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}

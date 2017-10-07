using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using System;

namespace OfficeMetaHandler.Models
{
    public class Document
    {
        #region Constructor

        public Document()
        {
            _path = string.Empty;
            _filename = string.Empty;
            _extension = string.Empty;
            _formFields = new List<string>();
            _contentControls = new List<string>();
        }

        public Document(string path)
        {
            _path = path;
            _filename = System.IO.Path.GetFileNameWithoutExtension(path);
            _extension = System.IO.Path.GetExtension(path);
            _formFields = new List<string>();
            _contentControls = new List<string>();
        }

        #endregion

        #region properties

        private string _filename;
        public string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        private string _extension;
        public string Extension
        {
            get
            {
                return _extension;
            }
            set
            {
                _extension = value;
            }
        }

        private List<string> _formFields;
        public List<string> FormFields
        {
            get
            {
                return _formFields;
            }
            set
            {
                _formFields = value;
            }
        }

        private List<string> _contentControls;
        public List<string> ContentControls
        {
            get
            {
                return _contentControls;
            }
            set
            {
                _contentControls = value;
            }
        }

        #endregion

        #region Public Functions

        public void ExtractFormFields()
        {
            switch (_extension)
            {
                case ".docx":
                    Application application = new Application();
                    Microsoft.Office.Interop.Word.Document document = application.Documents.Open(_path);
                    foreach (FormField ff in document.FormFields)
                    {
                        _formFields.Add(ff.Name);
                    }
                    document.Close();
                    break;
                default:
                    break;
            }
        }

        public void ExtractContentControls()
        {
            switch (_extension)
            {
                case ".docx":
                    Application application = new Application();
                    Microsoft.Office.Interop.Word.Document document = application.Documents.Open(_path);
                    foreach (ContentControl cc in document.ContentControls)
                    {
                        _contentControls.Add(cc.Title);
                    }
                    document.Close();
                    break;
                default:
                    break;
            }

        }

        public void Fill(List<FillColumns> fillColumns, ExtractionType extractionType)
        {
            switch (extractionType)
            {
                case ExtractionType.ContentControls:
                    // create a copy of the file
                    string newFileName = _path.Replace(_filename, string.Format("{0}_Filled", _filename));
                    File.Copy(_path, newFileName);

                    // fill the values
                    Application application = new Application();
                    Microsoft.Office.Interop.Word.Document document = application.Documents.Open(newFileName);
                    foreach (ContentControl cc in document.ContentControls)
                    {
                        try
                        {
                            cc.Range.Text = fillColumns.Where(fc => fc.Name.Equals(cc.Title)).FirstOrDefault().Value;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    document.Close();
                    break;
                case ExtractionType.FormFields:
                    break;
            }
        }

        #endregion
    }
}

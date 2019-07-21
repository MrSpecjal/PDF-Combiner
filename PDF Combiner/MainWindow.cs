using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text.RegularExpressions;
using System.Threading;

namespace PDFCombiner
{
    public partial class PDFCombiner : Form
    {
        public int pdfCount = 0;
        private List<string> filePaths = new List<string>();
        public PDFCombiner()
        {
            Thread thread = new Thread(new ThreadStart(StartForm));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            InitFilesList();
            thread.Abort();
        }

        public void StartForm()
        {
            //Application.Run(new SplashScreen());
        }

        public void InitFilesList()
        {
            filesList.ColumnCount = 2;
            filesList.Columns[0].Name = "Numer";
            filesList.Columns[1].Name = "Ścieżka";

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            buttons.HeaderText = "Ustaw Ścieżkę";
            buttons.Name = "setPath";
            buttons.Text = "Zmień plik";
            buttons.UseColumnTextForButtonValue = true;
            filesList.Columns.Add(buttons);
            filesList.Rows.Clear();
        }

        private void setPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Title = "Otwóż plik(i) PDF";
            openFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var fileName in openFileDialog.FileNames)
                    {
                        filePath.Text += fileName + ";";
                        filePaths.Add(fileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void addFileToDataGrid_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath.Text))
            {
                foreach (var file in filePaths)
                {
                    var row = new ArrayList
                    {
                        pdfCount + 1,
                        file
                    };
                    filesList.Rows.Add(row.ToArray());
                    pdfCount++;
                }
                
                filePath.Text = null;
            }
            else
            {
                MessageBox.Show("Aby dodać plik najpierw musisz go wybrać. ", "PDF Combiner - Błąd (ErrKey: NOT_SELECTED_FILE)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setPath_Click(sender, e);
            }
        }

        private void makePDF_Click(object sender, EventArgs e)
        {
            if (pdfCount > 1)
            {
                string[] pdfPaths = new string[pdfCount];
                for (int i = 0; i < pdfCount-1; i++)
                {
                    pdfPaths[i] = (string)filesList[1, i].Value;
                }

                PdfReader reader = null;
                Document sourceDocument = null;
                PdfCopy pdfCopyProvider = null;
                PdfImportedPage importedPage;

                SaveFileDialog savePDF = new SaveFileDialog();
                savePDF.Filter = "Plik PDF (*.pdf)|*.pdf";
                savePDF.Title = "Zapisz połączone plik";
                savePDF.ShowDialog();
                string outputPdfPath;
                if (savePDF.FileName != "")
                {
                    outputPdfPath = savePDF.FileName;
                }
                else
                {
                    return;
                }

                sourceDocument = new Document();
                pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, FileMode.Create));
                
                sourceDocument.Open();

                try
                {
                    for (int j = 0; j < pdfPaths.Length - 1; j++)
                    {
                        int pages = get_pageCcount(pdfPaths[j]);

                        reader = new PdfReader(pdfPaths[j]);
                        PdfReader.unethicalreading = true;

                        for (int i = 1; i <= pages; i++)
                        {
                            importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                            pdfCopyProvider.AddPage(importedPage);
                        }

                        reader.Close();
                    }
                    sourceDocument.Close();
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                clearList_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Dodaj co najmniej 2 plik, żeby program mógł je połaczyć.", "PDF Combiner - Błąd (ErrKey: NOT_ENOUGH_FILES)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int get_pageCcount(string file)
        {
            using (StreamReader sr = new StreamReader(File.OpenRead(file)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }

        private void filesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (filesList.Columns[e.ColumnIndex].Index == 2 && filesList.Rows[e.RowIndex].Cells[2].Value == "Zmień plik")
            #pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Pliki pdf (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string path = openFileDialog.FileName;
                        filesList.Rows[e.RowIndex].Cells[1].Value = path;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void wybierzPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPath_Click(sender, e);
        }

        private void dodajPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFileToDataGrid_Click(sender, e);
        }

        private void połączPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makePDF_Click(sender, e);
        }

        private void author_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://szymon-mis.pl/");
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            filesList.Rows.Clear();
            filesList.Refresh();
            pdfCount = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System.Net;
using System.IO;

//www.codeproject.com/Articles/12445/Converting-PDF-to-Text-in-C
//http://pdfsharp.com/PDFsharp/index.php?option=com_content&task=view&id=13&Itemid=1
//http://www.cityofomaha.org/cityclerk/city-council/agendas

namespace ConvertPDFToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set the open file dialog (if the local radio button is selcted) to the desktop
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        /// <summary>
        /// The user can double click on the destination textbox to pick a folder location to save the plain text to.
        /// </summary>
        private void uxTextBoxDestination_DoubleClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uxTextBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// If the user has the 'local file' radiobutton checked allow them to select the pdf file.
        /// Save that value to the 'file location' text box.
        /// </summary>
        private void uxTextBoxFileLocation_DoubleClick(object sender, EventArgs e)
        {
            if (uxRadioButtonLocalFile.Checked)
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    uxTextBoxFileLocation.Text = openFileDialog.FileName;
                }
            }
        }

        /// <summary>
        /// I like being able to close a simple form with the escape key.. so let the users do that too!
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        /// <summary>
        /// Do some basic validation and determine which path to get the source file.
        /// </summary>
        private void uxButtonGet_Click(object sender, EventArgs e)
        {
            //1.0  Validate there is a file/web location
            if (uxTextBoxFileLocation.Text.Trim() == string.Empty)
            {
                // if no location draw focus back to it and throw up a warning message.
                uxTextBoxFileLocation.Focus();
                MessageBox.Show("No File Path");
                return;
            }

            //2.0 No destination - then use the desktop!
            if (uxTextBoxDestination.Text.Trim() == string.Empty)
            {
                uxTextBoxDestination.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            //3.0 basic determination of which way to find the source.
            if (uxRadioButtonLocalFile.Checked)
            {
                DoLocal();
            }
            else
            {
                DoWeb();
            }


        }

        /// <summary>
        /// Grab the file source location runi through the pdfbox class, get the plain text, and save that plain text to the destination.
        /// </summary>
        private void DoLocal()
        {
            string sPlainText = string.Empty;
            string sDestinationPath = string.Empty;
            System.IO.StreamWriter sw = null;
            try
            {
                //1.0  Using the 'file location' text box, parse out the PDF.
                sPlainText = PDFToPlainText(uxTextBoxFileLocation.Text);

                //sDestinationPath = string.Format("{0}{1}{2}_{3}{4}_{5}.txt", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                //2.0  Using the file name of the PDF, make it a .txt
                sDestinationPath = System.IO.Path.GetFileNameWithoutExtension(uxTextBoxFileLocation.Text);
                sDestinationPath += ".txt";

                //3.0  Save it to the 'destination' location with the filename.txt
                sw = new System.IO.StreamWriter(uxTextBoxDestination.Text + "\\" + sDestinationPath);
                sw.Write(sPlainText);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                // 4.0 clean up
                if (sw != null)
                    sw.Dispose();
            }

        }

        /// <summary>
        /// Grab the PDf from the website.
        /// Save it to a temp spot (I am just lazy on trying to convert the stream to somethign the PDFBOX can use.)
        /// Convert the pdf to the plain text.
        /// Delete the temp pdf.
        /// </summary>
        private void DoWeb()
        {
            string sWebPath = string.Empty;
            string sDestinationPath = string.Empty;
            StreamWriter sw = null;
            string sPlainText = string.Empty;
            string[] temp;
            string sFileName = string.Empty;
            string sTempPath = string.Empty;
            WebClient myWebClient;
            try
            {
                //1.0  Get the file source
                sWebPath = uxTextBoxFileLocation.Text;

                //2.0  validate we are at least trying to get a .PDF file
                if (!sWebPath.ToUpper().Contains(".PDF"))
                {
                    MessageBox.Show("No PDF in that URL!");
                    uxTextBoxFileLocation.Focus();
                    return;
                }

                //  testing   sWebPath = "http://www.cityofomaha.org/cityclerk/images/stories/agenda/a13-10-22.pdf";

                //3.0  To get the file name split the URL on the /, and grab the last substring.
                temp = sWebPath.Split('/');
                sFileName = temp[temp.Length - 1];
                //4.0  Create the temp file path based off the exe's execution directory and the pdf's file name.
                sTempPath = Environment.CurrentDirectory + "\\" + sFileName; ;

                //5.0  Setup the webclient.
                myWebClient = new WebClient();

                //6.0  Download the file
                myWebClient.DownloadFile(sWebPath, sTempPath);

                //7.0  Pump the temp pdf through the PDFBox class and get the plain text.
                sPlainText = PDFToPlainText(sTempPath);

                //8.0  Get the PDF file name sans .PDF and make it .TXT
                sDestinationPath = System.IO.Path.GetFileNameWithoutExtension(sTempPath);
                sDestinationPath += ".txt";

                //9.0  Write the plain text string to the local destination location.
                sw = new System.IO.StreamWriter(uxTextBoxDestination.Text + "\\" + sDestinationPath);
                sw.Write(sPlainText);

                //10.0  delete local temp pdf
                if (System.IO.File.Exists(sTempPath))
                    System.IO.File.Delete(sTempPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //  throw;
            }
            finally
            {
                // 11.0  clean up
                if (sw != null)
                    sw.Dispose();
            }
        }

        /// <summary>
        /// Takes a PDF and regurgitates plain text.
        /// </summary>
        /// <param name="fileLocation">Location of the PDF on the local machine</param>
        /// <returns></returns>
        private string PDFToPlainText(string fileLocation)
        {
            string sReturn = string.Empty;
            PDDocument doc = null;
            PDFTextStripper stripper = null;

            try
            {
                //1.0  file the PDDoc object
                doc = PDDocument.load(fileLocation);
                
                //2.0 Create a stripper (even with out a dollar bill!)
                stripper = new PDFTextStripper();
                
                //3.0  Get the text
                sReturn = stripper.getText(doc);
                
                doc.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sReturn;
        }

    

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            help foo = new help();
            foo.TopLevel = true;
            foo.ShowDialog();

        }

    }
}

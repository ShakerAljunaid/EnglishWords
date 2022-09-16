using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace English_word
{
    public partial class frmMainPage : Form
    {

        public frmMainPage()
        {
            InitializeComponent();
            //DataTable into that the data of the call of show data method will be stored  in word table
            DataTable dt = aw.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_WordData(dt);

            WordListBox.DataSource = dt;
            WordListBox.DisplayMember = "Word";
            //DataTable into that the data of the call of show data method will be stored  in grammar table
            DataTable gdt = ag.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_GramData(gdt);
            //DataTable into that the data of the call of show data method will be stored  in idiom table
            DataTable idt = ai.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_IdiomData(idt);
            //DataTable into that the data of the call of show data method will be stored  in notes table
            DataTable ndt = ni.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_NoteData(ndt);
        }

        //Declaring and Initializing the public variable
        //The index used to keep track of the numbe of rows resulted from a query
        public int index = 0;
        public int indexIdiom = 0;
        public int indexNote = 0;
        //Instance of the command class 
        Classes.Add_word aw = new Classes.Add_word();
        Classes.Add_Gram ag = new Classes.Add_Gram();
        Classes.Add_idiom ai = new Classes.Add_idiom();
        Classes.Add_Notes ni = new Classes.Add_Notes();




        //Method to show the data of the word table
        public void Show_WordData(DataTable dt)
        {
            try
            {

                //Set textboxes to the columns in the table
                txtWord.Text = dt.Rows[index]["Word"].ToString();
                txtBelongingofword.Text = dt.Rows[index]["Belongingofword"].ToString();
                txtAorB.Text = dt.Rows[index]["AmrorBrit"].ToString();
                txtKinda.Text = dt.Rows[index]["Kinda"].ToString();
                txtKIndOfuse.Text = dt.Rows[index]["KIndOfuse"].ToString();
                txtKind.Text = dt.Rows[index]["KInd"].ToString();
                txtPronuciation.Text = dt.Rows[index]["Pronuciation"].ToString();
                txtsyn.Text = dt.Rows[index]["Synonym"].ToString();
                txtopp.Text = dt.Rows[index]["Opposite"].ToString();
                rtxtMoreInfo.Text = dt.Rows[index]["More_info"].ToString();
                //WordListBox.SelectedValue = dt.Rows[index]["Word"].ToString();






                if (bytetoimg(dt.Rows[index]["Picture"]) != null)
                    PicturePictureBox.Image = bytetoimg(dt.Rows[index]["Picture"]);
                else
                    PicturePictureBox.Image = PicturePictureBox.InitialImage;


            }
            catch (Exception)
            {

                throw;
            }

        }//End show data method

        //Method to show the data of the Grammar table
        public void Show_GramData(DataTable dt)
        {
            try
            {


                //Set textboxes to the columns in the table
                txtID.Text = dt.Rows[index]["ID"].ToString();
                txtTitle.Text = dt.Rows[index]["Title"].ToString();
                txtSubject.Text = dt.Rows[index]["Subject"].ToString();
                rtxtGrammar.Text = dt.Rows[index]["Grammar"].ToString();
                rtxtExamples.Text = dt.Rows[index]["Examples"].ToString();
                rtxtmoreinf.Text = dt.Rows[index]["More_info"].ToString();
                dtpicDate.Text = dt.Rows[index]["Written_Date"].ToString(); 

                bindingNavigatorCountItem1.Text = Convert.ToString(dt.Rows.Count);
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();




            }
            catch (Exception)
            {

                throw;
            }

        }//End show data method

        //Method to show the data of the Idiom table
        public void Show_IdiomData(DataTable dt)
        {
            try
            {


                //Set textboxes to the columns in the table
                txtidiomID.Text = dt.Rows[indexIdiom]["ID"].ToString();
                txtIdiom.Text = dt.Rows[indexIdiom]["Idiom"].ToString();
                rtxtIdiomDetails.Text = dt.Rows[indexIdiom]["belongingofIdioms"].ToString();
                txtIdiomExamp.Text = dt.Rows[indexIdiom]["Examples"].ToString();
                rtxtIdiomMore.Text = dt.Rows[indexIdiom]["More_info"].ToString();
                dptIdiom.Text = dt.Rows[index]["Written_Date"].ToString(); 

                lblIdiomTotalItems.Text = Convert.ToString(dt.Rows.Count);
                txtIdiomPosition.Text = (indexIdiom + 1).ToString();




            }
            catch (Exception)
            {

                //throw;
            }

        }//End show data method
        //Method to show the data of the Idiom table
        public void Show_NoteData(DataTable dt)
        {
            try
            {
               

                //Set textboxes to the columns in the table
                txtNoteID.Text = dt.Rows[indexNote]["ID"].ToString();
                txtNoteSubject.Text = dt.Rows[indexNote]["Subject"].ToString();
                rtxtNote.Text = dt.Rows[indexNote]["Note_info"].ToString();
                rtxtNoteMore.Text = dt.Rows[indexNote]["More_info"].ToString();
                rtxtNotePicCom.Text = dt.Rows[indexNote]["Pic_comment"].ToString();
                dptNotes.Text = dt.Rows[index]["Written_Date"].ToString(); 
             



                lblNotesTotalItems.Text = Convert.ToString(dt.Rows.Count);
                txtNotePosition.Text = (indexNote + 1).ToString();



                if (bytetoimg(dt.Rows[index]["Note_pic"]) != null)
                    pbNotes.Image = bytetoimg(dt.Rows[indexNote]["Note_pic"]);
                else
                    pbNotes.Image = pbNotes.InitialImage;


            }
            catch (Exception)
            {

                throw;
            }


        }//End show data method


        //That method is necessary to convert the byte format in the db to be easily read by the C#
        public Image bytetoimg(object imagedata)
        {
            try
            {
                byte[] b = (byte[])(imagedata);
                MemoryStream ms = new MemoryStream(b);
                ms.Seek(0, SeekOrigin.Begin);
                Image im = Image.FromStream(ms);
                ms.Dispose();
                return (im);
            }
            catch (Exception)
            {
                return null;
                throw;
            }


        }
        //End of the converting method
        private void button7_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpGram;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = aw.Search_Data(WordListBox.Text);

            //Then show the data if there is correct data
            Show_WordData(dt);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = aw.Search_Data(txtSearch.Text);
                //Then show the data if there is correct data
                Show_WordData(dt);
                WordListBox.DataSource = dt;
                WordListBox.DisplayMember = "Word";
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                txtSearch.Focus();
            }

        }

        private void WordListBox_MouseClick(object sender, MouseEventArgs e)
        {
            //txtSearch.Text = WordListBox.Text;
        }

        private void btnAddword_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpWord;
        }

        private void btnExer_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpExer;
        }

        private void btnTofel_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpTofel;
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpDS;
        }

        private void PicturePictureBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void grbtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the first  row of the table
            DataTable dt = ag.Show_Data();

            index = 0;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_GramData(dt);
        }

        private void grbtnMovePreviousItem_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be decremented to show the  previous row of the table
            DataTable dt = ag.Show_Data();

            if (index > 0)
            {
                index--;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_GramData(dt);
            }
        }

        private void grbtnMoveNextItem_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            DataTable dt = ag.Show_Data();

            if (index < dt.Rows.Count - 1)
            {
                index++;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_GramData(dt);
            }
        }

        private void grbtnMoveLastItem_Click(object sender, EventArgs e)
        {

            //When clicking on this button the index will be incremented to the last row of the table
            DataTable dt = ag.Show_Data();
            index = dt.Rows.Count - 1;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_GramData(dt);
        }

        private void txtGramSearch_TextChanged(object sender, EventArgs e)
        {
            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = ag.Search_Data(txtGramSearch.Text);
                //Then show the data if there is correct data
                Show_GramData(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGramSearch.Clear();
                txtGramSearch.Focus();
            }
        }

        private void btnAddGram_Click(object sender, EventArgs e)
        {

        }

        private void PicturePictureBox_Click(object sender, EventArgs e)
        {
            Picture_viewer pcv = new Picture_viewer();

            pcv.PicturePictureBox.Image = PicturePictureBox.Image;
            pcv.Show();
            pcv.lblPosition.Text = "1:1";

        }
        string path;
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 1.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 2.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 3.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 4.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel35_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 5.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel34_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 6.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel33_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 7.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 8.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel51_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 9.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel50_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 10.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel49_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 11.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel48_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 12.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 13.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 14.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 15.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 16.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 17.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 18.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 19.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 20.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel47_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 21.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel46_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 22.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel45_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 23.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel44_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 24.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 25.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 26.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 27.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 28.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 29.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 30.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 31.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 32.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel43_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 33.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel42_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 34.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel41_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 35.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel40_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 36.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 37.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 38.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 39.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 40.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 41.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 42.docx";

            System.Diagnostics.Process.Start(path);


        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 43.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 44.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel39_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 45.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel38_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 46.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel37_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 47.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel36_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 48.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel87_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 49.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel86_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 50.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel85_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 51.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel84_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 52.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel75_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 53.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel74_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 54.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel73_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 55.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel72_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 56.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel63_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 57.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel62_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 58.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel61_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 59.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel60_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 60.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel83_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 61.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel82_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 62.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel81_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 63.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel80_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 64.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel71_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 65.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel70_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 66.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel69_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 67.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel68_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 68 Long.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel59_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 69 Long.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel58_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 70.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel57_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 71.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel56_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 72.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel79_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 73.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel78_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 74.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel77_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 75.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel76_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 76.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel67_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 77.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel66_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 78.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel65_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 79.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel52_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 22 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 68 Long Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 69 Long Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel53_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 21 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel54_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 12 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel55_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 11 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 10 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel65_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 9 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel66_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 20 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel67_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 19 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel76_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 18 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel77_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 17 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel78_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 8 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel88_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 7 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel89_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 6 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel90_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 5 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel91_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 16 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel92_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expression Practice 15 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel93_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 14 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel94_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 13 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel95_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 4 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel96_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 3 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel97_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expressions Practice 2 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel98_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Written Expression Practice/Written Expression Practice 1 Key.docx";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel171_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 1.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel170_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 2.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel169_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 3.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel168_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 4.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel155_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 5.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel154_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 6.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel153_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 7.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel152_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 8.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel139_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 9.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel138_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 10.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel137_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 11.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel136_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 12.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel167_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 13.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel166_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 14.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel165_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 15.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel164_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 16.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel151_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 17.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel150_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 18.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel149_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 19.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel148_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 20.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel135_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 21.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel134_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 22.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel133_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 23.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel132_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 24.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel163_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 25.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel162_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 26.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel161_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 27.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel160_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 28.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel147_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 29.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel146_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 30.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel145_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 31.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel144_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 32.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel131_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 33.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel130_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 34.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel129_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 35.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel128_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 36.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel159_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 37.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel158_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 38.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel157_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 39.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel156_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 40.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel143_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 41.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel142_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 42.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel141_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 43.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel140_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 44.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel127_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 45.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel126_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 46.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel125_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 47.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel124_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 48.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel123_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 49.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel122_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 50.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel121_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 51.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel120_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 52.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel119_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 53.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel118_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 54.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel117_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 55.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel116_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 56.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel115_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 57.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel114_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 58.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel113_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 59.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel112_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 60.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel111_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 61.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel110_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 62.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel109_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 63.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel108_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 64.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel106_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 65.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel105_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 66 Long One.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel104_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 67 Long 2 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel103_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 68.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel102_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 69.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel101_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 70.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel239_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 71.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel195_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 1 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel194_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 2 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel193_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 3 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel192_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 4 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel187_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 5 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel186_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 6 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel185_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 7 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel184_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 8 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel179_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 9 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel178_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 10 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel177_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 11 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel176_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 12 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel191_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 13 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel190_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 14 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel189_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 15 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel188_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 16 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel183_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 17 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel182_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 18 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel181_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 19 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel180_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 20 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel175_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 21 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel174_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 22 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel222_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 23 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel221_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 24 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel238_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 25 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel237_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 26 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel236_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 27 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel235_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 28 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel230_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 29 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel229_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 30 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel228_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 31 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel227_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 32 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel220_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 33 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel219_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 34 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel218_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 35 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel217_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 36 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel234_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 37 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel233_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 38 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel232_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 39 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel231_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 40 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel226_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 41 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel225_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 42 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel224_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 43 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel223_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 44 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel216_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 45 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel215_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 46 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel214_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 47 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel213_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 48 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel212_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 49 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel211_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 50 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel210_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 51 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel209_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 52 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel208_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 53 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel207_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 54 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel206_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 55 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel205_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 56 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel204_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 57 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel203_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 58 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel202_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 59 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel201_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 60 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel200_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 61 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel199_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 62 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel198_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 63 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel197_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 64 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel196_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 65 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel173_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 66 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel172_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 67 Long 2 Key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel107_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 68 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel100_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 69 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel99_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 70 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel240_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = Application.StartupPath + "/Structure Practice/Structure Practice 71 key.docx";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel245_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {




        }

        private void linkLabel246_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable Idiomdt = ai.Show_Data();
            DataTable Worddt = aw.Show_Data();
            DataTable Gramddt = ag.Show_Data();
            DataTable Notedt = ni.Show_Data();
            Show_WordData(Worddt);
            Show_GramData(Gramddt);
            Show_IdiomData(Idiomdt);
            Show_NoteData(Notedt);
            
            //The following codes are specialized to show the updates in the list box
            WordListBox.Refresh();
             txtSearch.Text = "1";        
             txtSearch.Clear();
        }

        private void linkLabel241_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_Grammar ng = new New_Grammar();
            ng.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_word nw = new New_word();
            nw.Show();

        }

        private void btnIdiomMoveFirst_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the first  row of the table
            DataTable dt = ai.Show_Data();

            indexIdiom = 0;
            lblIdiomTotalItems.Text = (indexIdiom + 1).ToString();
            Show_IdiomData(dt);
        }

        private void btnIdiomMovePrev_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be decremented to show the  previous row of the table
            DataTable dt = ai.Show_Data();

            if (indexIdiom > 0)
            {
                indexIdiom--;
                lblIdiomTotalItems.Text = (indexIdiom + 1).ToString();
                Show_IdiomData(dt);
            }
        }

        private void btnIdiomMoveNex_Click(object sender, EventArgs e)
        {//When clicking on this button the index will be incremented to show the  next row of the table
            DataTable dt = ai.Show_Data();

            if (indexIdiom < dt.Rows.Count - 1)
            {
                indexIdiom++;
                lblIdiomTotalItems.Text = (indexIdiom + 1).ToString();
                Show_IdiomData(dt);
            }

        }

        private void btnIdiomMoveLast_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the last row of the table
            DataTable dt = ai.Show_Data();
            indexIdiom = dt.Rows.Count - 1;
            lblIdiomTotalItems.Text = (indexIdiom + 1).ToString();
            Show_IdiomData(dt);

        }

        private void txtIdiomSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                indexNote = 0;
                DataTable dt = ai.Search_Data(txtIdiomSearch.Text);
                //Then show the data if there is correct data
                Show_IdiomData(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdiomSearch.Clear();
                txtIdiomSearch.Focus();

            }
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }
         
      
        private void linkLabel244_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_note nn = new New_note();
            nn.Show();
            
        }

        private void btnNoteMoveLast_Click(object sender, EventArgs e)
        {//When clicking on this button the index will be incremented to the last row of the table
            
            DataTable dt = ni.Search_Data(txtNoteSearch.Text);
            indexNote = dt.Rows.Count - 1;
            txtNotePosition.Text = (indexNote + 1).ToString();
            Show_NoteData(dt);

        }

        private void btnNoteMoveFirst_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
           
            DataTable dt =ni.Search_Data(txtNoteSearch.Text);
            indexNote = 0;
            txtNotePosition.Text = (indexNote + 1).ToString();
            Show_NoteData(dt);
        }

        private void btnNoteMovePrev_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            
            DataTable dt = ni.Search_Data(txtNoteSearch.Text);
            if (indexNote > 0)
            {
                indexNote--;
                txtNotePosition.Text = (indexNote + 1).ToString();
                Show_NoteData(dt);
            }
        }

        private void btnNoteMoveNex_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
           
            DataTable dt = ni.Search_Data(txtNoteSearch.Text);


            if (indexNote < dt.Rows.Count - 1)
            {
                indexNote++;
                txtNotePosition.Text = (indexNote + 1).ToString();
                Show_NoteData(dt);
            }
        }

        private void txtNotePosition_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNotePosition_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNoteSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                indexNote = 0;
                DataTable dt = ni.Search_Data(txtNoteSearch.Text);
                //Then show the data if there is correct data
                Show_NoteData(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoteSearch.Clear();
                txtNoteSearch.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Picture_viewer pcv = new Picture_viewer();

            pcv.PicturePictureBox.Image = pbNotes.Image;
            pcv.Show();
            pcv.lblPosition.Text = "1:1";
        }

        private void linkLabel247_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\LONGMAN Complete Course for the TOEFL\LONGMAN_2001_Complete.course.for.the.TOEFL.test_Preparation.for.the.computer.and.paper.tests.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel243_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\LONGMAN Complete Course for the TOEFL\Longman_Audio";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel250_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\The Complete Guide to the TOEFL® Test - PBT Edition\The complete guide to the toefl test pbt Bruce Rogers.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel251_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\The Complete Guide to the TOEFL® Test - PBT Edition\gigatraining.net_The Complete Guide to the TOEFL® Test - PBT Edition";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel249_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\New stuff\185 TOEFL Writing (TWE) Topics and Model EssaysBy RaSHeeD.pdf";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel248_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\New stuff\Fundamentals of English Grammar Interactive CD-ROM-slicer";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel252_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\tofel tests\2000test";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel253_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\tofel tests";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel268_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\tofel tests\ets toefl preparation kit workbook.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel255_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\5000 - WORDS - vocabulary.pdf";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel254_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\Answers to all TOEFL Essay Questions.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel257_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\Cambridge TOEFL(m06166).pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel256_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL -   ESSENTIAL EXAMS.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel261_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - 4OO MUST HAVE WORD TESTSS.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel260_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - ACE THE TOFEL  TWE.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel259_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - AN ESSAY COLLECTION.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel258_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - COMPUTER BASED TEST.pdf";

            System.Diagnostics.Process.Start(path);
        }

        private void linkLabel265_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - EXAM ESSENTIAL-TESTS.pdf";

            System.Diagnostics.Process.Start(path);
            
        }

        private void linkLabel264_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - PAPER AND PENCIL.pdf";

            System.Diagnostics.Process.Start(path);
            
        }

        private void linkLabel263_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - READING COMPRHENSION SUCCESS.pdf";

            System.Diagnostics.Process.Start(path);
            
        }

        private void linkLabel262_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - SECRETS.pdf";

            System.Diagnostics.Process.Start(path);
           
        }

        private void linkLabel267_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - TEST # 308.pdf";

            System.Diagnostics.Process.Start(path);
            
        }

        private void linkLabel266_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            path = @"F:\Entertainment\English stuff\Toefl stuff\TOEFL\TOFEL - YALI - TEACHER  KHALED - AL-SHARAI\TOFEL - UNDERSTANDING + TESTS + EXECERCISES.pdf";

            System.Diagnostics.Process.Start(path);

        }

        private void linkLabel242_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_idiom ni = new New_idiom();
            ni.Show();
        }

        private void linkLabel245_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

     
    }
}

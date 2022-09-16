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
    public partial class New_note : Form
    {
        public New_note()
        {
            InitializeComponent();
            //DataTable into that the data of the call of show data method will be stored 
            DataTable dt = an.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_Data(dt);
        }

        //Declaring and Initializing the public variable
        //The index used to keep track of the numbe of rows resulted from a query
        public int index = 0;
        //Instance of the command class 
        Classes.Add_Notes an = new Classes.Add_Notes();


        //Method to initialize the form for new input
        public void Add_New()
        {
            try
            {

                an.Insert_NewRow();

                DataTable dt = an.Show_Data();

                lblNotesTotalItems.Text = Convert.ToString(dt.Rows.Count);
                txtNotePosition.Text = (index + 1).ToString();
                btnNoteMoveLast.PerformClick();
                //--------------------------------------------------------------------------
                txtNoteID.Text = dt.Rows[index]["ID"].ToString();
                txtNoteSubject.Clear();
                rtxtNote.Clear();
                rtxtNoteMore.Clear();
                rtxtNotePicCom.Clear();
                


            }
            catch (Exception)
            {

                throw;
            }


        }
        //End of Add new method

        //Method that is used to accomplish the update task
        public void Update_Row()
        {
            //Declaring array to be sent to update statement which requires this
            string[] textboxes = new string[4];

            textboxes[0] = txtNoteSubject.Text;
            textboxes[1] = rtxtNote.Text;
            textboxes[2] = rtxtNoteMore.Text;
            textboxes[3] = rtxtNotePicCom.Text;





            an.update_Row(Convert.ToInt32(txtNoteID.Text), textboxes, dtpNote.Value);
        }
        //End of the updating method  

        //Method to show the data of the table
        public void Show_Data(DataTable dt)
        {
            try
            {
                //if condition checks if the only one row is displayed ,then this row can never be deleted ,avoiding conflection
                if (dt.Rows.Count == 1)
                    btnDelete.Enabled = false;
                else
                    btnDelete.Enabled = true;

                //Set textboxes to the columns in the table
                txtNoteID.Text = dt.Rows[index]["ID"].ToString();
                txtNoteSubject.Text = dt.Rows[index]["Subject"].ToString();
                rtxtNote.Text = dt.Rows[index]["Note_info"].ToString();
                rtxtNoteMore.Text = dt.Rows[index]["More_info"].ToString();
                rtxtNotePicCom.Text = dt.Rows[index]["Pic_comment"].ToString();
                dtpNote.Text = dt.Rows[index]["Written_Date"].ToString(); 

                lblNotesTotalItems.Text = Convert.ToString(dt.Rows.Count);
                txtNotePosition.Text = (index + 1).ToString();



                if (bytetoimg(dt.Rows[index]["Note_pic"]) != null)
                    pbNotes.Image = bytetoimg(dt.Rows[index]["Note_pic"]);
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
        private void pbNotes_Click(object sender, EventArgs e)
        {

        }

        private void pbNotes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //File dialog to allow the user to choose an image then store it the picture box to be stored in the db
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files |*.JPG;*.PNG;*.GIF;*.BMB";
                if (ofd.ShowDialog() == DialogResult.OK)
                    pbNotes.Image = Image.FromFile(ofd.FileName);

                an.Save_Snapshot(Convert.ToInt32(txtNoteID.Text), pbNotes.Image);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Picture_viewer pcv = new Picture_viewer();

            pcv.PicturePictureBox.Image = pbNotes.Image;
            pcv.Show();
            pcv.lblPosition.Text = "1:1";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Call Add new to add new row when clicking on this button
            Add_New();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //Call Update row to update the specific row when clicking on this button
            Update_Row();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtNoteID.Text) == 1)
                MessageBox.Show("You can not delete the first row", "Deletion denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //Call the delete method to remove the selected row
            else
            {

                //Call the delete method to remove the selected row
                if (MessageBox.Show("You are about to delete this row ,are sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Call the delete method to remove the selected row
                    an.Delete_Row(Convert.ToInt32(txtNoteID.Text));
                    //Referesh the data when clicking on this button
                    btnNoteMovePrev.PerformClick();
                    MessageBox.Show("Deletion Done");
                }
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            TCNote.SelectedTab = tpNote;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            TCNote.SelectedTab = tpNotePic;
        }

        private void btnNoteMoveLast_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the last row of the table
            Update_Row();
            DataTable dt = an.Search_Data(txtNoteSearch.Text);
            index = dt.Rows.Count - 1;
            txtNotePosition.Text = (index + 1).ToString();
            Show_Data(dt);
        }

        private void btnNoteMoveNex_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = an.Search_Data(txtNoteSearch.Text);


            if (index < dt.Rows.Count - 1)
            {
                index++;
                txtNotePosition.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void btnNoteMovePrev_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = an.Search_Data(txtNoteSearch.Text);
            if (index > 0)
            {
                index--;
                txtNotePosition.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void btnNoteMoveFirst_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = an.Search_Data(txtNoteSearch.Text);
            index = 0;
            txtNotePosition.Text = (index + 1).ToString();
            Show_Data(dt);
        }

        private void txtNoteSearch_TextChanged(object sender, EventArgs e)
        {
            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = an.Search_Data(txtNoteSearch.Text);
                //Then show the data if there is correct data
                Show_Data(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoteSearch.Clear();
                txtNoteSearch.Focus();
            }
            
        }

        private void txtNotePosition_Click(object sender, EventArgs e)
        {
            
        }

        private void New_note_Load(object sender, EventArgs e)
        {

        }

        private void txtNotePosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}

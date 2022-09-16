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
using System.Drawing.Imaging;

namespace English_word
{
    public partial class New_word : Form
    {
        public New_word()
        {
            InitializeComponent();
            //DataTable into that the data of the call of show data method will be stored 
            DataTable dt = aw.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_Data(dt);
           
        
        }

        //Declaring and Initializing the public variable
        //The index used to keep track of the numbe of rows resulted from a query
        public int index = 0;
        //Instance of the command class 
        Classes.Add_word aw = new Classes.Add_word();
        

        //Method to initialize the form for new input
        public void Add_New()
        {
            try
            {

                aw.Insert_NewRow();

                DataTable dt = aw.Show_Data();

                bindingNavigatorCountItem1.Text = Convert.ToString(dt.Rows.Count);
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                bindingNavigatorMoveLastItem1.PerformClick();
                //--------------------------------------------------------------------------
                txtID.Text = dt.Rows[index]["ID"].ToString();
                rtxtExp.Clear();
                txtWord.Text = string.Empty;
                
               
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
            string[] textboxes = new string[10];

            textboxes[0] = rtxtExp.Text;
            textboxes[1] = txtWord.Text;
            textboxes[2] = cmbKinda.Text;
            textboxes[3] =cmbKindOfWord.Text;
            textboxes[4] = cmbKIndOfuse.Text;
            textboxes[5] = txtProun.Text;
            textboxes[6] = cmbAorB.Text;
            textboxes[7] = txtsyn.Text;
            textboxes[8] = txtopp.Text;
            textboxes[9] = rtxtMoreInfo.Text;


            

            aw.update_Row(Convert.ToInt32(txtID.Text), textboxes, dpDatatime.Value);
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
                txtID.Text = dt.Rows[index]["ID"].ToString();
                txtWord.Text = dt.Rows[index]["Word"].ToString();
                rtxtExp.Text = dt.Rows[index]["Belongingofword"].ToString();
                cmbKindOfWord.Text = dt.Rows[index]["Kind"].ToString();
                cmbKinda.Text = dt.Rows[index]["Kinda"].ToString();
                txtProun.Text = dt.Rows[index]["Pronuciation"].ToString();
                cmbAorB.Text = dt.Rows[index]["AmrorBrit"].ToString();
                cmbKIndOfuse.Text = dt.Rows[index]["KIndOfuse"].ToString();
                txtsyn.Text = dt.Rows[index]["Synonym"].ToString();
                txtopp.Text = dt.Rows[index]["Opposite"].ToString();
                rtxtMoreInfo.Text = dt.Rows[index]["More_info"].ToString();
                dpDatatime.Text = dt.Rows[index]["Written_Date"].ToString(); 
                
               
             

                bindingNavigatorCountItem1.Text = Convert.ToString(dt.Rows.Count);
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();


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

        private void cmbKindOfWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lblKinda_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (Convert.ToInt32(txtID.Text) == 1)
                MessageBox.Show("You can not delete the first row", "Deletion denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //Call the delete method to remove the selected row
            else
            {

                //Call the delete method to remove the selected row
                if (MessageBox.Show("You are about to delete this row ,are sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Call the delete method to remove the selected row
                    aw.Delete_Row(Convert.ToInt32(txtID.Text));
                    //Referesh the data when clicking on this button
                    bindingNavigatorMovePreviousItem1.PerformClick();
                    MessageBox.Show("Deletion Done");
                }
            }

        }

        private void bindingNavigatorMoveFirstItem1_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the first  row of the table
            Update_Row();
            DataTable dt = aw.Search_Data(txtSearch.Text);
            index = 0;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_Data(dt);
        }

        private void bindingNavigatorMovePreviousItem1_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be decremented to show the  previous row of the table
            Update_Row();
            DataTable dt = aw.Search_Data(txtSearch.Text);
            if (index > 0)
            {
                index--;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void bindingNavigatorMoveNextItem1_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = aw.Search_Data(txtSearch.Text);


            if (index < dt.Rows.Count - 1)
            {
                index++;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void bindingNavigatorMoveLastItem1_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the last row of the table
            Update_Row();
           DataTable dt = aw.Search_Data(txtSearch.Text);
            index = dt.Rows.Count - 1;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_Data(dt);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = aw.Search_Data(txtSearch.Text);
                //Then show the data if there is correct data
                Show_Data(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                txtSearch.Focus();
            }
            
        }

        private void New_word_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbKindOfWord_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbKinda.Visible = true;
            cmbKinda.Items.Clear();

              if (cmbKinda.Items.Count != 0)
            {
                for (int i = 0; i < (cmbKinda.Items.Count); i++)

                    cmbKinda.Items.RemoveAt(i);

            }
            if (cmbKindOfWord.SelectedItem.ToString() =="noun")
            {
                label1.Text = "Kind of " + cmbKindOfWord.Text + " :";
                cmbKinda.Items.Add("countable");
                cmbKinda.Items.Add("uncountable");
                cmbKinda.Items.Add("countable & uncountable ");

            }
            else if ((cmbKindOfWord.SelectedItem.ToString() == "verb") || (cmbKindOfWord.SelectedItem.ToString() == "phrasal verb"))
            {
                label1.Text = "Kind of " + cmbKindOfWord.Text + " :";
                cmbKinda.Items.Add("transitive");
                cmbKinda.Items.Add("intransitive");
                cmbKinda.Items.Add("transitive & intransitive");

            }
            else
            {
                cmbKinda.Visible =false;
                label1.Visible = false;


            }
        }

        private void cmbKinda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PicturePictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //File dialog to allow the user to choose an image then store it the picture box to be stored in the db
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files |*.JPG;*.PNG;*.GIF;*.BMB";
                if (ofd.ShowDialog() == DialogResult.OK)
                    PicturePictureBox.Image = Image.FromFile(ofd.FileName);

                aw.Save_Snapshot(Convert.ToInt32(txtID.Text), PicturePictureBox.Image);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Picture_viewer  pcv=new Picture_viewer();

            pcv.PicturePictureBox.Image = PicturePictureBox.Image;
            pcv.Show();
            pcv.lblPosition.Text = "1:1";
        }

        private void btnPasswordClose_Click(object sender, EventArgs e)
        {        
            this.Close();
           
        }

        private void PicturePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            tcWord.SelectedTab = tpFirstPage;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            tcWord.SelectedTab = tpSecondPage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_word
{
    public partial class New_idiom : Form
    {
        public New_idiom()
        {
            InitializeComponent();
            //DataTable into that the data of the call of show data method will be stored 
            DataTable dt = ai.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_Data(dt);
        }
        //Declaring and Initializing the public variable
        //The index used to keep track of the numbe of rows resulted from a query
        public int index = 0;
        //Instance of the command class 
        Classes.Add_idiom ai = new Classes.Add_idiom();


        //Method to initialize the form for new input
        public void Add_New()
        {
            try
            {

                ai.Insert_NewRow();

                DataTable dt = ai.Show_Data();

                try
                {


                    //Set textboxes to the columns in the table
                    txtidiomID.Text = dt.Rows[index]["ID"].ToString();
                    txtIdiom.Text = dt.Rows[index]["Idiom"].ToString();
                    rtxtIdiomDetails.Text = dt.Rows[index]["belongingofIdioms"].ToString();
                    txtIdiomExamp.Text = dt.Rows[index]["Examples"].ToString();
                    rtxtIdiomMore.Text = dt.Rows[index]["More_info"].ToString();
                    dptIdiom.Text = dt.Rows[index]["Written_Date"].ToString();

                                      
                    lblIdiomTotalItems.Text = Convert.ToString(dt.Rows.Count);
                    txtIdiomPosition.Text = (index + 1).ToString();
                    btnIdiomMoveLast.PerformClick();



                }
                catch (Exception)
                {

                    //throw;
                }



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

            textboxes[0] = txtIdiom.Text;
            textboxes[1] = rtxtIdiomDetails.Text;
            textboxes[2] = txtIdiomExamp.Text;
            textboxes[3] = rtxtIdiomMore.Text;
                                  


            ai.update_Row(Convert.ToInt32(txtidiomID.Text), textboxes, dptIdiom.Value);
        }
        //End of the updating method  

        //Method to show the data of the table
        public void Show_Data(DataTable dt)
        {
            try
            {
                

                //Set textboxes to the columns in the table
                txtidiomID.Text = dt.Rows[index]["ID"].ToString();
                txtIdiom.Text = dt.Rows[index]["Idiom"].ToString();
                rtxtIdiomDetails.Text = dt.Rows[index]["belongingofIdioms"].ToString();
                txtIdiomExamp.Text = dt.Rows[index]["Examples"].ToString();
                rtxtIdiomMore.Text = dt.Rows[index]["More_info"].ToString();



                lblIdiomTotalItems.Text = Convert.ToString(dt.Rows.Count);
                txtIdiomPosition.Text = (index + 1).ToString();
                
                              


            }
            catch (Exception)
            {

                throw;
            }

        }//End show data method

        private void txtIdiomSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIdiomMoveFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnIdiomMovePrev_Click(object sender, EventArgs e)
        {

        }

        private void btnIdiomMoveNex_Click(object sender, EventArgs e)
        {

        }

        private void btnIdiomMoveLast_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void btnIdiomMoveLast_Click_1(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = ai.Search_Data(txtIdiomSearch.Text);
                   index = dt.Rows.Count - 1;
                txtIdiomPosition.Text = (index + 1).ToString();
                Show_Data(dt);
           
        }

        private void btnIdiomMoveNex_Click_1(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = ai.Search_Data(txtIdiomSearch.Text);


            if (index < dt.Rows.Count - 1)
            {
                index++;
                txtIdiomPosition.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void btnIdiomMovePrev_Click_1(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            Update_Row();
            DataTable dt = ai.Search_Data(txtIdiomSearch.Text);
            if (index > 0)
            {
                index--;
                txtIdiomPosition.Text = (index + 1).ToString();
                Show_Data(dt);

            }
        }

        private void btnIdiomMoveFirst_Click_1(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the first  row of the table
            Update_Row();
            DataTable dt = ai.Search_Data(txtIdiomSearch.Text);
            index = 0;
            txtIdiomPosition.Text = (index + 1).ToString();
            Show_Data(dt);


        }

        private void txtIdiomSearch_TextChanged_1(object sender, EventArgs e)
        {
            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = ai.Search_Data(txtIdiomSearch.Text);
                //Then show the data if there is correct data
                Show_Data(dt);
            }
            catch (Exception)
            {

                MessageBox.Show("No matching result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdiomSearch.Clear();
                txtIdiomSearch.Focus();
            }
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
            if (Convert.ToInt32(txtidiomID.Text) == 1)
                MessageBox.Show("You can not delete the first row", "Deletion denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //Call the delete method to remove the selected row
            else
            {

                //Call the delete method to remove the selected row
                if (MessageBox.Show("You are about to delete this row ,are sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Call the delete method to remove the selected row
                    ai.Delete_Row(Convert.ToInt32(txtidiomID.Text));
                    //Referesh the data when clicking on this button
                    btnIdiomMovePrev.PerformClick();
                    MessageBox.Show("Deletion Done");
                }
            }
        }
    }
}

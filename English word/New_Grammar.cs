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
    public partial class New_Grammar : Form
    {
        public New_Grammar()
        {
            InitializeComponent();
            //DataTable into that the data of the call of show data method will be stored 
            DataTable dt = ag.Show_Data();
            //Then the result will be shown on the textboxes of this form
            Show_Data(dt);
        }

        //Declaring and Initializing the public variable
        //The index used to keep track of the numbe of rows resulted from a query
        public int index = 0;
        //Instance of the command class 
        Classes.Add_Gram ag = new Classes.Add_Gram();


        //Method to initialize the form for new input
        public void Add_New()
        {
            try
            {

                ag.Insert_NewRow();

                DataTable dt = ag.Show_Data();

                bindingNavigatorCountItem1.Text = Convert.ToString(dt.Rows.Count);
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                btnMoveLastItem.PerformClick();
                //--------------------------------------------------------------------------
                txtID.Text = dt.Rows[index]["ID"].ToString();
                rtxtExamples.Clear();
                txtTitle.Clear();
                rtxtExamples.Clear();
                rtxtmoreinf.Clear();



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
            string[] textboxes = new string[5];

            textboxes[0] = txtTitle.Text;
            textboxes[1] = cmbSubject.Text;
            textboxes[2] = rtxtGram.Text;
            textboxes[3] = rtxtExamples.Text;
            textboxes[4] = rtxtmoreinf.Text;


            ag.update_Row(Convert.ToInt32(txtID.Text), textboxes, dpDatatime.Value);
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
                txtTitle.Text = dt.Rows[index]["Title"].ToString();
                cmbSubject.Text = dt.Rows[index]["Subject"].ToString();
                rtxtGram.Text = dt.Rows[index]["Grammar"].ToString();
                rtxtExamples.Text = dt.Rows[index]["Examples"].ToString();
                rtxtmoreinf.Text = dt.Rows[index]["More_info"].ToString();
                dpDatatime.Text = dt.Rows[index]["Written_Date"].ToString(); 


                bindingNavigatorCountItem1.Text = Convert.ToString(dt.Rows.Count);
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();




            }
            catch (Exception)
            {

                throw;
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
            if (Convert.ToInt32(txtID.Text) == 1)
                MessageBox.Show("You can not delete the first row", "Deletion denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //Call the delete method to remove the selected row
            else
            {

                //Call the delete method to remove the selected row
                if (MessageBox.Show("You are about to delete this row ,are sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Call the delete method to remove the selected row
                    ag.Delete_Row(Convert.ToInt32(txtID.Text));
                    //Referesh the data when clicking on this button
                    btnMovePrev.PerformClick();
                    MessageBox.Show("Deletion Done");
                }
            }//End show data method




        }

        private void btnMoveLastItem_Click(object sender, EventArgs e)
        {
            //Call Update row to update the specific row when clicking on this button
            Update_Row();
            //When clicking on this button the index will be incremented to the last row of the table
            DataTable dt = ag.Show_Data();
            index = dt.Rows.Count - 1;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_Data(dt);
        }

        private void btnMoveNex_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to show the  next row of the table
            // DataTable dt = Notecommand.Show_Data();
            DataTable dt = ag.Show_Data();
            //Call Update row to update the specific row when clicking on this button
            Update_Row();

            if (index < dt.Rows.Count - 1)
            {
                index++;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_Data(dt);
            }
        }

        private void btnMovePrev_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be decremented to show the  previous row of the table
            DataTable dt = ag.Show_Data();
            //Call Update row to update the specific row when clicking on this button
            Update_Row();
            if (index > 0)
            {
                index--;
                bindingNavigatorPositionItem1.Text = (index + 1).ToString();
                Show_Data(dt);
            }

        }

        private void btnMoveFirstItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When Inserting any thing in this textbox the search method will begin to look for it in the db table
            try
            {
                index = 0;
                DataTable dt = ag.Search_Data(txtSearch.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            //When clicking on this button the index will be incremented to the first  row of the table
            DataTable dt = ag.Show_Data();
            //Call Update row to update the specific row when clicking on this button
            Update_Row();
            index = 0;
            bindingNavigatorPositionItem1.Text = (index + 1).ToString();
            Show_Data(dt);
        }

    }
}
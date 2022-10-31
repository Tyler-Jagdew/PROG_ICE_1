using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_ICE_1
{
    public partial class Form1 : Form
    {
        SLinkedList<string> SLinkedList = new SLinkedList<string>();

        // field
        string Input1;
        string Input2;
        string Input3;

        #region Form 
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Once the form loads press START to begin");
        }
        #endregion
        
        #region Button Actions
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void ButtonAppend_Click(object sender, EventArgs e)
        {
            // get user input
            Input1 = FindTextbox.Text;

            // validate user input
            if (validation(Input1))
            {
                // prepend to tail
                SLinkedList.AddToEnd(Input1);

                // display
                GetLinkedListData();
            }
        }

        private void ButtonPrepend_Click(object sender, EventArgs e)
        {
            // get user input
            Input1 = FindTextbox.Text;

            // validate user input
            if (validation(Input1))
            {
                // append to head
                SLinkedList.AddToBeginning(Input1);

                // display
                GetLinkedListData();
            }
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            // get user input
            Input2 = GetterTextBox.Text;
            Input3 = SetterTextBox.Text;

            // validate user input
            if (validation(Input2) || validation(Input3))
            {
                // insert after node 
                SLinkedList.AddAfter(SLinkedList.Find(Input3), Input2);

                // display
                GetLinkedListData();
            }
        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            // get user input
            Input2 = GetterTextBox.Text;
            Input3 = SetterTextBox.Text;

            // validate user input
            if (validation(Input2) || validation(Input3))
            {
                // search for node and replace node with data
                SLinkedList.Find(Input2).Data = Input3;

                // display
                GetLinkedListData();

            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // get user input
            Input1 = FindTextbox.Text;

            // validate user input
            if (validation(Input1))
            {
                // delete node
                SLinkedList.Remove(Input1);

                // display
                GetLinkedListData();
            }
        }
            #endregion

            #region Methods
            private void GetLinkedListData()
            {
                // refresh the user interface
                RefreshUI();

                // convert linked list to array
                var arrSLL = SLinkedList.ToArray();

                // iterate through array and populate data to rich text box
                foreach (var x in arrSLL)
                {
                    outputBox.AppendText(x.ToString() + "\n");
                }
            }
        private void RefreshUI()
        {
            // initialise ui componenets back to default
            FindTextbox.Text = "";
            GetterTextBox.Text = "";
            SetterTextBox.Text = "";
            outputBox.Text = "";
        }

        private bool validation(string input)
        {
            // validates if the user entered a valid input
            if (input.Equals(""))
            {
                MessageBox.Show("There seems to be no data found. Please try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SLinkedList.AddToBeginning("One Two Buckle My Shoe,");

            // display data in the linked list
            GetLinkedListData();
        }

      
    }
}

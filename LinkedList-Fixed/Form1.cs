using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_Fixed
{
    public partial class Form1 : Form
    {
        private FixedList<int> fixedList;

        public Form1()
        {
            InitializeComponent();
            fixedList = new FixedList<int>();
            numberAddedLabel.Visible = false;
            sumOfTheListLabel.Visible = false;
            valueFound.Visible = false;
            insertNumberLabel.Visible = false;

            /*
            FixedList<int> fixedList = new FixedList<int>();
            fixedList.addItem(1);
            fixedList.addItem(2);
            fixedList.addItems(new int[] { 1, 2, 3 });

            FixedList<String> fixedList2 = new FixedList<string>(new String[] { "Hi", "Bye" });
            fixedList2.addItem("Left");

            printList(fixedList.getFixedList());
            fixedList.addValue(7, 2);
            printList(fixedList.getFixedList());*/


        }

        //The list is printed out
        public String printList(int[] list)
        {
            //String
            String op = "";
            //For each value in the list it is added
            foreach(int n in list)
            {
                op += n + " ";
            }
            //Print line
            return op;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            numberAddedLabel.Visible = false;
            //If the box is empty
            if (addItemBox.Text == "")
                return;
            //Instantiating number
            int num = 0;
            //Parses the text
            try
            {
               num = int.Parse(addItemBox.Text);
            } catch (Exception ee)
            {
                return;
            }
            //Sets the good message to visable
            numberAddedLabel.Visible = true;
            //Adds the number to the list
            fixedList.addItem(num);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sets the sum of the list label to the sum of the list
            sumOfTheListLabel.Text = "" + fixedList.sumOfList();
            sumOfTheListLabel.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            valueFound.Visible = false;
            //If the box is empty
            if (valueBox.Text == "")
                return;
            //Instantiating number
            int num = 0;
            //Parses the text
            try
            {
                num = int.Parse(addItemBox.Text);
            }
            catch (Exception ee)
            {
                return;
            }

            if (fixedList.findValue(num) <= -1)
                return;

            //Sets the value found
            valueFound.Text = "Found at index: " + fixedList.findValue(num);
            //Sets the good message to visable
            valueFound.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            insertNumberLabel.Visible = false;
            //If the box is empty
            if (valueBox.Text == "")
                return; 
            if (indexBox.Text == "")
                return;
            //Instantiating number
            int value = 0;
            int index = 0;
            //Parses the text
            try
            {
                value = int.Parse(valueBox.Text);
                index = int.Parse(indexBox.Text);
            }
            catch (Exception ee)
            {
                return;
            }
            if (index > fixedList.getFixedList().Length)
                return;

            //Adds the number to the fixedd list
            fixedList.addValue(value, index);
            //Sets the good message to visable
            insertNumberBox.Visible = true;
        }
    }
}

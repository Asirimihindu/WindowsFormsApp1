using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 loginForm;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            loginForm = parentForm;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
            Application.Exit();
        }

        private void buttonAddTrans_Click(object sender, EventArgs e)
        {
            decimal TransValue = Convert.ToDecimal(textBoxTransAmount.Text);
            string TransDescription = textBoxTransDes.Text;
            DateTime TransDate = dateTimePickerTrans.Value;
            int TransType = 0;

            if (radioButtonPayment.Checked)
            {
                TransType = 0;
            }

            if (radioButtonIncome.Checked)
            {
                TransType = 1;
            }
            //Creat an object from newmly created class TransactionTableTableAdapter and use the object to insert data to DB
            //TableAdapter is just a strongty typed class that holds an DataAdapter which holds select-,insert,update- and delete commands.
            DataSet1TableAdapters.TransactionTableTableAdapter Myadapter = new DataSet1TableAdapters.TransactionTableTableAdapter();
            Myadapter.InsertTransaction(TransValue,TransDescription,TransDate,Convert.ToBoolean(TransType));

            MessageBox.Show("Data Added to the Database! ");

            transactionTableTableAdapter.Fill(dataSet1.TransactionTable);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TransactionTable' table. You can move, or remove it, as needed.
            transactionTableTableAdapter.Fill(dataSet1.TransactionTable);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
            transactionTableTableAdapter.Update(dataSet1);
            dataGridView1.EndEdit();
           
            transactionTableTableAdapter.Fill(dataSet1.TransactionTable);


        }
    }
}

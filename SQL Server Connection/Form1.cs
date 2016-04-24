using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Server_Connection
{
    public partial class Form1 : Form
    {
    
         private SqlCommand command; 
         private DataTable dt;
         private int number;

         private SqlConnection m_Connection;
         private SqlDataAdapter m_DataAdapter;
         private static DataSet m_DataSet;
         private static SqlCommandBuilder m_CmdBuilder;

         public Form1()
         {
             connectDB();
             InitializeComponent();
             initialAll();
        
         }

         //
         //Function  connectDB()
         //       
         public void connectDB()
         {
             m_Connection = new SqlConnection("Server = localhost\\SQLSERVER; Database = BBOnlineMarket; Trusted_Connection = True");
             m_Connection.Open();
         }

         //
         //Function  initialAll()
         //   
         public void initialAll()
         {
             comboBox1.Items.AddRange(ListTables().ToArray());
             comboBox1.SelectedIndex = 0;
             dgv.Visible = false;
         }

         //
         //Function  ListTables()
         //
         public List<string> ListTables()
         {
             List<string> tables = new List<string>();

             DataTable dt = m_Connection.GetSchema("Tables");

             foreach (DataRow row in dt.Rows)
             {
                 string tablename = (string)row[2];
                 tables.Add(tablename);
             }

             return tables;
         }

         //
         //Function  ListTableAttributes()
         //
         public List<string> ListTableAttributes(string tableName)
         {
             List<string> attributes = new List<string>();
             string sql = "SELECT * FROM " + tableName + " WHERE 1=0";

             m_DataAdapter = new SqlDataAdapter(sql, m_Connection);
             m_DataSet = new DataSet();
             m_CmdBuilder = new SqlCommandBuilder(m_DataAdapter);

             m_DataAdapter.Fill(m_DataSet, tableName);

             foreach (DataColumn col in m_DataSet.Tables[0].Columns)
             {
                 attributes.Add(col.ColumnName);
             }

             return attributes;
         }

         public bool executeSQL(string sql)
         {
             m_DataAdapter = new SqlDataAdapter(sql, m_Connection);
             m_DataSet = new DataSet();
             m_CmdBuilder = new SqlCommandBuilder(m_DataAdapter);

             try
             {
                 m_DataAdapter.Fill(m_DataSet);

                 if (m_DataSet.Tables.Count > 0)
                     dgv.DataSource = m_DataSet.Tables[0];
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }

             return true;
         }


         //
         //Function  executeSQL()
         //
         public bool executeSQL(string sql, string table)
         {
             m_DataAdapter = new SqlDataAdapter(sql, m_Connection);
             m_DataSet = new DataSet();
             m_CmdBuilder = new SqlCommandBuilder(m_DataAdapter);

             try
             {
                 m_DataAdapter.Fill(m_DataSet, table);
                 dgv.DataSource = m_DataSet.Tables[table];
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }

             return true;
         }

         //
         //Function  getTable() for Search
         //
         public void getTable()
         {
             dgv.Visible = true;
             string cmd = "";          

             switch (number)
             {
                 case 0:                      
                     cmd = "Select * From " + comboBox1.SelectedItem.ToString()+ " where username= '" + textBox1.Text + "'";
                     break;
                 case 1:                      
                     cmd = "Select * From " + comboBox1.SelectedItem.ToString() + " where productID= '" + textBox1.Text + "'";
                     break;
                case 3:
                    cmd = "Select * From " + comboBox1.SelectedItem.ToString() + " where orderID= '" + textBox1.Text + "'";
                    break;
                 default:
                     break;
             }

             command = new SqlCommand(cmd, m_Connection);
             m_DataAdapter = new SqlDataAdapter(command);

             m_DataSet = new DataSet();
             m_DataAdapter.Fill(m_DataSet, comboBox1.SelectedItem.ToString());
             dgv.DataSource = m_DataSet.Tables[comboBox1.SelectedItem.ToString()];             
         }

         //
         //Function  getTable3() for delete
         //
         public void getTable3()
         {
             dgv.Visible = true;
             string cmd = "";

             switch (number)
             {
                 case 0:
                     cmd = " Delete From " + comboBox1.SelectedItem.ToString() + " where username= '" + textBox1.Text + "'";
                     break;
                 case 1:
                     cmd = "Delete From " + comboBox1.SelectedItem.ToString() + " where productID= '" + textBox1.Text + "'";
                     break;
                case 3:
                    cmd = "Delete From " + comboBox1.SelectedItem.ToString() + " where orderID= '" + textBox1.Text + "'";
                    break;
                 default:
                     break;
             }

             command = new SqlCommand(cmd, m_Connection);
             m_DataAdapter = new SqlDataAdapter(command);

             m_DataSet = new DataSet();
             m_DataAdapter.Fill(m_DataSet, comboBox1.SelectedItem.ToString());
             dgv.DataSource = m_DataSet.Tables[comboBox1.SelectedItem.ToString()];    
         }

         //
         //Function for display
         //
         public void displayTable()
         {
             dgv.Visible = true;
             string cmd = " Select * From " + comboBox1.SelectedItem.ToString();
             command = new SqlCommand(cmd, m_Connection);
             m_DataAdapter = new SqlDataAdapter(command);

             m_DataSet = new DataSet();
             m_DataAdapter.Fill(m_DataSet, comboBox1.SelectedItem.ToString());
             dgv.DataSource = m_DataSet.Tables[comboBox1.SelectedItem.ToString()];             
         }

         //
         //Function  getTable() for search
         //        
            private void button1_Click(object sender, EventArgs e)
            {
                getTable();
            }

        //
        //Function for update
        //  
        private void button3_Click(object sender, EventArgs e)
        {           
            try
            {
                int changes = 0;
                m_CmdBuilder = new SqlCommandBuilder(m_DataAdapter); 

                m_DataAdapter.UpdateCommand = m_CmdBuilder.GetUpdateCommand();
                changes = m_DataAdapter.Update(m_DataSet.Tables[comboBox1.SelectedItem.ToString()]);

                MessageBox.Show(changes.ToString() + " Record(s) Updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //
        //Function for delete
        //  
        private void button4_Click(object sender, EventArgs e)
        {
           getTable3();
        }

        //
        //Function for exit
        //  
         private void button2_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Exit?", "exit info", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)            
             {
                Application.Exit();
             }
         }

         //
         //Function  for comboBox
         //  
          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
             number = comboBox1.SelectedIndex;
             switch (number)
             {
                 case 0:
                 case 1:
                 textBox1.Text = "Enter a username, productID, or orderID here";
                 break;
                 default:
                 textBox1.Text = " ";
                 break;
             }
          }

          //
          //Function  for textBox
          //  
         private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == '\'')
             {
                e.Handled = true;
             }
         }

         //
         //Function  for display
         //  
         private void button5_Click(object sender, EventArgs e)
         {
             displayTable();
         }

        private void button6_Click(object sender, EventArgs e)
        {
            executeSQL(customQueryTextBox.Text);
            customQueryTextBox.Clear();
        }

        private void customQueryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}

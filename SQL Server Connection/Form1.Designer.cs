namespace SQL_Server_Connection
{
 partial class Form1
 {
 /// <summary>
 /// Required designer variable.
 /// </summary>
 private System.ComponentModel.IContainer components = null;
 /// <summary>
 /// Clean up any resources being used.
 /// </summary>
 /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 protected override void Dispose(bool disposing)
 {
 if (disposing && (components != null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }
 #region Windows Form Designer generated code
 /// <summary>
 /// Required method for Designer support - do not modify
 /// the contents of this method with the code editor.
 /// </summary>
 private void InitializeComponent()
 {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customQueryLabel = new System.Windows.Forms.Label();
            this.executeCustomQuery = new System.Windows.Forms.Button();
            this.customQueryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 42);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(952, 483);
            this.dgv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LSJPRRGSLQ;Initial Catalog=EmployeeDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(465, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "display";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customQueryTextBox);
            this.panel1.Controls.Add(this.executeCustomQuery);
            this.panel1.Controls.Add(this.customQueryLabel);
            this.panel1.Location = new System.Drawing.Point(12, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 88);
            this.panel1.TabIndex = 8;
            // 
            // customQueryLabel
            // 
            this.customQueryLabel.AutoSize = true;
            this.customQueryLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customQueryLabel.Location = new System.Drawing.Point(9, 17);
            this.customQueryLabel.Name = "customQueryLabel";
            this.customQueryLabel.Size = new System.Drawing.Size(238, 38);
            this.customQueryLabel.TabIndex = 0;
            this.customQueryLabel.Text = "Custom Query";
            this.customQueryLabel.Click += new System.EventHandler(this.sampleQueriesLabel_Click);
            // 
            // executeCustomQuery
            // 
            this.executeCustomQuery.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeCustomQuery.Location = new System.Drawing.Point(771, 3);
            this.executeCustomQuery.Name = "executeCustomQuery";
            this.executeCustomQuery.Size = new System.Drawing.Size(178, 82);
            this.executeCustomQuery.TabIndex = 8;
            this.executeCustomQuery.Text = "Execute Query";
            this.executeCustomQuery.UseVisualStyleBackColor = true;
            this.executeCustomQuery.Click += new System.EventHandler(this.button6_Click);
            // 
            // customQueryTextBox
            // 
            this.customQueryTextBox.Location = new System.Drawing.Point(253, 30);
            this.customQueryTextBox.Name = "customQueryTextBox";
            this.customQueryTextBox.Size = new System.Drawing.Size(512, 20);
            this.customQueryTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SQL Database Connection";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

 }
 #endregion
 private System.Windows.Forms.DataGridView dgv;
 private System.Windows.Forms.Button button1;
 private System.Data.SqlClient.SqlConnection sqlConnection1;
 private System.Windows.Forms.ComboBox comboBox1;
 private System.Windows.Forms.TextBox textBox1;
 private System.Windows.Forms.Button button2;
 private System.Windows.Forms.Button button3;
 private System.Windows.Forms.Button button4;
 private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button executeCustomQuery;
        private System.Windows.Forms.Label customQueryLabel;
        private System.Windows.Forms.TextBox customQueryTextBox;
    }
}

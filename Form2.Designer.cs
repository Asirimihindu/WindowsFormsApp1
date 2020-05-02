namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTransAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTransDes = new System.Windows.Forms.TextBox();
            this.dateTimePickerTrans = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPayment = new System.Windows.Forms.RadioButton();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.buttonAddTrans = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.transactionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.TransactionTableTableAdapter();
            this.transAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Amount(LKR) :";
            // 
            // textBoxTransAmount
            // 
            this.textBoxTransAmount.Location = new System.Drawing.Point(240, 33);
            this.textBoxTransAmount.Name = "textBoxTransAmount";
            this.textBoxTransAmount.Size = new System.Drawing.Size(273, 22);
            this.textBoxTransAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description                       :";
            // 
            // textBoxTransDes
            // 
            this.textBoxTransDes.Location = new System.Drawing.Point(240, 79);
            this.textBoxTransDes.Multiline = true;
            this.textBoxTransDes.Name = "textBoxTransDes";
            this.textBoxTransDes.Size = new System.Drawing.Size(454, 74);
            this.textBoxTransDes.TabIndex = 3;
            // 
            // dateTimePickerTrans
            // 
            this.dateTimePickerTrans.Location = new System.Drawing.Point(240, 188);
            this.dateTimePickerTrans.Name = "dateTimePickerTrans";
            this.dateTimePickerTrans.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTrans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date and Time                 :";
            // 
            // radioButtonPayment
            // 
            this.radioButtonPayment.AutoSize = true;
            this.radioButtonPayment.Checked = true;
            this.radioButtonPayment.Location = new System.Drawing.Point(487, 188);
            this.radioButtonPayment.Name = "radioButtonPayment";
            this.radioButtonPayment.Size = new System.Drawing.Size(84, 21);
            this.radioButtonPayment.TabIndex = 6;
            this.radioButtonPayment.TabStop = true;
            this.radioButtonPayment.Text = "Payment";
            this.radioButtonPayment.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(620, 186);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(74, 21);
            this.radioButtonIncome.TabIndex = 7;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // buttonAddTrans
            // 
            this.buttonAddTrans.Location = new System.Drawing.Point(42, 247);
            this.buttonAddTrans.Name = "buttonAddTrans";
            this.buttonAddTrans.Size = new System.Drawing.Size(156, 52);
            this.buttonAddTrans.TabIndex = 8;
            this.buttonAddTrans.Text = "Add Transaction";
            this.buttonAddTrans.UseVisualStyleBackColor = true;
            this.buttonAddTrans.Click += new System.EventHandler(this.buttonAddTrans_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transAmountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.transTypeDataGridViewCheckBoxColumn,
            this.counterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 224);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableBindingSource
            // 
            this.transactionTableBindingSource.DataMember = "TransactionTable";
            this.transactionTableBindingSource.DataSource = this.dataSet1;
            // 
            // transactionTableTableAdapter
            // 
            this.transactionTableTableAdapter.ClearBeforeFill = true;
            // 
            // transAmountDataGridViewTextBoxColumn
            // 
            this.transAmountDataGridViewTextBoxColumn.DataPropertyName = "TransAmount";
            this.transAmountDataGridViewTextBoxColumn.HeaderText = "TransAmount";
            this.transAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transAmountDataGridViewTextBoxColumn.Name = "transAmountDataGridViewTextBoxColumn";
            this.transAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transTypeDataGridViewCheckBoxColumn
            // 
            this.transTypeDataGridViewCheckBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.transTypeDataGridViewCheckBoxColumn.Name = "transTypeDataGridViewCheckBoxColumn";
            this.transTypeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // counterIDDataGridViewTextBoxColumn
            // 
            this.counterIDDataGridViewTextBoxColumn.DataPropertyName = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.HeaderText = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.counterIDDataGridViewTextBoxColumn.Name = "counterIDDataGridViewTextBoxColumn";
            this.counterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.counterIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(221, 247);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(144, 52);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 575);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddTrans);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.radioButtonPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTrans);
            this.Controls.Add(this.textBoxTransDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTransAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTransAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTransDes;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPayment;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.Button buttonAddTrans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transactionTableBindingSource;
        private DataSet1TableAdapters.TransactionTableTableAdapter transactionTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
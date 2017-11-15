namespace Hafala_Hub
{
    partial class Sched_n__List
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
            this.contactList1DataSet = new Hafala_Hub.ContactList1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Hafala_Hub.ContactList1DataSetTableAdapters.TableTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.שםכונןDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.מספרמטכליDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.מספראדוםDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.מספראזרחיDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactList1DataSet1 = new Hafala_Hub.ContactList1DataSet1();
            this.contactListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactListTableAdapter = new Hafala_Hub.ContactList1DataSet1TableAdapters.ContactListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.contactList1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactList1DataSet
            // 
            this.contactList1DataSet.DataSetName = "ContactList1DataSet";
            this.contactList1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.contactList1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(764, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(523, 296);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.שםכונןDataGridViewTextBoxColumn,
            this.מספרמטכליDataGridViewTextBoxColumn,
            this.מספראדוםDataGridViewTextBoxColumn,
            this.מספראזרחיDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(562, 296);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // שםכונןDataGridViewTextBoxColumn
            // 
            this.שםכונןDataGridViewTextBoxColumn.DataPropertyName = "שם כונן";
            this.שםכונןDataGridViewTextBoxColumn.HeaderText = "שם כונן";
            this.שםכונןDataGridViewTextBoxColumn.Name = "שםכונןDataGridViewTextBoxColumn";
            // 
            // מספרמטכליDataGridViewTextBoxColumn
            // 
            this.מספרמטכליDataGridViewTextBoxColumn.DataPropertyName = "מספר מטכלי";
            this.מספרמטכליDataGridViewTextBoxColumn.HeaderText = "מספר מטכלי";
            this.מספרמטכליDataGridViewTextBoxColumn.Name = "מספרמטכליDataGridViewTextBoxColumn";
            // 
            // מספראדוםDataGridViewTextBoxColumn
            // 
            this.מספראדוםDataGridViewTextBoxColumn.DataPropertyName = "מספר אדום";
            this.מספראדוםDataGridViewTextBoxColumn.HeaderText = "מספר אדום";
            this.מספראדוםDataGridViewTextBoxColumn.Name = "מספראדוםDataGridViewTextBoxColumn";
            // 
            // מספראזרחיDataGridViewTextBoxColumn
            // 
            this.מספראזרחיDataGridViewTextBoxColumn.DataPropertyName = "מספר אזרחי";
            this.מספראזרחיDataGridViewTextBoxColumn.HeaderText = "מספר אזרחי";
            this.מספראזרחיDataGridViewTextBoxColumn.Name = "מספראזרחיDataGridViewTextBoxColumn";
            // 
            // contactList1DataSet1
            // 
            this.contactList1DataSet1.DataSetName = "ContactList1DataSet1";
            this.contactList1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactListBindingSource
            // 
            this.contactListBindingSource.DataMember = "ContactList";
            this.contactListBindingSource.DataSource = this.contactList1DataSet1;
            // 
            // contactListTableAdapter
            // 
            this.contactListTableAdapter.ClearBeforeFill = true;
            // 
            // Sched_n__List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 718);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Sched_n__List";
            this.Text = "Sched_n__List";
            this.Load += new System.EventHandler(this.Sched_n__List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactList1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContactList1DataSet contactList1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ContactList1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn שםכונןDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn מספרמטכליDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn מספראדוםDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn מספראזרחיDataGridViewTextBoxColumn;
        private ContactList1DataSet1 contactList1DataSet1;
        private System.Windows.Forms.BindingSource contactListBindingSource;
        private ContactList1DataSet1TableAdapters.ContactListTableAdapter contactListTableAdapter;
    }
}
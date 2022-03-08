namespace FinalErg2
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
            this.database1DataSet = new FinalErg2.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.πίνακας1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.πίνακας1TableAdapter = new FinalErg2.Database1DataSetTableAdapters.Πίνακας1TableAdapter();
            this.tableAdapterManager = new FinalErg2.Database1DataSetTableAdapters.TableAdapterManager();
            this.πίνακας1DataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // πίνακας1BindingSource
            // 
            this.πίνακας1BindingSource.DataMember = "Πίνακας1";
            this.πίνακας1BindingSource.DataSource = this.database1DataSet;
            // 
            // πίνακας1TableAdapter
            // 
            this.πίνακας1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = FinalErg2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Πίνακας1TableAdapter = this.πίνακας1TableAdapter;
            // 
            // πίνακας1DataGridView
            // 
            this.πίνακας1DataGridView.AllowUserToAddRows = false;
            this.πίνακας1DataGridView.AllowUserToDeleteRows = false;
            this.πίνακας1DataGridView.AutoGenerateColumns = false;
            this.πίνακας1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.πίνακας1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.betDataGridViewTextBoxColumn,
            this.winDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.πίνακας1DataGridView.DataSource = this.πίνακας1BindingSource;
            this.πίνακας1DataGridView.Location = new System.Drawing.Point(12, 12);
            this.πίνακας1DataGridView.Name = "πίνακας1DataGridView";
            this.πίνακας1DataGridView.ReadOnly = true;
            this.πίνακας1DataGridView.Size = new System.Drawing.Size(461, 226);
            this.πίνακας1DataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // betDataGridViewTextBoxColumn
            // 
            this.betDataGridViewTextBoxColumn.DataPropertyName = "Bet";
            this.betDataGridViewTextBoxColumn.HeaderText = "Bet";
            this.betDataGridViewTextBoxColumn.Name = "betDataGridViewTextBoxColumn";
            this.betDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // winDataGridViewTextBoxColumn
            // 
            this.winDataGridViewTextBoxColumn.DataPropertyName = "Win";
            this.winDataGridViewTextBoxColumn.HeaderText = "Win";
            this.winDataGridViewTextBoxColumn.Name = "winDataGridViewTextBoxColumn";
            this.winDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 270);
            this.Controls.Add(this.πίνακας1DataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource πίνακας1BindingSource;
        private Database1DataSetTableAdapters.Πίνακας1TableAdapter πίνακας1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView πίνακας1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn betDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}
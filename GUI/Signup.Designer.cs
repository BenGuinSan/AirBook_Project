namespace GUI
{
    partial class Signup
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
            this.aIRBOOKDataSet = new GUI.AIRBOOKDataSet();
            this.actionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionsTableAdapter = new GUI.AIRBOOKDataSetTableAdapters.actionsTableAdapter();
            this.tableAdapterManager = new GUI.AIRBOOKDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aIRBOOKDataSet
            // 
            this.aIRBOOKDataSet.DataSetName = "AIRBOOKDataSet";
            this.aIRBOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionsBindingSource
            // 
            this.actionsBindingSource.DataMember = "actions";
            this.actionsBindingSource.DataSource = this.aIRBOOKDataSet;
            // 
            // actionsTableAdapter
            // 
            this.actionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actionsTableAdapter = this.actionsTableAdapter;
            this.tableAdapterManager.airlinesTableAdapter = null;
            this.tableAdapterManager.airport_gatesTableAdapter = null;
            this.tableAdapterManager.airportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flightsTableAdapter = null;
            this.tableAdapterManager.more_luggageTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.permissionTableAdapter = null;
            this.tableAdapterManager.planesTableAdapter = null;
            this.tableAdapterManager.promotionsTableAdapter = null;
            this.tableAdapterManager.receiversTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.seatsTableAdapter = null;
            this.tableAdapterManager.ticket_classesTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.AIRBOOKDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 431);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AIRBOOKDataSet aIRBOOKDataSet;
        private System.Windows.Forms.BindingSource actionsBindingSource;
        private AIRBOOKDataSetTableAdapters.actionsTableAdapter actionsTableAdapter;
        private AIRBOOKDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
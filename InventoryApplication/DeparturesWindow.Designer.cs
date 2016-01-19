namespace InventoryApplication
{
    partial class DeparturesWindow
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
            this.btnAddArrive = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgDepartures = new System.Windows.Forms.DataGridView();
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddArrive
            // 
            this.btnAddArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddArrive.Location = new System.Drawing.Point(316, 307);
            this.btnAddArrive.Name = "btnAddArrive";
            this.btnAddArrive.Size = new System.Drawing.Size(109, 23);
            this.btnAddArrive.TabIndex = 18;
            this.btnAddArrive.Text = "Entregar productos";
            this.btnAddArrive.UseVisualStyleBackColor = true;
            this.btnAddArrive.Click += new System.EventHandler(this.btnAddArrive_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(12, 307);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Imprimir reporte";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgDepartures
            // 
            this.dgDepartures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartures.Location = new System.Drawing.Point(12, 91);
            this.dgDepartures.MultiSelect = false;
            this.dgDepartures.Name = "dgDepartures";
            this.dgDepartures.ReadOnly = true;
            this.dgDepartures.Size = new System.Drawing.Size(524, 210);
            this.dgDepartures.TabIndex = 16;
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainWindow.Location = new System.Drawing.Point(431, 307);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(105, 23);
            this.btnMainWindow.TabIndex = 15;
            this.btnMainWindow.Text = "Menu principal";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha de inicio:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(101, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 28;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(101, 37);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 27;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(316, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(73, 23);
            this.btnFilter.TabIndex = 26;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(101, 10);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(200, 21);
            this.cbProducts.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Producto:";
            // 
            // DeparturesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddArrive);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgDepartures);
            this.Controls.Add(this.btnMainWindow);
            this.Name = "DeparturesWindow";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.DeparturesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArrive;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgDepartures;
        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label1;

    }
}
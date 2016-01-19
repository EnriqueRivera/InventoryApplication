namespace InventoryApplication
{
    partial class AddDeparture
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
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.dtpArriveDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddDeparture = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPetitioner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantityLeft = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(105, 12);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(210, 21);
            this.cbProducts.TabIndex = 24;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // dtpArriveDate
            // 
            this.dtpArriveDate.Location = new System.Drawing.Point(105, 63);
            this.dtpArriveDate.Name = "dtpArriveDate";
            this.dtpArriveDate.Size = new System.Drawing.Size(210, 20);
            this.dtpArriveDate.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(167, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDeparture
            // 
            this.btnAddDeparture.Location = new System.Drawing.Point(87, 179);
            this.btnAddDeparture.Name = "btnAddDeparture";
            this.btnAddDeparture.Size = new System.Drawing.Size(74, 23);
            this.btnAddDeparture.TabIndex = 20;
            this.btnAddDeparture.Text = "Entregar";
            this.btnAddDeparture.UseVisualStyleBackColor = true;
            this.btnAddDeparture.Click += new System.EventHandler(this.btnAddDeparture_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 37);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(89, 20);
            this.txtQuantity.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto:";
            // 
            // txtPetitioner
            // 
            this.txtPetitioner.Location = new System.Drawing.Point(108, 92);
            this.txtPetitioner.Name = "txtPetitioner";
            this.txtPetitioner.Size = new System.Drawing.Size(207, 20);
            this.txtPetitioner.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Solicitante:";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(108, 118);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(207, 20);
            this.txtFolio.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Folio vale:";
            // 
            // lblQuantityLeft
            // 
            this.lblQuantityLeft.AutoSize = true;
            this.lblQuantityLeft.Location = new System.Drawing.Point(200, 40);
            this.lblQuantityLeft.Name = "lblQuantityLeft";
            this.lblQuantityLeft.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityLeft.TabIndex = 29;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(108, 144);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(207, 20);
            this.txtArea.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Área que solicitó:";
            // 
            // AddDeparture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 219);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuantityLeft);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPetitioner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.dtpArriveDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDeparture);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDeparture";
            this.Text = "Entregar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.DateTimePicker dtpArriveDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddDeparture;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPetitioner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantityLeft;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label6;
    }
}
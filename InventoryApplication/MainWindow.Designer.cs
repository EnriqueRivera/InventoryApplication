namespace InventoryApplication
{
    partial class MainWindow
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
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnArrives = new System.Windows.Forms.Button();
            this.btnDepartures = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(33, 24);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(132, 24);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnArrives
            // 
            this.btnArrives.Location = new System.Drawing.Point(33, 63);
            this.btnArrives.Name = "btnArrives";
            this.btnArrives.Size = new System.Drawing.Size(75, 23);
            this.btnArrives.TabIndex = 2;
            this.btnArrives.Text = "Entradas";
            this.btnArrives.UseVisualStyleBackColor = true;
            this.btnArrives.Click += new System.EventHandler(this.btnArrives_Click);
            // 
            // btnDepartures
            // 
            this.btnDepartures.Location = new System.Drawing.Point(132, 63);
            this.btnDepartures.Name = "btnDepartures";
            this.btnDepartures.Size = new System.Drawing.Size(75, 23);
            this.btnDepartures.TabIndex = 3;
            this.btnDepartures.Text = "Salidas";
            this.btnDepartures.UseVisualStyleBackColor = true;
            this.btnDepartures.Click += new System.EventHandler(this.btnDepartures_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(83, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 140);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDepartures);
            this.Controls.Add(this.btnArrives);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Control de inventario CEB 7/1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnArrives;
        private System.Windows.Forms.Button btnDepartures;
        private System.Windows.Forms.Button btnExit;
    }
}
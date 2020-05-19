namespace Projekt_I
{
    partial class Cart
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
            this.data_grid_table_cart = new System.Windows.Forms.DataGridView();
            this.button_return_cart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_table_cart
            // 
            this.data_grid_table_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_table_cart.Location = new System.Drawing.Point(12, 113);
            this.data_grid_table_cart.Name = "data_grid_table_cart";
            this.data_grid_table_cart.RowHeadersWidth = 51;
            this.data_grid_table_cart.RowTemplate.Height = 24;
            this.data_grid_table_cart.Size = new System.Drawing.Size(533, 325);
            this.data_grid_table_cart.TabIndex = 0;
            // 
            // button_return_cart
            // 
            this.button_return_cart.Location = new System.Drawing.Point(557, 12);
            this.button_return_cart.Name = "button_return_cart";
            this.button_return_cart.Size = new System.Drawing.Size(159, 102);
            this.button_return_cart.TabIndex = 1;
            this.button_return_cart.Text = "Sklep";
            this.button_return_cart.UseVisualStyleBackColor = true;
            this.button_return_cart.Click += new System.EventHandler(this.button_return_cart_Click_1);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_return_cart);
            this.Controls.Add(this.data_grid_table_cart);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_return_cart;
        public System.Windows.Forms.DataGridView data_grid_table_cart;
    }
}
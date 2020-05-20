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
            this.button_delete = new System.Windows.Forms.Button();
            this.txt_delete_cart = new System.Windows.Forms.TextBox();
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
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(557, 139);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "button1";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // txt_delete_cart
            // 
            this.txt_delete_cart.Location = new System.Drawing.Point(638, 140);
            this.txt_delete_cart.Name = "txt_delete_cart";
            this.txt_delete_cart.Size = new System.Drawing.Size(100, 22);
            this.txt_delete_cart.TabIndex = 3;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_delete_cart);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_return_cart);
            this.Controls.Add(this.data_grid_table_cart);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_return_cart;
        public System.Windows.Forms.DataGridView data_grid_table_cart;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox txt_delete_cart;
    }
}
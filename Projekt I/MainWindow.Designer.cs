namespace Projekt_I
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
            this.data_grid_table = new System.Windows.Forms.DataGridView();
            this.button_load_book = new System.Windows.Forms.Button();
            this.txt_name_authora_find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.find_book_button = new System.Windows.Forms.Button();
            this.button_sort_desc = new System.Windows.Forms.Button();
            this.button_sord_asc = new System.Windows.Forms.Button();
            this.book_store_customer_want = new System.Windows.Forms.Button();
            this.username_name = new System.Windows.Forms.TextBox();
            this.txt_username_id_mw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_order_generic = new System.Windows.Forms.TextBox();
            this.txt_author_shop = new System.Windows.Forms.TextBox();
            this.txt_title_shop = new System.Windows.Forms.TextBox();
            this.txt_price_shop = new System.Windows.Forms.TextBox();
            this.txt_numer_book = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_shop_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_table
            // 
            this.data_grid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_table.Location = new System.Drawing.Point(26, 127);
            this.data_grid_table.Name = "data_grid_table";
            this.data_grid_table.RowHeadersWidth = 51;
            this.data_grid_table.RowTemplate.Height = 24;
            this.data_grid_table.Size = new System.Drawing.Size(549, 296);
            this.data_grid_table.TabIndex = 0;
            this.data_grid_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_table_CellClick);
            // 
            // button_load_book
            // 
            this.button_load_book.Location = new System.Drawing.Point(26, 12);
            this.button_load_book.Name = "button_load_book";
            this.button_load_book.Size = new System.Drawing.Size(125, 64);
            this.button_load_book.TabIndex = 1;
            this.button_load_book.Text = "Załaduj Książki";
            this.button_load_book.UseVisualStyleBackColor = true;
            this.button_load_book.Click += new System.EventHandler(this.button_load_book_Click);
            // 
            // txt_name_authora_find
            // 
            this.txt_name_authora_find.Location = new System.Drawing.Point(157, 90);
            this.txt_name_authora_find.Name = "txt_name_authora_find";
            this.txt_name_authora_find.Size = new System.Drawing.Size(125, 22);
            this.txt_name_authora_find.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor:";
            // 
            // find_book_button
            // 
            this.find_book_button.Location = new System.Drawing.Point(157, 12);
            this.find_book_button.Name = "find_book_button";
            this.find_book_button.Size = new System.Drawing.Size(125, 64);
            this.find_book_button.TabIndex = 4;
            this.find_book_button.Text = "Znajdź Autora";
            this.find_book_button.UseVisualStyleBackColor = true;
            this.find_book_button.Click += new System.EventHandler(this.find_book_button_Click);
            // 
            // button_sort_desc
            // 
            this.button_sort_desc.Location = new System.Drawing.Point(288, 12);
            this.button_sort_desc.Name = "button_sort_desc";
            this.button_sort_desc.Size = new System.Drawing.Size(108, 29);
            this.button_sort_desc.TabIndex = 5;
            this.button_sort_desc.Text = "Sort.Malejąco";
            this.button_sort_desc.UseVisualStyleBackColor = true;
            this.button_sort_desc.Click += new System.EventHandler(this.button_sort_desc_Click);
            // 
            // button_sord_asc
            // 
            this.button_sord_asc.Location = new System.Drawing.Point(288, 47);
            this.button_sord_asc.Name = "button_sord_asc";
            this.button_sord_asc.Size = new System.Drawing.Size(108, 29);
            this.button_sord_asc.TabIndex = 6;
            this.button_sord_asc.Text = "Sort.Rosnąco";
            this.button_sord_asc.UseVisualStyleBackColor = true;
            this.button_sord_asc.Click += new System.EventHandler(this.button_sord_asc_Click);
            // 
            // book_store_customer_want
            // 
            this.book_store_customer_want.Location = new System.Drawing.Point(402, 12);
            this.book_store_customer_want.Name = "book_store_customer_want";
            this.book_store_customer_want.Size = new System.Drawing.Size(125, 64);
            this.book_store_customer_want.TabIndex = 7;
            this.book_store_customer_want.Text = "Koszyk";
            this.book_store_customer_want.UseVisualStyleBackColor = true;
            this.book_store_customer_want.Click += new System.EventHandler(this.book_store_customer_want_Click);
            // 
            // username_name
            // 
            this.username_name.Location = new System.Drawing.Point(688, 12);
            this.username_name.Name = "username_name";
            this.username_name.ReadOnly = true;
            this.username_name.Size = new System.Drawing.Size(100, 22);
            this.username_name.TabIndex = 8;
            this.username_name.TextChanged += new System.EventHandler(this.username_name_TextChanged);
            // 
            // txt_username_id_mw
            // 
            this.txt_username_id_mw.Location = new System.Drawing.Point(688, 40);
            this.txt_username_id_mw.Name = "txt_username_id_mw";
            this.txt_username_id_mw.ReadOnly = true;
            this.txt_username_id_mw.Size = new System.Drawing.Size(33, 22);
            this.txt_username_id_mw.TabIndex = 9;
            this.txt_username_id_mw.TextChanged += new System.EventHandler(this.txt_username_id_mw_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Witaj :";
            // 
            // txt_order_generic
            // 
            this.txt_order_generic.Location = new System.Drawing.Point(674, 122);
            this.txt_order_generic.Name = "txt_order_generic";
            this.txt_order_generic.ReadOnly = true;
            this.txt_order_generic.Size = new System.Drawing.Size(59, 22);
            this.txt_order_generic.TabIndex = 11;
            // 
            // txt_author_shop
            // 
            this.txt_author_shop.Location = new System.Drawing.Point(639, 150);
            this.txt_author_shop.Name = "txt_author_shop";
            this.txt_author_shop.ReadOnly = true;
            this.txt_author_shop.Size = new System.Drawing.Size(122, 22);
            this.txt_author_shop.TabIndex = 12;
            // 
            // txt_title_shop
            // 
            this.txt_title_shop.Location = new System.Drawing.Point(639, 178);
            this.txt_title_shop.Name = "txt_title_shop";
            this.txt_title_shop.ReadOnly = true;
            this.txt_title_shop.Size = new System.Drawing.Size(122, 22);
            this.txt_title_shop.TabIndex = 13;
            // 
            // txt_price_shop
            // 
            this.txt_price_shop.Location = new System.Drawing.Point(639, 206);
            this.txt_price_shop.Name = "txt_price_shop";
            this.txt_price_shop.ReadOnly = true;
            this.txt_price_shop.Size = new System.Drawing.Size(59, 22);
            this.txt_price_shop.TabIndex = 14;
            // 
            // txt_numer_book
            // 
            this.txt_numer_book.Location = new System.Drawing.Point(639, 234);
            this.txt_numer_book.Name = "txt_numer_book";
            this.txt_numer_book.Size = new System.Drawing.Size(59, 22);
            this.txt_numer_book.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tytuł:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ilość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Zamówienie:";
            // 
            // button_shop_add
            // 
            this.button_shop_add.Location = new System.Drawing.Point(620, 273);
            this.button_shop_add.Name = "button_shop_add";
            this.button_shop_add.Size = new System.Drawing.Size(125, 64);
            this.button_shop_add.TabIndex = 21;
            this.button_shop_add.Text = "Dodaj do koszyka";
            this.button_shop_add.UseVisualStyleBackColor = true;
            this.button_shop_add.Click += new System.EventHandler(this.button_shop_add_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_shop_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_numer_book);
            this.Controls.Add(this.txt_price_shop);
            this.Controls.Add(this.txt_title_shop);
            this.Controls.Add(this.txt_author_shop);
            this.Controls.Add(this.txt_order_generic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username_id_mw);
            this.Controls.Add(this.username_name);
            this.Controls.Add(this.book_store_customer_want);
            this.Controls.Add(this.button_sord_asc);
            this.Controls.Add(this.button_sort_desc);
            this.Controls.Add(this.find_book_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name_authora_find);
            this.Controls.Add(this.button_load_book);
            this.Controls.Add(this.data_grid_table);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_table;
        private System.Windows.Forms.Button button_load_book;
        private System.Windows.Forms.TextBox txt_name_authora_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_book_button;
        private System.Windows.Forms.Button button_sort_desc;
        private System.Windows.Forms.Button button_sord_asc;
        private System.Windows.Forms.Button book_store_customer_want;
        private System.Windows.Forms.TextBox username_name;
        private System.Windows.Forms.TextBox txt_username_id_mw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_order_generic;
        private System.Windows.Forms.TextBox txt_author_shop;
        private System.Windows.Forms.TextBox txt_title_shop;
        private System.Windows.Forms.TextBox txt_price_shop;
        private System.Windows.Forms.TextBox txt_numer_book;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_shop_add;
    }
}
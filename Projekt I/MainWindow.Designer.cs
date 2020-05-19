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
            this.txt_name_authora_find.Location = new System.Drawing.Point(688, 127);
            this.txt_name_authora_find.Name = "txt_name_authora_find";
            this.txt_name_authora_find.Size = new System.Drawing.Size(100, 22);
            this.txt_name_authora_find.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 130);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
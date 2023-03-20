namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Wishlistbtn = new System.Windows.Forms.Label();
            this.wishlist = new System.Windows.Forms.ListBox();
            this.Fillbtn = new System.Windows.Forms.Button();
            this.Sortbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Countbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Selectionbtn = new System.Windows.Forms.Label();
            this.countbtn2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Wishlistbtn
            // 
            this.Wishlistbtn.AutoSize = true;
            this.Wishlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wishlistbtn.Location = new System.Drawing.Point(25, 69);
            this.Wishlistbtn.Name = "Wishlistbtn";
            this.Wishlistbtn.Size = new System.Drawing.Size(69, 18);
            this.Wishlistbtn.TabIndex = 0;
            this.Wishlistbtn.Text = "Wish List";
            // 
            // wishlist
            // 
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(28, 109);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(112, 173);
            this.wishlist.TabIndex = 1;
            this.wishlist.SelectedIndexChanged += new System.EventHandler(this.wishlist_SelectedIndexChanged);
            // 
            // Fillbtn
            // 
            this.Fillbtn.Location = new System.Drawing.Point(213, 109);
            this.Fillbtn.Name = "Fillbtn";
            this.Fillbtn.Size = new System.Drawing.Size(75, 23);
            this.Fillbtn.TabIndex = 2;
            this.Fillbtn.Text = "Fill";
            this.Fillbtn.UseVisualStyleBackColor = true;
            this.Fillbtn.Click += new System.EventHandler(this.Fillbtn_Click);
            // 
            // Sortbtn
            // 
            this.Sortbtn.Location = new System.Drawing.Point(213, 153);
            this.Sortbtn.Name = "Sortbtn";
            this.Sortbtn.Size = new System.Drawing.Size(75, 23);
            this.Sortbtn.TabIndex = 3;
            this.Sortbtn.Text = "Sort";
            this.Sortbtn.UseVisualStyleBackColor = true;
            this.Sortbtn.Click += new System.EventHandler(this.Sortbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(213, 194);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 4;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Countbtn
            // 
            this.Countbtn.Location = new System.Drawing.Point(213, 234);
            this.Countbtn.Name = "Countbtn";
            this.Countbtn.Size = new System.Drawing.Size(75, 25);
            this.Countbtn.TabIndex = 5;
            this.Countbtn.Text = "Count";
            this.Countbtn.UseVisualStyleBackColor = true;
            this.Countbtn.Click += new System.EventHandler(this.Countbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(213, 278);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 6;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Selectionbtn
            // 
            this.Selectionbtn.AutoSize = true;
            this.Selectionbtn.Location = new System.Drawing.Point(12, 309);
            this.Selectionbtn.Name = "Selectionbtn";
            this.Selectionbtn.Size = new System.Drawing.Size(57, 13);
            this.Selectionbtn.TabIndex = 7;
            this.Selectionbtn.Text = "Selection :";
            // 
            // countbtn2
            // 
            this.countbtn2.AutoSize = true;
            this.countbtn2.Location = new System.Drawing.Point(12, 347);
            this.countbtn2.Name = "countbtn2";
            this.countbtn2.Size = new System.Drawing.Size(44, 13);
            this.countbtn2.TabIndex = 8;
            this.countbtn2.Text = "Count : ";
            this.countbtn2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 400);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.countbtn2);
            this.Controls.Add(this.Selectionbtn);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Countbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Sortbtn);
            this.Controls.Add(this.Fillbtn);
            this.Controls.Add(this.wishlist);
            this.Controls.Add(this.Wishlistbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wishlistbtn;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Button Fillbtn;
        private System.Windows.Forms.Button Sortbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Countbtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label Selectionbtn;
        private System.Windows.Forms.Label countbtn2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


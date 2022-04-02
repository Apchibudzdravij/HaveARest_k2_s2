
namespace OOP_Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.APPLY = new System.Windows.Forms.Button();
            this.SHOP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.tshirt = new System.Windows.Forms.Label();
            this.SIZE = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emaillabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.namelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.modellabel = new System.Windows.Forms.Label();
            this.modelBox1 = new System.Windows.Forms.ComboBox();
            this.validation = new System.Windows.Forms.TextBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FIND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // APPLY
            // 
            this.APPLY.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APPLY.Location = new System.Drawing.Point(418, 351);
            this.APPLY.Name = "APPLY";
            this.APPLY.Size = new System.Drawing.Size(112, 41);
            this.APPLY.TabIndex = 0;
            this.APPLY.Text = "APPLY";
            this.APPLY.UseVisualStyleBackColor = true;
            this.APPLY.Click += new System.EventHandler(this.APPLY_Click);
            // 
            // SHOP
            // 
            this.SHOP.AutoSize = true;
            this.SHOP.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SHOP.Location = new System.Drawing.Point(536, 9);
            this.SHOP.Name = "SHOP";
            this.SHOP.Size = new System.Drawing.Size(252, 98);
            this.SHOP.TabIndex = 2;
            this.SHOP.Text = "SHOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // emailbox
            // 
            this.emailbox.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailbox.Location = new System.Drawing.Point(12, 64);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(193, 39);
            this.emailbox.TabIndex = 4;
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailbox.TextChanged += new System.EventHandler(this.emailbox_TextChanged);
            // 
            // tshirt
            // 
            this.tshirt.AutoSize = true;
            this.tshirt.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tshirt.Location = new System.Drawing.Point(567, 97);
            this.tshirt.Name = "tshirt";
            this.tshirt.Size = new System.Drawing.Size(168, 42);
            this.tshirt.TabIndex = 5;
            this.tshirt.Text = "T-SHIRTS";
            // 
            // SIZE
            // 
            this.SIZE.AutoSize = true;
            this.SIZE.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SIZE.Location = new System.Drawing.Point(12, 128);
            this.SIZE.Name = "SIZE";
            this.SIZE.Size = new System.Drawing.Size(74, 35);
            this.SIZE.TabIndex = 6;
            this.SIZE.Text = "Size";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(397, 39);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emaillabel.Location = new System.Drawing.Point(12, 26);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(193, 35);
            this.emaillabel.TabIndex = 8;
            this.emaillabel.Text = "Your E-mail";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datelabel.Location = new System.Drawing.Point(111, 128);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(397, 35);
            this.datelabel.TabIndex = 9;
            this.datelabel.Text = "expected date of receipt";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkOrange;
            this.progressBar1.Location = new System.Drawing.Point(12, 351);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 41);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.Location = new System.Drawing.Point(231, 26);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(174, 35);
            this.namelabel.TabIndex = 12;
            this.namelabel.Text = "Your name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(231, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 39);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modellabel
            // 
            this.modellabel.AutoSize = true;
            this.modellabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modellabel.Location = new System.Drawing.Point(111, 219);
            this.modellabel.Name = "modellabel";
            this.modellabel.Size = new System.Drawing.Size(110, 35);
            this.modellabel.TabIndex = 13;
            this.modellabel.Text = "Model";
            // 
            // modelBox1
            // 
            this.modelBox1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelBox1.FormattingEnabled = true;
            this.modelBox1.Items.AddRange(new object[] {
            "Black&Yellow #01",
            "Black&White #02",
            "Black&Blue #03",
            "Black&Red #04",
            "Black #05",
            "White #06",
            "Skyblue #07"});
            this.modelBox1.Location = new System.Drawing.Point(111, 257);
            this.modelBox1.Name = "modelBox1";
            this.modelBox1.Size = new System.Drawing.Size(397, 39);
            this.modelBox1.TabIndex = 14;
            this.modelBox1.SelectedIndexChanged += new System.EventHandler(this.modelBox1_SelectedIndexChanged);
            // 
            // validation
            // 
            this.validation.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validation.Location = new System.Drawing.Point(536, 173);
            this.validation.Multiline = true;
            this.validation.Name = "validation";
            this.validation.ReadOnly = true;
            this.validation.Size = new System.Drawing.Size(264, 231);
            this.validation.TabIndex = 15;
            // 
            // SAVE
            // 
            this.SAVE.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SAVE.Location = new System.Drawing.Point(12, 304);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(112, 41);
            this.SAVE.TabIndex = 16;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // LOAD
            // 
            this.LOAD.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LOAD.Location = new System.Drawing.Point(130, 304);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(112, 41);
            this.LOAD.TabIndex = 17;
            this.LOAD.Text = "Load";
            this.LOAD.UseVisualStyleBackColor = true;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "s",
            "m",
            "l",
            "xl"});
            this.listBox1.Location = new System.Drawing.Point(12, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(74, 120);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(463, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FIND
            // 
            this.FIND.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIND.Location = new System.Drawing.Point(248, 304);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(112, 41);
            this.FIND.TabIndex = 20;
            this.FIND.Text = "menu";
            this.FIND.UseVisualStyleBackColor = true;
            this.FIND.Click += new System.EventHandler(this.FIND_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.FIND);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LOAD);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.modelBox1);
            this.Controls.Add(this.modellabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SIZE);
            this.Controls.Add(this.tshirt);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SHOP);
            this.Controls.Add(this.APPLY);
            this.Controls.Add(this.validation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SHOP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button APPLY;
        private System.Windows.Forms.Label SHOP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.Label tshirt;
        private System.Windows.Forms.Label SIZE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label modellabel;
        private System.Windows.Forms.ComboBox modelBox1;
        private System.Windows.Forms.TextBox validation;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button FIND;
    }
}


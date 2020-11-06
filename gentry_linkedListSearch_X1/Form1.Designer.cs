namespace gentry_linkedListSearch_X1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfMales = new System.Windows.Forms.TextBox();
            this.TotalPeople = new System.Windows.Forms.TextBox();
            this.TotalFemales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PopularMale = new System.Windows.Forms.TextBox();
            this.PopularFemale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchList = new System.Windows.Forms.Button();
            this.SearchResults = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameToAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GenderSelection = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PopularityAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "People By Popular Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Males";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Females";
            // 
            // numberOfMales
            // 
            this.numberOfMales.Location = new System.Drawing.Point(17, 97);
            this.numberOfMales.Name = "numberOfMales";
            this.numberOfMales.ReadOnly = true;
            this.numberOfMales.Size = new System.Drawing.Size(192, 22);
            this.numberOfMales.TabIndex = 4;
            // 
            // TotalPeople
            // 
            this.TotalPeople.Location = new System.Drawing.Point(318, 97);
            this.TotalPeople.Name = "TotalPeople";
            this.TotalPeople.ReadOnly = true;
            this.TotalPeople.Size = new System.Drawing.Size(147, 22);
            this.TotalPeople.TabIndex = 5;
            // 
            // TotalFemales
            // 
            this.TotalFemales.Location = new System.Drawing.Point(557, 97);
            this.TotalFemales.Name = "TotalFemales";
            this.TotalFemales.ReadOnly = true;
            this.TotalFemales.Size = new System.Drawing.Size(221, 22);
            this.TotalFemales.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Most Popular Male";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Most Popular Female";
            // 
            // PopularMale
            // 
            this.PopularMale.Location = new System.Drawing.Point(17, 184);
            this.PopularMale.Name = "PopularMale";
            this.PopularMale.ReadOnly = true;
            this.PopularMale.Size = new System.Drawing.Size(318, 22);
            this.PopularMale.TabIndex = 9;
            // 
            // PopularFemale
            // 
            this.PopularFemale.Location = new System.Drawing.Point(434, 184);
            this.PopularFemale.Name = "PopularFemale";
            this.PopularFemale.ReadOnly = true;
            this.PopularFemale.Size = new System.Drawing.Size(344, 22);
            this.PopularFemale.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search List";
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(126, 294);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(321, 22);
            this.SearchName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name you are looking for:";
            // 
            // SearchList
            // 
            this.SearchList.Location = new System.Drawing.Point(471, 293);
            this.SearchList.Name = "SearchList";
            this.SearchList.Size = new System.Drawing.Size(75, 23);
            this.SearchList.TabIndex = 14;
            this.SearchList.Text = "Search";
            this.SearchList.UseVisualStyleBackColor = true;
            this.SearchList.Click += new System.EventHandler(this.SearchList_Click);
            // 
            // SearchResults
            // 
            this.SearchResults.AutoSize = true;
            this.SearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResults.Location = new System.Drawing.Point(123, 319);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(0, 31);
            this.SearchResults.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Add To List";
            // 
            // NameToAdd
            // 
            this.NameToAdd.Location = new System.Drawing.Point(68, 416);
            this.NameToAdd.Name = "NameToAdd";
            this.NameToAdd.Size = new System.Drawing.Size(192, 22);
            this.NameToAdd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Name:";
            // 
            // GenderSelection
            // 
            this.GenderSelection.FormattingEnabled = true;
            this.GenderSelection.Items.AddRange(new object[] {
            "M",
            "F",
            "GF",
            "NB"});
            this.GenderSelection.Location = new System.Drawing.Point(318, 414);
            this.GenderSelection.Name = "GenderSelection";
            this.GenderSelection.Size = new System.Drawing.Size(121, 24);
            this.GenderSelection.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gender:";
            // 
            // PopularityAdd
            // 
            this.PopularityAdd.Location = new System.Drawing.Point(500, 416);
            this.PopularityAdd.Name = "PopularityAdd";
            this.PopularityAdd.Size = new System.Drawing.Size(184, 22);
            this.PopularityAdd.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(495, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Popularity:";
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(707, 407);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(71, 31);
            this.AddToList.TabIndex = 23;
            this.AddToList.Text = "Add";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PopularityAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GenderSelection);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameToAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.SearchList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PopularFemale);
            this.Controls.Add(this.PopularMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalFemales);
            this.Controls.Add(this.TotalPeople);
            this.Controls.Add(this.numberOfMales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gentry_LinkedListSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfMales;
        private System.Windows.Forms.TextBox TotalPeople;
        private System.Windows.Forms.TextBox TotalFemales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PopularMale;
        private System.Windows.Forms.TextBox PopularFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchList;
        private System.Windows.Forms.Label SearchResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameToAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GenderSelection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PopularityAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddToList;
    }
}


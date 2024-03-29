namespace GUIStudent
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            add = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtName = new TextBox();
            Name = new Label();
            ID = new Label();
            Major = new Label();
            GPA = new Label();
            txtID = new TextBox();
            txtGPA = new TextBox();
            update = new Button();
            delete = new Button();
            search = new Button();
            Detail = new Label();
            title = new Label();
            listView1 = new ListView();
            LName = new ColumnHeader();
            LID = new ColumnHeader();
            LGPA = new ColumnHeader();
            LMajor = new ColumnHeader();
            exit = new Button();
            txtMajor = new TextBox();
            SuspendLayout();
            
            add.Location = new Point(39, 360);
            add.Name = "add";
            add.Size = new Size(123, 51);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            
            txtName.Location = new Point(102, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += Name_TextChanged;
            
            Name.AutoSize = true;
            Name.Location = new Point(12, 123);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 3;
            Name.Text = "Name";
            Name.Click += label1_Click;
             
            ID.AutoSize = true;
            ID.Location = new Point(12, 175);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 5;
            ID.Text = "ID";
            
            Major.AutoSize = true;
            Major.Location = new Point(14, 296);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 6;
            Major.Text = "Major";
             
            GPA.AutoSize = true;
            GPA.Location = new Point(14, 237);
            GPA.Name = "GPA";
            GPA.Size = new Size(36, 20);
            GPA.TabIndex = 7;
            GPA.Text = "GPA";
           
            txtID.Location = new Point(102, 175);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 8;
            txtID.TextChanged += ID_TextChanged;
            
            txtGPA.Location = new Point(102, 237);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(125, 27);
            txtGPA.TabIndex = 9;
            txtGPA.TextChanged += GPA_TextChanged;
            
            update.Location = new Point(211, 360);
            update.Name = "update";
            update.Size = new Size(120, 51);
            update.TabIndex = 11;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            
            delete.Location = new Point(380, 360);
            delete.Name = "delete";
            delete.Size = new Size(125, 51);
            delete.TabIndex = 12;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
             
            search.Location = new Point(567, 361);
            search.Name = "search";
            search.Size = new Size(120, 50);
            search.TabIndex = 13;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            
            Detail.AutoSize = true;
            Detail.Location = new Point(496, 72);
            Detail.Name = "Detail";
            Detail.Size = new Size(131, 20);
            Detail.TabIndex = 14;
            Detail.Text = "Detail information";
            Detail.Click += label5_Click;
            
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(360, 9);
            title.Name = "title";
            title.Size = new Size(190, 31);
            title.TabIndex = 15;
            title.Text = "Manage Student";
            title.Click += label6_Click;
            
            listView1.Columns.AddRange(new ColumnHeader[] { LName, LID, LGPA, LMajor });
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(272, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 236);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            
            LName.Text = "Name";
            LName.Width = 100;
            
            LID.Text = "ID";
            LID.TextAlign = HorizontalAlignment.Center;
            LID.Width = 100;
            
            LGPA.Text = "GPA";
            LGPA.TextAlign = HorizontalAlignment.Center;
            LGPA.Width = 100;
            
            LMajor.Text = "Major";
            LMajor.TextAlign = HorizontalAlignment.Center;
            LMajor.Width = 100;
            
            exit.Location = new Point(734, 361);
            exit.Name = "exit";
            exit.Size = new Size(120, 50);
            exit.TabIndex = 16;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            
            txtMajor.Location = new Point(102, 289);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(125, 27);
            txtMajor.TabIndex = 10;
            txtMajor.TabStop = false;
            txtMajor.TextChanged += Major_TextChanged;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 568);
            Controls.Add(listView1);
            Controls.Add(exit);
            Controls.Add(title);
            Controls.Add(Detail);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(txtMajor);
            Controls.Add(txtGPA);
            Controls.Add(txtID);
            Controls.Add(GPA);
            Controls.Add(Major);
            Controls.Add(ID);
            Controls.Add(Name);
            Controls.Add(txtName);
            Controls.Add(add);
            //Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtName;
        private Label Name;
        private Label ID;
        private Label Major;
        private Label GPA;
        private TextBox txtID;
        private TextBox txtGPA;
        private Button update;
        private Button delete;
        private Button search;
        private Label Detail;
        private Label title;
        private ListView listView1;
        private ColumnHeader LName;
        private ColumnHeader LID;
        private ColumnHeader LGPA;
        private ColumnHeader LMajor;
        private Button exit;
        private TextBox txtMajor;
    }
}

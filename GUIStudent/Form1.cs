

namespace GUIStudent
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            //if (txtName.Text == "")
            //{
            //    MessageBox.Show("Input your name", "Notification");
            //    txtName.Focus();
            //    return;
            //}
        }
        private void ID_TextChanged(object sender, EventArgs e)
        {
            //if (txtID.Text == "")
            //{
            //    MessageBox.Show("Input your ID", "Notification");
            //    txtID.Focus();
            //    return;
            //}
        }
        private void GPA_TextChanged(object sender, EventArgs e)
        {
            //if (txtGPA.Text == "")
            //{
            //    MessageBox.Show("Input your GPA", "Notification");
            //    txtGPA.Focus();
            //    return;
            //}
        }

        
        private void Major_TextChanged(object sender, EventArgs e)
        {
            //if (txtMajor.Text == "")
            //{
            //    MessageBox.Show("Input your Major", "Notification");
            //    txtMajor.Focus();
            //    return;
                
            //}
        }

        private void ResetTextBoxes()
        {
            txtName.Text = "";
            txtID.Text = "";
            txtGPA.Text = "";
            txtMajor.Text = "";
        }

        // Add
        private void add_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sinh viên từ các TextBox
            string name = txtName.Text;
            string id = txtID.Text;
            string gpa = txtGPA.Text;
            string major = txtMajor.Text;

            // Thêm thông tin sinh viên vào ListView
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(id);
            item.SubItems.Add(gpa);
            item.SubItems.Add(major);
            listView1.Items.Add(item);

            // Xóa nội dung trong TextBox sau khi thêm
            txtName.Text = "";
            txtID.Text = "";
            txtGPA.Text = "";
            txtMajor.Text = "";
            
            MessageBox.Show("Add student successfully.", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
         


        }

        // Update student by ID
        private void update_Click(object sender, EventArgs e)
        {
            string selectedID = Microsoft.VisualBasic.Interaction.InputBox("Enter Student ID to Update:", "Update by ID", "");
            ListViewItem selectedItem = null;

            // Tìm sinh viên theo ID
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == selectedID)
                {
                    selectedItem = item;
                    break;
                }
            }

            // Kiểm tra nếu sinh viên được tìm thấy
            if (selectedItem != null)
            {
                // Hiển thị thông tin sinh viên đã chọn trong các TextBox
                txtName.Text = selectedItem.SubItems[0].Text;
                txtID.Text = selectedItem.SubItems[1].Text;
                txtGPA.Text = selectedItem.SubItems[2].Text;
                txtMajor.Text = selectedItem.SubItems[3].Text;

                
                DialogResult result = MessageBox.Show("Please input new information for the student.", "Update Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    //update student in ListView
                    selectedItem.SubItems[0].Text = txtName.Text;
                    //selectedItem.SubItems[1].Text = txtID.Text;
                    selectedItem.SubItems[2].Text = txtGPA.Text;
                    selectedItem.SubItems[3].Text = txtMajor.Text;

                    // Delete student in  ListView
                    listView1.Items.Remove(selectedItem); 
                }
            }
            else
            {
                MessageBox.Show("Student with provided ID not found.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete student by ID
        private void delete_Click(object sender, EventArgs e)
        {
            // Nhập ID sinh viên cần xóa
            string deleteID = Microsoft.VisualBasic.Interaction.InputBox("Enter Student ID to delete:", "Delete by ID", "");

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.ToLower() == deleteID.ToLower())
                {
                    // Xác nhận xóa sinh viên
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        listView1.Items.Remove(item);
                        ResetTextBoxes(); 
                        return;
                    }
                }
            }

          
            MessageBox.Show("Student with the given ID was not found.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Search student by id
        private void search_Click(object sender, EventArgs e)
        {
            string searchID = Microsoft.VisualBasic.Interaction.InputBox("Enter Student ID:", "Search by ID", "");

            // Duyệt qua danh sách sinh viên và tìm kiếm theo ID
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.ToLower() == searchID.ToLower())
                {
                    // Chỉ hiển thị thông tin của sinh viên được tìm thấy
                    item.Selected = true;
                    listView1.EnsureVisible(item.Index); // Cuộn để đảm bảo item được nhìn thấy
                    listView1.Focus();
                    break;
                }
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private class Student
        {
            public string Name { get; set; }
            public string ID { get; }
            public string Major { get; set; }
            public double GPA { get; set; }

            public Student(string name, string id, double gpa, string major)
            {
                Name = name;
                ID = id;
                GPA = gpa;
                Major = major;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit program", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            e.Cancel = true;
        }
    }
}

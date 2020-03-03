using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StdManagement
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =; database = student_manager; SslMode = none");
        public Form1()
        {
            InitializeComponent();
            this.Text = "Quản Lí Sinh Viên™";
            Icon icon = Icon.ExtractAssociatedIcon("icon.ico");
            this.Icon = icon;
            Load += new EventHandler(Form1_LoadStudents);
            Load += new EventHandler(Form1_LoadClass);
            Load += new EventHandler(Form1_LoadClassName);
        }

        public void Form1_LoadStudents(object sender, EventArgs e)
        {
            loadStudent();
        }

        public void Form1_LoadClass(object sender, EventArgs e)
        {
            loadClass();
        }

        public void Form1_LoadClassName(object sender, EventArgs e)
        {
            loadClassName();
        }

        public void loadClassName ()
        {
            tenlopsvTxt.Items.Clear();
            List<LopHoc> listclass = model.getCLassName();
            for (int i = 0; i < listclass.Count; i++)
            {
                tenlopsvTxt.Items.Add(listclass[i].getTenLop());
            }
        }

        public void loadClass()
        {
            string query = "SELECT * FROM class";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            tableClass.DataSource = table;
            conn.Close();
        }

        public void loadStudent()
        {
            string query = "SELECT * FROM students";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            tableStudent.DataSource = table;
            conn.Close();
        }

        public void resetFormClass()
        {
            tenlopTxt.Text = "";
            diachiTxt.Text = "";
        }

        public void resetFormStudent()
        {
            tensvTxt.Text = "";
            masvTxt.Text = "";
            tenlopsvTxt.Text = "";
            diachisvTxt.Text = "";
            tuoiTxt.Text = "";
            searchTxt.Text = "";
        }

        private void classAdd_Click(object sender, EventArgs e)
        {
            String TenLop = tenlopTxt.Text;
            String DiaChi = diachiTxt.Text;
            if (TenLop != "" && DiaChi != "")
            {
                if(model.checkClass(TenLop))
                {
                    MessageBox.Show("Lớp học đã tồn tại !");
                }
                else
                {
                    LopHoc cls = new LopHoc(TenLop, DiaChi);
                    if (model.SaveClass(cls))
                    {
                        resetFormClass();
                        resetFormStudent();
                        MessageBox.Show("Đã Thêm Lớp Học " + TenLop + "");
                        loadClassName();
                        loadClass();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
        }
        private void studentAdd_Click(object sender, EventArgs e)
        {
            String MaSV = masvTxt.Text;
            String TenSV = tensvTxt.Text;
            String TenLop = tenlopsvTxt.Text;
            String DiaChi = diachisvTxt.Text;
            if (MaSV != "" && TenSV != "" && TenLop != "" && tuoiTxt.Text != "" && DiaChi != "")
            {
                if(model.checkStudent(MaSV))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại ! Nhập lại");
                }
                else
                {
                    if (model.checkClass(TenLop))
                    {
                        int Tuoi = Convert.ToInt32(tuoiTxt.Text);
                        Students std = new Students(MaSV, TenSV, TenLop, Tuoi, DiaChi);
                        if (model.SaveStudent(std))
                        {
                            resetFormStudent();
                            resetFormClass();
                            MessageBox.Show("Đã Thêm Sinh Viên " + TenSV + "");
                            loadStudent();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lớp học không tồn tại ! Vui lòng tạo lớp học mới");
                        resetFormClass();
                        tenlopTxt.Text = TenLop;
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
        }

        private void getInfoClass(object sender, DataGridViewCellEventArgs e)
        {
            tenlopTxt.Text = tableClass.CurrentRow.Cells[1].Value.ToString();
            diachiTxt.Text = tableClass.CurrentRow.Cells[2].Value.ToString();
        }

        private void getInfoStudent(object sender, DataGridViewCellEventArgs e)
        {
            masvTxt.Text = tableStudent.CurrentRow.Cells[1].Value.ToString();
            tensvTxt.Text = tableStudent.CurrentRow.Cells[2].Value.ToString();
            tenlopsvTxt.Text = tableStudent.CurrentRow.Cells[3].Value.ToString();
            tuoiTxt.Text = tableStudent.CurrentRow.Cells[4].Value.ToString();
            diachisvTxt.Text = tableStudent.CurrentRow.Cells[5].Value.ToString();
        }

        private void deleteStudent(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeleteStudentf();
        }


        private void studentDelete_Click(object sender, EventArgs e)
        {
            DeleteStudentf();
        }

        private void deleteClass(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteClassf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteClassf();
        }

        public void DeleteStudentf()
        {
            String tenSV = tableStudent.CurrentRow.Cells[2].Value.ToString();
            DialogResult res = MessageBox.Show("Bạn muốn xoá sinh viên " + tenSV + " ?", "Xoá Sinh Viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                int id = Convert.ToInt32(tableStudent.CurrentRow.Cells[0].Value.ToString());
                if (model.deleteStudent(id))
                {
                    resetFormStudent();
                    MessageBox.Show("Đã Xoá Sinh Viên " + tenSV + "");
                    loadStudent();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                    loadStudent();
                }
            }
        }

        public void deleteClassf()
        {
            String TenLop = tableClass.CurrentRow.Cells[1].Value.ToString();
            DialogResult res = MessageBox.Show("Bạn muốn xoá lớp học " + TenLop + " ?", "Xoá Lớp Học", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            int id = Convert.ToInt32(tableClass.CurrentRow.Cells[0].Value.ToString());
            if (res == DialogResult.OK)
            {
                if(model.checkStudentOfClass(TenLop))
                {
                    MessageBox.Show("Lớp học hiện đang có sinh viên, Không thể xoá lớp!");
                }
                else
                {
                    if (model.deleteClass(id))
                    {
                        resetFormClass();
                        MessageBox.Show("Đã Xoá Lớp " + TenLop + "");
                        loadClass();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                        loadClass();
                    }
                }
            }
        }

        private void classEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tableClass.CurrentRow.Cells[0].Value.ToString());
            String TenLop = tenlopTxt.Text;
            String DiaChi = diachiTxt.Text;
            if (TenLop != "" && DiaChi != "")
            {
                LopHoc cls = new LopHoc(ID, TenLop, DiaChi);
                if (model.editClass(cls))
                {
                    resetFormClass();
                    MessageBox.Show("Đã Sửa Lớp Học " + TenLop + "");
                    loadClass();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
        }

        private void studentEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tableStudent.CurrentRow.Cells[0].Value.ToString());
            String MaSV = masvTxt.Text;
            String TenSV = tensvTxt.Text;
            String TenLop = tenlopsvTxt.Text;
            String DiaChi = diachisvTxt.Text;
            if (MaSV != "" && TenSV != "" && TenLop != "" && tuoiTxt.Text != "" && DiaChi != "")
            {
                int Tuoi = Convert.ToInt32(tuoiTxt.Text);
                Students std = new Students(ID, MaSV, TenSV, TenLop, Tuoi, DiaChi);
                if (model.editStudent(std))
                {
                    resetFormStudent();
                    MessageBox.Show("Đã Sửa Sinh Viên " + TenSV + "");
                    loadStudent();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
        }

        private void studentSearch_Click(object sender, EventArgs e)
        {
            String key = "%" + searchTxt.Text + "%";
            if(searchTxt.Text != "")
            {
                searchStudent(key);
            }
            else
            {
                MessageBox.Show("Nhập từ khoá tìm kiếm !");
            }
        }

        public void searchStudent(String key)
        {
            string query = "SELECT * FROM students WHERE MaSV like '" + key + "' OR ID like '" + key + "' OR TenSV like '" + key + "' OR TenLop like '" + key + "' OR Tuoi like '" + key + "' OR DiaChi like '" + key + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            tableStudent.DataSource = table;
            conn.Close();
        }

        private void viewAllStudent_Click(object sender, EventArgs e)
        {
            String TenLop = tableClass.CurrentRow.Cells[1].Value.ToString();
            viewStudentonClass(TenLop);
        }

        public void viewStudentonClass(String TenLop)
        {
            string query = "SELECT * FROM students WHERE TenLop = '" + TenLop + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            tableStudent.DataSource = table;
            conn.Close();
        }

        private void reloadStd_Click(object sender, EventArgs e)
        {
            loadStudent();
            resetFormStudent();
        }

        private void reloadCls_Click(object sender, EventArgs e)
        {
            loadClass();
            resetFormClass();
        }
    }
}

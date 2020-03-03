using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StdManagement
{
    class Model
    {
        MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =; database = student_manager; SslMode = none");

        public List<LopHoc> getCLassName()
        {
            List<LopHoc> listclass = new List<LopHoc>();
            try
            {
                string query = "SELECT TenLop FROM class";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rs = commandDatabase.ExecuteReader();
                while (rs.Read())
                {
                    String TenLop = rs.GetString("TenLop");
                    LopHoc cls = new LopHoc(TenLop);
                    listclass.Add(cls);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return listclass;
        }

        public bool SaveStudent(Students std)
        {
            try
            {
                string query = "insert into `students` (`MaSV`, `TenSV`, `TenLop`, `Tuoi`, `DiaChi`) values ('" + std.getMaSV() + "','" + std.getTenSV() + "','" + std.getTenLop() + "'," + std.getTuoi() + ",'" + std.getDiaChi() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool editStudent(Students std)
        {
            try
            {
                string query = "UPDATE students SET MaSV = '" + std.getMaSV() + "', TenSV = '" + std.getTenSV() + "', TenLop = '" + std.getTenLop() + "', Tuoi = '" + std.getTuoi() + "', DiaChi = '" + std.getDiaChi() + "' WHERE ID = '"+ std.getID() +"'";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool SaveClass(LopHoc cls)
        {
            try
            {
                string query = "insert into `class` (`TenLop`, `DiaChi`) values ('" + cls.getTenLop() + "','" + cls.getDiaChi() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool editClass(LopHoc cls)
        {
            try
            {
                string query = "UPDATE class SET TenLop = '" + cls.getTenLop() + "', DiaChi = '" + cls.getDiaChi() + "' WHERE IDClass = '" + cls.getID() +"'";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool deleteClass(int id)
        {
            try
            {
                string query = "DELETE FROM class WHERE IDClass = " + id + "";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool checkClass(String TenLop)
        {
            try
            {
                string query = "SELECT * FROM class WHERE TenLop = '"+ TenLop +"'";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rs = commandDatabase.ExecuteReader();
                while (rs.Read())
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool checkStudentOfClass(String TenLop)
        {
            try
            {
                string query = "SELECT * FROM students WHERE TenLop = '" + TenLop + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rs = commandDatabase.ExecuteReader();
                while (rs.Read())
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool checkStudent(String MaSV)
        {
            try
            {
                string query = "SELECT * FROM students WHERE MaSV = '" + MaSV + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rs = commandDatabase.ExecuteReader();
                while (rs.Read())
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

        public bool deleteStudent(int id)
        {
            try
            {
                string query = "DELETE FROM students WHERE ID = " + id + "";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                conn.Open();
                commandDatabase.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            conn.Close();
            return false;
        }

    }
}

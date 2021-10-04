using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LAB Task Products.Models.Entity;

namespace LAB Task Products.Models.Tables
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Student s)
        {
            string query = String.Format("Insert into Info values ('{0}','{1}','{2}','{3}')", s.Name, s.Price, s.Quantity,s.Description);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(Student s)
        {
            //string sql = "UPDATE PhotosDB SET PhotoName='" + textBox1.Text + "',Story='" + textBox3.Text + "',Location='" + textBox2.Text + "' WHERE PhotoId=" + Convert.ToInt32(textBox4.Text);
            //string query = "Update Info Set where Name:"+ s.Name, s.Price, s.Quantity, s.Description, " WHERE Id = "+ Id ;
            //SqlCommand cmd = new SqlCommand(query, conn);
            //conn.Open();
            //int r = cmd.ExecuteNonQuery();
            //conn.Close();
        }
        public void Delete(int? Id)
        {
            
            string query = "DELETE FROM Info WHERE Id= "+ Id ;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Student Get(int id)
        {
            return null;
        }
        public List<Student>GetAll()
        {
            string query = "select * from Info";
            //string query = String.Format("Insert into StudentInfo values ('{0}','{1}','{2}',0.0)", s.Name, s.Dob, s.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))

                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }

        public Student AddCart(int Id)
        {

            //string query = "select * from Info WHERE Id= " + Id; 
            string query =String.Format( "select * from Info WHERE Id = {0} " , Id); 
            //string query = String.Format("Insert into StudentInfo values ('{0}','{1}','{2}',0.0)", s.Name, s.Dob, s.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Student s = null;
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                 s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))

                };
                
            }
            conn.Close();
            return s;
        }

    }
}
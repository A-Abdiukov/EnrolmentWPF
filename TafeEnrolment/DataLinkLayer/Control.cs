﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLinkLayer
{
    public class Control
    {
        readonly public string _connectionString;
        /// <summary>
        /// Constructor for Control class
        /// Connects to the Repository class and sets up the connection string
        /// </summary>
        public Control()
        {
            Repository conn_string = new Repository();
            _connectionString = conn_string._connectionString;
        }

        public List<Assessment> GetAssessments()
        {
            List<Assessment> outputlist = new List<Assessment>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllAssessment", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        Assessment output = new Assessment(dataReader.GetInt32(0), dataReader.GetString(1),
                            dataReader.GetDateTime(2), dataReader.GetDateTime(3),
                            (Assessment.AssessmentType)dataReader.GetInt32(4));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetAssessments()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Cluster> GetClusters()
        {
            List<Cluster> outputlist = new List<Cluster>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllCluster", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        Cluster output = new Cluster(dataReader.GetInt32(0), dataReader.GetString(1));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetClusters()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Course> GetCourses()
        {
            List<Course> outputlist = new List<Course>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllCourse", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Course output = new Course(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetDateTime(2), dataReader.GetInt32(3), dataReader.GetDateTime(4));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetCourse()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Location> GetLocations()
        {
            List<Location> outputlist = new List<Location>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllLocation", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Location output = new Location(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetLocations()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        //public List<Payment> GetPayments()
        //{
        //    List<Payment> outputlist = new List<Payment>();
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(_connectionString);
        //        //Execute query
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("exec usp_SelectAllPayment", conn);
        //        SqlDataReader dataReader = cmd.ExecuteReader();

        //        if (dataReader.HasRows)
        //        {
        //            while (dataReader.Read())
        //            {
        //                Payment output = new Payment(dataReader.GetInt32(0), dataReader.GetDateTime(1),
        //                    dataReader.GetBoolean(4), (Payment.PaymentType)dataReader.GetInt32(5),
        //                    dataReader.GetDouble(6));
        //                outputlist.Add(output);
        //            }
        //        }
        //        //disposing
        //        conn.Dispose();
        //        cmd.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error has occured at the GetPayments()\n" + ex.Message);
        //    }
        //    //output
        //    return outputlist;
        //}

        public List<Semester> GetSemesters()
        {
            List<Semester> outputlist = new List<Semester>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllSemester", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Semester output = new Semester(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetDateTime(2), dataReader.GetDateTime(3));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetSemesters()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Student> GetStudents()
        {
            List<Student> outputlist = new List<Student>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);

                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllStudent", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        Student output = new Student(dataReader.GetInt32(0), dataReader.GetString(1),
                            (Student.Gender)dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetString(4),
                            dataReader.GetDateTime(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetBoolean(8), dataReader.GetBoolean(9));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetStudents()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> outputlist = new List<Teacher>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);

                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllTeacher", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //Teacher output = new Teacher(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2),
                        //    (Teacher.Gender)dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetString(5), dataReader.GetDateTime(6));
                        //outputlist.Add(new Teacher());
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetTeachers()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public List<Unit> GetUnits()
        {
            List<Unit> outputlist = new List<Unit>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);

                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_SelectAllUnit", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Unit output = new Unit(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(4));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the GetUnits()\n" + ex.Message);
            }
            //output
            return outputlist;
        }

        public bool AttemptLogin()
        {
            List<User> outputlist = new List<User>();
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);

                //Execute query
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_AttemptLogin", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        User output = new User(dataReader.GetString(1), dataReader.GetString(2));
                        outputlist.Add(output);
                    }
                }
                //disposing
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured at the AttemptLogin()\n" + ex.Message);
            }

            //output
            if (outputlist.Count == 1)
            {
                return true;
            }
            return false;
        }

    }
}

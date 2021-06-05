﻿using DataLinkLayer;
using System.Collections.Generic;

namespace ModelLayer
{
    public class Logic
    {
        private readonly Control control;
        /// <summary>
        /// The consturctor links to the Control.cs in the Model Layer
        /// </summary>
        public Logic()
        {
            this.control = new Control();
        }


        public IEnumerable<BusinessLayer.Teacher> GetTeachers()
        {
            return control.GetTeachers();
        }

        public IEnumerable<BusinessLayer.Student> GetStudents()
        {
            return control.GetStudents();
        }

        public IEnumerable<BusinessLayer.Enrolment> GetEnrolmentsByID(int studentID)
        {
            return control.GetEnrolmentsByID(studentID);
        }


        public IEnumerable<BusinessLayer.Location> GetLocations()
        {
            return control.GetLocations();
        }

        public IEnumerable<BusinessLayer.StudentResult> GetStudentResults(int studentID)
        {
            return control.GetStudentResults(studentID);
        }

        public bool AttemptLogin(string username, string password)
        {
            return control.AttemptLogin(username, password);
        }


        public IEnumerable<BusinessLayer.Cluster> GetClusters()
        {
            return control.GetClusters();
        }

        public IEnumerable<BusinessLayer.Course> GetTeacherHistoryByID(int teacherID)
        {
            return control.GetTeacherHistoryByID(teacherID);
        }

        public IEnumerable<BusinessLayer.NotOfferedCourse> GetNotOfferedCourses()
        {
            return control.AllNotOfferedCourses();
        }

        public IEnumerable<BusinessLayer.Cluster> GetUnallocatedUnits()
        {
            return control.GetUnallocatedUnits();
        }

        public IEnumerable<BusinessLayer.Timetable> GetTimetables()
        {
            return control.GetTimetables();
        }

        //public IEnumerable<BusinessLayer.Teacher> GetPartTimeTeachers()
        //{
        //    IEnumerable<BusinessLayer.Teacher> unsorted_teachers = control.GetTeachers();
        //    List<BusinessLayer.Teacher> output = new List<BusinessLayer.Teacher>();
        //    foreach (var teacher in unsorted_teachers)
        //    {
        //        if (teacher.Position == "Part Time")
        //        {
        //            output.Add(teacher);
        //        }
        //    }
        //    return output;
        //}


        //public IEnumerable<BusinessLayer.Student> GetPartTimeStudents()
        //{
        //    IEnumerable<BusinessLayer.Student> unsorted_students = control.GetStudents();
        //    List<BusinessLayer.Student> output = new List<BusinessLayer.Student>();
        //    foreach (var student in unsorted_students)
        //    {
        //        if (student.Position == "Part Time")
        //        {
        //            output.Add(student);
        //        }
        //    }
        //    return output;
        //}

        //public IEnumerable<BusinessLayer.Student> GetFullTimeStudents()
        //{
        //    IEnumerable<BusinessLayer.Student> unsorted_students = control.GetStudents();
        //    List<BusinessLayer.Student> output = new List<BusinessLayer.Student>();
        //    foreach (var student in unsorted_students)
        //    {
        //        if (student.Position == "Full Time")
        //        {
        //            output.Add(student);
        //        }
        //    }
        //    return output;
        //}

        //public IEnumerable<BusinessLayer.Teacher> GetFullTimeTeachersOtherThanBasedLocation()
        //{
        //    IEnumerable<BusinessLayer.Teacher> unsorted_teachers = control.GetTeachers();
        //    List<BusinessLayer.Teacher> output = new List<BusinessLayer.Teacher>();
        //    foreach (var teacher in unsorted_teachers)
        //    {
        //        if (teacher.Position == "Full Time" //&& teacher's location is other than based location
        //            )
        //        {
        //            output.Add(teacher);
        //        }
        //    }
        //    return output;
        //}

    }
}

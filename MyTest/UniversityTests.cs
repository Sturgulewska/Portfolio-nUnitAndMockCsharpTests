using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class UniversityTests
    {
        [Test]
        public void CheckCreateStudentObject()
        {
            //arrange
            var student = new Student(1, "Kamil");
            //act
            Assert.IsTrue(student.Id==1 && student.Name == "Kamil");
            Assert.IsInstanceOf(typeof(Student), student);
        }

        [Test]
        public void CheckDepartmentObject()
        {//arrange
            var student = new Student(1, "Ania");
            var student1 = new Student(2, "Mateusz");

            var studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student1);
            //arrange
            var department = new Department(1, "Informatyka", studentList);
            // studentList.Clear();
            
            //act and assert
            Assert.IsTrue(department.Id==1 && department.Name=="Informatyka"&& department.Students.Any(s=>s.Id==1 && s.Name=="Ania")
            && department.Students.Any(s=>s.Id==2 && s.Name=="Mateusz"));
            Assert.IsInstanceOf(typeof(Department), department);
        }

        [Test]
        public void CheckCreateUniversity()
        {
            //arrange
            var student = new Student(1, "Ania");
            var student1 = new Student(2, "Mateusz");

            var studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student1);
            //arrange
            var department = new Department(1, "Informatyka", studentList);
            var department2 = new Department(2, "Automatyka", studentList);

            var departmentList = new List<Department>();
            departmentList.Add(department);
            departmentList.Add(department2);

            var university = new University(1, "Politechnika", departmentList);
            //Act and assert
            Assert.IsTrue(university.Id== 1 && university.Name == "Politechnika" &&
                          university.Departments.Any(d=>d.Id==1 && d.Name == "Informatyka"&& d.Students.Any(s=>
                              s.Id==1 && s.Name=="Ania")&& d.Students.Any(s=>s.Id==2 && s.Name=="Mateusz")&& 
                                                        university.Departments.Any(d=>d.Id==2 && d.Name=="Automatyka" && d.Students.
                                                            Any(s=>(s.Id==1 && s.Name=="Ania")&& d.Students.Any(s=>s.Id==2 && s.Name=="Mateusz")))));
            
        }

    }
}
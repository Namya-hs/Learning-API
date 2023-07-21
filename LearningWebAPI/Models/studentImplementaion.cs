using LearningWebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningWebAPI.Models
{
    public class studentImplementaion : Istudent
    {
        private readonly StudentContext _student;
        public studentImplementaion(StudentContext studentContext)
        {
           _student = studentContext;
        }

        public List<student> GetAllStds()
        {
            List<student>? students = _student.Stu.ToList();
            //  student student = _student.Stu.FirstOrDefault(s => s.id == id);

            return students;
        }

        public student GetStdById(int id)
        {
            student? s = _student.Stu.Where(x=>x.id == id).FirstOrDefault();

            return s;
        }

        public student NewStudent(student student)
        {

            student st = new student()
            {
                description = student.description,
                id = student.id,
                name   = student.name,

            };

           _student.Stu.Add(st);
            _student.SaveChanges();

            return st;
        }

        public int UpdateStudent(int id,student updatedstudent)
        {
            bool isExist;

            isExist = _student.Stu.Any(x => x.id == id);

            if(isExist)
            {

               var user = _student.Stu.FirstOrDefault(x => x.id == id);

                user.name = updatedstudent.name;
                user.description = updatedstudent.description;

                
                int a = _student.SaveChanges();

                return a;

            }
            else
            {
                return 0;
            }
            
        }
    }
}
//Home Work
//Create Two Urls
//Getall student
//update information
   //\\
// || || \\
//Actor model id ,name,...
/*1 get by id
    2: create new actor
    3:delete acotr by id
    4:edit actor by id*/
//CRUD
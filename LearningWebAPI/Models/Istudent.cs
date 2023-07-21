namespace LearningWebAPI.Models
{
    public interface Istudent
    {
        public student NewStudent(student student);

        public student GetStdById(int id);

        public List<student> GetAllStds();

        public int UpdateStudent(int id,student updatedstudent);
    }
}

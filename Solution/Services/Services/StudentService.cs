namespace Services.Services;
using Domain.Models;

public class StudentService
{
    private List<Student> Students = new List<Student>();
    
    public List<Student> GetStudent()
    {
        return Students;
    }
    public void Update(Student student,int id)
    {
        int cnt=0;
        foreach (var st in Students)
        {
            cnt++;
           if(st.Id == id)
           {
            Students.Remove(st);
            Students.Insert(cnt, student);            
           }
        }
    }
    public void GetStudentById(Student st1, int id)
    {
       foreach (var st in Students)
       {
        if(id==st1.Id)
        return;
       }
    }
   
    public void StudentDelete(Student st1, int id)
    {
       foreach (var st in Students)
       {
        if(id==st1.Id)
        Students.Remove(st);
       }
    }

    public int StudentCount(int cnt)
    {
       cnt = Students.Count();
       return cnt;
    }
    
}

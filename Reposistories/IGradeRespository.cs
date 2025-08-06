using ClassesGradeApp.Models;
using System.Data;

namespace ClassesGradeApp.Repositories
{
    public interface IGradeRepository
    {
        void AddGrade(Grade grade);
        void UpdateGrade(Grade grade);
        void DeleteGrade(int gradeId);
        DataTable GetAll();
    }
}

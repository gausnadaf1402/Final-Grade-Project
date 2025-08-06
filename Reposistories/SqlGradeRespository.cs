using ClassesGradeApp.Models;
using ClassesGradeApp.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class SqlGradeRepository : IGradeRepository
{
    public void AddGrade(Grade grade)
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";

        string query = @"INSERT INTO dbo.MstGrades 
                         (GradeName, Description, ActiveStatus, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
                         VALUES 
                         (@GradeName, @Description, @ActiveStatus, @IsDeleted, @CreatedBy, GETDATE(), @ModifiedBy, GETDATE())";

        var conn = new SqlConnection(connectionString);
        var cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@GradeName", grade.GradeName);
        cmd.Parameters.AddWithValue("@Description", grade.Description);
        cmd.Parameters.AddWithValue("@ActiveStatus", grade.ActiveStatus);
        cmd.Parameters.AddWithValue("@IsDeleted", grade.IsDeleted);
        cmd.Parameters.AddWithValue("@CreatedBy", grade.CreatedBy);
        cmd.Parameters.AddWithValue("@ModifiedBy", grade.ModifiedBy);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void UpdateGrade(Grade grade)
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";
        string query = @"UPDATE dbo.MstGrades 
                         SET GradeName = @GradeName, 
                             Description = @Description, 
                             ActiveStatus = @ActiveStatus, 
                             IsDeleted = @IsDeleted, 
                             ModifiedBy = @ModifiedBy, 
                             ModifiedDate = GETDATE() 
                         WHERE GradeID = @GradeID";
        var conn = new SqlConnection(connectionString);
        var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@GradeID", grade.GradeID);
        cmd.Parameters.AddWithValue("@GradeName", grade.GradeName);
        cmd.Parameters.AddWithValue("@Description", grade.Description);
        cmd.Parameters.AddWithValue("@ActiveStatus", grade.ActiveStatus);
        cmd.Parameters.AddWithValue("@IsDeleted", grade.IsDeleted);
        cmd.Parameters.AddWithValue("@ModifiedBy", grade.ModifiedBy);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void DeleteGrade(int gradeId)
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";
        string query = @"DELETE FROM dbo.MstGrades WHERE GradeID = @GradeID";
        var conn = new SqlConnection(connectionString);
        var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@GradeID", gradeId);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public DataTable GetAll()
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";
        var con = new SqlConnection(connectionString);
        var da = new SqlDataAdapter(
            @"SELECT GRADEID, GradeName, Description, ActiveStatus, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
              FROM dbo.MstGrades", con);
        var dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}

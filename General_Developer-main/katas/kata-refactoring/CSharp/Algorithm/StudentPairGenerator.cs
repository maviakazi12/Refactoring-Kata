using System;

namespace Algorithm
{
    public class StudentPairGenerator{
        public static List<StudentAgeComparison> GeneratePairs(List<Student> listOfStudents){
            var studentsAgeComparisonList = new List<StudentAgeComparison>();

            for(var i = 0; i < listOfStudents.Count - 1; i++)
            {
                for(var j = i + 1; j < listOfStudents.Count; j++)
                {
                    var studentAgeComparison = new StudentAgeComparison();
                    if(listOfStudents[i].BirthDate < listOfStudents[j].BirthDate)
                    {
                        studentAgeComparison.YoungerStudent = listOfStudents[i];
                        studentAgeComparison.OlderStudent = listOfStudents[j];
                    }
                    else
                    {
                        studentAgeComparison.YoungerStudent = listOfStudents[j];
                        studentAgeComparison.OlderStudent = listOfStudents[i];
                    }
                    studentAgeComparison.AgeDifference = studentAgeComparison.OlderStudent.BirthDate - studentAgeComparison.YoungerStudent.BirthDate;
                    studentsAgeComparisonList.Add(studentAgeComparison);
                }
            }
            return studentsAgeComparisonList;
        }
    }
    
}
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
                        studentAgeComparison.Student1 = listOfStudents[i];
                        studentAgeComparison.Student2 = listOfStudents[j];
                    }
                    else
                    {
                        studentAgeComparison.Student1 = listOfStudents[j];
                        studentAgeComparison.Student2 = listOfStudents[i];
                    }
                    studentAgeComparison.AgeDifference = studentAgeComparison.Student2.BirthDate - studentAgeComparison.Student1.BirthDate;
                    studentsAgeComparisonList.Add(studentAgeComparison);
                }
            }
            return studentsAgeComparisonList;
        }
    }
    
}
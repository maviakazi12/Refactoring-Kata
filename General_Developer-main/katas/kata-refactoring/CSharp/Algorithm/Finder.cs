using System.Collections.Generic;

namespace Algorithm
{
    public class Finder
    {
        private readonly List<Student> _listOfStudents;

        public Finder(List<Student> listOfStudents)
        {
            _listOfStudents = listOfStudents;
        }

        public StudentAgeComparison Find(FT ft)
        {
            var studentsAgeComparisonList = new List<StudentAgeComparison>();

            for(var i = 0; i < _listOfStudents.Count - 1; i++)
            {
                for(var j = i + 1; j < _listOfStudents.Count; j++)
                {
                    var studentAgeComparison = new StudentAgeComparison();
                    if(_listOfStudents[i].BirthDate < _listOfStudents[j].BirthDate)
                    {
                        studentAgeComparison.Student1 = _listOfStudents[i];
                        studentAgeComparison.Student2 = _listOfStudents[j];
                    }
                    else
                    {
                        studentAgeComparison.Student1 = _listOfStudents[j];
                        studentAgeComparison.Student2 = _listOfStudents[i];
                    }
                    studentAgeComparison.AgeDifference = studentAgeComparison.Student2.BirthDate - studentAgeComparison.Student1.BirthDate;
                    studentsAgeComparisonList.Add(studentAgeComparison);
                }
            }

            if(studentsAgeComparisonList.Count < 1)
            {
                return new StudentAgeComparison();
            }

            StudentAgeComparison answer = studentsAgeComparisonList[0];
            foreach(var result in studentsAgeComparisonList)
            {
                switch(ft)
                {
                    case FT.One:
                        if(result.AgeDifference < answer.AgeDifference)
                        {
                            answer = result;
                        }
                        break;

                    case FT.Two:
                        if(result.AgeDifference > answer.AgeDifference)
                        {
                            answer = result;
                        }
                        break;
                }
            }

            return answer;
        }
    }
}
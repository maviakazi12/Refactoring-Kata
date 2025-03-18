using System.Collections.Generic;

namespace Algorithm
{
    public class AgeDifferenceFinder
    {
        private readonly List<Student> _listOfStudents;

        public AgeDifferenceFinder(List<Student> listOfStudents)
        {
            _listOfStudents = listOfStudents;
        }

        public StudentAgeComparison FindClosestOrFarthestAgePair(AgeComparison ageComparison)
        {
            var studentsAgeComparisonList =  StudentPairGenerator.GeneratePairs(_listOfStudents);

            return StudentPairSelector.SelectPair();
            
        }
    }
}
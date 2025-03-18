using System;
using System.Collections.Generic;


namespace Algorithm
{
    public class StudentPairSelector{
        public static StudentAgeComparison SelectPair(){
            var studentsAgeComparisonList = new List<StudentAgeComparison>();
            StudentAgeComparison bestMatch = studentsAgeComparisonList[0];
            foreach(var currentComparison in studentsAgeComparisonList)
            {
                if (currentComparison.AgeDifference < bestMatch.AgeDifference){
                    bestMatch = currentComparison;
                }else if(currentComparison.AgeDifference > bestMatch.AgeDifference){
                            bestMatch = currentComparison;
                }else{
                    return new StudentAgeComparison();
                }
            }
            return bestMatch;
            
        }
    }   
}



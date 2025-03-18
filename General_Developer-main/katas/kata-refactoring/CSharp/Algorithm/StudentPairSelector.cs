using System;
using System.Collections.Generic;


namespace Algorithm
{
    public class StudentPairSelector{
        public static StudentAgeComparison SelectPair(List<StudentAgeComparison>studentsAgeComparisonList){
            var studentsAgeCompareList = new List<StudentAgeComparison>();
            StudentAgeComparison bestMatch = studentsAgeCompareList[0];
            foreach(var currentComparison in studentsAgeCompareList)
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



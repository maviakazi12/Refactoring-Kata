using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithm.Test
{    
    public class AgeDifferenceFinderTests
    {
        [Fact]
        public void Returns_Empty_Results_When_Given_Empty_List()
        {
            var list = new List<Student>();
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.SmallestDifference);

            Assert.Null(result.Student1);
            Assert.Null(result.Student2);
        }

        [Fact]
        public void Returns_Empty_Results_When_Given_One_Person()
        {
            var list = new List<Student>() { sue };
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.SmallestDifference);

            Assert.Null(result.Student1);
            Assert.Null(result.Student2);
        }

        [Fact]
        public void Returns_Closest_Two_For_Two_People()
        {
            var list = new List<Student>() { sue, greg };
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.SmallestDifference);

            Assert.Same(sue, result.Student1);
            Assert.Same(greg, result.Student2);
        }

        [Fact]
        public void Returns_Furthest_Two_For_Two_People()
        {
            var list = new List<Student>() { greg, mike };
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.LargestDifference);

            Assert.Same(greg, result.Student1);
            Assert.Same(mike, result.Student2);
        }

        [Fact]
        public void Returns_Furthest_Two_For_Four_People()
        {
            var list = new List<Student>() { greg, mike, sarah, sue };
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.LargestDifference);

            Assert.Same(sue, result.Student1);
            Assert.Same(sarah, result.Student2);
        }

        [Fact]
        public void Returns_Closest_Two_For_Four_People()
        {
            var list = new List<Student>() { greg, mike, sarah, sue };
            var finder = new AgeDifferenceFinder(list);

            var result = finder.FindClosestOrFarthestAgePair(AgeComparison.SmallestDifference);

            Assert.Same(sue, result.Student1);
            Assert.Same(greg, result.Student2);
        }

        Student sue = new Student() {Name = "Sue", BirthDate = new DateTime(1950, 1, 1)};
        Student greg = new Student() {Name = "Greg", BirthDate = new DateTime(1952, 6, 1)};
        Student sarah = new Student() { Name = "Sarah", BirthDate = new DateTime(1982, 1, 1) };
        Student mike = new Student() { Name = "Mike", BirthDate = new DateTime(1979, 1, 1) };
    }
}
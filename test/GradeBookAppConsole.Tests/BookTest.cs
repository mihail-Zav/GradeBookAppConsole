using System;
using Xunit;

namespace GradeBookAppConsole.Tests
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesGradesStats()
        {
            var book1 = new Book("");
            book1.AddGrade(16.5);
            book1.AddGrade(34.9);
            book1.AddGrade(20.6);
            book1.AddGrade(56.5);
            book1.AddGrade(10.8);

            var stats = book1.GetStats();

            Assert.Equal(10.8, stats.Low, 1);
            Assert.Equal(56.5, stats.High, 1);
            Assert.Equal(27.9, stats.Average, 1);

        }
    }
}

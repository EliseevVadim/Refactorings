using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class Student
    {
        public Student(int mark, int all, int passed)
        {
            exams_average_mark = mark;
            test_count = all;
            passed_tests_count = passed;
        }
        public int GetMark()
        {
            return exams_average_mark;
        }
        public int GetAllTestsCount()
        {
            return test_count;
        }
        public int GetPassedTests()
        {
            return passed_tests_count;
        }
        private int exams_average_mark;
        private int test_count;
        private int passed_tests_count;
    }
}

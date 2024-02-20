using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Starter koden
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

        int[] sophiaPoints = { 90, 86, 87, 98, 100 };
        int[] andrewPoints = { 92, 89, 81, 96, 90 };
        int[] emmaPoints = { 90, 85, 87, 98, 68 };
        int[] loganPoints = { 90, 95, 87, 88, 96 };

        int sophiaSum = 0;
        int andrewSum = 0;
        int emmaSum = 0;
        int loganSum = 0;

        foreach (int i in sophiaPoints)
        {
            sophiaSum += i;
        }

        foreach (int i in andrewPoints)
        {
            andrewSum += i;
        }

        foreach (int i in emmaPoints)
        {
            emmaSum += i;
        }

        foreach (int i in loganPoints)
        {
            loganSum += i;
        }

        decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
        decimal andrewScore = (decimal)andrewSum / currentAssignments;
        decimal emmaScore = (decimal)emmaSum / currentAssignments;
        decimal loganScore = (decimal)loganSum / currentAssignments;

        string currentStudentGrade = "";

        Console.WriteLine("Student\t\tGrade\n");

        foreach (string student in studentNames)
        {
            decimal currentStudentScore = 0;

            if (student == "Sophia")
            {
                currentStudentScore = sophiaScore;
            }
            else if (student == "Andrew")
            {
                currentStudentScore = andrewScore;
            }
            else if (student == "Emma")
            {
                currentStudentScore = emmaScore;
            }
            else if (student == "Logan")
            {
                currentStudentScore = loganScore;
            }

            if (currentStudentScore >= 97) {
                currentStudentGrade = "A+";
            }
            else if (currentStudentScore >= 93)
            {
                currentStudentGrade = "A";
            }
            else if (currentStudentScore >= 90)
            {
                currentStudentGrade = "A-";
            }
            else if (currentStudentScore >= 87)
            {
                currentStudentGrade = "B+";
            }
            else if (currentStudentScore >= 83)
            {
                currentStudentGrade = "B";
            }
            else if (currentStudentScore >= 80)
            {
                currentStudentGrade = "B-";
            }
            else if (currentStudentScore >= 77)
            {
                currentStudentGrade = "C+";
            }
            else if (currentStudentScore >= 73)
            {
                currentStudentGrade = "C";
            }
            else if (currentStudentScore >= 70)
            {
                currentStudentGrade = "C-";
            }
            else if (currentStudentScore >= 67)
            {
                currentStudentGrade = "D+";
            }
            else if (currentStudentScore >= 63)
            {
                currentStudentGrade = "D";
            }
            else if (currentStudentScore >= 60)
            {
                currentStudentGrade = "D-";
            }
            else
            {
                currentStudentGrade = "F";
            }

            Console.WriteLine($"{student}:\t\t" + currentStudentScore + $"\t{currentStudentGrade}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}




//Final code example
///* 
//This C# console application is designed to:
//- Use arrays to store student names and assignment scores.
//- Use a `foreach` statement to iterate through the student names as an outer program loop.
//- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
//- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
//- Use an algorithm within the outer loop to calculate the average exam score for each student.
//- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
//- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
//    - detects extra credit assignments based on the number of elements in the student's scores array.
//    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
//- use the following report format to report student grades: 

//    Student         Grade

//    Sophia:         92.2    A-
//    Andrew:         89.6    B+
//    Emma:           85.6    B
//    Logan:          91.2    A-
//*/

//int examAssignments = 5;

//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
//int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
//int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

//int[] studentScores = new int[10];

//string currentStudentLetterGrade = "";

//// display the header row for scores/grades
//Console.Clear();
//Console.WriteLine("Student\t\tGrade\n");

///*
//The outer foreach loop is used to:
//- iterate through student names 
//- assign a student's grades to the studentScores array
//- sum assignment scores (inner foreach loop)
//- calculate numeric and letter grade
//- write the score report information
//*/

//foreach (string name in studentNames)
//{
//    string currentStudent = name;

//    if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//    else if (currentStudent == "Andrew")
//        studentScores = andrewScores;

//    else if (currentStudent == "Emma")
//        studentScores = emmaScores;

//    else if (currentStudent == "Logan")
//        studentScores = loganScores;

//    int sumAssignmentScores = 0;
//    decimal currentStudentGrade = 0;
//    int gradedAssignments = 0;

//    /* 
//    the inner foreach loop sums assignment scores
//    extra credit assignments are worth 10% of an exam score
//    */
//    foreach (int score in studentScores)
//    {
//        gradedAssignments += 1;

//        if (gradedAssignments <= examAssignments)
//            sumAssignmentScores += score;
//        else
//            sumAssignmentScores += score / 10;
//    }

//    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//    if (currentStudentGrade >= 97)
//        currentStudentLetterGrade = "A+";
//    else if (currentStudentGrade >= 93)
//        currentStudentLetterGrade = "A";
//    else if (currentStudentGrade >= 90)
//        currentStudentLetterGrade = "A-";
//    else if (currentStudentGrade >= 87)
//        currentStudentLetterGrade = "B+";
//    else if (currentStudentGrade >= 83)
//        currentStudentLetterGrade = "B";
//    else if (currentStudentGrade >= 80)
//        currentStudentLetterGrade = "B-";
//    else if (currentStudentGrade >= 77)
//        currentStudentLetterGrade = "C+";
//    else if (currentStudentGrade >= 73)
//        currentStudentLetterGrade = "C";
//    else if (currentStudentGrade >= 70)
//        currentStudentLetterGrade = "C-";
//    else if (currentStudentGrade >= 67)
//        currentStudentLetterGrade = "D+";
//    else if (currentStudentGrade >= 63)
//        currentStudentLetterGrade = "D";
//    else if (currentStudentGrade >= 60)
//        currentStudentLetterGrade = "D-";
//    else
//        currentStudentLetterGrade = "F";

//    // Student         Grade
//    // Sophia:         92.2    A-

//    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
//}

//// required for running in VS Code (keeps the Output windows open to view results)
//Console.WriteLine("\n\rPress the Enter key to continue");
//Console.ReadLine();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //DAY05
                //ASSIGNMENT 06
                //Manipulating data with jagged arrays
                // Create a jagged array called studentScores
                int[][] studentScores = new int[3][];

                // Initialize the studentScores array with the scores
                studentScores[0] = new int[3] { 85, 92, 78 };
                studentScores[1] = new int[4] { 90, 87, 93, 89 };
                studentScores[2] = new int[2] { 76, 88 };

                // Print the scores of each student using nested loops
                for (int i = 0; i < studentScores.Length; i++)
                {
                    Console.Write("Student {0}: ", i + 1);
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        Console.Write(studentScores[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // Calculate the average score for each student and print the results
                for (int i = 0; i < studentScores.Length; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        sum += studentScores[i][j];
                    }
                    double average = sum / studentScores[i].Length;
                    Console.WriteLine("Average score for Student {0}: {1}", i + 1, average);
                }

                Console.WriteLine();

                // Calculate the average score for all the students combined and print the result
                double totalSum = 0;
                int totalLength = 0;

                for (int i = 0; i < studentScores.Length; i++)
                {
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        totalSum += studentScores[i][j];
                        totalLength++;
                    }
                }

                double totalAverage = totalSum / totalLength;
                Console.WriteLine("Average score for all students combined: {0}", totalAverage);

            Console.ReadKey();      
        }


     
        }

    }



﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                                    .Split(", ")
                                    .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] cmdArg = command.Split(":").ToArray();
                string firstCommand = cmdArg[0];
                string lessonTitle = cmdArg[1];

                if (firstCommand == "Add")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (firstCommand == "Insert")
                {
                    int indexToInsert = int.Parse(cmdArg[2]);
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(indexToInsert, lessonTitle);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    lessons.Remove(lessonTitle);
                }
                else if (firstCommand == "Swap")
                {
                    string secondLessonTitle = cmdArg[2];

                    int indexOfFirstLesson = lessons.IndexOf(lessonTitle);
                    int indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);

                    if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
                    {
                        lessons[indexOfFirstLesson] = secondLessonTitle;
                        lessons[indexOfSecondLesson] = lessonTitle;

                        string firstLessonExercise = $"{lessonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson < lessons.Count &&
                            lessons[indexOfFirstExercise] == firstLessonExercise)
                        {
                            lessons.RemoveAt(indexOfFirstExercise);
                            indexOfFirstExercise = lessons.IndexOf(lessonTitle);
                            lessons.Insert(indexOfFirstExercise, firstLessonExercise);
                        }

                        string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                        int indexOfSecondExercise = indexOfSecondLesson + 1;

                        if (indexOfSecondExercise < lessons.Count &&
                            lessons[indexOfSecondExercise] == secondLessonExercise)
                        {
                            lessons.RemoveAt(indexOfSecondLesson + 1);
                            indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                            lessons.Insert(indexOfSecondLesson, secondLessonExercise);
                        }
                    }
                }
                else if (firstCommand == "Exercise")
                {
                    int index = lessons.IndexOf(lessonTitle);
                    string exercise = $"{lessonTitle}-Exercise";

                    bool isThereLesson = lessons.Contains(lessonTitle);
                    bool isThereExercise = lessons.Contains(exercise);

                    if (isThereLesson && !isThereExercise)
                    {
                        lessons.Insert(index + 1, exercise);
                    }
                    else if (!isThereLesson)
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }
                }

                //switch (firstCommand)
                //{
                //    case "Add":
                //        if (!lessons.Contains(lessonTitle))
                //        {
                //            lessons.Add(lessonTitle);
                //        }
                //        break;
                //    case "Insert":
                //        int indexToInsert = int.Parse(cmdArg[2]);
                //        if (lessons.Contains(lessonTitle))
                //        {
                //            lessons.Insert(indexToInsert, lessonTitle);
                //        } 
                //        break;
                //    case "Remove":
                //        lessons.Remove(lessonTitle);
                //        break;
                //    case "Swap":
                //        string secondLessonTitle = cmdArg[2];
                //        
                //        int indexOfFirstLesson = lessons.IndexOf(lessonTitle);
                //        int indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                //
                //        if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
                //        {
                //            lessons[indexOfFirstLesson] = secondLessonTitle;
                //            lessons[indexOfSecondLesson] = lessonTitle;
                //
                //            string firstLessonExercise = $"{lessonTitle}-Exercise";
                //            int indexOfFirstExercise = indexOfFirstLesson + 1;
                //
                //            if (indexOfFirstLesson < lessons.Count &&
                //                lessons[indexOfFirstExercise] == firstLessonExercise)
                //            {
                //                lessons.RemoveAt(indexOfFirstExercise);
                //                indexOfFirstExercise = lessons.IndexOf(lessonTitle);
                //                lessons.Insert(indexOfFirstExercise, firstLessonExercise);
                //            }
                //
                //            string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                //            int indexOfSecondExercise = indexOfSecondLesson + 1;
                //
                //            if (indexOfSecondLesson < lessons.Count &&
                //                lessons[indexOfSecondExercise] == secondLessonExercise)
                //            {
                //                lessons.RemoveAt(indexOfSecondLesson + 1);
                //                indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                //                lessons.Insert(indexOfSecondLesson, secondLessonExercise);
                //            }
                //        }
                //        break;
                //    case "Exercise":
                //        int index = lessons.IndexOf(lessonTitle);
                //        string exercise = $"{lessonTitle}-Exercise";
                //
                //        bool isThereLesson = lessons.Contains(lessonTitle);
                //        bool isThereExercise = lessons.Contains(exercise);
                //
                //        if (isThereLesson && !isThereExercise)
                //        {
                //            lessons.Insert(index + 1, exercise);
                //        }
                //        else if (!isThereLesson)
                //        {
                //            lessons.Add(lessonTitle);
                //            lessons.Add(exercise);
                //        }
                //        break;
                //    
                //}

                command = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }

        }
    }
}

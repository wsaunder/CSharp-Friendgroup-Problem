using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        /*
    This problem was asked by Twitter.

    A classroom consists of N students, whose friendships can be represented in an adjacency list. For example, the following
        descibes a situation where 0 is friends with 1 and 2, 3 is friends with 6, and so on.

    {0: [1, 2],
     1: [0, 5],
     2: [0],
     3: [6],
     4: [],
     5: [1],
     6: [3]} 
    Each student can be placed in a friend group, which can be defined as the transitive closure of that student's 
        friendship relations. In other words, this is the smallest set such that no student in the group has any friends 
        outside this group. For the example above, the friend groups would be {0, 1, 2, 5}, {3, 6}, {4}.

    How solve?

    */
    public class Class2
    {
        public struct Student
        {
            public int studentNumber;
            public int[] friends;
        }
        public static Student StudentBuilder(int studentNumber, int[] friends)
        {
            Student student = new Student();
            student.studentNumber = studentNumber;
            student.friends = friends;

            return student;
        }
        public static Student[] BuildClass(int[][] input)
        {
            Student[] students = new Student[input.Length];
            for (int i=0; i<input.Length; i++)
            {
                students[i] = StudentBuilder(i, input[i]);
            }
            return students; 
        }
        public static int[] ComboFriends(Student[] students)
        {
            List<int> friends = new List<int>();
            for (int j=0; j<students.Length; j++)
            {
                for (int i=0; i<students[j].friends.Length; i++)
                {
                    friends.Add(students[j].friends[i]);
                }
            }
            return friends.ToArray();
        }
        public static List<List<int>> ClassCrawl(Student[] students)
        {
            List<List<int>> fullFriendGroup = new List<List<int>>();
            for(int i=0; i<students.Length; i++)
            {
                List<int> ints = new List<int>();
                for (int j=0; j<students.Length; j++)
                {
                    if (i == j)
                    {
                        foreach(int s in students[j].friends)
                        {
                            ints.Add(s);
                        }
                    }
                    if (Array.Exists(students[j].friends, e => e == i))
                    {
                        foreach (int s in students[j].friends)
                        {
                            ints.Add(s);
                        }
                    }
                }
                ints = ints.Distinct().ToList();
                ints.Sort();
                fullFriendGroup.Add(ints);
            }
            fullFriendGroup = DeDupe(fullFriendGroup);
            return fullFriendGroup;

        }

        public static List<List<int>> DeDupe(List<List<int>> arr)
        {
            List<List<int>> deduped = new List<List<int>>(); 
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Count == 0)
                {
                    deduped.Add(arr[i]);
                }
                if (arr[i].IndexOf(i) == 0)
                {
                    deduped.Add(arr[i]) ;
                    
                }
            }
            return deduped;
        }
    }
}

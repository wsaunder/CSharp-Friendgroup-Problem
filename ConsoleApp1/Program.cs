

using ClassLibrary1;
using static ClassLibrary1.Class2;

int[][] studentClassList = new int[][]
            {
                new int[] {1,2 },
                new int[] {0,5 },
                new int[] {0 },
                new int[] {6 },
                new int[] { },
                new int[] {1 },
                new int[] {3 }
            };
Student[] resultList = Class2.BuildClass(studentClassList);
List<List<int>> ints = Class2.ClassCrawl(resultList); 

for (int i = 0; i < ints.Count; i++)
{
    Console.WriteLine("{" + string.Join(", ", ints[i]) + "},");
}

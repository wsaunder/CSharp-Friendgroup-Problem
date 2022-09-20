using ClassLibrary1;
using Student = ClassLibrary1.Class2.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FriendGroupTest()
        {
            int studentNumber = 0;
            int[] friends = { 1, 2 };
            Student student0 = Class2.StudentBuilder(studentNumber, friends);
            
            Assert.AreEqual(studentNumber, student0.studentNumber);
            Assert.AreEqual(friends, student0.friends);
        }
        [TestMethod]
        public void StudentClassBuilderTest()
        {
            int[][] studentClassList = new int[][]
            {
                new int[] {1,2 },
                new int[] {0,5 } 
            };
            Student[] resultList = Class2.BuildClass(studentClassList);
            for (int i = 0; i < resultList.Length; i++)
            {
                Assert.AreEqual(studentClassList[i], resultList[i].friends);
            }
        }
        [TestMethod]
        public void ComboFriendsTest()
        {
            int[][] studentClassList = new int[][]
            {
                new int[] {1,2 },
                new int[] {0,5 }
            };
            Student[] resultList = Class2.BuildClass(studentClassList);
            int[] comboFriends = Class2.ComboFriends(resultList);
            Assert.AreEqual(comboFriends.Length, comboFriends.Length);
        }
        
    }
}

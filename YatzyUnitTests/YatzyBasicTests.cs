using System.Collections.Generic;
using Xunit;
using YatzyKata;
using Moq;

namespace YatzyUnitTests
{
    public class UnitTest1
    {
       // var consoleActionsMock = new Mock<IConsole>();
        [Fact]
        public void TestToSeeIfFiveNumbersGenerated()
        {
            var consoleActionsMock = new Mock<IConsole>();

            List<int> testNumbers = new List<int>() {3, 4, 5, 5, 2};
            int expected = 5;
            YatzyGame player = new YatzyGame(consoleActionsMock.Object);
            int result = player.RollDice(testNumbers).Count;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestToSeeIfCalculateSumReturnsSum()
        {
            var consoleActionsMock = new Mock<IConsole>();
            List<int> testNumbers = new List<int>() {3, 4, 5, 5, 2};
            int expected = 19;
            YatzyGame player = new YatzyGame(consoleActionsMock.Object);
            int result = player.CalculateSum(testNumbers);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void TestIfKeepNumPutsNumbersSpecifiedByUserInAnArray()
        {
            var consoleActionsMock = new Mock<IConsole>();
            consoleActionsMock.Setup(s => s.ReadLine())
                .Returns("1,2,3"); //fake readline
            List<int> testNumbers = new List<int>();
            int[] array = new int[] {3, 4, 5, 5, 2};
          //  testNumbers.AddRange(array);
          //  int[] heldNumbers = {1,2,3};
            string[] expected = {"1", "2", "3"};
            YatzyGame player = new YatzyGame(consoleActionsMock.Object);
            string[] result = player.KeepNum(testNumbers);
            Assert.Equal(expected, result);
        }

        
        [Fact]
        public void TestIfGetIndexesToKeepReturnsKeepNumAsInt()
        {
            var consoleActionsMock = new Mock<IConsole>();
            string[] eachNumToKeep = {"1", "2", "3"};
            int[] expected = {1,2,3};
            YatzyGame player = new YatzyGame(consoleActionsMock.Object);
            List<int> result = player.GetIndexesToKeep(eachNumToKeep);
            Assert.Equal(expected, result);
        }
        
        
       
        
    }


}
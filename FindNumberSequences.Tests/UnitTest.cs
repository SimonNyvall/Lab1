using FindNumberSequences;

namespace FindNumberSequences.Tests
{
    public class UnitTest
    {
        [Fact]
        public void GetNextIndexForMachingNumber_TestNormalCase()
        {
            const string input = "29535123p48723487597645723645";
            int startIndex = 0;

            int expected = 6;

            int actual = Lab.GetNextIndexForMachingDigit(input, startIndex);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetNextIndexForMachingNumber_TestOnlyLetters()
        {
            const string input = "pppppppppppppppppppppppppppp";
            int startIndex = 0;

            int expected = 1;

            int actual = Lab.GetNextIndexForMachingDigit(input, startIndex);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetNextIndexForMachingNumber_TestNullCase()
        {
            const string input = null;
            int startIndex = 0;

            int expected = -1;

            int actual = Lab.GetNextIndexForMachingDigit(input, startIndex);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetNextIndexForMachingNumber_TestEmptyCase()
        {
            string input = String.Empty;
            int startIndex = 0;

            int expected = -1;

            int actual = Lab.GetNextIndexForMachingDigit(input, startIndex);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetSubstringFromStartToEndIndex_TestNormalCase()
        {
            string input = "29535123p48723487597645723645";
            int start = 0;
            int end = 6;

            string expected = "2953512";

            string actual = Lab.GetSubstringFromStartToEndIndex(input, start, end);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetSubstringFromStartToEndIndex_TestNullCase()
        {
            string input = null;
            int start = 0;
            int end = 6;

            Action nullTest = () => Lab.GetSubstringFromStartToEndIndex(input, start, end);
            Assert.Throws<ArgumentException>(nullTest);                      
        }
        public void GetSubstringFromStartToEndIndex_TestEmptyCase()
        {
            string input = String.Empty;
            int start = 0;
            int end = 6;

            Action emptyTest = () => Lab.GetSubstringFromStartToEndIndex(input, start, end);
            Assert.Throws<ArgumentException>(emptyTest);
        }
        [Fact]
        public void DoesStringOnlyContainNumbers_TestOnlyNumbers()
        {
            string outputSubstring = "456329563";

            Assert.True(Lab.DoesStringOnlyContainNumbers(outputSubstring));
        }
        [Fact]
        public void DoesStringOnlyContainNumbers_TestOnlyLetters()
        {
            string outputSubstring = "eitwoper";

            Assert.False(Lab.DoesStringOnlyContainNumbers(outputSubstring));
        }
        [Fact]
        public void DoesStringOnlyContainNumbers_TestNumberAndLetters()
        {
            string outputSubstring = "21342p13312";

            Assert.False(Lab.DoesStringOnlyContainNumbers(outputSubstring));
        }
        [Fact]
        public void DoesStringOnlyContainNumbers_TestNullCase()
        {
            string outputSubstring = null;

            Assert.False(Lab.DoesStringOnlyContainNumbers(outputSubstring));
        }
        [Fact]
        public void DoesStringOnlyContainNumbers_TestEmptyCase()
        {
            string outputSubstring = String.Empty;

            Assert.False(Lab.DoesStringOnlyContainNumbers(outputSubstring));
        }
    }
}
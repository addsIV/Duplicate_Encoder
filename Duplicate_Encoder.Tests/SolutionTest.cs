// <copyright file="SolutionTest.cs">Copyright ©  2020</copyright>

using System;
using Duplicate_Encoder;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Duplicate_Encoder.Tests
{
    [TestClass]
    [PexClass(typeof(Solution))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SolutionTest
    {

        [PexMethod]
        [PexAllowedException(typeof(IndexOutOfRangeException))]
        [PexAllowedException(typeof(OverflowException))]
        public string ZigZagConvert(
            [PexAssumeUnderTest] Solution target,
            string s,
            int numRows
        )
        {
            string result = target.ZigZagConvert(s, numRows);
            return result;
            // TODO: 將判斷提示加入 方法 SolutionTest.ZigZagConvert(Solution, String, Int32)
        }

        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public int MySqrt([PexAssumeUnderTest] Solution target, int x)
        {
            int result = target.MySqrt(x);
            return result;
            // TODO: 將判斷提示加入 方法 SolutionTest.MySqrt(Solution, Int32)
        }
    }
}

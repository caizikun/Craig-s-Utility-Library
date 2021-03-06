﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

using Utilities.DataTypes;
using Xunit;

namespace UnitTests.DataTypes.ExtensionMethods
{
    public class ArrayExtensions
    {
        [Fact]
        public void ClearTest()
        {
            int[] TestObject = { 1, 2, 3, 4, 5, 6 };
            TestObject = TestObject.Clear();
            foreach (int Item in TestObject)
                Assert.Equal(0, Item);
        }

        [Fact]
        public void CombineTest()
        {
            int[] TestObject1 = { 1, 2, 3 };
            int[] TestObject2 = { 4, 5, 6 };
            int[] TestObject3 = { 7, 8, 9 };
            TestObject1 = TestObject1.Concat(TestObject2, TestObject3);
            for (int x = 0; x < 8; ++x)
                Assert.Equal(x + 1, TestObject1[x]);
        }
    }
}
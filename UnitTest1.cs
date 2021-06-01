using System;
using System.Collections.Generic;
using TestApplication.Controllers;
using Xunit;

namespace TestApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expectedresult = 9;
            int d = 3;
            int n = 2;
            DynamicSeriesController objController = new DynamicSeriesController();
            var result = objController.Get((d*n)-1);
            var value =  (((Microsoft.AspNetCore.Mvc.ObjectResult)result).Value);
            Assert.Equal(expectedresult, (((Microsoft.AspNetCore.Mvc.ObjectResult)result).Value));
        }

        [Fact]
        public void Test2()
        {

        }
    }
}

using System;
using AreaCalc;
using NUnit.Framework;

namespace AreaCalcTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FindAreaCircle_r1_314()
        {    
            Calculator calc = new Calculator();
            double result = calc.FindCircleArea(1);
            Assert.AreEqual(result, 3.14);
        }
        
        [Test]
        public void FindAreaCircle_rLessThanZero_0()
        {    
            Calculator calc = new Calculator();
            double result = calc.FindCircleArea(-1);
            Assert.AreEqual(result, 0);
        }
        
        [Test]
        public void FindTriangleArea_a5b10c14_176()
        {    
            Calculator calc = new Calculator();
            double result = calc.FindTriangleArea(5,10,14);
           // Assert.AreEqual( Math.Round(result, 2), 17.60);
            Assert.AreEqual( result, 17.605041891458253);
        }
        
        [Test]
        public void IsSquare_a5b12c13_true()
        {    
            Calculator calc = new Calculator();
            Assert.True(calc.IsSquare(5,12,13));
        }
        
        [Test]
        public void IsSquare_a3b12c13_false()
        {    
            Calculator calc = new Calculator();
            Assert.False(calc.IsSquare(3,12,13));
        }
        
        [Test]
        public void IsSquare_lessThanZero_false()
        {    
            Calculator calc = new Calculator();
            Assert.False(calc.IsSquare(-3,-12,-13));
        }
        
        [Test]
        public void FindTriangleArea_a2b2c8_0()
        {    
            Calculator calc = new Calculator();
            double result = calc.FindTriangleArea(2,2, 8);
            // Assert.AreEqual( Math.Round(result, 2), 17.60);
            Assert.AreEqual( result, 0);
        }
        
        [Test]
        public void FindTriangleArea_a2b2c4_0()
        {    
            Calculator calc = new Calculator();
            double result = calc.FindTriangleArea(2,2, 4);
            // Assert.AreEqual( Math.Round(result, 2), 17.60);
            Assert.AreEqual( result, 0);
        }
    }
}
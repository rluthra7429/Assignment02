
using Assignment02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        public void Sides1and3and5forNotPossible()
        {
            //Arrange
            int s1 = 1, s2 = 3, s3 = 5;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Trinagle is Not Posssible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides5and5and5forEquilateral()
        {
            //Arrange
            int s1 = 5, s2 = 5, s3 = 5;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "It's Equilateral");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void Sides10and5and6forScalene()
        {
            //Arrange
            int s1 = 10, s2 = 5, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "It's Scalene");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides10and6and6forIsosceles()
        {
            //Arrange
            int s1 = 10, s2 = 6, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "It's Isosceles");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides2and3and4forIsosceles()
        {
            //Arrange
            int s1 =2, s2 = 3, s3 = 4;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "It's Scalene");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void Sides0and3and4forNotPossible()
        {
            //Arrange
            int s1 = 0, s2 = 3, s3 = 4;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Trinagle is Not Posssible");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void SidesNegativeand3and4forNotPossible()
        {
            //Arrange
            int s1 = -5, s2 = 3, s3 = 4;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Trinagle is Not Posssible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides7and7and4forNotPossible()
        {
            //Arrange
            int s1 = 7, s2 = 7, s3 = 4;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "It's Isosceles");
            Console.WriteLine("Please check the result");
        }


    }
}
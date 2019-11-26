using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;

namespace BMIUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNormalBmi()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }

        [TestMethod]
        public void TestOverweightBmi()
        {
            BMI bmi = new BMI() { WeightStones = 15, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Overweight);
        }

        [TestMethod]
        public void TestUnderweightBmi()
        {
            BMI bmi = new BMI() { WeightStones = 8, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Underweight);
        }

        [TestMethod]
        public void TestObeseBmi()
        {
            BMI bmi = new BMI() { WeightStones = 25, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Obese);
        }

       
       
    }
}

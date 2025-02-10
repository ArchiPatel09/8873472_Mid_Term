using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mid_Term_Archi_8873472;

namespace Mid_Term_Archi_8873472_Tests
{
    [TestFixture]
    public class Registration_Tests
    {
        [Test]
        public void  RegisterName_InputArchi_ReturnsArchi()
        {
            // Arrange
            string name = "Archi";
            string expectedName = "Archi";

            //// Act
            string actual = Registration.RegisterName(name);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedName));
        }

        [Test]
        public void RegisterName_InputVibhav_Patel_ReturnsVibhav_Patel()
        {
            // Arrange
            string name = "Vibhav_Patel";
            string expectedName = "Vibhav_Patel";

            //// Act
            string actual = Registration.RegisterName(name);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedName));
        }

        [Test]
        public void RegisterName_InputMaheshkumar_Chandrakantbhai_Patel_ReturnsMaheshkumar_Chandrakantbhai_Patel()
        {
            // Arrange
            string name = "Maheshkumar_Chandrakantbhai_Patel";
            string expectedName = "Maheshkumar_Chandrakantbhai_Patel";

            //// Act
            string actual = Registration.RegisterName(name);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedName));
        }

        [Test]
        public void RegisterAge_Input19_Returns19()
        {
            // Arrange
            int age = 19;
            int expectedAge = 19;

            //// Act
            int actual = Registration.RegisterAge(age);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }

        [Test]
        public void RegisterAge_Input90_Returns90()
        {
            // Arrange
            int age = 90;
            int expectedAge = 90;

            //// Act
            int actual = Registration.RegisterAge(age);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }

        [Test]
        public void RegisterAge_Input125_Returns125()
        {
            // Arrange
            int age = 125;
            int expectedAge = 125;

            //// Act
            int actual = Registration.RegisterAge(age);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }

        [Test]
        public void RegisterGroupSize_Input3_Returns3()
        {
            // Arrange
            int groupSize = 3;
            int expectedGroupSize = 3;

            //// Act
            int actual = Registration.RegisterGroupSize(groupSize);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedGroupSize));
        }

        [Test]
        public void RegisterGroupSize_Input10_Returns10()
        {
            // Arrange
            int groupSize = 10;
            int expectedGroupSize = 10;

            //// Act
            int actual = Registration.RegisterGroupSize(groupSize);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedGroupSize));
        }

        [Test]
        public void RegisterGroupSize_Input18_Returns18()
        {
            // Arrange
            int groupSize = 18;
            int expectedGroupSize = 18;

            //// Act
            int actual = Registration.RegisterGroupSize(groupSize);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedGroupSize));
        }
    }
}

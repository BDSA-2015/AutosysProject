﻿using System;
using ApplicationLogics.PaperManagement.Bibtex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationLogicTests.PaperManagement.Bibtex
{
    [TestClass()]
    public class CustomFieldCheckerTests
    {
        /// <summary>
        /// Tests the validation a single string which should be valid using a custom made regular expression
        /// </summary>
        [TestMethod()]
        public void ValidateTest()
        {
            //Arrange
            var checker = new CustomFieldChecker("[Will]");

            //Act
            var input = "William Swuer";

            //Assert
            Assert.IsTrue(checker.Validate(input));
        }

        /// <summary>
        /// Tests null input for the validation in a custom made field checker method which should be invalid
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateNullTest()
        {
            //Arrange
            var checker = new CustomFieldChecker("[a-zA-Z]*");

            //Act
            checker.Validate(null);
        }
    }
}
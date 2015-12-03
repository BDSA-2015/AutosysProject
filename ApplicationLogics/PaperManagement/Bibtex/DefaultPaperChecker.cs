﻿using System;
using System.ComponentModel;
using System.Linq;
using ApplicationLogics.PaperManagement.Interfaces;

namespace ApplicationLogics.PaperManagement.Bibtex
{
    /// <summary>
    /// The default Paper checker which is chosen, when no custom validator is specified.
    /// All fields of the Paper need to be valid for the Paper to be valid.
    /// </summary>
    public class DefaultPaperChecker : IPaperChecker
    {
        //Validates fields against a default field checker
        readonly FieldValidator _validator;

        public DefaultPaperChecker(FieldValidator validator = null)
        {
            _validator = validator ?? new FieldValidator();
        }

        /// <summary>
        /// Method for validating a Paper for parsing in a BibtexParser
        /// </summary>
        /// <param name="paper">The Paper which is to be validated for parsing</param>
        /// <returns>True if the Paper is valid otherwise false</returns>
        public bool Validate(Paper paper)
        {
            if (paper == null)
            {
                throw new ArgumentNullException("The given Paper cannot be null");
            }
                return paper.Fields.All(field => _validator.IsFieldValid(field.Value, field.Key));
        }
    }
}

﻿// StudyHandler.cs is a part of Autosys project in BDSA-2015. Created: 17, 11, 2015.
// Creators: Dennis Thinh Tan Nguyen, William Diedricsehn Marstrand, Thor Valentin Aakjær Olesen Nielsen, 
// Jacob Mullit Møiniche.

using System;
using ApplicationLogics.StorageAdapter.Interface;

namespace ApplicationLogics.StudyManagement
{
    internal class StudyHandler // TODO Why internal? 
    {

        private IAdapter<Study> _studyAdapter;

        public StudyHandler(IAdapter<Study> adapter)
        {
            _studyAdapter = adapter;
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public Study Read(int studyId)
        {
            throw new NotImplementedException();
        }

        public void Update(Study study)
        {
        }

        public void Delete(Study study)
        {
            throw new NotImplementedException();
        }
    }
}
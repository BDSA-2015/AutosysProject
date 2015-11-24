﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLogics.StudyManagement;

namespace ApplicationLogics.ExportManagement
{
    /// <summary>
    /// Class for converting export files to the PDF format.
    /// </summary>
    //Class is under construction
    public class PDFConverter : IConverter
    {
        public IExportFile Convert(Protocol protocol)
        {
            var exportFile = new PdfFile();
            exportFile.Type = ExportType.PDF;
            exportFile.Description = protocol.Description;
            exportFile.Origin = protocol.Id;
            exportFile.Bytes = System.Convert.FromBase64String(ConvertInclusionData(protocol));
            return exportFile;
        }

        private string ConvertInclusionData(Protocol protocol)
        {
            var myList = new List<Criteria>();
            myList.AddRange(protocol.InclusionCriteria);

            return string.Join(" ", myList.Select(x => x.Name.ToArray()));
        }

        private string ConvertExclusionData(Protocol protocol)
        {
            var myList = new List<Criteria>();
            myList.AddRange(protocol.ExclusionCriteria);

            return string.Join(" ", myList.Select(x => x.Name.ToArray()));
        }
    }
}

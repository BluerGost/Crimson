using FellowOakDicom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.DesktopUI.Services
{
    public class DicomFileService : IDicomFileService
    {
        public async Task<DicomFile?> GetFileAsync(string filePath)
        {
            // Does not exist
            if (File.Exists(filePath) == false)
                return null;

            // Not a dicom file
            if (DicomFile.HasValidHeader(filePath) == false)
                return null;

            // Return dicom file
            return await DicomFile.OpenAsync(filePath);
        }

        public async Task<IList<DicomFile>> GetFilesAsync(string folderPath)
        {
            if (File.Exists(folderPath) == false)
                return null;

            var filePaths = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            IList<DicomFile> dicomFiles = new List<DicomFile>();

            foreach(var filePath in filePaths)
            {
                // Not a dicom file
                if (DicomFile.HasValidHeader(filePath) == false)
                    continue;

                dicomFiles.Add(await DicomFile.OpenAsync(filePath));
            }

            // Return dicom file
            return dicomFiles;
        }
    }
}

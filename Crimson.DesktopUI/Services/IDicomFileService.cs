using FellowOakDicom;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crimson.DesktopUI.Services
{
    public interface IDicomFileService
    {
        /// <summary>
        /// Reads the dicom file from the provided path and return the dicomfile.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>
        /// If successfully read then returns the dicomfile otherwise returns null.
        /// </returns>
        Task<DicomFile?> GetFileAsync(string filePath);

        /// <summary>
        /// Reads the dicom files from the provided folder path given and returns the sucessfully read files.
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns>
        /// Return dicom files, if no file could be read then returns empty list.
        /// </returns>
        Task<IList<DicomFile>> GetFilesAsync(string folderPath);
    }
}
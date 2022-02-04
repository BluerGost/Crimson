using FellowOakDicom;
using System.Collections.Generic;

namespace Crimson.DesktopUI.Services
{
    public interface IDicomFileReaderService
    {
        IList<DicomFile> GetFiles();
        IList<DicomFile> GetFilesAsync();
    }
}
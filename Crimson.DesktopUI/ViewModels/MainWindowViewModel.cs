using Crimson.DesktopUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.DesktopUI.ViewModels
{
    public class MainWindowViewModel
    {
        #region Fields
        private readonly DicomFileService _dicomFileService;
        #endregion

        #region Properties

        #endregion


        #region Constructors
        public MainWindowViewModel()
        {
            _dicomFileService = new DicomFileService();
        }
        #endregion

        #region Methods

        #endregion

        #region Commands

        #endregion
    }
}

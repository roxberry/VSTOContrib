using System.ComponentModel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools;
using VSTOContrib.Core.RibbonFactory.Interfaces;
using VSTOContrib.Word.RibbonFactory;

namespace VSTOContrib.Word.Tests.RibbonFactory.Views
{
    [WordRibbonViewModel]
    public class TestRibbonViewModel : IRibbonViewModel, INotifyPropertyChanged
    {
        public IRibbonUI RibbonUi { get; set; }
        public Factory VstoFactory { get; set; }

        public void Initialised(object context)
        {
        }

        public void CurrentViewChanged(object currentView)
        {
            
        }

        public bool PanelShown { get; set; }

        public bool MyActionEnabled(IRibbonControl control)
        {
            return true;
        }

        public void Cleanup()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}
using System.ComponentModel;

namespace VSTOContrib.Excel.RibbonFactory
{
    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(ExcelWorkbook)]
    public enum ExcelRibbonType
    {
        /// <summary>
        /// Excel Document Ribbon
        /// </summary>
        [Description("Microsoft.Excel.Workbook")]
        ExcelWorkbook = 1
    }
}
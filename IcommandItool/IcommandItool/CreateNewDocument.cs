using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.SystemUI;
using System.Diagnostics;


namespace IcommandItool
{
    /// <summary>
    /// Summary description for CreateNewDocument.
    /// </summary>
    public class CreateNewDocument : BaseCommand
    {
        private IHookHelper m_hookHelper = null;

        //constructor
        public CreateNewDocument()
        {
            //update the base properties
            base.m_category = ".NET Samples";
            base.m_caption = "NewDocument";
            base.m_message = "Create a new map";
            base.m_toolTip = "Create a new map";
            base.m_name = "DotNetTemplate_NewDocumentCommand";
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this command is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {

            Debugger.Break(); // 在这里设置条件断点
            if (m_hookHelper == null)
                m_hookHelper = new HookHelper();

            m_hookHelper.Hook = hook;
        }

        /// <summary>
        /// Occurs when this command is clicked
        /// </summary>
        public override void OnClick()
        {

            Debugger.Break(); // 在这里设置条件断点
            //allow the user to save the current document
            DialogResult res = MessageBox.Show("你要保存当前文档吗?", "AoView", 
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
          
        }

        #endregion
    }
}

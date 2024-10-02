#region Assembly System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Design.dll
#endregion

using System.ComponentModel;
using System.ComponentModel.Design;

namespace System.Windows.Forms.Design
{
    internal class DataGridDesigner : ControlDesigner
    {
        protected DesignerVerbCollection designerVerbs;

        public override DesignerVerbCollection Verbs { get; }

    }
}
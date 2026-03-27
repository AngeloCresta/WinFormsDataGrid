//------------------------------------------------------------------------------
// <copyright file="DataGridLineStyle.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

#if NET10_0_OR_GREATER
namespace System.Windows.Forms.Legacy
#else
namespace System.Windows.Forms
#endif
{
    using System.Diagnostics;
    /// <include file='doc\DataGridLineStyle.uex' path='docs/doc[@for="DataGridLineStyle"]/*' />
    /// <devdoc>
    ///    <para>
    ///       Specifies the style of gridlines in a <see cref='DataGrid'/>.
    ///    </para>
    /// </devdoc>
    public enum DataGridLineStyle {
        /// <include file='doc\DataGridLineStyle.uex' path='docs/doc[@for="DataGridLineStyle.None"]/*' />
        /// <devdoc>
        ///    <para>
        ///       No gridlines between cells.
        ///    </para>
        /// </devdoc>
        None,
        /// <include file='doc\DataGridLineStyle.uex' path='docs/doc[@for="DataGridLineStyle.Solid"]/*' />
        /// <devdoc>
        ///    <para>
        ///       Solid gridlines between cells.
        ///    </para>
        /// </devdoc>
        Solid
    }
}
        

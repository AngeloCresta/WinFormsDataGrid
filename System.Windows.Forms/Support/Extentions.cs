using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms
{
    public static class Extentions
    {

        #region "    CurrencyManager   "
        /// <devdoc>
        ///    <para>Gets the sort direction of a list.</para>
        /// </devdoc>
        public static ListSortDirection GetSortDirection(this IList list)
        {
            if ((list is IBindingList) && ((IBindingList)list).SupportsSorting)
            {
                return ((IBindingList)list).SortDirection;
            }
            return ListSortDirection.Ascending;
        }

        /// <devdoc>
        ///    <para>Sets the column to sort by, and the direction of the sort.</para>
        /// </devdoc>
        public static void SetSort(this CurrencyManager cm, PropertyDescriptor property, ListSortDirection sortDirection)
        {
            IList list = cm.List;

            if (list is IBindingList && ((IBindingList)list).SupportsSorting)
            {
                ((IBindingList)list).ApplySort(property, sortDirection);
            }
        }

        /// <devdoc>
        /// <para>Gets a <see cref='System.ComponentModel.PropertyDescriptor'/> for a CurrencyManager.</para>
        /// </devdoc>
        public static PropertyDescriptor GetSortProperty(this CurrencyManager cm)
        {
            IList list = cm.List;

            if ((list is IBindingList) && ((IBindingList)list).SupportsSorting)
            {
                return ((IBindingList)list).SortProperty;
            }
            return null;
        }

        /// <devdoc>
        ///    <para>Gets the sort direction of a list.</para>
        /// </devdoc>
        public static ListSortDirection GetSortDirection(this CurrencyManager cm)
        {
            IList list = cm.List;
            if ((list is IBindingList) && ((IBindingList)list).SupportsSorting)
            {
                return ((IBindingList)list).SortDirection;
            }
            return ListSortDirection.Ascending;
        }

        /// <devdoc>
        ///    <para>Gets the name of the list.</para>
        /// </devdoc>
        public static string GetListName(this CurrencyManager cm)
        {
            IList list = cm.List;

            if (list is ITypedList)
            {
                return ((ITypedList)list).GetListName(null);
            }
            else
            {
                return null;
            }
        }

        public static bool AllowAdd(this CurrencyManager cm)
        {
            IList list = cm.List;

            if (list is IBindingList)
            {
                return ((IBindingList)list).AllowNew;
            }
            if (list == null)
                return false;
            return true;// !list.IsReadOnly && !list.IsFixedSize;
        }

        /// <devdoc>
        ///    <para>Gets a value
        ///       indicating whether edits to the list are allowed.</para>
        /// </devdoc>
        public static bool AllowEdit(this CurrencyManager cm)
        {
            IList list = cm.List;

            if (list is IBindingList)
            {
                return ((IBindingList)list).AllowEdit;
            }
            if (list == null)
                return false;
            return true;//!list.IsReadOnly;
        }

        /// <devdoc>
        ///    <para>Gets a value indicating whether items can be removed from the list.</para>
        /// </devdoc>
        public static bool AllowRemove(this CurrencyManager cm)
        {
            IList list = cm.List;

            if (list is IBindingList)
            {
                return ((IBindingList)list).AllowRemove;
            }
            if (list == null)
                return false;
            return true;//!list.IsReadOnly && !list.IsFixedSize;

        }

        public static object GetByID(this CurrencyManager cm, int index)
        {
            IList list = cm.List;

            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("ListManagerNoValue " + index.ToString(CultureInfo.CurrentCulture));
            }

            if (list is IBindingList)
            {
                return ((IBindingList)list)[index];
            }

            return null;

        }

        #endregion

        #region "   Cursor   "
        public static Rectangle GetClipInternal(this Cursor cursor)
        {
            NativeMethods.RECT r = new NativeMethods.RECT();
            SafeNativeMethods.GetClipCursor(ref r);
            return Rectangle.FromLTRB(r.left, r.top, r.right, r.bottom);
        }


        public static void SetClipInternal(this Cursor cursor, Rectangle value)
        {
            if (value.IsEmpty)
            {
                UnsafeNativeMethods.ClipCursor(null);
            }
            else
            {
                NativeMethods.RECT rcClip = NativeMethods.RECT.FromXYWH(value.X, value.Y, value.Width, value.Height);
                UnsafeNativeMethods.ClipCursor(ref rcClip);
            }
        }
        #endregion
    }











}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe implémentant la fonction de tri pour les bindinglist 
    /// </summary>
    public class BusinessObjectListView<T> : BindingList<T>
    {
        private bool m_Sorted = false;
        private ListSortDirection m_SortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor m_SortProperty = null;
        private List<T> m_OriginalCollection = new List<T>();

        // constructors, AddNew, etc... omitted
        protected override bool SupportsSearchingCore
        {
            get { return true; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override bool IsSortedCore
        {
            get { return m_Sorted; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return m_SortDirection; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return m_SortProperty; }
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            m_SortDirection = direction;
            m_SortProperty = property;
            SortComparer<T> comparer = new
            SortComparer<T>(property, direction);
            ApplySortInternal(comparer);
        }

        private void ApplySortInternal(SortComparer<T> comparer)
        {
            // store the original order of the collection
            if (m_OriginalCollection.Count == 0)
            {
                m_OriginalCollection.AddRange(this);
            }

            List<T> listRef = this.Items as List<T>;
            if (listRef == null)
                return;
            // Let List<T> do the actual sorting based on your comparer
            listRef.Sort(comparer);
            m_Sorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {

            if (!m_Sorted)

                return;
            Clear();
            foreach (T item in m_OriginalCollection)
            {
                Add(item);
            }
            m_OriginalCollection.Clear();
            m_SortProperty = null;
            m_Sorted = false;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////

    public class SortComparer<T> : IComparer<T>
    {
        private PropertyDescriptor m_PropDesc = null;
        private ListSortDirection m_Direction =
        ListSortDirection.Ascending;

        public SortComparer(PropertyDescriptor propDesc, ListSortDirection direction)
        {
            m_PropDesc = propDesc;
            m_Direction = direction;
        }

        int IComparer<T>.Compare(T x, T y)
        {
            object xValue = m_PropDesc.GetValue(x);
            object yValue = m_PropDesc.GetValue(y);
            return CompareValues(xValue, yValue, m_Direction);
        }

        private int CompareValues(object xValue, object yValue, ListSortDirection direction)
        {
            int retValue = 0;
            if (xValue is IComparable) // Can ask the x value
            {
                retValue = ((IComparable)xValue).CompareTo(yValue);
            }
            else if (yValue is IComparable) //Can ask the y value
            {
                retValue = ((IComparable)yValue).CompareTo(xValue);
            }
            // not comparable, compare String representations
            else if (!xValue.Equals(yValue))
            {
                retValue = xValue.ToString().CompareTo(yValue.ToString());
            }

            if (direction == ListSortDirection.Ascending)
            {
                return retValue;
            }
            else
            {
                return retValue * -1;
            }
        }

    }
}

// Developer Express Code Central Example:
// How to show text (Yes/No) for an in-place CheckEdit in the GridColumn
// 
// Implement two templates, one for editing and the other one for display mode.
// Assign these templates to the GridColumn.EditTemplate and
// GridColumn.DisplayTemplate properties.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2374

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Xpf.Grid;
using System.Windows.Threading;
using DevExpress.Xpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;
using System.Windows.Markup;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        BindingList<ContactItem> coll;
        public Window1() {
            InitializeComponent();
            coll = new BindingList<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = "Abcd bla bl1111a  333 32dfsdf 32423dsfs 32423dfsdf 32423dfsdf 444 dsfsdf 2342 fdsdf abcdsdf dfsd dsfdsfdfdfsdf sdfsdf sdfsdf sdfsdf sdfsdfsd   3434 3434 3434 222 1111 343 1111 444 kjdf kkh kdf dfkjdf dlfkj a222 dlfjsd 222 ldfksldfkj 334234 dslfjsd 34343 ldsfjsldjf 34234";
            f1.Salary = 13d;
            f1.Date = DateTime.Today;
            f1.IsFired=false;
            coll.Add(f1);
            ContactItem f2 = new ContactItem();
            f2.Name = "bla1";
            f2.Date = DateTime.Today;
            f2.Salary = 13;

            coll.Add(f2);

            ContactItem f3 = new ContactItem();
            f3.Name = "la";
            f3.Salary = 13;
            f3.IsFired=true;
            f3.Date = DateTime.Today;
            coll.Add(f3);

            ContactItem f4 = new ContactItem();
            f4.Name = " bla";
            f4.IsFired=true;
            f4.Salary = 13;

            coll.Add(f4);

            gridControl1.ItemsSource = coll;


        }


    }

    public class checkBoxConverter : MarkupExtension, IValueConverter
    {

        #region IValueConverter Members

        public object Convert(object value, System.Type targetType,
                    object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return "bb";
            if ((bool)value)
                return "Yes";
            else
                return "No";
        }

        public object ConvertBack(object value, System.Type targetType,
                    object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        public override object ProvideValue(System.IServiceProvider serviceProvider)
        {
            return this;
        }
    }

}

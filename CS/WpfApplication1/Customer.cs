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
using DevExpress.Xpo;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;

namespace WpfApplication1 {
    public class ContactItem : INotifyPropertyChanged {


        
        protected string _Name;

        public string Name {
            get {
                return this._Name;
            }

            set {
                if(this._Name != value) {
                    this._Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
        
        protected double _Salary;

        public double Salary {
            get {
                return this._Salary;
            }

            set {
                if(this._Salary != value) {
                    this._Salary = value;
                    this.OnPropertyChanged("Salary");
                }
            }
        }
        protected DateTime _Date;

        public DateTime Date {
            get {
                return this._Date;
            }

            set {
                if(this._Date != value) {
                    this._Date = value;
                    this.OnPropertyChanged("Date");
                }
            }
        }

        
        protected bool _IsFired;

        public bool IsFired {
            get {
                return this._IsFired;
            }

            set {
                if(this._IsFired != value) {
                    this._IsFired = value;
                    this.OnPropertyChanged("IsFired");
                }
            }
        }


        public void OnPropertyChanged(string info) {
            if(this.PropertyChanged != null) {
                this.PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}

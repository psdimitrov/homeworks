using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StudentClass
{
    class PropertyChangedEventArgs : EventArgs
    {        
        public PropertyChangedEventArgs(Object oldValue, Object newValue, string propertyName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.PropertyName = propertyName;
        }

        public Object OldValue { get; private set; }

        public Object NewValue { get; private set; }

        public string PropertyName { get; private set; }
    }
}

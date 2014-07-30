namespace ConverterBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class Vm : INotifyPropertyChanged
    {
        private string _stringValue;
        private double _doubleValue;
        public event PropertyChangedEventHandler PropertyChanged;

        public string StringValue
        {
            get { return _stringValue; }
            set
            {
                if (value == _stringValue)
                {
                    return;
                }
                _stringValue = value;
                OnPropertyChanged();
            }
        }

        public double DoubleValue
        {
            get { return _doubleValue; }
            set
            {
                if (value.Equals(_doubleValue))
                {
                    return;
                }
                _doubleValue = value;
                OnPropertyChanged();
            }
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

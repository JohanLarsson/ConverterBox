namespace ConverterBox
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class Vm : INotifyPropertyChanged
    {
        private readonly ObservableCollection<Person> _persons = new ObservableCollection<Person>();
        private string _stringValue;
        private double _doubleValue;

        public Vm()
        {
            _persons.Add(new Person { Name = "Reed", Age = 38 });
            _persons.Add(new Person { Name = "Johan", Age = 36 });
            _persons.Add(new Person { Name = "Brad", Age = 38 });
            _persons.Add(new Person { Name = "George", Age = 41 });
        }

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

        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
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

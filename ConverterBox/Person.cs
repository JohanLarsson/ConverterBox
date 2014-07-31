namespace ConverterBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using ConverterBox.Annotations;

    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int _age;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == this.name)
                {
                    return;
                }
                this.name = value;
                this.OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value == _age)
                {
                    return;
                }
                _age = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
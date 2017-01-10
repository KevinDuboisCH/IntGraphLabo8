using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace UserControls
{
    /// <summary>
    /// Interaction logic for DataField.xaml
    /// </summary>
    public partial class DataField : UserControl
    {
        public DataField()
        {
            InitializeComponent();

            DependencyPropertyDescriptor dataFieldDescriptor =
                DependencyPropertyDescriptor.FromProperty(
                    DataField.ValueProprety,
                    typeof(DataField));
            dataFieldDescriptor.AddValueChanged(this, ValueChanged);
        }

        public event EventHandler EventValueChanged;

        protected virtual void OnValueChanged()
        {
            if (EventValueChanged != null)
                EventValueChanged(this, new EventArgs());
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged();
        }

        public static readonly DependencyProperty ValueProprety = DependencyProperty.Register(
            nameof(Value), typeof(string), typeof(DataField));

        public string Label
        {
            get { return (string)LabelBox.Content; }
            set { LabelBox.Content = String.Format("{0} :", value); }
        }

        public string Value
        {
            get { return (string)GetValue(ValueProprety); }
            set { SetValue(ValueProprety, value); }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Value = TextBox.Text;
        }
    }
}

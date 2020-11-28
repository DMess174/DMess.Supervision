using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DMess.Supervision.Desktop.Components
{
    public partial class BindablePasswordBox : UserControl
    {
        private bool _isPasswordChanging;

        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    PasswordPropertyChanged, null, false, UpdateSourceTrigger.PropertyChanged));

        public BindablePasswordBox()
        {
            InitializeComponent();
        }

        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is BindablePasswordBox passwordBox)
            {
                passwordBox.UpdatePassword();
            }
        }

        private void UpdatePassword()
        {
            if (!_isPasswordChanging)
            {
                passwordbox.Password = Password;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = passwordbox.Password;
            _isPasswordChanging = false;
        }
    }
}

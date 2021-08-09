using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DMess.Supervision.Shared.Models
{
    public abstract class ValidatableObject : ObservableObject
    {
        protected override bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            ValidateProperty<T>(value, propertyName);

            return base.Set(ref field, value, propertyName);
        }

        private void ValidateProperty<T>(T value, [CallerMemberName] string name = null)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}

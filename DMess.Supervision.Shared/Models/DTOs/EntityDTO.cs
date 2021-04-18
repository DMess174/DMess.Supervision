namespace DMess.Supervision.Shared.Models.DTOs
{
    public class EntityDTO : ValidatableObject
    {
        private string _id;
        public string Id
        {
            get => _id;
            set => Set(ref _id, value);
        }
    }
}

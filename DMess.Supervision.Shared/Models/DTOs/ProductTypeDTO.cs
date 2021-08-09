using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class ProductTypeDTO : EntityDTO
    {
        private string _shortName;
        [Required(ErrorMessage = "Поле \"наименование\" не может быть пустым")]
        public string ShortName { get => _shortName; set => Set(ref _shortName, value); }

        private string _fullName;
        [Required(ErrorMessage = "Поле \"наименование\" не может быть пустым")]
        public string FullName { get => _fullName; set => Set(ref _fullName, value); }
    }
}
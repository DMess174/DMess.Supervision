using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class PIDDTO : EntityDTO
    {
        private string _number;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(64)]
        public string Number { get => _number; set => Set(ref _number, value); }

        private int _productQuantity;
        public int ProductQuantity { get => _productQuantity; set => Set(ref _productQuantity, value); }

        private string _consignee;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(4096)]
        public string Consignee { get => _consignee; set => Set(ref _consignee, value); }

        private DateTime _shipmentDate;
        [Required]
        public DateTime ShipmentDate { get => _shipmentDate; set => Set(ref _shipmentDate, value); }

        private string _status;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Status { get => _status; set => Set(ref _status, value); }

        private SpecificationDTO _specification;
        public SpecificationDTO Specification { get => _specification; set => Set(ref _specification, value); }

        private FactoryDTO _factory;
        public FactoryDTO Factory { get => _factory; set => Set(ref _factory, value); }

        private ProductTypeDTO _productType;
        public ProductTypeDTO ProductType { get => _productType; set => Set(ref _productType, value); }
    }
}
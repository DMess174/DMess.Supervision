namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Базовый металлический материал
    /// </summary>
    public interface IMetalMaterialEntity : IMaterialEntity
    { 
        MetalMaterialAssortment Assortment { get; set; }
        string Melt { get; set; }
    }

    /// <summary>
    /// Базовая деталь, комплектующее
    /// </summary>
    public interface IPartEntity: IMetalMaterialEntity
    {
        PartProductionType ProductionType { get; set; }
        IMetalMaterialEntity Material { get; set; }
    }

    /// <summary>
    /// Сущность с геометрическими параметрами
    /// </summary>
    public interface ISizebleEntity
    {

    }
}

namespace CosId.Segment;

public interface IIdSegmentDistributorFactory
{
    IIdSegmentDistributor Create(IdSegmentDistributorDefinition definition);
}
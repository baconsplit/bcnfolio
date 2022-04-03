namespace Bcnfolio.Database
{
    public interface ISummitTaskContextFactory
    {
        Task<SummitTaskContext> CreateSummitContextAsync();
    }
}

namespace Pibidex.Domain.Common
{
    public interface IBusinessRule
    {
        bool Condition { get; }
        void Enforce();
    }
}
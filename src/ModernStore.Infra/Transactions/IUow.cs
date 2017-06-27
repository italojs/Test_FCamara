namespace TestFCamara.Infra.Transactions
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}

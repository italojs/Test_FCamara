using FCamaraProject.Infra.Contexts;

namespace FCamaraProject.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly FCamaraDataContext _context;

        public Uow(FCamaraDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Do nothing :)
        }
    }
}

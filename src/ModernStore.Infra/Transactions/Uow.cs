using TestFCamara.Infra.Contexts;

namespace TestFCamara.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly DB_FCAMARADataContext _context;

        public Uow(DB_FCAMARADataContext context)
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

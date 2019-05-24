using System.Data.Entity;

namespace Ioc.Data
{
    public class XepHangTuDongDBInitializer : CreateDatabaseIfNotExists<IocDbContext>
    {
        protected override void Seed(IocDbContext context)
        {
            base.Seed(context);
        }
    }
}

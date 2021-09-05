using BlazorTestProject.Entities;
using BlazorTestProject.Repositories.Interfaces;

namespace BlazorTestProject.Repositories
{
    public class EntryRepository : GenericRepository<Entry>,IEntryRepository
    {
        public EntryRepository(BlazorContext context):base(context)
        {
        }
    }
}
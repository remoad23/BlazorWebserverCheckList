using BlazorTestProject.Entities;
using CheckListLibrary;

namespace BlazorTestProject.Repositories
{
    public class BlazorRepository<T> : GenericRepository<T,BlazorContext> where T : class
    {
        public BlazorRepository(BlazorContext context) : base(context)
        {
            
        }
    }
}
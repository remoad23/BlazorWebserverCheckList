using BlazorTestProject.Entities;
using BlazorTestProject.Repositories.Interfaces;

namespace BlazorTestProject.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly BlazorContext _context;
        
        public UnityOfWork(BlazorContext context)
        {
            _context = context;
            Entries = new EntryRepository(_context);
            CheckLists = new CheckListRepository(_context);
        }
        public IEntryRepository Entries { get; private set; }
        public ICheckListRepository CheckLists { get; private set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
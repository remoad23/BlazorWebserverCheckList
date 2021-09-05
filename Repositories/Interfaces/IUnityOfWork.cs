using System;

namespace BlazorTestProject.Repositories.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        ICheckListRepository CheckLists { get; }
        IEntryRepository Entries { get; }
        int Complete();
    }
}
using BlazorTestProject.Entities;
using BlazorTestProject.Repositories.Interfaces;

namespace BlazorTestProject.Repositories
{
    public class CheckListRepository : GenericRepository<CheckList>, ICheckListRepository
    {
        public CheckListRepository(BlazorContext context):base(context)
        {
        }
    }
}
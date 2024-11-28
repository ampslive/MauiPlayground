using CommunityToolkit.Mvvm.Input;
using MAUIPlayground.Models;

namespace MAUIPlayground.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
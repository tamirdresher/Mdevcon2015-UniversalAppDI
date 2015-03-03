namespace MdevconUniversal.Navigation
{
    public interface INavigationService
    {
        void Navigate<TPage>(object parameter);
        void Navigate<TPage>();
    }
}
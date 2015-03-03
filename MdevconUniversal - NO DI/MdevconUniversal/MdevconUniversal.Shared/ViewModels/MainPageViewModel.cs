using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MdevconUniversal.Common.Domain;
using MdevconUniversal.Common.Managers;
using MdevconUniversal.Navigation;
using MdevconUniversal.Views;

namespace MdevconUniversal.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly LectureManager _lectureManager;
        private readonly NavigationService _navigationService;
        private ObservableCollection<LectureDay> _lectures;


        public ObservableCollection<LectureDay> Lectures
        {
            get { return _lectures; }
            set
            {
                if (Equals(value, _lectures)) return;
                _lectures = value;
                OnPropertyChanged();
            }
        }

        public LectureManager LectureManager
        {
            get { return _lectureManager; }
        }

        public NavigationService NavigationService
        {
            get { return _navigationService; }
        }

    

        public MainPageViewModel()
        {
            _lectureManager = new LectureManager();
            _navigationService = new NavigationService(Window.Current.Content as Frame);
            Lectures = new ObservableCollection<LectureDay>();
        }



        public async void ViewLoaded()
        {
            var lectures = await LectureManager.GetAllLecturesAsync();

            var lectureDays = lectures.GroupBy(lect => lect.StartTime.DayOfWeek)
                .Select(day =>
                {
                    var lectDay = new LectureDay() { DayTitle = day.Key.ToString() };
                    lectDay.AddRange(day.OrderBy(lect=>lect.StartTime));
                    return lectDay;
                });
            Lectures = new ObservableCollection<LectureDay>(lectureDays);
        }

        public void OpenLecture(Lecture lecture)
        {
#if WINDOWS_APP
            NavigationService.Navigate<LectureInfoPage>(lecture);
#else
            _navigationService.Navigate<LecturePage>(lecture);
#endif
        }
    }

    public class LectureDay : List<Lecture>
    {
        public string DayTitle { get; set; }

    }
}

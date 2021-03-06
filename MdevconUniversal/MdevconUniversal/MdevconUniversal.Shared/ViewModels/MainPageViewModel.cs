﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.Storage.Pickers;
using MdevconUniversal.Common.Domain;
using MdevconUniversal.Common.Managers;
using MdevconUniversal.Navigation;
using MdevconUniversal.Views;

namespace MdevconUniversal.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ILectureManager _lectureManager;
        private readonly INavigationService _navigationService;
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

        public MainPageViewModel(ILectureManager lectureManager,
            INavigationService navigationService)
        {
            _lectureManager = lectureManager;
            _navigationService = navigationService;
            Lectures = new ObservableCollection<LectureDay>();
        }



        public async void ViewLoaded()
        {
            var lectures = await _lectureManager.GetAllLecturesAsync();

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
            _navigationService.Navigate<LectureInfoPage>(lecture);
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

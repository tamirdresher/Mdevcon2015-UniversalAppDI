using System;
using System.Collections.Generic;
using System.Text;
using MdevconUniversal.Common.Domain;

namespace MdevconUniversal.ViewModels
{
    public class LecturePageViewModel:ViewModelBase
    {
        private Lecture _lecture;

        public void ViewLoaded(object parameter)
        {
            Lecture = parameter as Lecture;

        }

        public string Name { get {return Lecture.Name; } }
        public string Description { get { return Lecture.Description; } }
        public TimeSpan StartTime { get {return Lecture.StartTime.TimeOfDay; } }
        public TimeSpan Duration { get {return Lecture.Duration; } }
        public Lecture Lecture
        {
            get { return _lecture; }
            set
            {
                _lecture = value;
                OnPropertyChanged();
            }
        }
    }
}

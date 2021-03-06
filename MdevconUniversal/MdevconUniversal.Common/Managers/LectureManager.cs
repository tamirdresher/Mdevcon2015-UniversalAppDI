﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage.Pickers;
using MdevconUniversal.Common.Contracts;
using MdevconUniversal.Common.Domain;
using MdevconUniversal.Common.MdevconService;
using Newtonsoft.Json;

namespace MdevconUniversal.Common.Managers
{
    public class LectureManager : ILectureManager
    {
        private readonly IMdevconService _mdevconService;

        public LectureManager(IMdevconService mdevconService)
        {
            _mdevconService = mdevconService;
        }

        public async Task<IEnumerable<Lecture>> GetAllLecturesAsync()
        {

            var confInfo = await _mdevconService.GetConferenceInfoAsync();
            return confInfo.tracks
                .Where(track => track.Value.sessions != null)
                .SelectMany(track => track.Value.sessions)
                .Select(session =>
                {
                    var l = new Lecture()
                    {
                        Name = session.talkTitle,
                        StartTime = DateTime.Parse(session.startDate),
                        Duration = TimeSpan.FromMinutes(session.duration),
                        Type = session.type,
                        Description = session.talkDescription,
                        Speakers = session.speakers.Select(speaker => new LectureSpeaker {Name = speaker.speakerName})
                    };
                    return l;
                }).ToList();
        }

    }
}

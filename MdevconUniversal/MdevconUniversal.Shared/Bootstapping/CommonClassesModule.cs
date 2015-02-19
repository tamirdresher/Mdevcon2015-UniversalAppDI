using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MdevconUniversal.Common.Managers;
using MdevconUniversal.Common.MdevconService;

namespace MdevconUniversal.Bootstapping
{
    class CommonClassesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<LectureManager>().As<ILectureManager>().SingleInstance();
            //builder.RegisterType<MdevconService>().As<IMdevconService>().SingleInstance();            
            builder.RegisterType<DummyMdevconService>().As<IMdevconService>().SingleInstance();
        }
    }
}

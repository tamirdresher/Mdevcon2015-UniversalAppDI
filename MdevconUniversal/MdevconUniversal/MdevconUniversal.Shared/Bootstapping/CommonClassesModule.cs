using Autofac;
using MdevconUniversal.Common.Contracts;
using MdevconUniversal.Common.Log;
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

using System.Collections.Generic;
using System.Threading.Tasks;
using MdevconUniversal.Common.Domain;

namespace MdevconUniversal.Common.Managers
{
    public interface ILectureManager
    {
        Task<IEnumerable<Lecture>> GetAllLecturesAsync();
    }
}
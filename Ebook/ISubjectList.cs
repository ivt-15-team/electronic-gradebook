using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook
{
    public interface ISubjectRepository : IDisposable
    {
        IEnumerable<Subject> GetSubject();
        Subject GetSubjectByID(int subjectId);
        void InsertSubject(Subject subject);
        void DeleteSubject(int subjectID);
        void UpdateSubject(Subject subject);
        void Save();
    }
}

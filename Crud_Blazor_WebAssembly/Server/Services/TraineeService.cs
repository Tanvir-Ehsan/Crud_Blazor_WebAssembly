using Crud_Blazor_WebAssembly.Server.Interfaces;
using Crud_Blazor_WebAssembly.Server.Models;
using Crud_Blazor_WebAssembly.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Blazor_WebAssembly.Server.Services
{
    public class TraineeService : ITrainee
    {
        readonly MyDbContext _db = new();
        public TraineeService(MyDbContext db)
        {
            _db = db;
        }
        public void AddTrainee(Trainee trainee)
        {
            _db.Trainees.Add(trainee);
            _db.SaveChanges();
        }

        public void DeleteTrainee(int id)
        {
            Trainee? trainee = _db.Trainees.Find(id);
            if (trainee != null)
            {
                _db.Trainees.Remove(trainee);
                _db.SaveChanges();
            }
        }

        public Trainee GetTrainee(int id)
        {
            Trainee? trainee = _db.Trainees.Find(id);
            if (trainee != null)
            {
                return trainee;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public List<Trainee> GetTraineeDetails()
        {
            return _db.Trainees.ToList();
        }

        public void UpdateTraineeDetails(Trainee trainee)
        {
            _db.Entry(trainee).State=EntityState .Modified;
            _db.SaveChanges();
        }
    }
}

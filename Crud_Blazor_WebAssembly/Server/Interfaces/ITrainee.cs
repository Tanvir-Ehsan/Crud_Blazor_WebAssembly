using Crud_Blazor_WebAssembly.Shared.Models;

namespace Crud_Blazor_WebAssembly.Server.Interfaces
{
    public interface ITrainee
    {
        public List<Trainee> GetTraineeDetails();
        public Trainee GetTrainee(int id);
        public void UpdateTraineeDetails(Trainee trainee);
        public void AddTrainee(Trainee trainee);
        public void DeleteTrainee(int id);
    }
}

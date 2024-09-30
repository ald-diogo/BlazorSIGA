using BlazorSIGA.Server.Entidades;

namespace BlazorSIGA.Server.Services
{
    public class ProfessorService
    {
        private List<Professor> professores = new List<Professor>();

        public List<Professor> GetProfessores() => professores;

        public void AddProfessor(Professor professor)
        {
            professor.Id = professores.Count > 0 ? professores.Max(p => p.Id) + 1 : 1;
            professores.Add(professor);
        }

        public void UpdateProfessor(Professor professor)
        {
            var existingProfessor = professores.FirstOrDefault(p => p.Id == professor.Id);
            if (existingProfessor != null)
            {
                existingProfessor.Nome = professor.Nome;
                existingProfessor.Email = professor.Email;
                existingProfessor.DataContratacao = professor.DataContratacao;
            }
        }

        public void DeleteProfessor(int id)
        {
            var professor = professores.FirstOrDefault(p => p.Id == id);
            if (professor != null)
            {
                professores.Remove(professor);
            }
        }
    }

}

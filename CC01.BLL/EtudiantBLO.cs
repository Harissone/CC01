using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }

        public void CreateEtudiant(Etudiants etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteEtudiant(Etudiants etudiant)
        {
            productRepo.Remove(etudiant);
        }

        public IEnumerable<Etudiants> GetAllProducts()
        {
            return etudiantRepo.Find();
        }

        public IEnumerable<Etudiants> GetByIdentifiant(string identifiant)
        {
            return etudiantRepo.Find(x => x.Identifiant == identifiant);
        }

        public void EditProduct(Etudiants oldEtudiants, Etudiants newEtudiants)
        {
            etudiantRepo.Set(oldEtudiants, newEtudiants);
        }
    }
}

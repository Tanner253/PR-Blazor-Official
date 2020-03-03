using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrehistoricRealism.Data.Interfaces
{
    interface IDinoManager
    {
        Task CreateDinosaur(DinosaurInfo dinosaur);

        Task UpdateDinosaur(int id, DinosaurInfo dinosaur);

        Task<DinosaurInfo> DeleteDinosaur(int id);

        Task DeleteDinosaurFR(int id);


        Task<DinosaurInfo> GetDinosaur(int id);

        Task<List<DinosaurInfo>> GetDinosaurs();

   

        bool DinosaurExists(int id);
    }
}

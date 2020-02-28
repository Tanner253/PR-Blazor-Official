using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrehistoricRealism.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrehistoricRealism.Data.Services
{
    public class DinoServices : IDinoManager
    {
        private ApplicationDbContext _db;

        public DinoServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task CreateDinosaur(DinosaurInfo dinosaur)
        {
            try
            {
                _db.Add(dinosaur);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public async Task<DinosaurInfo> DeleteDinosaur(int id)
        {
            if (!DinosaurExists(id))
            {
                return null;
            }

            try
            {
                DinosaurInfo dino = await _db.Dinosaurs.FirstOrDefaultAsync(m => m.ID == id);
                return dino;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }



        }

        public async Task DeleteDinosaurFR(int id)
        {
            try
            {
                var dino = await _db.Dinosaurs.FirstOrDefaultAsync(m => m.ID == id);
                _db.Dinosaurs.Remove(dino);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }


        public async Task<DinosaurInfo> GetDinosaur(int id)
        {
            try
            {
                var dino = await _db.Dinosaurs.FirstOrDefaultAsync(m => m.ID == id);
                return dino;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<IEnumerable<DinosaurInfo>> GetDinosaurs()
        {
            try
            {
                var dinosaurs = await _db.Dinosaurs.ToListAsync();
                return dinosaurs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;            }
        }

        public async Task UpdateDinosaur(int id, [Bind("Name,Diet,NeedToKnow,Behavior,SocialInteraction,PackLimits,Image,AdditionalInfo")] DinosaurInfo dinosaur)
        {
            _db.Update(dinosaur);
            await _db.SaveChangesAsync();
        }
        public bool DinosaurExists(int id)
        {
            try
            {
            return _db.Dinosaurs.Any(m => m.ID == id);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<IEnumerable<DinosaurInfo>> GetCarnis()
        {
            var carnis = await _db.Dinosaurs.ToListAsync();
                var query = carnis.Where(n => n.Diet == DinosaurInfo.Food.Carnivore).OrderBy(n => n.Name);
                return query;
         
        }
    }
}

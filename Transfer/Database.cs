using System;
using System.Collections.Generic;
using System.Linq;

namespace Transfer
{
    internal class Database
    {
        private List<Fighter> _fighters1 = new List<Fighter>();
        private List<Fighter> _fighters2 = new List<Fighter>();

        public Database()
        {
            AddFighters();
        }

        public void TransferFighters()
        {
            string simbol = "б";

            var sortList = _fighters1.Where(fighter => fighter.Name.StartsWith(simbol,StringComparison.OrdinalIgnoreCase)).ToList();

            _fighters1 = _fighters1.Except(sortList).ToList();

            _fighters2 = _fighters2.Union(sortList).ToList();
        }

       
        public void ShowAllFighters()
        {
            ShowFighters(_fighters1);

            ShowFighters(_fighters2);
        }

        private void ShowFighters(List<Fighter> fighters)
        {
            foreach (Fighter fighter in fighters)
            {
                Console.WriteLine(fighter.Name);
            }

            Console.WriteLine();
        }

        private void AddFighters()
        {
            _fighters1.Add(new Fighter("Багулин"));
            _fighters1.Add(new Fighter("Бабуинов"));
            _fighters1.Add(new Fighter("Брызгин"));
            _fighters1.Add(new Fighter("Клопов"));
            _fighters1.Add(new Fighter("Калинин"));

            _fighters2.Add(new Fighter("Рагулин"));
            _fighters2.Add(new Fighter("Мешков"));
            _fighters2.Add(new Fighter("Попов"));
            _fighters2.Add(new Fighter("Слонов"));
            _fighters2.Add(new Fighter("Артемонов"));
        }
    }
}
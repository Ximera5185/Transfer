using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
    internal class Database
    {
        private List<Fighter> _fighters1 = new List<Fighter>();
        private List<Fighter> _fighters2 = new List<Fighter>();

        public Database() { }

        public void ShowFighters(int numberSquad) 
        {
            if (numberSquad == 1) 
            {
                foreach (Fighter fighter in _fighters1)
                {
                    Console.WriteLine(fighter.Name);
                }
            }
            else if(numberSquad == 2)
            {
                foreach (Fighter fighter in _fighters2)
                {
                    Console.WriteLine(fighter.Name);
                }
            }
            else
            {
                Console.WriteLine("Такого отряда нет");
            }
        }

        public void TransferFighters() 
        {
            
        }

        private void AddFighters() 
        {
            _fighters1.Add(new Fighter("Рагулин"));
            _fighters1.Add(new Fighter("Мешков"));
            _fighters1.Add(new Fighter("Попов"));
            _fighters1.Add(new Fighter("Слонов"));
            _fighters1.Add(new Fighter("Артемонов"));

            _fighters2.Add(new Fighter("Багулин"));
            _fighters2.Add(new Fighter("Бабуинов"));
            _fighters2.Add(new Fighter("Брызгин"));
            _fighters2.Add(new Fighter("Клопов"));
            _fighters2.Add(new Fighter("Калинин"));
        }
    }
}

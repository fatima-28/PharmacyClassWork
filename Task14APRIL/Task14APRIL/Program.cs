using System;
using System.Collections.Generic;

namespace Task14APRIL
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine derman1 = new Medicine("Nurofen",150,6,false);
            Medicine derman2 = new Medicine("Noshba", 250, 2, false);
            Medicine derman3 = new Medicine("SP2", 5, 10, false);
            Medicine derman4 = new Medicine("ND6", 50, 7, false);

            Pharmacy Aptek1 = new Pharmacy(30);
            


            
           
            
           
            Aptek1.AddMedicine(derman4);
            Aptek1.AddMedicine(derman1);
            Aptek1.AddMedicine(derman2);
            Aptek1.AddMedicine(derman3);



            //Aptek1.GetAllMedicines();
            //Aptek1.FilterMedicinesByPrice(1,8);
            //Aptek1.EditMedicineEmail(1, "Nurofen");
            Aptek1.DeleteMedicineById(1);


        }
    }
}

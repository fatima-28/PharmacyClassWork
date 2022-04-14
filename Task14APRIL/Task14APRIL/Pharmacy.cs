using System;
using System.Collections.Generic;
using System.Text;

namespace Task14APRIL
{
    class Pharmacy
    {


        public int MedicineLimit { get; set; }
        public static List<Medicine> Medicines;
        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
            Medicines = new List<Medicine>();
        }
        public void AddMedicine(Medicine derman)
        {
            if (MedicineLimit < derman.Count)
            {
                throw new CapacityLimitException("Medicine over flow");
            }

            foreach (var item in Medicines)
            {
               

                if (item.Name==derman.Name)
                {
                    throw new MedicineAlreadyExistsException("This medicine already exist!");
                }
               
            }
            Medicines.Add(derman);

        }
        public void GetAllMedicines() 
        {
            List<Medicine> CopyMedicines = new List<Medicine>();
            CopyMedicines = Medicines;
            foreach (var item in CopyMedicines)
            {
                item.IsDeleted = false;
            }
        }

        public void FilterMedicinesByPrice(double minPrice,double maxPrice)
        {
            foreach (var item in Medicines)
            {
                if (item.Price<maxPrice&&item.Price>minPrice)
                {
                    Console.WriteLine($"Name: {item.Name}, Price: { item.Price}, Id: {item.Id}");
                }
            }
        }
        public void GetMedicineById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("This id is not exist!");
            }
            else
            {
                foreach (var item in Medicines)
                {
                    if (id==item.Id && item.IsDeleted==false)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This id is not exist!");
            }
            else
            {
                foreach (var item in Medicines)
                {
                    if (id == item.Id && item.IsDeleted == false)
                    {
                        item.IsDeleted = true;
                    }
                    else
                    {
                        throw new NotFoundException("We cant find this object in our list");
                    }
                }
            }
        }
        public void EditMedicineEmail(int? id,string name)
        {
            if (id == null || name == null)
            {
                throw new NullReferenceException("Name or id is null");
            }
            else
            {
                foreach (var item in Medicines)
                {
                    if (item.Id==id&&item.IsDeleted==false)
                    {
                        name=item.Name;
                    }
                    else
                    {
                        throw new NotFoundException("We cant found this object in our list");
                    }
 
                }
               
            }
        
        }
    }
}

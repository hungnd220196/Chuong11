using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class PatientList
    {
        public ArrayList objPatientList = new ArrayList();
        public void AcceptDetails()
        {
            char choice = 'Y';
            try
            {
                do
                {
                    Console.WriteLine("nhap ten benh nhan");
                    objPatientList.Add(Console.ReadLine());
                    Console.WriteLine("ban co muon them benh nhan nua khong?[y/n]");
                    choice = char.Parse(Console.ReadLine());

                } while (choice=='Y' || choice =='y');

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\ndanh sach benh nhan");
            for (int i = 0; i < objPatientList.Count; i++)
            {
                Console.WriteLine(objPatientList[i]);
            }
            // tong so benh nhan
            Console.WriteLine($"tong so benh nhan : {objPatientList.Count}");

        }
        public bool Remove()
        {
            string choice;
            Console.WriteLine("moi ban nhap ten bn");
            choice = Console.ReadLine();
            //dung contains kt ton tai
           
            if (objPatientList.Contains(choice))
            {
               objPatientList.Remove(choice);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objPatientList.Contains(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine(objPatientList[objPatientList.IndexOf(choice)]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}

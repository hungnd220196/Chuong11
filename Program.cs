
using System.Collections;

namespace Chuong11
{
    internal class Program
    {
        public static void DisplayArrayList(string arrayListName, ArrayList myArrayList)
        {
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(arrayListName + "[" + i + "] = " + myArrayList[i]);
            }
        }
        static void Main(string[] args)
        {
            //vd1
            ArrayList al = new ArrayList();
            Console.WriteLine("add 6 elements");
            // them cac phan tu vao array list
            al.Add("C");
            al.Add("A");
            al.Add("B");
            al.Add("D");
            al.Add("E");
            al.Add("F");
            Console.WriteLine("REMOVE 2 ELEMENTS");
            al.Remove("A");
            al.Remove("B");
            Console.WriteLine("Number of elements: " + al.Count);

            // tao arraylist 
            ArrayList arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add(129);
            arrayList.Add(124);
            arrayList.Add(126);
            arrayList.Add(128);
            Console.WriteLine("original contents:");
            foreach (int item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arrayList.Sort();

            Console.WriteLine("Contents after sorting");

            foreach (int item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"index of 129 is: {arrayList.BinarySearch(129)}");

            // demo product
            ArrayList al2 = new ArrayList();
            al2.Add(new Product("A", 24000, 3));
            al2.Add(new Product("b", 29000, 9));
            al2.Add(new Product("c", 49000, 4));
            al2.Add(new Product("d", 99000, 2));
            Console.WriteLine("product list");
            foreach (Product item in al2)
            {
                Console.WriteLine(" " + item);
            }

            //demo Employee
            ArrayList empList = new ArrayList();
            Employee myH = new Employee("H", 1996);
            Employee myU = new Employee("U", 1999);
            Employee myN = new Employee("N", 2007);
            Employee myG = new Employee("G", 2003);
            empList.Add(myH);
            empList.Add(myU);
            empList.Add(myN);
            empList.Add(myG);
            // mang truoc khi sap xep
            DisplayArrayList("bfEmpList", empList);
            empList.Sort();
            //mang sau khi sap xep
            DisplayArrayList("afEmpList", empList);

            //demo hashtable

            Hashtable ht = new Hashtable();
            ht.Add("a", "A");
            ht.Add("b", "B");
            ht.Add("c", "C");
            ht.Add("d", "D");

            // lay tap keys trong Hashtable
            ICollection c = ht.Keys;
            foreach (string str in c) 
            {
                Console.WriteLine(str +": "+ ht[str] );
            }

            // demo sorted list
            SortedList sl = new SortedList();
            sl.Add("a", "A");
            sl.Add("b", "B");
            sl.Add("c", "C");
            sl.Add("d", "D");
            //lay cac key trong collection
            ICollection d = sl.Keys;
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine(sl.GetByIndex(i));
            }


            //demo hospital

            //try
            //{
            //    // Tao 1 doi tuong cua lop PatientList
            //    PatientList objPatientList = new PatientList();
            //    // Goi phuong thuc AcceptDetails cua lop PatientList de nhap ten benh nhan
            //    objPatientList.AcceptDetails();
            //    //goi phuong thuc DisplayDetails cua lop PatientList de hien thi ten benh nhan
            //    objPatientList.DisplayDetails();
            //    char input = 'Y';
            //    do
            //    {
            //        int choice;
            //        Console.WriteLine("\nSelect one of the following options:");
            //        Console.WriteLine(" 1. Sort\n 2. Remove\n 3. Reverse\n 4. Search\n 5. Exit");
            //        Console.Write("Enter your choice : ");
            //        choice = Convert.ToInt32(Console.ReadLine());
            //        switch (choice)
            //        {
            //            case 1:
            //                // Sap tep benh nhan theo thu tu tang dan bang cach su dung phuong thuc Sort
            //                objPatientList.objPatientList.Sort();
            //                Console.Write("\n-----After Sorting-----");
            //                objPatientList.DisplayDetails();
            //                break;
            //            case 2:
            //                // Xoa ten benh nhan
            //                if (objPatientList.Remove())
            //                {
            //                    Console.Write("\n-----After Removing-----");
            //                    objPatientList.DisplayDetails();
            //                }
            //                else

            //                    Console.WriteLine("Patient with this name does not exist");
            //                break;
            //            case 3:
            //                // Dao nguoi danh sach ten ben nhan bang phuong thuc Reverse
            //                objPatientList.objPatientList.Reverse();
            //                Console.Write("\n-----After Reversing-----");
            //                objPatientList.DisplayDetails();
            //                break;
            //            case 4:
            //                // Tim kiem ten benh nhan
            //                objPatientList.Search();
            //                break;
            //            case 5:
            //                return;
            //            default:
            //                Console.WriteLine("Invalid Data Entry!");
            //                break;
            //        }
            //    } while (input == 'Y' || input == 'y');

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Error: {0}", e.Message);
            //}

            //bt

            Bank bank = new Bank();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Save to file");
                Console.WriteLine("5. Display");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Account Number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter Account Name: ");
                        string accountName = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        double initialBalance = double.Parse(Console.ReadLine());
                        bank.CreateAccount(accountNumber, accountName, initialBalance);
                        break;

                    case 2:
                        Console.Write("Enter Account Number: ");
                        accountNumber = Console.ReadLine();
                        Console.Write("Enter Amount to Withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        bank.Withdraw(accountNumber, withdrawAmount);
                        break;

                    case 3:
                        Console.Write("Enter Account Number: ");
                        accountNumber = Console.ReadLine();
                        Console.Write("Enter Amount to Deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        bank.Deposit(accountNumber, depositAmount);
                        break;

                    case 4:

                        break;

                    case 5:
                        bank.Display();
                        break;

                    case 6:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}


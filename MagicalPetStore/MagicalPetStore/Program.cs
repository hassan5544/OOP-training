using MagicalPetStore;
using System.Security.Cryptography;

class Program
{
    static List<Students> students = new List<Students>();
    static List<Pets> pets = new List<Pets>();

    static void Main()
    {
        Console.WriteLine("Magical Pet Store");
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Pet");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Exercise Pet");
            Console.WriteLine("4. Feed Pet");
            Console.Write("Select an option: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddPet();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        ExercisePet();
                        break;
                    case 4:
                        FeedPet();
                        break;
                    case 5:
                        DisplayPets();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }

    }
    public static void AddPet()
    {
        Console.Write("\nEnter Pet Name: ");
        string PetName = Console.ReadLine();
        if (PetName == null)
            return;
        Pets NewPet = new Pets(PetName);
        pets.Add(NewPet);
        Console.WriteLine($"Pet '{PetName}' added successfully.");
    }

    public static void AddStudent()
    {
        Console.Write("\nEnter Student Name: ");
        string StudentName = Console.ReadLine();
        if(StudentName == null)
        {
            return;
        }
        Students NewStudent = new Students(StudentName);
        students.Add(NewStudent);
        Console.WriteLine($"Student '{StudentName}' added successfully.");
    }

    public static Pets? SelectePet()
    {
        Pets selectedPet;

        Console.WriteLine("\nSelect a Pet :");
        for (int i = 0; i < pets.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pets[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= students.Count)
        {
            selectedPet = pets[choice - 1];
            return selectedPet;
        }

        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return null;
        }
    }

    public static Students? SelectStudent()
    {
        Students selectedStudent;

        Console.WriteLine("\nSelect a Student :");
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {students[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= students.Count)
        {
            selectedStudent = students[choice - 1];
            return selectedStudent;
        }

        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return null;
        }
    }

    public static void ExercisePet()
    {
        Students? selectedStudent;
        Pets? selectedPet;
        selectedStudent = SelectStudent();
        if (selectedStudent == null)
        {
            return;
        }

        selectedPet = SelectePet();
        if (selectedPet == null)
        {
            return;
        }
        selectedStudent.ExercisePet(selectedPet);
    }

    public static void FeedPet()
    {
        Students? selectedStudent;
        Pets? selectedPet;
        selectedStudent = SelectStudent();
        if(selectedStudent == null)
        {
            return;
        }

        selectedPet = SelectePet();
        if(selectedPet == null)
        {
            return;
        }
        selectedStudent.FeedPet(selectedPet);
    }


    public static void DisplayPets()
    {
        for (int i = 0; i < pets.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pets[i].Name}. {pets[i].IsHungry}");
        }
    }
}

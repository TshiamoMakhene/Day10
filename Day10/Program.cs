namespace Day10
{
    internal class Program
    {
        static void Main(string[] args) { 
      
     
                //list of strings and the names that have already been defined.
                List<string> names = new List<string> { "Name", "Anna", "Felipe" };

                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}");
                }

                names.Add("Jimmy");
                names.Add("Jobe");
                names.Remove("Name");

                foreach (var name in names)
                {//display the names and also converts all names to upper case.
                    Console.WriteLine($"\n Hello {name.ToUpper()}");
                }

                //counts how many names are in the list
                Console.WriteLine($"The list has {names.Count} name stored in it");
                //shows the index in postion of Felipe
                var index = names.IndexOf("Jobe");
                // if statement to allow the
                if (index == -1)
                {
                    Console.WriteLine($"Whe the index is not found, indexof returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name Jobe is in index: {names[index]} in at index {index}");
                }
                // when the name is not found
                index = names.IndexOf("Not Found");

                if (index == -1)
                {
                    Console.WriteLine($"Whe the index is not fount, indexof returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name Jobe is in index: {names[index]} in at index {index}");
                }

                //sorts the names of the list entered.
                names.Sort();
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}");
                }
                

                            Console.WriteLine();

                            //List Examples
                            List<int> primeNumbers = new List<int>();

                            //Basically the same as arrays but using <> instead
                            //Adding elements using add() method to add values.
                            primeNumbers.Add(1);
                            primeNumbers.Add(3);
                            primeNumbers.Add(5);
                            primeNumbers.Add(7);

                            List<int> primeNumbers2 = new List<int>() { 11,13,15,11};
                //Using strings in list and having the values
                            List<string> cities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };
                //



                            List<string> students = new List<string>() { "James", "Tammy", "James", "Mason" };

                            students.Insert(1, "Tom"); //inserts "Tom" at 1st index: after Tammy.

                            foreach (var name in students)

                                Console.WriteLine(name + " ");
                //removes the first "James" from a list
                            students.Remove("James");
                //removes the 3rd element (index starts from 0)
                            students.RemoveAt(3);
                //Makes space for the names
                            Console.WriteLine();
                // num is created as a ("NickName").
                            students.ForEach(num => Console.WriteLine(num + ", "));

                            Console.WriteLine();
                // Searches for the name thats in the list created
                            bool val = students.Contains("Tom");
                //Displays the value that contains the name searched
                            Console.WriteLine($"Contains Tom: {val}");

                            Dictionary<int,string> Learner =new Dictionary<int, string>();

                            Learner.Add(20225, "Jimmy");
                            Learner.Add(20325, "Minny");
                            Learner.Add(20425, "Limmy");
                            Learner.Add(20525, "KipKat");

                            foreach(KeyValuePair<int,string> learn in Learner)
                                Console.WriteLine($"Studnet Number:{learn.Key}\t\t Name: {Learner}");

                            var capitals = new Dictionary<string, string>()
                            {
                                {"UK","London"},
                                {"USA","Washington"},
                                {"India","Mumbai"},
                                {"SA","Pretoria"},
                            };
                //use a different varible for 'KVP'
                            foreach (var kvp in capitals)
                                Console.WriteLine("Country:{0}\t Capital:{1}", kvp.Key,kvp.Value);
                //Prints number of elements
                            Console.WriteLine($"We have {capitals.Count} countries in collection ");
                            //Prints value of UK key
                            Console.WriteLine(capitals["UK"]);
                            //Prints value of USA key
                            Console.WriteLine(capitals["USA"]);

                    

                Console.ReadKey();

            }
        }
    }
}

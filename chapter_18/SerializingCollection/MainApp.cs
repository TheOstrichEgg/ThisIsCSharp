using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializingCollection
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }

        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            using (Stream ws = new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                List<NameCard> list = new List<NameCard>();
                list.Add(new NameCard("Micahel Jackson", "010-0000-0000", 40));
                list.Add(new NameCard("Bob Marley", "010-1111-1111", 40));
                list.Add(new NameCard("Lady Gaga", "010-2222-2222", 40));

                serializer.Serialize(ws, list);
            }

            using Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List<NameCard>)deserializer.Deserialize(rs);

            foreach(NameCard nc in list2)
            {
                Console.WriteLine(
                    $"Name: {nc.Name}, Phone: {nc.Phone}, Age: {nc.Age}");
            }
        }
    }
}

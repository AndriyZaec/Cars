using System.Collections.Generic;
using System.IO;

namespace Cars
{
    class FileWorking : ICRUD
    {
        public static string path = "Cars.dat";
        private List<Car> _cars = new List<Car>();

        public void Create()
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists == false)
            {
                file.Create();
            }
        }

        public List<Car> Read()
        {
            MainForm mainForm = new MainForm();

            using (StreamReader reader = new StreamReader(path))
            {
                while (true)
                {
                    string temp = reader.ReadLine();

                    if (temp == null) break;

                    string[] split = temp.Split(new char[] { '|' });

                    _cars.Add(new Car() { Model = split[0], Color = split[1], Price = decimal.Parse(split[2]), Power = int.Parse(split[3]) });
                }
            }
            return _cars;
        }

        public void Update(List<Car> list)
        {
            StreamWriter writer = new StreamWriter(path, false);

            foreach(var el in list)
            {
                string temp = el.Model + "|" + el.Color + "|" + el.Price + "|" + el.Power;

                writer.WriteLine(temp);
            }

            writer.Close();
        }

        public void Adding(string temp)
        {
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(temp);

            writer.Close();
        }
    }
}

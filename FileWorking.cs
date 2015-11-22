

using System;
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

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Car> Read()
        {
            MainForm mainForm = new MainForm();
            StreamReader reader = new StreamReader(path);
                while (true)
                {
                    string temp = reader.ReadLine();

                    if (temp == null) break;

                    string[] split = temp.Split(new char[] { '|' });

                    _cars.Add(new Car() { Model = split[0], Color = split[1], Price = decimal.Parse(split[2]), Power = int.Parse(split[3])});
            }
            reader.Close();
            return _cars;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

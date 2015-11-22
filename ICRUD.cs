using System.Collections.Generic;

namespace Cars
{
   public interface ICRUD
    {
        void Create();
        List<Car> Read();
        void Update();
        void Delete();
    }
}

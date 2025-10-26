using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DragRaceManager : IRaceService
    {
        public void Add()
        {
            Console.WriteLine("Drag Yarışı eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Drag Yarışı silindi");
        }

        public void Update()
        {
            Console.WriteLine("Drag Yarışı güncellendi");
        }
    }
}
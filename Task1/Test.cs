using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Test
    {
        private Random rand;

        public Dictionary<int, int>[] mapArray;

        int id;

        int value; 

        public Test()
        {
            mapArray = new Dictionary<int, int>[10];
            rand = new Random();
        }

        public Dictionary<int, int>[] NewMapArray()
        {
              
            for(int i = 0; i < mapArray.Length; i++)   
            {
                value = rand.Next(1,10);
                mapArray[i] = new Dictionary<int, int>() { { id, value } };

                while (mapArray[i].ContainsKey(id))    
                {
                        id++;
                } 
            }
                
            if(mapArray != null)
            {
                return mapArray;
            }
            else Console.WriteLine("Struct is empty.");

            return null;
            
        }

        public Dictionary<int, int> GetMapById(Dictionary<int, int>[] mapArr, int id)
        {
            var newMap = mapArr[id];
            return newMap;
        }
    }
}

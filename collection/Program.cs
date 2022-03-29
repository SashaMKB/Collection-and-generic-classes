using System;
using System.Collections.Generic;

namespace Second_Task_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entity> list = new List<Entity>();
            list.Add(new Entity(1, 0, "Root entity"));
            list.Add(new Entity(2, 1, "Child of 1 entity"));
            list.Add(new Entity(3, 1, "Child of 1 entity"));
            list.Add(new Entity(4, 2, "Child of 2 entity"));
            list.Add(new Entity(5, 4, "Child of 4 entity"));

            Dictionary<int, List<Entity>> dict = Entity.SomeMethod(list);
        }

        public class Entity
        {
            public int Id, ParentId;
            public string Name;
            public Entity(int id, int parentId, string name) { Id = id; ParentId = parentId; Name = name; }
            public static Dictionary<int, List<Entity>> SomeMethod(List<Entity> list)
            {
                Dictionary<int, List<Entity>> dict = new Dictionary<int, List<Entity>>();
                foreach (var element in list)
                {
                    if (!dict.TryAdd(element.ParentId, new List<Entity>() { element }))
                    {
                        dict[element.ParentId].Add(element);
                    }
                }

                return dict;
            }
        }
    }
}

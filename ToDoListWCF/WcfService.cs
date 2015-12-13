using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDoList;
using ToDoListService;

namespace ToDoListWcf
{
    public class WcfService : IWcfService
    {
        public List<ToDo> GetToDoList()
        {
            var toDoList = Service.GetToDoList();
            return toDoList;
        }

        public List<ToDo> GetToDoListByName(string name)
        {
            var toDoList = Service.GetToDoListByName(name);
            return toDoList;
        }

        public List<ToDo> GetToDoListById(string name, string id)
        {
            var toDoList = Service.GetToDoListById(name, id);
            return toDoList;
        }
    }
}

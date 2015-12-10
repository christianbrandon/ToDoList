using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ToDoList;


namespace ToDoListWCF
{
    [ServiceContract]
    public interface IToDoListWCF
    {
        [OperationContract]
        [WebGet(UriTemplate = "ToDoList",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ToDo> GetToDoList();

        [OperationContract]
        [WebGet(UriTemplate = "ToDoList/id/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ToDo> GetToDoListById(string id);

        [OperationContract]
        [WebGet(UriTemplate = "ToDoList/name/{name}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ToDo> GetToDoListByName(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "Add",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST")]
        bool AddToDoList(ToDo toDoList);

        [OperationContract]
        [WebInvoke(UriTemplate = "ToDolist/{id}/remove/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "DELETE")]
        bool RemoveToDoList(string id);
    }
}

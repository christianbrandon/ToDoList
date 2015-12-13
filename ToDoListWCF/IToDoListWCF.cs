using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ToDoList;


namespace WcfService
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
        [WebGet(UriTemplate = "ToDoList/{name}/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ToDo> GetToDoListById(string name, string id);

        [OperationContract]
        [WebGet(UriTemplate = "ToDoList/{name}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ToDo> GetToDoListByName(string name);
        
    }
}

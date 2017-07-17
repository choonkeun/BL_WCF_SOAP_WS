using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BL_WCF_SOAP_WS
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IService1
    {
        [OperationContract]
        List<ToDoItem> GetToDos();

        [OperationContract]
        void AddOrUpdateToDo(ToDoItem toDoItem);

        [OperationContract]
        void DeleteToDo(ToDoItem toDoItem);
    }

    [DataContract]
    public class ToDoItem
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
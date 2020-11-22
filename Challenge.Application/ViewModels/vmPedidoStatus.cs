using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Challenge.Application.ViewModels
{
    [Serializable]
    [DataContract]
    public class vmPedidoStatus
    {
        public vmPedidoStatus()
        {            
            status = new List<vmStatus>();
        }
        [DataMember]
        public string pedido { get; set; }     
     

        [DataMember]
        public List<vmStatus> status { get; set; }

    }
}

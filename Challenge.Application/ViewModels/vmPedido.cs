using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Challenge.Application.ViewModels
{
    [Serializable]
    [DataContract]
    public class vmPedido
    {
        public vmPedido()
        {
            itens = new List<vmItem>();       
        }
        [DataMember]
        public string pedido { get; set; }
       
        [DataMember]
        public List<vmItem> itens { get; set; }

       

    }
}

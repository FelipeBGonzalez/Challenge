using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Challenge.Application.ViewModels
{
    [Serializable]
    [DataContract]
    public class vmFiltroPedido
    {
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public int itensAprovados { get; set; }
        [DataMember]
        public decimal valorAprovado { get; set; }
        [DataMember]
        public string pedido { get; set; }
    }
}

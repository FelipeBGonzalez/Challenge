using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Challenge.Application.ViewModels
{
    [Serializable]
    [DataContract]
    public class vmItem
    { 
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public decimal precoUnitario { get; set; }
        [DataMember]
        public int qtd { get; set; }
    }
}

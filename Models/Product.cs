using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS23_First_MVC.Models
{
    public class Product
    {
        public int Id {get;set;}
        public string? descricao {get;set;}
        public bool IsActive {get;set;}
        public string? ImageURL {get;set;}
        public double Valor {get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Produit
    {
        public int Id { get; set; }
        public int Référence {  get; set; }

        public bool EstDispo {  get; set; }

        public string Désignation {  get; set; }
        public double PrixHT {  get; set; }
        public string Catégorie { get; set; }

    }
}

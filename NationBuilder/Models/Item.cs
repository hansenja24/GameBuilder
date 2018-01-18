using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilder.Models
{
    [Table("Items")]
    public class Item
    {
        public Item(int thisId, string thisName, string thisType, string thisEconomy, string thisGeography)
        {
            Id = thisId;
            Name = thisName;
            Type = thisType;
            Economy = thisEconomy;
            Geography = thisGeography;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Economy { get; set; }
        public string Geography { get; set; }
        public int Capital { get; set; }
        public int Population { get; set; }
        public int Stability { get; set; }
        public int Iron { get; set; }
        public int Oil { get; set; }
        public int Food { get; set; }
        public int Wood { get; set; }
        public int Wool { get; set; }
        public virtual ApplicationUser User { get; set; }

        public void GetBeginValue()
        {
            if(Type == "Democracy")
            {
                
            }
            else if(Type == "Monarchy")
            {
                
            }
            else if (Type == "Republic")
            {
                
            }

            if(Economy == "Capitalism")
            {
                
            }
            else if(Economy == "Socialism")
            {
                
            }
            else if (Economy == "Futurism")
            {
                
            }

            if(Geography == "Coastal")
            {
                
            }
            else if(Geography == "Mountains")
            {
                
            }
            else if(Geography == "Plains")
            {
                
            }
            else if(Geography == "Forests")
            {
                
            }
        }
    }
}
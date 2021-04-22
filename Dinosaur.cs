using System;

namespace JurasicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public DateTime DateAcquired { get; set; } = DateTime.Now;

        public string Description()
        {
            var newDescription = $"The {Name} is a {DietType}, which weighs {Weight} lbs, is in enclosure number {EnclosureNumber}, and was acquired on {DateAcquired}";
            return newDescription;
        }

    }
}

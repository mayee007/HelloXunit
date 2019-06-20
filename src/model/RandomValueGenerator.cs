using System; 
namespace src.model
{
    class RandonValueGenerator
    {
        public int min { get; set; } 
        public int max { get; set; } 
        public RandonValueGenerator(int min, int max)
        {
            this.min = min; 
            this.max = max; 
        }

        public int getRandonValue()
        {
            Random rand = new Random(); 
            return rand.Next(min,max); 
        }
    }
}
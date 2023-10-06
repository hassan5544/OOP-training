using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MagicalPetStore
{
    public class Pets : BaseEntity
    {
        public bool IsHungry { get; set; } = true;
        public bool MagicalPowerActivated { get; set; } = false;
        public bool Exercise { get; set; } = false;

        public Pets(string PetName)
        {
            Name = PetName;
        }
        public void FeedingPet()
        {
            IsHungry = false;
        }

        public void ActivateMagicalPower()
        {
            MagicalPowerActivated = true;
        }

        public void ExercisePet()
        {
            Exercise = true;
        }
    }
}

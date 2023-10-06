using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicalPetStore;

namespace MagicalPetStore
{
    public class Students : BaseEntity
    {

        public Students(string StudentName)
        {
            Name = StudentName;
        }
        public void ExercisePet(Pets SelectedPet)
        {
            SelectedPet.ExercisePet();

        }

        public void ActivateMagicalAbility(Pets SelectedPet)
        {
            SelectedPet.ActivateMagicalPower();
        }

        public void FeedPet(Pets SelectedPet)
        {
            SelectedPet.FeedingPet();

        }
    }
}

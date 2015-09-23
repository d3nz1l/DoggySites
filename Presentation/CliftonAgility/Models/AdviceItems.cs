// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdviceItems.cs" company="">
//   
// </copyright>
// <summary>
//   The advice items.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The advice items.
    /// </summary>
    public class AdviceItems : IEnumerable<AdviceItem>
    {
        /// <summary>
        /// The internal collection.
        /// </summary>
        private List<AdviceItem> internalCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdviceItems"/> class.
        /// </summary>
        public AdviceItems()
        {
            this.CreateItems();
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        public IEnumerator<AdviceItem> GetEnumerator()
        {
            return this.internalCollection.GetEnumerator();
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// The create items.
        /// </summary>
        private void CreateItems()
        {
            this.internalCollection = new List<AdviceItem>
                {
                    new AdviceItem { Id = "feeding", Title = "Feeding your dog before training", Description = "If you intend to use food as a reward during training we recommend only giving your dog a small meal in the afternoon, or not feeding them until after training. If you intend to fed your dog before training we recommend feeding them at least 2 hours before training." }, 
                    new AdviceItem { Id = "recall", Title = "Wait/Stay with recall", Description = "Please try to have a wait or stay with recall on your dog. This will help in training and also be a really BIG help in competitions." }, 
                    new AdviceItem { Id = "poobag", Title = "Always have a poo bag", Description = "Please try to have a poo bag with you at all times for all those little accidents our dogs have." }, 
                    new AdviceItem { Id = "settingup", Title = "Setting up/Packing away", Description = "This is self-help club so please try to arrive early to help setup the equipment for your class. As if setup is delayed the start of the class will be delayed meaning it will be shorter as we are unable to run in to the later classes time." }, 
                    new AdviceItem { Id = "clothing", Title = "What to wear", Description = "We suggest wearing old clothes as the training surface can be a little dusty. Also,we recommend a good pair of trainers or walking boots as you'll be moving around the arena with your dog, hopefully quite quickly." }, 
                    new AdviceItem { Id = "dogneeds", Title = "What your dog needs", Description = "We suggest your dog has a flat collar with nothing dangling from it as this could get caught on the equipment. Also, bring some kind of reward for your dog, whether it's titbits, or some kind of toy. Your dog is here to have fun as well." }, 
                    new AdviceItem { Id = "staycalm", Title = "Try to remain calm whist training", Description = "We've had times where things go completely wrong when training, but please try to remain calm and listen to your trainer as they've seen it all before and will have some good advice." }, 
                    new AdviceItem { Id = "unfit", Title = "If your dog is unfit to train", Description = "if your dog is unfit to train please let one of the committee members know, as you will not be able to train with that dog." }, 
                    new AdviceItem { Id = "vacines", Title = "Dog Vaccinations", Description = "It is recommended that your dog is kept up to date with all vaccinations and is flea, tick and worm treated. This is for the benefit of dogs that train with us." }, 
                    new AdviceItem { Id = "absent", Title = "If your absent from training", Description = "If you know you're going to be absent from training for any length of time, please let a member of the committee know. As if you're absent for more 4 consecutive weeks, your name can be removed from the club register." }, 
                };
        }
    }
}
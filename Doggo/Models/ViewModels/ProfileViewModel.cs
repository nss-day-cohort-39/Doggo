using System.Collections.Generic;

namespace Doggo.Models.ViewModels
{
    public class ProfileViewModel
    {
        public Owner Owner { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Walker> Walkers { get; set; }
    }
}

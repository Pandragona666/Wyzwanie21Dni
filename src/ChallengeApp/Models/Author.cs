using System.Linq;

namespace ChallengeApp.Models
{
    public class Author
    {
        private string FirstName { get; set; }

        public string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeLastName(string lastName){
            if(!containsAnyDigit(lastName)){
                this.LastName = lastName;
            };
        }

        public bool containsAnyDigit(string checkedString){
            return checkedString.Any(c => char.IsDigit(c));

            // foreach(char c in checkedString){
            //     if(char.IsDigit(c)){
            //         return true;
            //     }
            // }
            // return false;
        }
    }
}


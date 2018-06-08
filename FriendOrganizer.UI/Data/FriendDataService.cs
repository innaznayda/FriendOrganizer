using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data {
    public class FriendDataService : IFriendDataService {
        public IEnumerable<Friend> GetAll() {

            //TODO: load real data from DB
            yield return new Friend {FirstName = "John", LastName = "Johnson"};
            yield return new Friend { FirstName = "Jack", LastName = "Jackson" };
            yield return new Friend { FirstName = "Dick", LastName = "Dickson" };
            yield return new Friend { FirstName = "Rick", LastName = "Rickson" };
        }
    }
}

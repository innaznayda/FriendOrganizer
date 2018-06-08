using System.Collections.ObjectModel;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel {
    public class MainViewModel : ViewModelBase {
        private Friend _selectedFriend;
        private IFriendDataService _friendDataService;

        public Friend SelectedFriend {
            get { return _selectedFriend; }
            set{
                _selectedFriend = value;
                OnPropertyChanged("SelectedFriend");
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }
        

        public MainViewModel(IFriendDataService frienddataService) {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = frienddataService;
        }

        public void Load() {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var fr in friends) {
                Friends.Add(fr);
            }
        }
    }
}

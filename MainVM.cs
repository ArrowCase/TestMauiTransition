using System.Collections.ObjectModel;

namespace TestMauiTransition
{
    public class ListItem : BindableObject
    {
        private string _side;
        public string Side
        {
            get => _side;
            set
            {
                if (_side != value)
                {
                    _side = value;
                    OnPropertyChanged(nameof(Side));
                }
            }
        }

        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                if (_count != value)
                {
                    _count = value;
                    OnPropertyChanged(nameof(Count));
                }
            }
        }
    }

    public class MainVM : BindableObject
    {
        private ObservableCollection<ListItem> _leftList = null;
        public ObservableCollection<ListItem> LeftList
        {
            get => _leftList;
            set
            {
                if (_leftList != value)
                {
                    _leftList = value;
                    OnPropertyChanged(nameof(LeftList));
                }
            }
        }

        private ObservableCollection<ListItem> _rightList = null;
        public ObservableCollection<ListItem> RightList
        {
            get => _rightList;
            set
            {
                if (_rightList != value)
                {
                    _rightList = value;
                    OnPropertyChanged(nameof(RightList));
                }
            }
        }

        private Command _addLeftItemCommand;
        public Command AddLeftItemCommand
        {
            get
            {
                return _addLeftItemCommand ??= new Command(() =>
                {
                    _leftList.Add(new ListItem() { Side = "Left" });
                });
            }
        }

        private Command _updateLeftTextCommand;
        public Command UpdateLeftTextCommand
        {
            get
            {
                return _updateLeftTextCommand ??= new Command(() =>
                {
                    _leftList[^1].Count += 1;
                });
            }
        }

        private Command _addRightItemCommand;
        public Command AddRightItemCommand
        {
            get
            {
                return _addRightItemCommand ??= new Command(() =>
                {
                    _rightList.Add(new ListItem() { Side = "Right" });
                });
            }
        }

        private Command _updateRightTextCommand;
        public Command UpdateRightTextCommand
        {
            get
            {
                return _updateRightTextCommand ??= new Command(() =>
                {
                    _rightList[^1].Count += 1;
                });
            }
        }

        public MainVM()
        {
            _leftList = new ObservableCollection<ListItem>() { new ListItem() { Side = "Left" } };
            _rightList = new ObservableCollection<ListItem>() { new ListItem() { Side = "Right" } };
        }
    }
}

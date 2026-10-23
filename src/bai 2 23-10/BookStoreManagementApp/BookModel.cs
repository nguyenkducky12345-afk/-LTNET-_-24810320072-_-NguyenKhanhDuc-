using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace BookStoreManagementApp
{
    public class BookModel : INotifyPropertyChanged
    {
        private string _bookId = string.Empty;
        private string _title = string.Empty;
        private string _author = string.Empty;
        private string _category = string.Empty;
        private int _quantity = 1;
        private decimal _price = 0;
        private string _coverImagePath = string.Empty;

        public string BookId
        {
            get => _bookId;
            set { if (_bookId != value) { _bookId = value; OnPropertyChanged(); } }
        }

        public string Title
        {
            get => _title;
            set { if (_title != value) { _title = value; OnPropertyChanged(); } }
        }

        public string Author
        {
            get => _author;
            set { if (_author != value) { _author = value; OnPropertyChanged(); } }
        }

        public string Category
        {
            get => _category;
            set { if (_category != value) { _category = value; OnPropertyChanged(); } }
        }

        public int Quantity
        {
            get => _quantity;
            set 
            { 
                if (_quantity != value) 
                { 
                    _quantity = value; 
                    OnPropertyChanged(); 
                    OnPropertyChanged(nameof(TotalAmount)); 
                } 
            }
        }

        public decimal Price
        {
            get => _price;
            set 
            { 
                if (_price != value) 
                { 
                    _price = value; 
                    OnPropertyChanged(); 
                    OnPropertyChanged(nameof(TotalAmount)); 
                } 
            }
        }

        public string CoverImagePath
        {
            get => _coverImagePath;
            set 
            { 
                if (_coverImagePath != value) 
                { 
                    _coverImagePath = value; 
                    OnPropertyChanged(); 
                    OnPropertyChanged(nameof(CoverImageName)); 
                } 
            }
        }

        public string CoverImageName => string.IsNullOrWhiteSpace(_coverImagePath) 
            ? "Chưa có ảnh" 
            : Path.GetFileName(_coverImagePath);

        public decimal TotalAmount => _quantity * _price;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

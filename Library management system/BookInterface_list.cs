using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal interface BookInterface_list
    {
        void AddBook(int id, string bookTitle, string author, string image, string status);
        void UpdateBook(int bookId, string title, string author, string image, string status);
        void DeleteBook(int bookId);
        List<BookInterface_list> GetAllBooks();
        BookInterface_list GetBookById(int bookId);
        List<BookInterface_list> SearchBooks(string searchTerm);
        void BorrowBook(int bookId, int userId);
        void ReturnBook(int bookId, int userId);
        

    }
}

using WebApp_HW_13.infrastructure.DataBase;
using WebApp_HW_13.Models;
using WebApp_HW_13.Models.Entity;

namespace WebApp_HW_13.infrastructure.DataAccess
{
    public class EF_Repository
    {
        private LibararyContext _LibraryDB;

        public int BookID { get; private set; }

        public EF_Repository()
        {
            _LibraryDB = new LibararyContext();
        }

        public List<QureryModelLibrary> GetAllInfoLibarary()
        {
            var result =
               (from L in _LibraryDB.Librarys
                join BL in _LibraryDB.BookLibararys on L.ID equals BL.LibraryID
                join B in _LibraryDB.Books on BL.BookID equals B.ID
                select new QureryModelLibrary
                {
                    id = 1,
                    LibraryName = L.LibraryName,
                    LibraryCity=L.LibraryCity,
                    LibraryAddress= L.LibraryAddress,
                    BookId=B.ID,
                    BookName= B.BookName,
                    Writer= B.Writer,
                    CountBook=BL.CountBook,
                 }).ToList();
            
                return result;      
        }
        public Book Getdatail(int bookid)
        {
            return _LibraryDB.Books.Where(x => x.ID ==bookid ).FirstOrDefault();
        }

        public void Edit(Book item)
        {
            var _Book = Getdatail(item.ID);
            _Book.BookName = item.BookName;
            _Book.Writer = item.Writer;
            _Book.CountPage  = item.CountPage;
            _LibraryDB.SaveChanges();

        }

        public void Delete(Book item)
        {
            var B = _LibraryDB.BookLibararys
            .Where(m => m.BookID == item.ID)
            .ToList();
            if (B.Count > 0)
                _LibraryDB.BookLibararys.RemoveRange(B);
          
            _LibraryDB.Books.Remove(item);
            _LibraryDB.SaveChanges();
          
        }

        public List<QureryModeAmanat> GetAllAmanat()
        {
            var result =
               (from B in _LibraryDB.Books
                join A in _LibraryDB.Amanats on B.ID equals A.BookID
                join M in _LibraryDB.Members on A.MemberID equals M.ID
                select new QureryModeAmanat
                {

                    MemberName = M.Name,
                    MemberCodemeli = M.Codemeli,
                    MemberTel = M.Tel,
                    BookId = B.ID,
                    BookName = B.BookName,
                    Writer = B.Writer,
                   
                }).ToList();

            return result;
        }

        public void AddAmanat(Amanat _Amanat)
        {
            _LibraryDB.Amanats.Add(_Amanat);

            var R= _LibraryDB.BookLibararys.Where(x => x.BookID == _Amanat.BookID &&
            x.LibraryID==_Amanat.LibraryID ).FirstOrDefault();

            var T = R.CountBook;
            R.CountBook = T - 1;
           
            _LibraryDB.SaveChanges();


        }

    }
}


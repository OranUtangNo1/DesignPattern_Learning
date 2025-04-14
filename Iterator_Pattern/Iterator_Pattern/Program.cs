
class Program
{
    // コンソールアプリケーションで実行を確認しました
    static void Main(string[] args)
    {
        BookShelf bookShelf = new BookShelf();
        bookShelf.appendBook(new Book("Around the world in 80 days"));
        bookShelf.appendBook(new Book("Bible"));
        bookShelf.appendBook(new Book("Cinderella"));
        bookShelf.appendBook(new Book("Daddy-Long-Legs"));
        IIterator it = bookShelf.Iterator();
        while (it.HasNext())
        {
            Book book = (Book)it.Next();
            Console.WriteLine(book.Name);
        }
        // 実行結果
        // Around the world in 80 days
        // Bible
        // Cinderella
        // Daddy-Long-Legs

        // 実行が一瞬で終わって確認できないので、キーの入力を待ちます
        Console.ReadLine();
    }

    // 集合体を表すインターフェース
    public interface IAggregate
    {
        IIterator Iterator();
    }

    // 数え上げ、スキャンを表すインターフェース
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    // 本を表すクラス
    public class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            this.Name = name;
        }
    }

    // 本棚を表すクラス
    public class BookShelf : IAggregate
    {
        List<Book> books = new List<Book>();
        int Last { get; set; } = 0;
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        public void appendBook(Book book)
        {
            this.books.Add(book);
            Last++;
        }
        public int GetLength()
        {
            return this.Last;
        }
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }

    // 本棚をスキャンするクラス
    // Iteratorを介してデータ構造にアクセスすることで、データ構造の持つAggregateの形(List/Array)が変わったとしても
    // アクセス側はそれを意識せず、HasNext()とNext()を利用してデータに順番にアクセス可能
    public class BookShelfIterator : IIterator
    {
        BookShelf BookShelf { get; set; }
        int Index { get; set; }
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.BookShelf = bookShelf;
            this.Index = 0;
        }

        // 内部構造にアクセス 
        public bool HasNext()
        {
            if (Index < BookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Next()
        {
            Book book = BookShelf.GetBookAt(Index);
            this.Index++;
            return book;
        }
    }
}
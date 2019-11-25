namespace Inheritance
{
    public interface IPen
    {
        string Color {get;set;}
        bool Close();
        bool Open();
        void Write(string text);
    }
}
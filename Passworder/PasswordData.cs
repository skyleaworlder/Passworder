namespace Passworder
{
    internal class PasswordData
    {
        public List<PasswordColumnData> Columns { get; set; }
    }

    class PasswordColumnData
    {
        public string Title { get; set; }
        public string PasswordHint { get; set; }
    }
}

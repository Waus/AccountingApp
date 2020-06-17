namespace AccountingApp.Model
{
    public partial class invoice
    {
        public string incomeText
        {
            get
            {
                return income == true ? "tak" : "nie";
            }
        }
    }
}

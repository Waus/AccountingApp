namespace JPK_generator.Model
{
    using System;
    using System.Collections.Generic;

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

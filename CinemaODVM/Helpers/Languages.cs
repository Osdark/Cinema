namespace CinemaODVM.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }
        public static string User
        {
            get { return Resource.User; }
        }
        public static string Login
        {
            get { return Resource.Login; }
        }
        public static string Password
        {
            get { return Resource.Password; }
        }
        public static string Enter
        {
            get { return Resource.Enter; }
        }
        public static string Validation
        {
            get { return Resource.Validation; }
        }
        public static string ValidationMsgUser
        {
            get { return Resource.ValidationMsgUser; }
        }
        public static string ValidationMsgPw
        {
            get { return Resource.ValidationMsgPw; }
        }
        public static string OK
        {
            get { return Resource.OK; }
        }
        public static string IncorrectLogin
        {
            get { return Resource.IncorrectLogin; }
        }
        public static string Premier
        {
            get { return Resource.Premier; }
        }
        public static string Gender
        {
            get { return Resource.Gender; }
        }
        public static string Recomendation
        {
            get { return Resource.Recomendation; }
        }
        public static string Title
        {
            get { return Resource.Title; }
        }
        public static string Date
        {
            get { return Resource.Date; }
        }
        public static string Tickets
        {
            get { return Resource.Tickets; }
        }
        public static string Functions
        {
            get { return Resource.Functions; }
        }
        public static string CheckIn
        {
            get { return Resource.CheckIn; }
        }
        public static string Movie
        {
            get { return Resource.Movie; }
        }
        public static string Function
        {
            get { return Resource.Function; }
        }
        public static string Cinema
        {
            get { return Resource.Cinema; }
        }
        public static string TicketsLbl
        {
            get { return Resource.TicketsLbl; }
        }
        public static string Price
        {
            get { return Resource.Price; }
        }
        public static string Quantity
        {
            get { return Resource.Quantity; }
        }
        public static string TotalPrice
        {
            get { return Resource.TotalPrice; }
        }
        public static string ValidationMsgTicket
        {
            get { return Resource.ValidationMsgTicket; }
        }
        public static string Success
        {
            get { return Resource.Success; }
        }
        public static string SuccessMsgBuy
        {
            get { return Resource.SuccessMsgBuy; }
        }
    }
}

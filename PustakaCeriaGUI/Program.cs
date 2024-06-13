namespace PustakaCeriaGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserValidatorFactory userValidatorFactory = new JsonUserValidatorFactory();
            IBookFactory bookFactory = new BookFactory();

            Application.Run(new FormLogin(userValidatorFactory, bookFactory));
        }
    }
}
namespace BasicQueuingCashier
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

            QueuingForm qForm = new QueuingForm();
            CashierWindowQueueForm cForm = new CashierWindowQueueForm();
            CustomerView cvForm = new CustomerView();

            qForm.Show();
            cForm.Show();
            cvForm.Show();

            Application.Run();
        }
    }
}
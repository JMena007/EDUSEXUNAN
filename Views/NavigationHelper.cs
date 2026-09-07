namespace EDUSEX.Views
{
    internal static class NavigationHelper
    {
        public static void Open<T>(Form currentForm)
            where T : Form, new()
        {
            T destination = new T();
            destination.Show();
            currentForm.Hide();
        }

        public static void Logout(Form currentForm)
        {
            Login login = new Login();
            login.Show();
            currentForm.Close();
        }
    }
}

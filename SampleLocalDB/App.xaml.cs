
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SampleLocalDB
{
    public partial class App : Application
    {
        static Restaraunt_tableDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RestarauntListPage());
        }
        public static Restaraunt_tableDatabase Database
        { //if database doesnt exist, create a new one
            get {
                if(database == null){
                    database = new Restaraunt_tableDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Restaraunt_tableDatabase.db3"));
                }
                return database;

             }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }  

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

namespace MyLOB
{
    public class MyLOBTenant
    {
        #region Properties

        public string Name { get; set; }

        public string URL { get; set; }

        #endregion Properties

        #region Methods

        public MyLOBTenant()
        {
            Name = "";
            URL = "";
        }

        #endregion Methods
    }
}
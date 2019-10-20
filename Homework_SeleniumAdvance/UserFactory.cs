namespace Homework_SeleniumAdvance
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                
                FirstName = "Ivanka",
                LastName = "Trump",
                Password = "ggbgg",
                Year = "1989",
                Month = "3",
                Date = "3",
                RealFirstName = "Ivanka",
                RealLastName = "Trump",
                Gender = "female",
                Address = "Wallstreet 10",
                City = "New York",
                State = "3",
                PostCode = "10150",
                Country = "21",
                Phone = "874827482",
                Alias = "Walstreet  42"

            };
        }
    }
}

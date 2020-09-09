namespace BackstageMusic.Migrations
{
    using BackstageMusic.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BackstageMusic.Models.BackstageMusicDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BackstageMusicDB context)
        {
            //Continents
            SeedContinents(context);
            //Countries
            SeedContries(context);
            //UserTypes
            SeedUserTypes(context);
            //SuperAdmin
            SeedSuperAdmin(context);
            //Platforms
            SeedPlatforms(context);
            //Genre
            SeedGenres(context);
            //Products
            SeedProducts(context);
            //CollaboratorTypes
            SeedCollaboratorTypes(context);
            //Languages
            SeedLanguages(context);
            //Status
            SeedStatus(context);
            //AssetTypes
            SeedAssetTypes(context);
            //DummySeeder
            //SeedDummyData(context);
        }

        private void SeedContinents(BackstageMusicDB context)
        {
            context.Continents.Add(new Continent() { name = "Africa" });
            context.Continents.Add(new Continent() { name = "Antarctica" });
            context.Continents.Add(new Continent() { name = "Asia" });
            context.Continents.Add(new Continent() { name = "Europe" });
            context.Continents.Add(new Continent() { name = "North America" });
            context.Continents.Add(new Continent() { name = "Oceania" });
            context.Continents.Add(new Continent() { name = "South America" });
        }

        private void SeedContries(BackstageMusicDB context)
        {
            context.Countries.Add(new Country() { name = "Andorra", id_continent = 4 });
            context.Countries.Add(new Country() { name = "United Arab Emirates", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Afghanistan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Antigua and Barbuda", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Anguilla", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Albania", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Armenia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Netherlands Antilles", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Angola", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Antarctica", id_continent = 2 });
            context.Countries.Add(new Country() { name = "Argentina", id_continent = 7 });
            context.Countries.Add(new Country() { name = "American Samoa", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Austria", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Australia", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Aruba", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Aland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Azerbaijan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Bosnia and Herzegovina", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Barbados", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Bangladesh", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Belgium", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Burkina Faso", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Bulgaria", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Bahrain", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Burundi", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Benin", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Saint Barthelemy", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Bermuda", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Brunei Darussalam", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Bolivia", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Brazil", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Bahamas", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Bhutan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Bouvet Island", id_continent = 2 });
            context.Countries.Add(new Country() { name = "Botswana", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Belarus", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Belize", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Canada", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Cocos(Keeling) Islands", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Congo(Kinshasa)", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Central African Republic", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Congo(Brazzaville)", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Switzerland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Cote d'Ivoire", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Cook Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Chile", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Cameroon", id_continent = 1 });
            context.Countries.Add(new Country() { name = "China", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Colombia", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Costa Rica", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Cuba", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Cape Verde", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Christmas Island", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Cyprus", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Czech Republic", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Germany", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Djibouti", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Denmark", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Dominica", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Dominican Republic", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Algeria", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Ecuador", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Estonia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Egypt", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Western Sahara", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Eritrea", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Spain", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Ethiopia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Finland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Fiji", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Falkland Islands", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Micronesia", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Faroe Islands", id_continent = 4 });
            context.Countries.Add(new Country() { name = "France", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Gabon", id_continent = 1 });
            context.Countries.Add(new Country() { name = "United Kingdom", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Grenada", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Georgia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "French Guiana", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Guernsey", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Ghana", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Gibraltar", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Greenland", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Gambia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Guinea", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Guadeloupe", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Equatorial Guinea", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Greece", id_continent = 4 });
            context.Countries.Add(new Country() { name = "South Georgia and South Sandwich Islands", id_continent = 2 });
            context.Countries.Add(new Country() { name = "Guatemala", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Guam", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Guinea - Bissau", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Guyana", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Hong Kong", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Heard and McDonald Islands", id_continent = 2 });
            context.Countries.Add(new Country() { name = "Honduras", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Croatia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Haiti", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Hungary", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Indonesia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Ireland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Israel", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Isle of Man", id_continent = 4 });
            context.Countries.Add(new Country() { name = "India", id_continent = 3 });
            context.Countries.Add(new Country() { name = "British Indian Ocean Territory", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Iraq", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Iran", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Iceland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Italy", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Jersey", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Jamaica", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Jordan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Japan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Kenya", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Kyrgyzstan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Cambodia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Kiribati", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Comoros", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Saint Kitts and Nevis", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Korea", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Korea", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Kuwait", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Cayman Islands", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Kazakhstan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Laos", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Lebanon", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Saint Lucia", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Liechtenstein", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Sri Lanka", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Liberia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Lesotho", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Lithuania", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Luxembourg", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Latvia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Libya", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Morocco", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Monaco", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Moldova", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Montenegro", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Saint Martin(French part)", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Madagascar", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Marshall Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Macedonia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Mali", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Myanmar", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Mongolia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Macau", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Northern Mariana Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Martinique", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Mauritania", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Montserrat", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Malta", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Mauritius", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Maldives", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Malawi", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Mexico", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Malaysia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Mozambique", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Namibia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "New Caledonia", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Niger", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Norfolk Island", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Nigeria", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Nicaragua", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Netherlands", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Norway", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Nepal", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Nauru", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Niue", id_continent = 6 });
            context.Countries.Add(new Country() { name = "New Zealand", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Oman", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Panama", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Peru", id_continent = 7 });
            context.Countries.Add(new Country() { name = "French Polynesia", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Papua New Guinea", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Philippines", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Pakistan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Poland", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Saint Pierre and Miquelon", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Pitcairn", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Puerto Rico", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Palestine", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Portugal", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Palau", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Paraguay", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Qatar", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Reunion", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Romania", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Serbia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Russian Federation", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Rwanda", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Saudi Arabia", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Solomon Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Seychelles", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Sudan", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Sweden", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Singapore", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Saint Helena", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Slovenia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Svalbard and Jan Mayen Islands", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Slovakia", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Sierra Leone", id_continent = 1 });
            context.Countries.Add(new Country() { name = "San Marino", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Senegal", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Somalia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Suriname", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Sao Tome and Principe", id_continent = 1 });
            context.Countries.Add(new Country() { name = "El Salvador", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Syria", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Swaziland", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Turks and Caicos Islands", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Chad", id_continent = 1 });
            context.Countries.Add(new Country() { name = "French Southern Lands", id_continent = 2 });
            context.Countries.Add(new Country() { name = "Togo", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Thailand", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Tajikistan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Tokelau", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Timor - Leste", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Turkmenistan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Tunisia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Tonga", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Turkey", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Trinidad and Tobago", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Tuvalu", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Taiwan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Tanzania", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Ukraine", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Uganda", id_continent = 1 });
            context.Countries.Add(new Country() { name = "United States Minor Outlying Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "United States of America", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Uruguay", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Uzbekistan", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Vatican City", id_continent = 4 });
            context.Countries.Add(new Country() { name = "Saint Vincent and the Grenadines", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Venezuela", id_continent = 7 });
            context.Countries.Add(new Country() { name = "Virgin Islands", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Virgin Islands", id_continent = 5 });
            context.Countries.Add(new Country() { name = "Vietnam", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Vanuatu", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Wallis and Futuna Islands", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Samoa", id_continent = 6 });
            context.Countries.Add(new Country() { name = "Yemen", id_continent = 3 });
            context.Countries.Add(new Country() { name = "Mayotte", id_continent = 1 });
            context.Countries.Add(new Country() { name = "South Africa", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Zambia", id_continent = 1 });
            context.Countries.Add(new Country() { name = "Zimbabwe", id_continent = 1 });
        }

        private void SeedUserTypes(BackstageMusicDB context)
        {
            context.UserTypes.Add(new UserType() { id_usertype = 1, name = "Admin" });
            context.UserTypes.Add(new UserType() { id_usertype = 2, name = "Artista" });
            context.UserTypes.Add(new UserType() { id_usertype = 3, name = "Manager" });
            context.UserTypes.Add(new UserType() { id_usertype = 4, name = "Sello" });
        }

        private void SeedSuperAdmin(BackstageMusicDB context)
        {
            context.Users.Add(
                new User()
                {
                    id_user = 1,
                    username = "admin",
                    password = "b0a7cf02d3dc5e6d2a2d9d48cfd902830cc49df16cb2e909efaa484288ebb2dd",
                    id_usertype = 1,
                    is_suscribed = true,
                    is_confirmed = true,
                    primary_address = "Xenotech",
                    secondary_address = "Street",
                    city = "Monterrey",
                    zipcode = 67130,
                    id_country = 1,
                    voucher = "voucherprueba"
                });
            context.SaveChanges();
            context.Admins.Add(
                new Admin()
                {
                    id_user = 1,
                    name = "Admin"
                });
            context.Users.Add(
                    new User()
                    {
                        id_user = 2,
                        username = "xenoadmin",
                        password = "b0a7cf02d3dc5e6d2a2d9d48cfd902830cc49df16cb2e909efaa484288ebb2dd",
                        id_usertype = 1,
                        is_suscribed = true,
                        is_confirmed = true,
                        primary_address = "Xenotech",
                        secondary_address = "Street",
                        city = "Monterrey",
                        zipcode = 67130,
                        id_country = 1,
                        voucher = "voucherprueba"
                    });
            context.SaveChanges();
            context.Admins.Add(
                new Admin()
                {
                    id_user = 2,
                    name = "XenoAdmin"
                });
        }

        private void SeedDummyData(BackstageMusicDB context)
        {
            context.Users.Add(
                new User()
                {
                    id_user = 3,
                    username = "label@label.com",
                    password = "b0a7cf02d3dc5e6d2a2d9d48cfd902830cc49df16cb2e909efaa484288ebb2dd",
                    id_usertype = 2,
                    is_suscribed = true,
                    is_confirmed = true,
                    primary_address = "Xenotech",
                    secondary_address = "Street",
                    city = "Monterrey",
                    zipcode = 67130,
                    id_country = 1,
                    voucher = "voucherprueba"
                });
            context.SaveChanges();
            context.Labels.Add(
                new Label()
                {
                    id_user = 3,
                    name = "Asenath Records"
                });
            context.Users.Add(
                new User()
                {
                    id_user = 4,
                    username = "manager@manager.com",
                    password = "b0a7cf02d3dc5e6d2a2d9d48cfd902830cc49df16cb2e909efaa484288ebb2dd",
                    id_usertype = 3,
                    is_suscribed = true,
                    is_confirmed = true,
                    primary_address = "Xenotech",
                    secondary_address = "Street",
                    city = "Monterrey",
                    zipcode = 67130,
                    id_country = 1,
                    voucher = "voucherprueba"
                });
            context.SaveChanges();
            context.Managers.Add(
                new Manager()
                {
                    id_user = 4,
                    name = "Reyes Amaro"
                });
            context.Users.Add(
                new User()
                {
                    id_user = 5,
                    username = "artist@artist.com",
                    password = "b0a7cf02d3dc5e6d2a2d9d48cfd902830cc49df16cb2e909efaa484288ebb2dd",
                    id_usertype = 4,
                    is_suscribed = true,
                    is_confirmed = true,
                    primary_address = "Xenotech",
                    secondary_address = "Street",
                    city = "Monterrey",
                    zipcode = 67130,
                    id_country = 1,
                    voucher = "voucherprueba"
                });
            context.SaveChanges();
            context.Artists.Add(
                new Artist()
                {
                    id_user = 5,
                    name = "Monster"
                });
        }

        private void SeedPlatforms(BackstageMusicDB context)
        {
            context.Platforms.Add(new Platform() { name = "24 - 7 entertainment", photo_url = "24 - 7 - entertainment.svg" });
            context.Platforms.Add(new Platform() { name = "7Digital", photo_url = "7digital.svg" });
            context.Platforms.Add(new Platform() { name = "Akazoo", photo_url = "akazoo.svg" });
            context.Platforms.Add(new Platform() { name = "Amazon", photo_url = "amazon.svg" });
            context.Platforms.Add(new Platform() { name = "Anghami", photo_url = "anghami.svg" });
            context.Platforms.Add(new Platform() { name = "Aspiro", photo_url = "aspiro.svg" });
            context.Platforms.Add(new Platform() { name = "AWA music", photo_url = "awa.svg" });
            context.Platforms.Add(new Platform() { name = "Claro Musica", photo_url = "claromusica.svg" });
            context.Platforms.Add(new Platform() { name = "Deezer", photo_url = "deezer.svg" });
            context.Platforms.Add(new Platform() { name = "Facebook Content ID", photo_url = "facebook.svg" });
            context.Platforms.Add(new Platform() { name = "Google play", photo_url = "google - play.svg" });
            context.Platforms.Add(new Platform() { name = "I Heart Radio", photo_url = "iheart - radio.svg" });
            context.Platforms.Add(new Platform() { name = "Itunes Music Store", photo_url = "itunes.svg" });
            context.Platforms.Add(new Platform() { name = "KKBox", photo_url = "kkbox.svg" });
            context.Platforms.Add(new Platform() { name = "Medianet", photo_url = "medianet.svg" });
            context.Platforms.Add(new Platform() { name = "Napster", photo_url = "napster.svg" });
            context.Platforms.Add(new Platform() { name = "Netease Cloud Music", photo_url = "netease.svg" });
            context.Platforms.Add(new Platform() { name = "Nokia", photo_url = "nokia.svg" });
            context.Platforms.Add(new Platform() { name = "QQ music", photo_url = "qq - music.svg" });
            context.Platforms.Add(new Platform() { name = "Rdio", photo_url = "rdio.svg" });
            context.Platforms.Add(new Platform() { name = "Saavn", photo_url = "saavn.svg" });
            context.Platforms.Add(new Platform() { name = "Shazam", photo_url = "shazam.svg" });
            context.Platforms.Add(new Platform() { name = "Slacker", photo_url = "slacker.svg" });
            context.Platforms.Add(new Platform() { name = "Spotify", photo_url = "spotify.svg" });
            context.Platforms.Add(new Platform() { name = "United Media Agency", photo_url = "um - agency.svg" });
            context.Platforms.Add(new Platform() { name = "Xiami", photo_url = "xiami.svg" });
            context.Platforms.Add(new Platform() { name = "Yandex", photo_url = "yandex.svg" });
            context.Platforms.Add(new Platform() { name = "YouTube Art Tracks", photo_url = "youtube - music.svg" });
            context.Platforms.Add(new Platform() { name = "Zvooq", photo_url = "zvooq.svg" });
            context.Platforms.Add(new Platform() { name = "Apple Music", photo_url = "apple - music.svg" });
            context.Platforms.Add(new Platform() { name = "hmv - digital", photo_url = "hmv - digital.svg" });
            context.Platforms.Add(new Platform() { name = "Instagram Music", photo_url = "instagram.svg" });
            context.Platforms.Add(new Platform() { name = "kugou", photo_url = "kugou.svg" });
            context.Platforms.Add(new Platform() { name = "kuwo", photo_url = "kuwo.svg" });
            context.Platforms.Add(new Platform() { name = "pulselocker", photo_url = "pulselocker.svg" });
            context.Platforms.Add(new Platform() { name = "tidal", photo_url = "tidal.svg" });
            context.Platforms.Add(new Platform() { name = "wimp", photo_url = "wimp.svg" });
            context.Platforms.Add(new Platform() { name = "Pandora", photo_url = "pandora.svg" });
            context.Platforms.Add(new Platform() { name = "Alibaba Music Group", photo_url = "alibaba - group.png" });
            context.Platforms.Add(new Platform() { name = "AudibleMagic", photo_url = "AudibleMagic.png" });
            context.Platforms.Add(new Platform() { name = "Gracenote", photo_url = "Gracenote.png" });
            context.Platforms.Add(new Platform() { name = "Kuack Media Group", photo_url = "kuack.png" });
            context.Platforms.Add(new Platform() { name = "Sound Cloud", photo_url = "soundcloud.png" });
            context.Platforms.Add(new Platform() { name = "Tesla Music", photo_url = "tesla - logo.png" });
            context.Platforms.Add(new Platform() { name = "YouTube ContentID", photo_url = "youtube - music.svg" });
            context.Platforms.Add(new Platform() { name = "Youtube Play", photo_url = "youtube - music.svg" });
        }

        private void SeedGenres(BackstageMusicDB context)
        {
            context.Genres.Add(new Genre() { name = "Alabanza & Adoración" });
            context.Genres.Add(new Genre() { name = "Alternativo & Rock Latino" });
            context.Genres.Add(new Genre() { name = "Baladas / Boleros" });
            context.Genres.Add(new Genre() { name = "Blues" });
            context.Genres.Add(new Genre() { name = "Chill" });
            context.Genres.Add(new Genre() { name = "Clásica" });
            context.Genres.Add(new Genre() { name = "Country" });
            context.Genres.Add(new Genre() { name = "Dance / EDM" });
            context.Genres.Add(new Genre() { name = "Electrónica" });
            context.Genres.Add(new Genre() { name = "Folk" });
            context.Genres.Add(new Genre() { name = "Funk" });
            context.Genres.Add(new Genre() { name = "Gospel" });
            context.Genres.Add(new Genre() { name = "Hard Rock" });
            context.Genres.Add(new Genre() { name = "Hip Hop / Rap" });
            context.Genres.Add(new Genre() { name = "Indie Pop" });
            context.Genres.Add(new Genre() { name = "Inspiracional" });
            context.Genres.Add(new Genre() { name = "Instrumental" });
            context.Genres.Add(new Genre() { name = "Jazz" });
            context.Genres.Add(new Genre() { name = "Latin Jazz" });
            context.Genres.Add(new Genre() { name = "Mundo" });
            context.Genres.Add(new Genre() { name = "Musica Infantil" });
            context.Genres.Add(new Genre() { name = "Navidad" });
            context.Genres.Add(new Genre() { name = "Pop" });
            context.Genres.Add(new Genre() { name = "Pop Latino" });
            context.Genres.Add(new Genre() { name = "Pop Rock" });
            context.Genres.Add(new Genre() { name = "Punk" });
            context.Genres.Add(new Genre() { name = "R & B / Soul" });
            context.Genres.Add(new Genre() { name = "Reggae" });
            context.Genres.Add(new Genre() { name = "Reggaeton" });
            context.Genres.Add(new Genre() { name = "Regional" });
            context.Genres.Add(new Genre() { name = "Rock" });
            context.Genres.Add(new Genre() { name = "Salsa / Tropical" });
            context.Genres.Add(new Genre() { name = "Ska" });
            context.Genres.Add(new Genre() { name = "Soft Rock" });
            context.Genres.Add(new Genre() { name = "Soundtrack / TV" });
            context.Genres.Add(new Genre() { name = "Vocal" });

        }

        private void SeedProducts(BackstageMusicDB context)
        {
            context.Products.Add(new Product() { name = "Album/EP", photo_url = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_800/https://www.testingxperts.com/wp-content/uploads/2019/02/placeholder-img.jpg", price = 15.00M });
            context.Products.Add(new Product() { name = "Single", photo_url = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_800/https://www.testingxperts.com/wp-content/uploads/2019/02/placeholder-img.jpg", price = 5.00M });
            context.Products.Add(new Product() { name = "Landing", photo_url = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_800/https://www.testingxperts.com/wp-content/uploads/2019/02/placeholder-img.jpg", price = 5.00M });
            context.Products.Add(new Product() { name = "Presskit", photo_url = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_800/https://www.testingxperts.com/wp-content/uploads/2019/02/placeholder-img.jpg", price = 5.00M });
            context.Products.Add(new Product() { name = "Pre-Save", photo_url = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_800/https://www.testingxperts.com/wp-content/uploads/2019/02/placeholder-img.jpg", price = 5.00M });
        }

        private void SeedCollaboratorTypes(BackstageMusicDB context)
        {
            context.CollaboratorTypes.Add(new CollaboratorType() { name = "Artista" });
            context.CollaboratorTypes.Add(new CollaboratorType() { name = "Productor" });
            context.CollaboratorTypes.Add(new CollaboratorType() { name = "Compositor" });
        }

        private void SeedLanguages(BackstageMusicDB context)
        {
            context.Languages.Add(new Language() { name = "Español" });
            context.Languages.Add(new Language() { name = "Inglés" });
            context.Languages.Add(new Language() { name = "Portugués" });
        }

        private void SeedStatus(BackstageMusicDB context)
        {
            context.Status.Add(new Status() { name = "Completo" });
            context.Status.Add(new Status() { name = "Incompleto" });
            context.Status.Add(new Status() { name = "En revisión" });
            context.Status.Add(new Status() { name = "Rechazado" });
            context.Status.Add(new Status() { name = "Aprobado" });
            context.Status.Add(new Status() { name = "En tiendas" });
        }

        private void SeedAssetTypes(BackstageMusicDB context)
        {
            context.AssetTypes.Add(new AssetType() { name = "Album/EP" });
            context.AssetTypes.Add(new AssetType() { name = "Single" });
        }
    }
}

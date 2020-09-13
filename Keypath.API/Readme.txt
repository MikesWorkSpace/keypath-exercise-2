API for Keypath Education Exercise 2
Mike Sullivan - Candidate

Application is built on .NET Core 3.1

The only entity in the DB is ExampleItem

There is no identity in the program.  Anonymous users can read from and post to the database.

THe app uses Entity Framework.  The database will be created and seeded (if not already done) on application startup. The appsettings.json Connection String for
the KeypathRepo may need adjustment if run on another computer (other than Mike's home box).

The POST to ExampleItem allows Query String, JSON, or Form Data.  A slight change in the URL accommodates this


https://localhost:44303/api/ExampleItems/JSON   (expects JSON body)
https://localhost:44303/api/ExampleItems/QUERY?Word=XXX&SortOrder=999  (no body)
https://localhost:44303/api/ExampleItems/FORM   (expects multipart/form-data;)


JSON is the default if that portion of the URL is omitted.

Tested with Postman.


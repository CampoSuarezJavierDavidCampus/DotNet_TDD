
# TDD-Test-Project

this project is for my practice in a TDD environment, I used Xunit, Moq and AutoFixture to test a library and Api, so I created controllers and many different classes to test different features of my code




## Features

- Using Microsoft.EntityFrameworkCore.InMemory to mock my database
- API Controllers tested in different scenarios.
- TestLibrary tested in different scenarios.
- using coverlet to create a coverage.covertura.xml
- report generated in html thanks to the reportgenerator tool


## Running Tests

To run tests, run the following command

```bash
  dotnet test
```

To create the cobertura.xml file, run following command

```bash
   dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:ExcludeByAttribute="ExcludeFromCodeCoverage" /
```
following used this another command on Test folder to create the HTML report.
```bash
   reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html
```

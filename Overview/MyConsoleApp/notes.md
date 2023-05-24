You run the following command to make a new dot net console app:
`dotnet new console`

if you do not include the -n flag then it will default the file name to the directory it is in:
`dotnet new console -n MyApp`

You can also run it with the -f flag to specify the version:
`dotnet new console -f "net6.0"`

as of dotnet 6.0 there are a number of implicit using directives included with every project.
a quick list of them:
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

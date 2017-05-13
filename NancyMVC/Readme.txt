1. Create an Empty Project with depedency on System and Microsoft.CSharp
2. Install-Package Owin
3. Install-Package Microsoft.Owin
4. Create class Startup.cs
5. Add method Configuration (IAppbuilder app)
6. Decorate with attribute [assembly: OwinStartup(typeof(NancyMVC.Startup))]
7. Install-Package OwinHost
8. Under project properties --> web select OwinHost.exe
or
from commmand promp run the following:
C:\Tutorials\Code\NancyWeb\NancyMVC>..\packages\OwinHost.3.1.0\tools\OwinHost.exe
9. Reference :-https://docs.microsoft.com/en-us/aspnet/aspnet/overview/owin-and-katana/owin-startup-class-detection
10.With OwinHost it doesn't uses IIS or IISExpress as hosting
11.IISExpress and IIS is used as hosting, Microsoft.Owin provides the bridge for OWIN and IIS
12.NancyFX and ASP.Net provides middleware pipeline and web framework for web application
========
13. install-package nancy.owin
14. Install-Package Microsoft.Owin.Host.SystemWeb to host in IIS or IISExpress
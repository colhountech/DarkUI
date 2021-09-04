#FAQ

Q) I got an error:

Your project does not reference ".NETFramework,Version=v4.0,Profile=Client" framework. Add a reference to ".NETFramework,Version=v4.0,Profile=Client" in the "TargetFrameworks" property of your project file and then re-run NuGet restore.

A) If you want to run on net4.0, you must unload the .net5 Example project first. Right click the project and hit 'unload project', then following the steps below:

	* Clean solution
	* Delete folder "Example\bin"
	* Delete folder "example\obj"

For more info see: https://stackoverflow.com/questions/52833741/your-project-does-not-reference-netframework-version-v4-6-2-framework-add-a

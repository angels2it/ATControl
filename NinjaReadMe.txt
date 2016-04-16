
----------------------------------------------------------------------------------------------------
16 Apr 16 15:31 Add Projects
----------------------------------------------------------------------------------------------------

MvvmCross framework selected.
NUnit testing framework selected.
Moq mocking framework selected.

MainViewModel.cs added to ATControl.Core project (template=MvxSampleDataViewModel.t4)
MainView.cs added to ATControl.Droid project (template=SampleDataView.t4)
DetailViewModel.cs added to ATControl.Core project (template=BlankViewModel.t4)
DetailView.cs added to ATControl.Droid project (template=BlankView.t4)

----------------------------------------------------------------------------------------------------
Nuget Commands
----------------------------------------------------------------------------------------------------

Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName ATControl.Core 
Install-Package Scorchio.NinjaCoder.MvvmCross.Core -FileConflictAction Overwrite -ProjectName ATControl.Core 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName ATControl.Droid 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction ignore -ProjectName ATControl.Droid 
Install-Package PCLStorage -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Xam.Plugins.Settings -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Xam.Plugins.Settings -FileConflictAction ignore -ProjectName ATControl.Droid
Install-Package SQLite.Net-PCL -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package SQLite.Net-PCL -FileConflictAction ignore -ProjectName ATControl.Droid
Install-Package AsyncOAuth -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Scorchio.NinjaCoder.MvvmHelper.Core -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Scorchio.NinjaCoder.Settings.Simple.Core -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Scorchio.NinjaCoder.SQLite.Todo.Core -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package Scorchio.NinjaCoder.SQLite.Todo -FileConflictAction ignore -ProjectName ATControl.Droid
Install-Package MvvmCross.Plugins.Settings -FileConflictAction ignore -ProjectName ATControl.Core
Install-Package MvvmCross.Plugins.Settings -FileConflictAction ignore -ProjectName ATControl.Droid


----------------------------------------------------------------------------------------------------
Ninja Coder for MvvmCross and Xamarin Forms v4.0.0
----------------------------------------------------------------------------------------------------

All feedback welcome, please get in touch via twitter.

Thanks

@asudbury

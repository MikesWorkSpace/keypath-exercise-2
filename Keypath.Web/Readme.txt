The application runs on https://localhost:44327

The string matcher is at https://localhost:44327/string-match

Note: When navigating to string-match it is common to get this following http response:

	HTTP Error 500.35 - ANCM Multiple In-Process Applications in same Process
	
It usually goes away after a minute of two.  I find that I have to switch back and forth between
Home and String Matures.

-----------------------------------------------------------------------------------------------------
The full 500.35 response is:

HTTP Error 500.35 - ANCM Multiple In-Process Applications in same Process

Common solutions to this issue:
Select a different application pool to create another in-process application.

Specific error detected by ANCM:
Only one in-process application is allowed per IIS application pool. Please assign the application '/LM/W3SVC/3/ROOT/string-match' to a different IIS application pool.

Troubleshooting steps:
Check the system event log for error messages
Enable logging the application process' stdout messages

Attach a debugger to the application process and inspect
For more information visit: https://go.microsoft.com/fwlink/?LinkID=2028526
-----------------------------------------------------------------------------------------------------

FIX FOR ABOVE 500.35 Problem
FIX FOR ABOVE 500.35 Problem
FIX FOR ABOVE 500.35 Problem
FIX FOR ABOVE 500.35 Problem

https://stackoverflow.com/questions/58246822/http-error-500-35-ancm-multiple-in-process-applications-in-same-process-asp-ne

Follow the instructions on the "It's cuyrrently a bug in VS2019 - (Nov 4'2019)"
-	deleting the .applicatoinhost.config file in the hidden .vs folder at the solution root took care of it. It's nested inside the folder structur
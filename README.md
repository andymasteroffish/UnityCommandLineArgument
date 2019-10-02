# UnityCommandLineArgument
demo of accepting a command line argument in a Unity project

exmaple of the code you can drop into your app:

```
	string[] arguments = Environment.GetCommandLineArgs();
	 for (int i=0; i<arguments.Length; i++){
	     if (arguments[i] == "-freeplay" && i<arguments.Length-1 ){
	     	bool free_play = arguments[i+1].ToLower() == "true";
	     }
	 }
```
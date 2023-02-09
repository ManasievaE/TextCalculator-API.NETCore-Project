Project: API .NET Core - Text Calculator

Introduction

This project contains a TextCalculator class with an Add method that calculates the sum of numbers passed as string. 
It also contains a .NET Core API that exposes the functionality of the TextCalculator class over an API endpoint and 
a web frontend that provides a UI for the user to perform text calculations.

Requirements

	-.NET Core 3.1 or later
	- Visual Studio 2019 

Running the Project Locally

        -Extract the project to your local machine.
	-Open the solution file (TaskOne.sln) in Visual Studio.
	-Set the APIProject as the startup project by right-clicking on it and selecting "Set as Startup Project".
	-Run the project by clicking on the "Start" button or by pressing F5.	
        -The frontend will start running on http://localhost:44313.
	-Use the UI to perform text calculations by entering numbers separated by commas and hitting the submit button.

Testing

The project contains a test project (TextCalculatorTests.cs) that uses xUnit to test the functionality of the TextCalculator class. 
To run the tests, follow these steps:

	-Right-click on the test project and select "Run Tests".
	-The tests will run and the results will be displayed in the Test Explorer window.

Troubleshooting

"Failed to load resource: net::ERR_CONNECTION_RESET" is the erorr in the browser that i didn't manage to solve, 
so any suggestion is more than welcomed.

Conclusion

This project SHOULD provide a simple implementation of a Text Calculator that can perform addition of numbers passed as strings. 
The API and frontend provide a convenient way to use the calculator and the tests ensure that the implementation is correct.

# Pierre's Market of Sweet and Savory Treats

#### Pierre's Market uses C# and Identity framework to make a registration based website. Users will have to register an account to access the ability to Create, Read, Update, and Delete orders in their account.

## Technologies Used

* C#
* .NET 5
* Entity Core Framework
* Markdown
* ASP.NET Core
* Razer
* Linq


## Description
This web application uses C# and other HTML helper methods to create a live website that a user can add engineers based on which machines need repairing and the ability to add machines with already added engineers.  A user can also delete, edit and view details of each added engineer and edit, delete and view details of each machine. 

## Setup/Installation Requirements

* Navigate to `https://github.com/DonovanWeber/Sillystringz-Factory.Solution`
* Click on the green "Code" button and copy the repository URL or click on the copy button
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/DonovanWeber/Sillystringz-Factory.Solution`
* After cloning the project, navigate into it using the command `cd Sillystringz-Factory.Solution`
* Then run `cd Factory` and create an appsettings file by running `touch appsettings.json` in the terminal 
* Inside of the appsetting.json file add your database by writing in => `{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=donovan_weber;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
` add your password for mysql in the associated sections above
* Then run `cd Factory` and run `dotnet restore` inside of the testing directory to build out the objects folder
* Then  navigate to the same directory run `dotnet build`
* After you build the application go back into the terminal and run `dotnet run` to start the application 
* Copy and paste the first http://localhost:5000 and paste it into your browsers url to run


## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"

<details>
<summary><strong>Template Setup</strong></summary>
<ol>
<li>Navigate to https://github.com/DonovanWeber/Pierres_Treats.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/DonovanWeber/Pierres_Treats.Solution</strong>
<li>Be sure to rename everything so that it matches your project!
<br>
</details>

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/DonovanWeber/Pierres_Treats.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/DonovanWeber/Pierres_Treats.Solution</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "Pierres_Treats.Solution".
<li>Navigate to the projects root directory, "Pierres_Treats".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "Pierres_Treats" directory  
   <pre>Pierres_Treats.Solution
   └── Pierres_Treats
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=fan_book;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
<li>In root directory of project folder "Pierres_Treats.Solution", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>
<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "pierres_treats" schema.

  
</details>
<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>Pierres_Treats.Solution
   └── <strong>Pierres_Treats</strong></pre>
Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>
This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.
---

## Known Bugs
* No known bugs if any are found please 
contact me at [donovanweber03@gmail.com](mailto:donovanweber03@gmail.com) if any bugs are found.

## License

[MIT](https://choosealicense.com/licenses/mit/)
Copyright (c) 8/12/2022 Donovan Weber 


 
>#### _**A Big Thanks To:**_ 
>#### **Garrett Hays @ https://github.com/GarrettHays**    
>#### **Zachary Waggoner @ https://github.com/CyndaZ42**  
>#### _**for amazing README formatting and instructions!**_ 

## Known Bugs
* No known bugs if any are found please 
contact me at [donovanweber03@gmail.com](mailto:donovanweber03@gmail.com) if any bugs are found.


## License

[MIT](https://choosealicense.com/licenses/mit/)
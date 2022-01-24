This is project is about an ecommerce website that sells any kinds of products.<br>
The technologies used include blazor web server, Web API, EntityFramework Core, and Unit of Work Pattern.<br>
This project is subject to change on daily basis.
<br>
Instruction: <br>
1. Pull this project using git pull and the name of the repository or download the .zip file<br>
2. Open the project and go to package manager console<br>
3. Type update-database seedDatabase to create the database with sample data.<br>
4. If the products are not displayed, make sure to match the port number of your machine to what is specified in the startup.cs file of the ecommerce folder.<br>

e.g. In this example, the port number is 44311<br>
	    services.AddHttpClient<Iproduct, ProductService>(client => {<br>
                client.BaseAddress = new Uri("https://localhost:44311/");<br>
            });<br>

5. Build, rebuild, and run the project.

<br>
https://github.com/bethovenacha/Ecommerce-using-Blazor-Web-Server.git

# Property-Rental-System
This project is actually one of my academic assignments I had to complete for my Advance Web Technologies module, during my first semester of my masters degree. 

## About the project
The aim of the project, is to design property rental system for a rental company. All property records should have an address, maximum number of occupancy etc. 
I started by implementing the server side of the application, which is a WCF service that offers the user the following operations: 

1. Search for a property by postcode
2. Enter a new property into the database  
3. Get a list of available student lettings

The database solution my application uses is MySQL, and that is where I created two tables called Property and Lettings, which will hold the relevant information about the application. 
Lastly, I implemented the client side of the application to invoke the WCF services which I implemented on the server. 

This solution of mine received a mark of Distinction. 

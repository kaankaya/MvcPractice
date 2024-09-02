# MvcPractice

This project demonstrates a basic ASP.NET Core MVC application for displaying customer and order information. The primary focus is on understanding and implementing the Model-View-Controller (MVC) architecture.

## Features

- Display customer details, including ID, First Name, Last Name, and Email.
- View a list of orders associated with a customer, including Product Name, Price, and Quantity.
- Structured implementation of MVC patterns for clean and scalable code architecture.

## Project Structure

- **Models:** Defines `Customer` and `Order` classes.
- **ViewModels:** `CustomerOrderViewModel` aggregates customer and order data for the view layer.
- **Controllers:** `CustomerOrdersController` processes customer and order data and passes it to the view.
- **Views:** `Index.cshtml` displays customer details and related orders.

## Getting Started

To run the project:

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.

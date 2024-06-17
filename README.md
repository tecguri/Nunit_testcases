# Nunit Test Cases

**Overview**
This is a console application developed using Visual Studio, accompanied by a NUnit Test Project. The application has been thoroughly tested with 18 different test cases to ensure its reliability and accuracy.

**Application Description**
This C# (.NET Framework) class is part of an eCommerce application and represents a Product entity. The class is designed to be used in a console app, but the focus of this project is on developing and testing the Product class itself, rather than the console app.

**Class Description**
The Product class has a constructor that takes the following attributes:

**ProductID:** a unique identifier for the product
**ProductName:** the name of the product
**Price:** the price of the product
**Stock:** the current stock level of the product

This class has been thoroughly tested with 18 different unit tests to ensure its reliability and accuracy. The tests cover various scenarios and edge cases to validate the class's behavior.

**Test Cases**
The following 18 test cases have been implemented to validate the application's behavior:

**ProductID**

ProductID_ShouldBeWithinValidRange_Low: Verifies that the ProductID is set correctly within the valid range (low value).

ProductID_ShouldBeWithinValidRange_High: Verifies that the ProductID is set correctly within the valid range (high value).

ProductID_ShouldBeWithinValidRange_Mid: Verifies that the ProductID is set correctly within the valid range (mid value).

**ProductName**
ProductName_ShouldBeSet_Correctly: Verifies that the ProductName is set correctly.
ProductName_ShouldAllow_EmptyString: Verifies that an empty string is allowed as a ProductName.
ProductName_ShouldAllow_Null: Verifies that a null value is allowed as a ProductName.
**Price**
Price_ShouldBeWithinValidRange_Low: Verifies that the Price is within the valid range (low value).
Price_ShouldBeWithinValidRange_High: Verifies that the Price is within the valid range (high value).
Price_ShouldBeWithinValidRange_Mid: Verifies that the Price is within the valid range (mid value).
**Stock**
Stock_ShouldBeWithinValidRange_Low: Verifies that the Stock is within the valid range (low value).
Stock_ShouldBeWithinValidRange_High: Verifies that the Stock is within the valid range (high value).
Stock_ShouldBeWithinValidRange_Mid: Verifies that the Stock is within the valid range (mid value).
**Increase Method**
IncreaseStock_ShouldIncreaseStock: Verifies that the IncreaseStock method increases the stock level correctly.
IncreaseStock_ShouldHandleZeroIncrease: Verifies that the IncreaseStock method handles a zero increase correctly.
IncreaseStock_ShouldThrowExceptionWhenStockOutOfRange: Verifies that the IncreaseStock method throws an exception when the stock level exceeds the valid range.
**Decrease Method**
DecreaseStock_ShouldDecreaseStock: Verifies that the DecreaseStock method decreases the stock level correctly.
DecreaseStock_ShouldHandleZeroDecrease: Verifies that the DecreaseStock method handles a zero decrease correctly.
DecreaseStock_ShouldThrowExceptionWhenStockGoesNegative: Verifies that the DecreaseStock method throws an exception when the stock level goes negative.

**Running the Application**
To run the application, simply open the solution in Visual Studio and press F5 or click the "Run" button.

**Running the Tests**
To run the tests, open the Project in Visual Studio and click on Test from Top bar menu and select the "Run All" option or press Ctrl + R, A.

**Dependencies**
.NET Framework 
NUnit 

**Contact**
If you have any questions or issues with the application, please don't hesitate to reach out to **https://linkedin.com/in/gursahib-singh-bb3944169**.

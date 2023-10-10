# Introduction 
This MVC project is designed to demonstrate a web application following the Model-View-Controller architectural pattern. It incorporates Swagger for API documentation and includes authorization features to secure access to certain parts of the application.

# Getting Started
## Prerequisites
Before you begin, ensure you have met the following requirements:

- .NET SDK: Make sure you have the .NET SDK 6 installed on your machine.
- Docker: Install Docker on your machine if you haven't already. 

### To get this MVC application up and running locally, follow these steps:

1. Clone the Repository
2. Run the Database in Docker

Before running the project, you need to configure some settings. Locate the appsettings.json file in the project directory and update the following settings:

```sh
{
  "ConnectionStrings": {
    "DefaultConnection": "write connection string"
  },
  "EmailSettings": {
    "Uri": "https://api.eu.mailgun.net/v3",
    "ApiKey": "write ApiKey",
    "Domain": "eu.pta-events.co.uk",
    "From": "Excited User <mailgun@eu.pta-events.co.uk>"
  },
  "BlobSettings": {
    "ConnectionString": "YOUR_AZURE_BLOB_CONNECTION_STRING",
    "ContainerName": "YOUR_CONTAINER_NAME"
  },
  "ApplicationInsights": "take from Azure"
  },
  "AzureAdB2C": {
    "Instance": "take from Azure",
    "Domain": "take from Azure",
    "TenantId": "take from Azure",
    "ClientId": "take from Azure",
    "Scopes": [ "user.read", "gateway.read", "gateway.write" ],
    "CallbackPath": "/signout/B2C_1_sign_in_sign_up",
    "SignedOutCallbackPath": "",
    "SignUpSignInPolicyId": "B2C_1_sign_in_sign_up"
  }
}
```

# Build and Test
# Onboarding Controller
## Introduction
The OnboardingController is a pivotal component of our web application, responsible for handling various operations related to the onboarding process. This controller is designed to provide endpoints for the onboarding flow, including URL validation, organization onboarding, and email sending functionality.

## Endpoints
### URL Validation
Route: [POST] /url

This endpoint is used to validate URLs as part of the onboarding process. It accepts a JSON request containing a CheckUrlRequest object and performs URL validation, ensuring that the URL is unique. If the URL is valid and not already in use, it generates a list of URLs.

### Organization Onboarding
Route: [POST] /organisation

This endpoint is responsible for onboarding organizations. It accepts a JSON request containing an OnboardingFormDataDTO object, which includes details about the organization's branding and URL. It checks whether the provided URL is available and, if so, onboards the organization.

### Email Sending
Route: [POST] /sendemail

This endpoint allows sending emails by providing an email address as a query parameter. It invokes the email service to send an email to the specified address.

### Error Handling
The controller includes robust error handling to gracefully handle exceptions that may occur during the onboarding process. It logs errors and returns informative error messages to the client in case of any issues.

### URL Filtering
The controller utilizes URL filtering functions to sanitize and validate URLs, ensuring they adhere to a specific format and do not contain disallowed characters. This enhances the security and reliability of the onboarding process.

This OnboardingController plays a crucial role in the onboarding flow of our application, facilitating the smooth transition of organizations onto our platform.

# Report Controller
## Introduction
The Report Controller is part of our API application and is responsible for handling various report-related functionalities. This controller is secured with authorization to ensure that only authenticated users can access its endpoints. It provides a range of actions for generating and retrieving different types of reports, including PDFs, Excel files, CSV files, and more.

Authentication: The controller is decorated with the [Authorize] attribute, which requires users to be authenticated before accessing any of its endpoints. For authentication and authorization, we are using Azure B2C (Azure Active Directory B2C). This is a cloud service for managing user identities and accounts, allowing to implement security and access management in your application.

## Endpoints
### Data Report Endpoint
Route: [GET] /api/report/datareport: This endpoint is used to retrieve data reports based on a provided query. It accepts the following query parameters:
Type (string): Specifies the type of report to generate. This parameter determines the specific data to be retrieved and returned. Available report types include:
Mi Wizard Report
Customer Report
Order Report
Sale Report
Ticket Report
Volunteer Report
Booking Report
Product Question Horizontal Report
Product Question Vertical Report
Invoice Report
Treasurer by Date Report
Treasurer by Event Report
Banked Transaction Report
Child Only Booking Report
Email Tracker Report
Test Booking Report

### Random Booking Report
Count (integer, optional): Used for the "Random Booking Report" type to specify the number of random bookings to retrieve.

### Payment Methods Endpoint
Route: [GET] /api/report/paymentmethods: This endpoint is used to fetch payment methods. It does not require any additional query parameters.

### Test Banked Report Endpoint
Route: [GET] /api/report/testbankedreport: This endpoint is used to fetch a test banked report. It does not require any additional query parameters.

### Booking Products Endpoint
Route: [GET] /api/report/bookingproducts: This endpoint is used to fetch booking products. It accepts the following query parameters:
getBookingProductsRequest (object): A request object containing specific criteria for fetching booking products.

### Product Questions and Answers Endpoint
Route: [GET] /api/report/productquestionsandanswers: This endpoint is used to fetch product questions and answers. It accepts the following query parameters:
getProductQuestionsAndAnswersRequest (object): A request object containing specific criteria for fetching product questions and answers.

### Current Sales Report Endpoint
Route: [GET] /api/report/currentsales: This endpoint is used to fetch the current sales report for a specific product. It accepts the following query parameters:
getSalesReportForProductRequest (object): A request object containing criteria for fetching the current sales report.

### Last Orders Endpoint
Route: [GET] /api/report/lastorders: This endpoint is used to fetch the last orders report. It does not require any additional query parameters.

### Test Orders Endpoint
Route: [GET] /api/report/testorders: This endpoint is used to fetch test orders report. It does not require any additional query parameters.

### Common Live Sales Data Endpoint
Route: [GET] /api/report/commonlivesalesdata: This endpoint is used to fetch common live sales data. It does not require any additional query parameters.

### Current Live Sales Data Endpoint
Route: [GET] /api/report/currentlivesalesdata: This endpoint is used to fetch current live sales data for a specific product. It accepts the following query parameters:
productId (integer): Specifies the product for which to retrieve live sales data.

### Monthly Orders Data Endpoint
Route: [GET] /api/report/monthlyordersdata: This endpoint is used to fetch monthly orders data. It does not require any additional query parameters.

### Monthly Customer Registration Endpoint
Route: [GET] /api/report/monthlycustomerregistration: This endpoint is used to fetch monthly customer registration data. It does not require any additional query parameters.

### Booking Questions and Answers Endpoint
Route: [GET] /api/report/bookingquestionsandanswers: This endpoint is used to fetch booking questions and answers. It accepts the following query parameters:
getBookingQuestionsAndAnswersRequest (object): A request object containing criteria for fetching booking questions and answers.

### Organisation Data Endpoint
Route: [GET] /api/report/organisationdata: This endpoint is used to fetch organization data. It accepts the following query parameters:
organisationDataRequest (object): A request object containing criteria for fetching organization data.

### Blobs
The following endpoints are used to generate and retrieve reports in different formats (PDF, Excel, etc.) related to various aspects of our application:

/bankedspdf: Generates a banked report in PDF format.
/bankedsexcel: Generates a banked report in Excel format.
/bookingspdf: Generates a booking report in PDF format.
/bookingsexcel: Generates a booking report in Excel format.
/childonlybookingspdf: Generates a child-only booking report in PDF format.
/childonlybookingsexcel: Generates a child-only booking report in Excel format.
/customersexcel: Generates a customer report in Excel format.
/customerspdf: Generates a customer report in PDF format.
/ordersexcel: Generates an orders report in Excel format.
/orderspdf: Generates an orders report in PDF format.
/orderdeliverynotespdf: Generates an order delivery note report in PDF format.
/orderdeliverydocument: Generates an order delivery document in PDF format.
/productquestionsexcel: Generates a product questions report in Excel format.
/productquestionspdf: Generates a product questions report in PDF format.
/ticketsexcel: Generates a tickets report in Excel format.
/ticketspdf: Generates a tickets report in PDF format.
/ticketscsv: Generates a tickets report in CSV format.
/treasurerbydateexcel: Generates a treasurer by date report in Excel format.
/treasurerbydatepdf: Generates a treasurer by date report in PDF format.
/treasurerbyeventexcel: Generates a treasurer by event report in Excel format.
/treasurerbyeventpdf: Generates a treasurer by event report in PDF format.
/volunteerspdf: Generates a volunteers report in PDF format.

### Searching
The following endpoints allow searching for specific report data:

/emailtrackers: Retrieves email trackers report data based on query parameters.
/customers: Retrieves customer report data based on query parameters.
/orders: Retrieves order report data based on query parameters.
/treasurerbydate: Retrieves treasurer by date report data based on query parameters.
/childonlybookings: Retrieves child-only booking report data based on query parameters.
/tickets: Retrieves ticket report data based on query parameters.
/sales: Retrieves sales report data based on query parameters.

### Get Volunteers Filters
Route: [GET] /api/report/volunteersfilters: This endpoint is used to fetch filters for volunteers. It accepts query parameters for filtering volunteers and returns the filtered results.

### Sort Volunteers
Route: [GET] /api/report/sortvolunteers: This endpoint is used to sort volunteers based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Get Treasurer by Event Filters
Route: [GET] /api/report/treasurerbyeventfilters: This endpoint is used to fetch filters for treasurer by event reports. It accepts query parameters for filtering treasurer by event reports and returns the filtered results.

### Sort Treasurer by Event
Route: [GET] /api/report/sorttreasurerbyevent: This endpoint is used to sort treasurer by event reports based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Get Ticket Filters
Route: [GET] /api/report/ticketsfilters: This endpoint is used to fetch filters for tickets. It accepts query parameters for filtering tickets and returns the filtered results.

### Sort Tickets
Route: [GET] /api/report/sorttickets: This endpoint is used to sort tickets based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Get Sales Filters
Route: [GET] /api/report/salesfilters: This endpoint is used to fetch filters for sales. It accepts query parameters for filtering sales and returns the filtered results.

### Get Product Questions Filters
Route: [GET] /api/report/productquestionsfilters: This endpoint is used to fetch filters for product questions. It accepts query parameters for filtering product questions and returns the filtered results.

### Sort Product Questions
Route: [GET] /api/report/sortproductquestions: This endpoint is used to sort product questions based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Get Child Bookings Filters
Route: [GET] /api/report/childbookingsfilters: This endpoint is used to fetch filters for child bookings. It accepts query parameters for filtering child bookings and returns the filtered results.

### Sort Child Bookings
Route: [GET] /api/report/sortchildbookings: This endpoint is used to sort child bookings based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Get Bookings Filters
Route: [GET] /api/report/bookingsfilters: This endpoint is used to fetch filters for bookings. It accepts query parameters for filtering bookings and returns the filtered results.

### Sort Bookings
Route: [GET] /api/report/sortbookings: This endpoint is used to sort bookings based on specified criteria. It accepts query parameters for sorting and returns the sorted results.

### Remove User
Route: [DELETE] /api/report/removeuser: This endpoint is used to remove a user. It accepts a request to remove a user based on the provided UserId and ErasureDate.

### Toggle Approval User
Route: [PUT] /api/report/toggleapprovaluser: This endpoint is used to toggle the approval status of a user. It accepts a request to approve or unapprove a user based on the provided UserId and IsApprove flag.

### Mark as Not Dispatched Order
Route: [PUT] /api/report/markasnotdispatchedorder: This endpoint is used to mark an order as not dispatched. It accepts a request to mark an order as not dispatched based on the provided OrderId.

### Delete Order
Route: [DELETE] /api/report/deleteorder: This endpoint is used to delete an order. It accepts a request to delete an order based on the provided OrderId.

### Edit Booking
Route: [POST] /api/report/editbooking: This endpoint is used to edit a booking. It accepts a request to edit a booking with new details.

### Resend Confirmation Email for Order
Route: [POST] /api/report/resendconfirmationemailfororder: This endpoint is used to resend a confirmation email for an order. It accepts a request to resend the confirmation email for an order based on the provided details.

### Send Newsletter Email
Route: [POST] /api/report/sendnewsletteremail: This endpoint is used to send a newsletter email. It accepts a request to send a newsletter email for an order based on the provided details.

### Send Customer Email
Route: [POST] /api/report/sendcustomeremail: This endpoint is used to send a customer email. It accepts a request to send a customer email for an order based on the provided details.

# Contribute

- Introduce microservice architecture
- Add the missing tests
- Enforce coding style and conventions using linters
- Keep the project active and regularly update it with new features and bug fixes to demonstrate that it's actively maintained

# WebApplication(EventHub)-MicroServices(API)
 
Is an event manager website that allows users to create, browse, register and promote events. 


     It was built using Microservices architecture, Docker Linux containers, Swagger, Redis, RabbitMQ, IdentityServer4, ASP.NET Core 
     and C#.                                                

               List of API's and Containers in the project:
                         EventPicApi
                         EventCatalogApi
                         EventDetailsApi
                         TokenServiceApi
                         CartApi
                         OrderApi
                         OrderSummaryApi
                         WebMvc
                         Mssqlserver
                         RedisCache
                         RabbitMQ
     


Assignment 3a
YouTubelink: https://www.youtube.com/watch?v=DJ7ZB40gS6U
Another link: https://www.youtube.com/watch?v=Ad9Y6ICOFho&feature=youtu.be

    Microservice EventCatalog was created to the project, also added MSMSqL to load data for API's in microservice.
    WebMVC(Client for microservices) is added to the project which is to integrate with API's for User interface experience.
    TokenService API(microservice) is added to authenticate & authorize User's deatils.
    Microservice Cart was modified and it is using using RedisCache to save/update the user's cart and integrated with client(Web).
    Microservice Order was added to the project and saving all orders to MSSQL Database.
    Logging all the messages while creating cart and saving orders.
    Integrated with StripeAPI for test Payment.
    Created EventDetails API to view each catalog item with full details and integrated with client(Web).
    Created OrdersSummary API to view past and present orders and to view details of each order, also integrated with client(Web).
    Communication between services via messaging using RabbitMQ

Assignment 3b
Youtubelink: https://youtu.be/-EDA6RugJ_8

     All the project is Dockerized we are using 7 containers:
     eventcatalog
     eventcart
     order
     ordersummary
     tokenservice
     webmvc
     mssqlserver
     
   --> The TokenServiceAPI is integrated in the application and the user can register, login and logout from the app.
     

        The WebApp has 4 pages:

          Main Page(Events Catalog Page)
          Event Detail
          LoginPage
          Cart 
          Order Creation
          Order complete
          Order Summary Page -->
          Each order details page(Continuation Page of Order summary)
          Filter anything based on Location and event category
          LogOut page.





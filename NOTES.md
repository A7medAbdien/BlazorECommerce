# BlazorECommerce

This project is intended to be a full stack template for small businesses use cases,
that covers:

1. User Auth
2. CURD operations
3. Dockerizing
4. Deployment
5. Payment

This project was following this [course](https://www.udemy.com/course/blazor-ecommerce/)

## create Cart

1. add Local Storage package
2. create CartItem model
3. create a UI - button to add to cart (named CartCounter)
4. CartService on CLIENT side 
   1. event
   2. AddToCart
   3. GetCartItems
5. Turn CartItem to Products by calling SERVER - DTO
6. Create Cart page
7. Add RemoveProductFromCart
8. Add Quantity to Cart Model
9. Modify AddToCart in CartService
10. Add UpdateQuantity in CartService
11. Add UpdateQuantity UI


## user register

weirdly the instructor started from UI not Backend

**Instructor Approach:**

1. Register Form UI
2. MODEL-SERVER
3. FETCH-CLIENT - so here we edit the UI not creating it, maybe because its a POST

**Overall**

* SERVER: 
   1. receive email and password
   2. saves encoded password and email in the database
   3. return user id in the database
* CLIENT:
   1. posts email and password
   2. expects an id in return 


## User Login

1. Login form UI and MODEL
2. add our App Key Token in appsettings file
3. SERVER - receive email and password
   1. email: check if user exist
   2. password: uses key to check if the hashes are equal
   3. create tokens
4. CLIENT - post email and password and expect token(string) in return
 
## Cart form local storage to DB

purpose: migrating LS with DB -> 
1. store LS in DB
2. if user authorized? get its cart form db: get cart form LS

1. prepare/edit Model to have an Id - CartItem 
2. create the model table 
3. CLIENT: different behavior of AddToCart - un/authorized users
4. SERVER: add StoreCartItems to service and controller - args cartItems & userID, return cartItems as Products
5. CLIENT: add StoreCartItems to service - posts cartItems and empty LS
6. CLIENT: apply StoreCartItems on HandleLogin
7. SERVER: allow service to access authenticated user id

### get cart count from server

1. SERVER: add getCartCount function
2. CLIENT: fetch getCartCount
3. CLIENT: if user auth? get form SERVER: get from LS
4. CLIENT: apply getCartCount on GetCartItems, AddToCart, RemoveFromCart, HandleLogin and HandlesLogout 


8. SERVER: add GetDbCartProducts
9. CLIENT: fetch GetDbCartProducts - and he first merged GetCartItems with GetCartProducts, so if user auth? get from SERVER: get from LS
10. CLIENT: apply it on LoadCart  

TL;DR if user auth? get from SERVER: get from LS

# Qs

## Cart Implementation - is it ok to do a server call on each CRUD operation? 

I will do my best to make this question clear...

I am watching a tutorial about ECommerce Website with .Net Core - and the project is of type **Web Assembly Blazor** and I checked the .NET CORE Hosted, so the project spited to Client, Server and Sheared.

And the Cart model is consists of CartId, ProductId and UserId.

```c#
    public class CartItem
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;
    }
```

When the instructor implemented the Cart Model he was using the local storage only on the client side and he gets the Product details with a one server Call  

Server service

```c#
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
    }
```

Client service

```c#
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResponse>> GetCartProducts(); 
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductResponse product);
    }
```

So until now every thing make sense in my brian, all CURD operations are mainly on the Client side. But after he did the migration of local storage to the database. The CRUD operations are on both client and server side

Server service

```c#
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
        Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems);
        Task<ServiceResponse<int>> GetCartItemsCount();
        Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts();
        Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);
        Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);
        Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
```

Client service

```c#
public interface ICartService
{
   event Action OnChange;
   Task AddToCart(CartItem cartItem);
   Task<List<CartProductResponse>> GetCartProducts();
   Task RemoveProductFromCart(int productId, int productTypeId);
   Task UpdateQuantity(CartProductResponse product);
   Task StoreCartItems(bool emptyLocalCart);
   Task GetCartItemsCount();
}
```

My questions is:

Is that Ok/practical? having a call to the server on each cart change/update?

My suggestion: 

if we could update the server side on section ends or on checkout only, but i have no idea if this possible or not

# Archived post 

this is an E-Commerce website, too close to one of my last projects ProShop, but developed with .Net, SQL Server 2022, SSMS (SQL Server Management Studio) 19.1 and Payment via strip and the cart stored on server.

Thrilled to share a classic project, [ProShop](https://github.com/A7medAbdien/proshop) - an E-Commerce website developed using the MERN stack. Postman was utilized for testing and seamlessly integrating payment options. Although PayPal integration was effortless, it is unavailable in my region. However, Checkout and Tap are excellent alternatives worth exploring.

#MERNStack #React #Express #MongoDB #NodeJS #ECommerce #WebsiteDevelopment #APIIntegration #PaymentOptions #SecureTransactions #TechEnthusiasts

Blazor-ECommerce (E-Commerce website using .NET) 🔗
Problem: Manage store products and make them available online for customers to purchase.
Solution: An E-Commerce website with two roles: Admin and user/customer, allowing payment via Stripe.
Environment: Visual studio 2022, SQL Server 2022, SSMS (SQL Server Management Studio) 19.1.
Tools used: Blazer pages, Bootstrap, Swagger UI, Entity Framework.
Techniques: RESTful API, CRUD operations, Service Design Pattern, JWT (JSON Web Token).
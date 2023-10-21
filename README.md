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
 

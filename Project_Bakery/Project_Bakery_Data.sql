--ALTER TABLE OnlineCustomer ALTER COLUMN idCustomer varchar(255) autoincrement ;  
--ALTER TABLE OnlineCustomer AUTO_INCREMENT = ;
insert into Items values 
 (4, 'Chocolate Mint Cupcake', 150,1,'C:\Users\HP\OneDrive\Desktop\Project_Bakery\p2.jpg'),
 (5, 'Lemon Tart', 70,1,'C:\Users\HP\OneDrive\Desktop\Project_Bakery\p2.jpg'),
 (6, 'Chocolate Filled Croissant', 150,1,'C:\Users\HP\OneDrive\Desktop\Project_Bakery\p2.jpg'),
 (7, 'Banana Bread Loaf', 550,1,'C:\Users\HP\OneDrive\Desktop\Project_Bakery\p2.jpg');
 select * from Items;
/*0 for male, 1 for female */
SET ANSI_WARNINGS OFF; /*to avoid truncation of data */ 
insert into Employee values (101, 'Zoha Karim', 'Accountant', 23, 1) ,(102, 'Fahad Ahmed', 'Manager', 25, 0) , /*0 for male, 1 for female */ 
 (103, 'Amna Karim', 'Baker', 30, 1) ,
 (104, 'Samarah Asghar', 'Baker', 27, 1),
 (105, 'Mohammad Bilal', 'Baker', 26, 0) ,
 (106, 'Taha Ovais', 'Delivery Person', 26, 0), 
 (107, 'Danish Ahmed', 'Delivery Person', 27, 0),
(108, 'Zayn Mustafa', 'Delivery Person', 26, 0) ;/*done*/

SET ANSI_WARNINGS OFF; /*to avoid truncation of data */ 

insert into Ingredient values(1,'Flour', '2021-12-31','2021-07-09',300),
(2,'Baking Soda', '2022-07-31','2020-12-09',200),
(3,'Baking Powder', '2022-07-31','2020-12-09',200),
(4,'Cocoa Powder', '2022-12-31','2021-03-09',250),
(5,'Sugar', null ,'2021-11-09',250),
(6,'Brown Sugar', '2022-07-31','2021-07-09',350),
(7,'Vanilla Essence', '2022-07-31','2020-12-09',200);/*done*/

insert into Login1 values ('zoha_99', 'pass12'), ('fahad1', 'pass123'), ('bilal', 'pass1234');/*done*/


insert into OnlineCustomer values (1, 'Angila Rafiq', 'angila@gmail.com', '03002456876') ,
(2, 'Zaki Majid', 'zaki@hotmail.com', '03216483977') ,
 (3, 'Khizer Shahzad', 'khizer@gmail.com', '03333067088') ,
(4, 'Aaliyan Irshad', 'aliyaan99@gmail.com', '03006789345') ,
 (5, 'Momal Rauf', 'momal@yahoo.com', '03061101987') ,
 (5, 'Ovais Sattar', 'ovais00@yahoo.com', '030451101989') ;


insert into DeliveryPerson values (201,106,'Taha Ovais','03061101978'),
(202,107,'Danish Ahmed','03332654789'),
(203,106,'Zayn Mustafa','03214923837');/*done*/
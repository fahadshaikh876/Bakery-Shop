CREATE TABLE Items (
  idItems INTEGER   NOT NULL ,
  Name VARCHAR (50)   ,
  Price INTEGER    ,
  availabitlity BIT    ,
  Picture VARCHAR      ,
PRIMARY KEY(idItems));

CREATE TABLE Login1 (
  idLogin INTEGER IDENTITY(1,1) NOT NULL,
  User_Name varchar(50) NULL,
  Password1 varchar(50) NULL,
  PRIMARY KEY(idLogin)
);



CREATE TABLE Ingredient (
  idIngredient INTEGER   NOT NULL ,
  Name VARCHAR    ,
  Expiry_date DATE    ,
  Manufacturing_date DATE    ,
  Price INTEGER      ,
PRIMARY KEY(idIngredient));




CREATE TABLE order_status (
  Order_ID INTEGER   NOT NULL ,
  mystatus VARCHAR (50)   );




CREATE TABLE OnlineCustomer (
  idCustomer INTEGER   NOT NULL  ,
  Name VARCHAR   (50) ,
  Email VARCHAR (50)   ,
  Contact VARCHAR (50)      ,
PRIMARY KEY(idCustomer)  );




CREATE TABLE Employee (
  idEmployee INTEGER   NOT NULL ,
  Name VARCHAR  (50)  ,
  Position VARCHAR   (50) ,
  Age INTEGER    ,
  Gender BIT      ,
PRIMARY KEY(idEmployee));




CREATE TABLE DeliveryPerson (
  Ride_ID INTEGER   NOT NULL ,
  Employee_idEmployee INTEGER   NOT NULL ,
  Name VARCHAR  (50) NOT NULL ,
  Contact VARCHAR (50)      ,
PRIMARY KEY(Ride_ID)  ,
  FOREIGN KEY(Employee_idEmployee)
    REFERENCES Employee(idEmployee));


CREATE INDEX DeliveryPerson_FKIndex1 ON DeliveryPerson (Employee_idEmployee);


CREATE INDEX IFK_Rel_12 ON DeliveryPerson (Employee_idEmployee);


CREATE TABLE Items_has_Ingredient (
  Items_idItems INTEGER   NOT NULL ,
  Ingredient_idIngredient INTEGER   NOT NULL ,
  quantity FLOAT      ,
PRIMARY KEY(Items_idItems, Ingredient_idIngredient)    ,
  FOREIGN KEY(Items_idItems)
    REFERENCES Items(idItems),
  FOREIGN KEY(Ingredient_idIngredient)
    REFERENCES Ingredient(idIngredient));


CREATE INDEX Items_has_Ingredient_FKIndex1 ON Items_has_Ingredient (Items_idItems);
CREATE INDEX Items_has_Ingredient_FKIndex2 ON Items_has_Ingredient (Ingredient_idIngredient);


CREATE INDEX IFK_Rel_01 ON Items_has_Ingredient (Items_idItems);
CREATE INDEX IFK_Rel_02 ON Items_has_Ingredient (Ingredient_idIngredient);


CREATE TABLE DeliveryOrder (
  idDeliveryOrder INTEGER   NOT NULL ,
  DeliveryPerson_Ride_ID INTEGER   NOT NULL ,
  OnlineCustomer_idCustomer INTEGER   NOT NULL ,
  Dest_Address VARCHAR  (50)  ,
  Date_order_placed DATETIME    ,
  delivery_date DATETIME    ,
  Total_Amount FLOAT    ,
  payment_method VARCHAR   (50) ,
  Order_Status VARCHAR (50)   ,
  Rating INTEGER    ,
  Comments VARCHAR      ,
PRIMARY KEY(idDeliveryOrder)    ,
  FOREIGN KEY(OnlineCustomer_idCustomer)
    REFERENCES OnlineCustomer(idCustomer),
  FOREIGN KEY(DeliveryPerson_Ride_ID)
    REFERENCES DeliveryPerson(Ride_ID),
);


CREATE INDEX DeliveryOrder_FKIndex1 ON DeliveryOrder (OnlineCustomer_idCustomer);
CREATE INDEX DeliveryOrder_FKIndex2 ON DeliveryOrder (DeliveryPerson_Ride_ID);


CREATE INDEX IFK_Rel_04 ON DeliveryOrder (OnlineCustomer_idCustomer);
CREATE INDEX IFK_Rel_05 ON DeliveryOrder (DeliveryPerson_Ride_ID);



CREATE TABLE DeliveryOrder_has_Items (
  DeliveryOrder_idDeliveryOrder INTEGER   NOT NULL ,
  Items_idItems INTEGER   NOT NULL   ,
PRIMARY KEY(DeliveryOrder_idDeliveryOrder, Items_idItems)    ,
  FOREIGN KEY(DeliveryOrder_idDeliveryOrder)
    REFERENCES DeliveryOrder(idDeliveryOrder),
  FOREIGN KEY(Items_idItems)
    REFERENCES Items(idItems));


CREATE INDEX DeliveryOrder_has_Items_FKIndex1 ON DeliveryOrder_has_Items (DeliveryOrder_idDeliveryOrder);
CREATE INDEX DeliveryOrder_has_Items_FKIndex2 ON DeliveryOrder_has_Items (Items_idItems);


CREATE INDEX IFK_Rel_10 ON DeliveryOrder_has_Items (DeliveryOrder_idDeliveryOrder);
CREATE INDEX IFK_Rel_11 ON DeliveryOrder_has_Items (Items_idItems);



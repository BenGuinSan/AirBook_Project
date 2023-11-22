USE AIRBOOK;
GO

---
---
---
---
---
---ACTION TABLE
---

--region PROCEDURE dbo.usp_actions_Read
IF OBJECT_ID('dbo.usp_actions_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_actions_Read
END
GO
CREATE PROC dbo.usp_actions_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Action_ID, Action_name, Info, IsDelete
    FROM   dbo.actions

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_actions_Select
IF OBJECT_ID('dbo.usp_actions_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_actions_Select 
END
GO
CREATE PROC dbo.usp_actions_Select
    @Action_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Action_ID, Action_name, Info, IsDelete
    FROM   dbo.actions
    WHERE  Action_ID = @Action_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_actions_Insert
IF OBJECT_ID('dbo.usp_actions_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_actions_Insert
END 
GO
CREATE PROC dbo.usp_actions_Insert
    @Action_ID varchar(20),
    @Action_name nvarchar(max),
    @Info nvarchar(max),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.actions (Action_ID, Action_name, Info, IsDelete)
    SELECT @Action_ID, @Action_name, @Info, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Action_ID, Action_name, Info, IsDelete
    FROM   dbo.actions
    WHERE  Action_ID = @Action_ID AND Action_name = @Action_name AND Info = @Info AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_actions_Update
IF OBJECT_ID('dbo.usp_actions_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_actions_Update
END
GO
CREATE PROC dbo.usp_actions_Update
@Action_ID varchar(20),
@Action_name nvarchar(max),
@Info nvarchar(max),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.actions
    SET    Action_name = @Action_name, Info = @Info, IsDelete = @IsDelete
    WHERE  Action_ID = @Action_ID

    /*
    -- Begin Return row code block

    SELECT Action_name, Info, IsDelete
    FROM   dbo.actions
    WHERE  Action_ID = @Action_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_actions_Delete
IF OBJECT_ID('dbo.usp_actions_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_actions_Delete
END 
GO
CREATE PROC dbo.usp_actions_Delete
@Action_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.actions
    SET    IsDelete = 1
    WHERE  Action_ID = @Action_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---AIRLINE TABLE
---

--region PROCEDURE dbo.usp_airlines_Read
IF OBJECT_ID('dbo.usp_airlines_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airlines_Read
END
GO
CREATE PROC dbo.usp_airlines_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Airline_ID, Airline_name, IsDelete
    FROM   dbo.airlines

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airlines_Select
IF OBJECT_ID('dbo.usp_airlines_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airlines_Select 
END
GO
CREATE PROC dbo.usp_airlines_Select
    @Airline_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Airline_ID, Airline_name, IsDelete
    FROM   dbo.airlines
    WHERE  Airline_ID = @Airline_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airlines_Insert
IF OBJECT_ID('dbo.usp_airlines_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airlines_Insert
END 
GO
CREATE PROC dbo.usp_airlines_Insert
    @Airline_ID varchar(20),
    @Airline_name nvarchar(50),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.airlines (Airline_ID, Airline_name, IsDelete)
    SELECT @Airline_ID, @Airline_name, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Airline_ID, Airline_name, IsDelete
    FROM   dbo.airlines
    WHERE  Airline_ID = @Airline_ID AND Airline_name = @Airline_name AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airlines_Update
IF OBJECT_ID('dbo.usp_airlines_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airlines_Update
END
GO
CREATE PROC dbo.usp_airlines_Update
@Airline_ID varchar(20),
@Airline_name nvarchar(50),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airlines
    SET    Airline_name = @Airline_name, IsDelete = @IsDelete
    WHERE  Airline_ID = @Airline_ID

    /*
    -- Begin Return row code block

    SELECT Airline_name, IsDelete
    FROM   dbo.airlines
    WHERE  Airline_ID = @Airline_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airlines_Delete
IF OBJECT_ID('dbo.usp_airlines_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airlines_Delete
END 
GO
CREATE PROC dbo.usp_airlines_Delete
@Airline_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airlines
    SET    IsDelete = 1
    WHERE  Airline_ID = @Airline_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---AIRPORT GATES TABLE
---

--region PROCEDURE dbo.usp_airport_gates_Read
IF OBJECT_ID('dbo.usp_airport_gates_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airport_gates_Read 
END
GO
CREATE PROC dbo.usp_airport_gates_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Gate_ID, Airport_ID, Gate_name, IsDelete
    FROM   dbo.airport_gates

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airport_gates_Select
IF OBJECT_ID('dbo.usp_airport_gates_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airport_gates_Select 
END
GO
CREATE PROC dbo.usp_airport_gates_Select
    @Gate_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Gate_ID, Airport_ID, Gate_name, IsDelete
    FROM   dbo.airport_gates
    WHERE  Gate_ID = @Gate_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airport_gates_Insert
IF OBJECT_ID('dbo.usp_airport_gates_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airport_gates_Insert
END 
GO
CREATE PROC dbo.usp_airport_gates_Insert
    @Gate_ID varchar(20),
    @Airport_ID varchar(20),
    @Gate_name nvarchar(50),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.airport_gates (Gate_ID, Airport_ID, Gate_name, IsDelete)
    SELECT @Gate_ID, @Airport_ID, @Gate_name, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Gate_ID, Airport_ID, Gate_name, IsDelete
    FROM   dbo.airport_gates
    WHERE  Gate_ID = @Gate_ID AND Airport_ID = @Airport_ID AND Gate_name = @Gate_name AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airport_gates_Update
IF OBJECT_ID('dbo.usp_airport_gates_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airport_gates_Update
END
GO
CREATE PROC dbo.usp_airport_gates_Update
@Gate_ID varchar(20),
@Airport_ID varchar(20),
@Gate_name nvarchar(50),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airport_gates
    SET    Airport_ID = @Airport_ID, Gate_name = @Gate_name, IsDelete = @IsDelete
    WHERE  Gate_ID = @Gate_ID

    /*
    -- Begin Return row code block

    SELECT Airport_ID, Gate_name, IsDelete
    FROM   dbo.airport_gates
    WHERE  Gate_ID = @Gate_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airport_gates_Delete
IF OBJECT_ID('dbo.usp_airport_gates_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airport_gates_Delete
END 
GO
CREATE PROC dbo.usp_airport_gates_Delete
@Gate_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airport_gates
    SET    IsDelete = 1
    WHERE  Gate_ID = @Gate_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---AIRPORTS TABLE
---

--region PROCEDURE dbo.usp_airports_Read
IF OBJECT_ID('dbo.usp_airports_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airports_Read 
END
GO
CREATE PROC dbo.usp_airports_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Airport_ID, Airport_name, Province, IsDelete
    FROM   dbo.airports

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airports_Select
IF OBJECT_ID('dbo.usp_airports_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airports_Select 
END
GO
CREATE PROC dbo.usp_airports_Select
    @Airport_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Airport_ID, Airport_name, Province, IsDelete
    FROM   dbo.airports
    WHERE  Airport_ID = @Airport_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airports_Insert
IF OBJECT_ID('dbo.usp_airports_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airports_Insert
END 
GO
CREATE PROC dbo.usp_airports_Insert
    @Airport_ID varchar(20),
    @Airport_name nvarchar(50),
    @Province nvarchar(50),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.airports (Airport_ID, Airport_name, Province, IsDelete)
    SELECT @Airport_ID, @Airport_name, @Province, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Airport_ID, Airport_name, Province, IsDelete
    FROM   dbo.airports
    WHERE  Airport_ID = @Airport_ID AND Airport_name = @Airport_name AND Province = @Province AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airports_Update
IF OBJECT_ID('dbo.usp_airports_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airports_Update
END
GO
CREATE PROC dbo.usp_airports_Update
@Airport_ID varchar(20),
@Airport_name nvarchar(50),
@Province nvarchar(50),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airports
    SET    Airport_name = @Airport_name, Province = @Province, IsDelete = @IsDelete
    WHERE  Airport_ID = @Airport_ID

    /*
    -- Begin Return row code block

    SELECT Airport_name, Province, IsDelete
    FROM   dbo.airports
    WHERE  Airport_ID = @Airport_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_airports_Delete
IF OBJECT_ID('dbo.usp_airports_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_airports_Delete
END 
GO
CREATE PROC dbo.usp_airports_Delete
@Airport_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.airports
    SET    IsDelete = 1
    WHERE  Airport_ID = @Airport_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---FLIGHTS TABLE
---

--region PROCEDURE dbo.usp_flights_Read
IF OBJECT_ID('dbo.usp_flights_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_flights_Read 
END
GO
CREATE PROC dbo.usp_flights_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Flight_ID, Flying_from, Flying_to, Hours_fly, Departure_flight, IsDelete
    FROM   dbo.flights

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_flights_Select
IF OBJECT_ID('dbo.usp_flights_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_flights_Select 
END
GO
CREATE PROC dbo.usp_flights_Select
    @Flight_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Flight_ID, Flying_from, Flying_to, Hours_fly, Departure_flight, IsDelete
    FROM   dbo.flights
    WHERE  Flight_ID = @Flight_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_flights_Insert
IF OBJECT_ID('dbo.usp_flights_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_flights_Insert
END 
GO
CREATE PROC dbo.usp_flights_Insert
    @Flight_ID varchar(20),
    @Flying_from varchar(20),
    @Flying_to varchar(20),
    @Hours_fly int,
    @Departure_flight datetime,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.flights (Flight_ID, Flying_from, Flying_to, Hours_fly, Departure_flight, IsDelete)
    SELECT @Flight_ID, @Flying_from, @Flying_to, @Hours_fly, @Departure_flight, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Flight_ID, Flying_from, Flying_to, Hours_fly, Departure_flight, IsDelete
    FROM   dbo.flights
    WHERE  Flight_ID = @Flight_ID AND Flying_from = @Flying_from AND Flying_to = @Flying_to AND Hours_fly = @Hours_fly AND 
           Departure_flight = @Departure_flight AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_flights_Update
IF OBJECT_ID('dbo.usp_flights_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_flights_Update
END
GO
CREATE PROC dbo.usp_flights_Update
@Flight_ID varchar(20),
@Flying_from varchar(20),
@Flying_to varchar(20),
@Hours_fly int,
@Departure_flight datetime,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.flights
    SET    Flying_from = @Flying_from, Flying_to = @Flying_to, Hours_fly = @Hours_fly, Departure_flight = @Departure_flight, 
           IsDelete = @IsDelete
    WHERE  Flight_ID = @Flight_ID

    /*
    -- Begin Return row code block

    SELECT Flying_from, Flying_to, Hours_fly, Departure_flight, IsDelete
    FROM   dbo.flights
    WHERE  Flight_ID = @Flight_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_flights_Delete
IF OBJECT_ID('dbo.usp_flights_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_flights_Delete
END 
GO
CREATE PROC dbo.usp_flights_Delete
@Flight_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.flights
    SET    IsDelete = 1
    WHERE  Flight_ID = @Flight_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---MORE LUGGAGE TABLE
---

--region PROCEDURE dbo.usp_more_luggage_Read
IF OBJECT_ID('dbo.usp_more_luggage_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_more_luggage_Read
END
GO
CREATE PROC dbo.usp_more_luggage_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT More_luggage_ID, Airline_ID, Luggage_weight, Price, IsDelete
    FROM   dbo.more_luggage

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_more_luggage_Select
IF OBJECT_ID('dbo.usp_more_luggage_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_more_luggage_Select 
END
GO
CREATE PROC dbo.usp_more_luggage_Select
    @More_luggage_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT More_luggage_ID, Airline_ID, Luggage_weight, Price, IsDelete
    FROM   dbo.more_luggage
    WHERE  More_luggage_ID = @More_luggage_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_more_luggage_Insert
IF OBJECT_ID('dbo.usp_more_luggage_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_more_luggage_Insert
END 
GO
CREATE PROC dbo.usp_more_luggage_Insert
    @More_luggage_ID varchar(20),
    @Airline_ID varchar(20),
    @Luggage_weight int,
    @Price int,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.more_luggage (More_luggage_ID, Airline_ID, Luggage_weight, Price, IsDelete)
    SELECT @More_luggage_ID, @Airline_ID, @Luggage_weight, @Price, @IsDelete

    /*
    -- Begin Return row code block

    SELECT More_luggage_ID, Airline_ID, Luggage_weight, Price, IsDelete
    FROM   dbo.more_luggage
    WHERE  More_luggage_ID = @More_luggage_ID AND Airline_ID = @Airline_ID AND Luggage_weight = @Luggage_weight AND 
           Price = @Price AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_more_luggage_Update
IF OBJECT_ID('dbo.usp_more_luggage_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_more_luggage_Update
END
GO
CREATE PROC dbo.usp_more_luggage_Update
@More_luggage_ID varchar(20),
@Airline_ID varchar(20),
@Luggage_weight int,
@Price int,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.more_luggage
    SET    Airline_ID = @Airline_ID, Luggage_weight = @Luggage_weight, Price = @Price, IsDelete = @IsDelete
    WHERE  More_luggage_ID = @More_luggage_ID

    /*
    -- Begin Return row code block

    SELECT Airline_ID, Luggage_weight, Price, IsDelete
    FROM   dbo.more_luggage
    WHERE  More_luggage_ID = @More_luggage_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_more_luggage_Delete
IF OBJECT_ID('dbo.usp_more_luggage_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_more_luggage_Delete
END 
GO
CREATE PROC dbo.usp_more_luggage_Delete
@More_luggage_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.more_luggage
    SET    IsDelete = 1
    WHERE  More_luggage_ID = @More_luggage_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---ORDER DETAILS TABLE
---

--region PROCEDURE dbo.usp_order_details_Read
IF OBJECT_ID('dbo.usp_order_details_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_order_details_Read
END
GO
CREATE PROC dbo.usp_order_details_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Order_detail_ID, Order_ID, More_luggage_ID, Receiver_ID, Ticket_ID, Promo_ID
    FROM   dbo.order_details

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_order_details_Select
IF OBJECT_ID('dbo.usp_order_details_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_order_details_Select 
END
GO
CREATE PROC dbo.usp_order_details_Select
    @Order_detail_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Order_detail_ID, Order_ID, More_luggage_ID, Receiver_ID, Ticket_ID, Promo_ID
    FROM   dbo.order_details
    WHERE  Order_detail_ID = @Order_detail_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_order_details_Insert
IF OBJECT_ID('dbo.usp_order_details_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_order_details_Insert
END 
GO
CREATE PROC dbo.usp_order_details_Insert
    @Order_detail_ID varchar(20),
    @Order_ID varchar(20),
    @More_luggage_ID varchar(20),
    @Receiver_ID varchar(20),
    @Ticket_ID varchar(20),
    @Promo_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.order_details (Order_detail_ID, Order_ID, More_luggage_ID, Receiver_ID, Ticket_ID, 
                                   Promo_ID)
    SELECT @Order_detail_ID, @Order_ID, @More_luggage_ID, @Receiver_ID, @Ticket_ID, @Promo_ID

    /*
    -- Begin Return row code block

    SELECT Order_detail_ID, Order_ID, More_luggage_ID, Receiver_ID, Ticket_ID, Promo_ID
    FROM   dbo.order_details
    WHERE  Order_detail_ID = @Order_detail_ID AND Order_ID = @Order_ID AND More_luggage_ID = @More_luggage_ID AND 
           Receiver_ID = @Receiver_ID AND Ticket_ID = @Ticket_ID AND Promo_ID = @Promo_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_order_details_Update
IF OBJECT_ID('dbo.usp_order_details_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_order_details_Update
END
GO
CREATE PROC dbo.usp_order_details_Update
@Order_detail_ID varchar(20),
@Order_ID varchar(20),
@More_luggage_ID varchar(20),
@Receiver_ID varchar(20),
@Ticket_ID varchar(20),
@Promo_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.order_details
    SET    Order_ID = @Order_ID, More_luggage_ID = @More_luggage_ID, Receiver_ID = @Receiver_ID, Ticket_ID = @Ticket_ID, 
           Promo_ID = @Promo_ID
    WHERE  Order_detail_ID = @Order_detail_ID

    /*
    -- Begin Return row code block

    SELECT Order_ID, More_luggage_ID, Receiver_ID, Ticket_ID, Promo_ID
    FROM   dbo.order_details
    WHERE  Order_detail_ID = @Order_detail_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_order_details_Delete
IF OBJECT_ID('dbo.usp_order_details_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_order_details_Delete
END 
GO
CREATE PROC dbo.usp_order_details_Delete
@Order_detail_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    DELETE
    FROM   dbo.order_details
    WHERE  Order_detail_ID = @Order_detail_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---ORDER TABLE
---

--region PROCEDURE dbo.usp_orders_Read
IF OBJECT_ID('dbo.usp_orders_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_orders_Read
END
GO
CREATE PROC dbo.usp_orders_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Order_ID, User_ID, Date_order
    FROM   dbo.orders

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_orders_Select
IF OBJECT_ID('dbo.usp_orders_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_orders_Select 
END
GO
CREATE PROC dbo.usp_orders_Select
    @Order_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Order_ID, User_ID, Date_order
    FROM   dbo.orders
    WHERE  Order_ID = @Order_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_orders_Insert
IF OBJECT_ID('dbo.usp_orders_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_orders_Insert
END 
GO
CREATE PROC dbo.usp_orders_Insert
    @Order_ID varchar(20),
    @User_ID varchar(20),
    @Date_order datetime
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.orders (Order_ID, User_ID, Date_order)
    SELECT @Order_ID, @User_ID, @Date_order

    /*
    -- Begin Return row code block

    SELECT Order_ID, User_ID, Date_order
    FROM   dbo.orders
    WHERE  Order_ID = @Order_ID AND User_ID = @User_ID AND Date_order = @Date_order

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_orders_Update
IF OBJECT_ID('dbo.usp_orders_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_orders_Update
END
GO
CREATE PROC dbo.usp_orders_Update
@Order_ID varchar(20),
@User_ID varchar(20),
@Date_order datetime
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.orders
    SET    User_ID = @User_ID, Date_order = @Date_order
    WHERE  Order_ID = @Order_ID

    /*
    -- Begin Return row code block

    SELECT User_ID, Date_order
    FROM   dbo.orders
    WHERE  Order_ID = @Order_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_orders_Delete
IF OBJECT_ID('dbo.usp_orders_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_orders_Delete
END 
GO
CREATE PROC dbo.usp_orders_Delete
@Order_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    DELETE
    FROM   dbo.orders
    WHERE  Order_ID = @Order_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---PERMISSION TABLE
---

--region PROCEDURE dbo.usp_permission_Read
IF OBJECT_ID('dbo.usp_permission_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_permission_Read 
END
GO
CREATE PROC dbo.usp_permission_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Per_ID, Role_ID, Action_ID, Per_access, Per_create, Per_view, Per_edit, Per_delete, IsDelete
    FROM   dbo.permission

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_permission_Select
IF OBJECT_ID('dbo.usp_permission_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_permission_Select 
END
GO
CREATE PROC dbo.usp_permission_Select
    @Per_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Per_ID, Role_ID, Action_ID, Per_access, Per_create, Per_view, Per_edit, Per_delete, IsDelete
    FROM   dbo.permission
    WHERE  Per_ID = @Per_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_permission_Insert
IF OBJECT_ID('dbo.usp_permission_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_permission_Insert
END 
GO
CREATE PROC dbo.usp_permission_Insert
    @Per_ID varchar(20),
    @Role_ID varchar(20),
    @Action_ID varchar(20),
    @Per_access bit,
    @Per_create bit,
    @Per_view bit,
    @Per_edit bit,
    @Per_delete bit,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.permission (Per_ID, Role_ID, Action_ID, Per_access, Per_create, Per_view, Per_edit, 
                                Per_delete, IsDelete)
    SELECT @Per_ID, @Role_ID, @Action_ID, @Per_access, @Per_create, @Per_view, @Per_edit, @Per_delete, 
           @IsDelete

    /*
    -- Begin Return row code block

    SELECT Per_ID, Role_ID, Action_ID, Per_access, Per_create, Per_view, Per_edit, Per_delete, IsDelete
    FROM   dbo.permission
    WHERE  Per_ID = @Per_ID AND Role_ID = @Role_ID AND Action_ID = @Action_ID AND Per_access = @Per_access AND 
           Per_create = @Per_create AND Per_view = @Per_view AND Per_edit = @Per_edit AND Per_delete = @Per_delete AND 
           IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_permission_Update
IF OBJECT_ID('dbo.usp_permission_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_permission_Update
END
GO
CREATE PROC dbo.usp_permission_Update
@Per_ID varchar(20),
@Role_ID varchar(20),
@Action_ID varchar(20),
@Per_access bit,
@Per_create bit,
@Per_view bit,
@Per_edit bit,
@Per_delete bit,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.permission
    SET    Role_ID = @Role_ID, Action_ID = @Action_ID, Per_access = @Per_access, Per_create = @Per_create, 
           Per_view = @Per_view, Per_edit = @Per_edit, Per_delete = @Per_delete, IsDelete = @IsDelete
    WHERE  Per_ID = @Per_ID

    /*
    -- Begin Return row code block

    SELECT Role_ID, Action_ID, Per_access, Per_create, Per_view, Per_edit, Per_delete, IsDelete
    FROM   dbo.permission
    WHERE  Per_ID = @Per_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_permission_Delete
IF OBJECT_ID('dbo.usp_permission_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_permission_Delete
END 
GO
CREATE PROC dbo.usp_permission_Delete
@Per_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.permission
    SET    IsDelete = 1
    WHERE  Per_ID = @Per_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---PLANES TABLE
---

--region PROCEDURE dbo.usp_planes_Read
IF OBJECT_ID('dbo.usp_planes_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_planes_Read
END
GO
CREATE PROC dbo.usp_planes_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Plane_ID, Airline_ID, Plane_name, Seats, Plane_desc, IsDelete
    FROM   dbo.planes

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_planes_Select
IF OBJECT_ID('dbo.usp_planes_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_planes_Select 
END
GO
CREATE PROC dbo.usp_planes_Select
    @Plane_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Plane_ID, Airline_ID, Plane_name, Seats, Plane_desc, IsDelete
    FROM   dbo.planes
    WHERE  Plane_ID = @Plane_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_planes_Insert
IF OBJECT_ID('dbo.usp_planes_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_planes_Insert
END 
GO
CREATE PROC dbo.usp_planes_Insert
    @Plane_ID varchar(20),
    @Airline_ID varchar(20),
    @Plane_name nvarchar(50),
    @Seats int,
    @Plane_desc nvarchar(100),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.planes (Plane_ID, Airline_ID, Plane_name, Seats, Plane_desc, IsDelete)
    SELECT @Plane_ID, @Airline_ID, @Plane_name, @Seats, @Plane_desc, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Plane_ID, Airline_ID, Plane_name, Seats, Plane_desc, IsDelete
    FROM   dbo.planes
    WHERE  Plane_ID = @Plane_ID AND Airline_ID = @Airline_ID AND Plane_name = @Plane_name AND Seats = @Seats AND 
           Plane_desc = @Plane_desc AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_planes_Update
IF OBJECT_ID('dbo.usp_planes_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_planes_Update
END
GO
CREATE PROC dbo.usp_planes_Update
@Plane_ID varchar(20),
@Airline_ID varchar(20),
@Plane_name nvarchar(50),
@Seats int,
@Plane_desc nvarchar(100),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.planes
    SET    Airline_ID = @Airline_ID, Plane_name = @Plane_name, Seats = @Seats, Plane_desc = @Plane_desc, 
           IsDelete = @IsDelete
    WHERE  Plane_ID = @Plane_ID

    /*
    -- Begin Return row code block

    SELECT Airline_ID, Plane_name, Seats, Plane_desc, IsDelete
    FROM   dbo.planes
    WHERE  Plane_ID = @Plane_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_planes_Delete
IF OBJECT_ID('dbo.usp_planes_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_planes_Delete
END 
GO
CREATE PROC dbo.usp_planes_Delete
@Plane_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.planes
    SET    IsDelete = 1
    WHERE  Plane_ID = @Plane_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---PROMOTIONS TABLE
---

--region PROCEDURE dbo.usp_promotions_Read
IF OBJECT_ID('dbo.usp_promotions_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_promotions_Read
END
GO
CREATE PROC dbo.usp_promotions_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Promo_ID, Airline_ID, Promo_name, Promo_type, Date_start, Date_end, Decreased, IsDelete
    FROM   dbo.promotions

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_promotions_Select
IF OBJECT_ID('dbo.usp_promotions_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_promotions_Select 
END
GO
CREATE PROC dbo.usp_promotions_Select
    @Promo_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Promo_ID, Airline_ID, Promo_name, Promo_type, Date_start, Date_end, Decreased, IsDelete
    FROM   dbo.promotions
    WHERE  Promo_ID = @Promo_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_promotions_Insert
IF OBJECT_ID('dbo.usp_promotions_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_promotions_Insert
END 
GO
CREATE PROC dbo.usp_promotions_Insert
    @Promo_ID varchar(20),
    @Airline_ID varchar(20),
    @Promo_name nvarchar(200),
    @Promo_type int,
    @Date_start datetime,
    @Date_end datetime,
    @Decreased int,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.promotions (Promo_ID, Airline_ID, Promo_name, Promo_type, Date_start, Date_end, 
                                Decreased, IsDelete)
    SELECT @Promo_ID, @Airline_ID, @Promo_name, @Promo_type, @Date_start, @Date_end, @Decreased, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Promo_ID, Airline_ID, Promo_name, Promo_type, Date_start, Date_end, Decreased, IsDelete
    FROM   dbo.promotions
    WHERE  Promo_ID = @Promo_ID AND Airline_ID = @Airline_ID AND Promo_name = @Promo_name AND Promo_type = @Promo_type AND 
           Date_start = @Date_start AND Date_end = @Date_end AND Decreased = @Decreased AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_promotions_Update
IF OBJECT_ID('dbo.usp_promotions_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_promotions_Update
END
GO
CREATE PROC dbo.usp_promotions_Update
@Promo_ID varchar(20),
@Airline_ID varchar(20),
@Promo_name nvarchar(200),
@Promo_type int,
@Date_start datetime,
@Date_end datetime,
@Decreased int,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.promotions
    SET    Airline_ID = @Airline_ID, Promo_name = @Promo_name, Promo_type = @Promo_type, Date_start = @Date_start, 
           Date_end = @Date_end, Decreased = @Decreased, IsDelete = @IsDelete
    WHERE  Promo_ID = @Promo_ID

    /*
    -- Begin Return row code block

    SELECT Airline_ID, Promo_name, Promo_type, Date_start, Date_end, Decreased, IsDelete
    FROM   dbo.promotions
    WHERE  Promo_ID = @Promo_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_promotions_Delete
IF OBJECT_ID('dbo.usp_promotions_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_promotions_Delete
END 
GO
CREATE PROC dbo.usp_promotions_Delete
@Promo_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.promotions
    SET    IsDelete = 1
    WHERE  Promo_ID = @Promo_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---RECEIVERS TABLE
---

--region PROCEDURE dbo.usp_receivers_Read
IF OBJECT_ID('dbo.usp_receivers_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_receivers_Read 
END
GO
CREATE PROC dbo.usp_receivers_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Receiver_ID, Receiver_name, Gender, DoB, Receiver_address, Nation, Phone_number, CCCD, Email, User_ID, IsDelete
    FROM   dbo.receivers

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_receivers_Select
IF OBJECT_ID('dbo.usp_receivers_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_receivers_Select 
END
GO
CREATE PROC dbo.usp_receivers_Select
    @Receiver_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Receiver_ID, Receiver_name, Gender, DoB, Receiver_address, Nation, Phone_number, CCCD, Email, User_ID, IsDelete
    FROM   dbo.receivers
    WHERE  Receiver_ID = @Receiver_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_receivers_Insert
IF OBJECT_ID('dbo.usp_receivers_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_receivers_Insert
END 
GO
CREATE PROC dbo.usp_receivers_Insert
    @Receiver_ID varchar(20),
    @Receiver_name nvarchar(50),
    @Gender nvarchar(10),
    @DoB date,
    @Receiver_address nvarchar(100),
    @Nation nvarchar(20),
    @Phone_number varchar(11),
    @CCCD varchar(12),
    @Email varchar(50),
    @User_ID varchar(20),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.receivers (Receiver_ID, Receiver_name, Gender, DoB, Receiver_address, Nation, Phone_number, 
                               CCCD, Email, User_ID, IsDelete)
    SELECT @Receiver_ID, @Receiver_name, @Gender, @DoB, @Receiver_address, @Nation, @Phone_number, @CCCD, 
           @Email, @User_ID, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Receiver_ID, Receiver_name, Gender, DoB, Receiver_address, Nation, Phone_number, CCCD, Email, 
           User_ID, IsDelete
    FROM   dbo.receivers
    WHERE  Receiver_ID = @Receiver_ID AND Receiver_name = @Receiver_name AND Gender = @Gender AND DoB = @DoB AND 
           Receiver_address = @Receiver_address AND Nation = @Nation AND Phone_number = @Phone_number AND 
           CCCD = @CCCD AND Email = @Email AND User_ID = @User_ID AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_receivers_Update
IF OBJECT_ID('dbo.usp_receivers_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_receivers_Update
END
GO
CREATE PROC dbo.usp_receivers_Update
@Receiver_ID varchar(20),
@Receiver_name nvarchar(50),
@Gender nvarchar(10),
@DoB date,
@Receiver_address nvarchar(100),
@Nation nvarchar(20),
@Phone_number varchar(11),
@CCCD varchar(12),
@Email varchar(50),
@User_ID varchar(20),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.receivers
    SET    Receiver_name = @Receiver_name, Gender = @Gender, DoB = @DoB, Receiver_address = @Receiver_address, 
           Nation = @Nation, Phone_number = @Phone_number, CCCD = @CCCD, Email = @Email, User_ID = @User_ID, 
           IsDelete = @IsDelete
    WHERE  Receiver_ID = @Receiver_ID

    /*
    -- Begin Return row code block

    SELECT Receiver_name, Gender, DoB, Receiver_address, Nation, Phone_number, CCCD, Email, User_ID, 
           IsDelete
    FROM   dbo.receivers
    WHERE  Receiver_ID = @Receiver_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_receivers_Delete
IF OBJECT_ID('dbo.usp_receivers_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_receivers_Delete
END 
GO
CREATE PROC dbo.usp_receivers_Delete
@Receiver_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.receivers
    SET    IsDelete = 1
    WHERE  Receiver_ID = @Receiver_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---ROLES TABLE
---

--region PROCEDURE dbo.usp_roles_Read
IF OBJECT_ID('dbo.usp_roles_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_roles_Read
END
GO
CREATE PROC dbo.usp_roles_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Role_ID, Role_name, IsDelete
    FROM   dbo.roles

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_roles_Select
IF OBJECT_ID('dbo.usp_roles_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_roles_Select
END
GO
CREATE PROC dbo.usp_roles_Select
    @Role_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Role_ID, Role_name, IsDelete
    FROM   dbo.roles
	WHERE Role_ID = @Role_ID

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_roles_Insert
IF OBJECT_ID('dbo.usp_roles_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_roles_Insert
END 
GO
CREATE PROC dbo.usp_roles_Insert
    @Role_ID varchar(20),
    @Role_name nvarchar(200),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.roles (Role_ID, Role_name, IsDelete)
    SELECT @Role_ID, @Role_name, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Role_ID, Role_name, IsDelete
    FROM   dbo.roles
    WHERE  Role_ID = @Role_ID AND Role_name = @Role_name AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_roles_Update
IF OBJECT_ID('dbo.usp_roles_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_roles_Update
END
GO
CREATE PROC dbo.usp_roles_Update
@Role_ID varchar(20),
@Role_name nvarchar(200),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.roles
    SET    Role_name = @Role_name, IsDelete = @IsDelete
    WHERE  Role_ID = @Role_ID

    /*
    -- Begin Return row code block

    SELECT Role_name, IsDelete
    FROM   dbo.roles
    WHERE  Role_ID = @Role_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_roles_Delete
IF OBJECT_ID('dbo.usp_roles_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_roles_Delete
END 
GO
CREATE PROC dbo.usp_roles_Delete
@Role_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.roles
    SET    IsDelete = 1
    WHERE  Role_ID = @Role_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---SEATS TABLE
---

--region PROCEDURE dbo.usp_seats_Read
IF OBJECT_ID('dbo.usp_seats_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_seats_Read
END
GO
CREATE PROC dbo.usp_seats_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Seat_ID, Ticket_class_ID, Seat_name, IsDelete
    FROM   dbo.seats

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_seats_Select
IF OBJECT_ID('dbo.usp_seats_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_seats_Select 
END
GO
CREATE PROC dbo.usp_seats_Select
    @Seat_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Seat_ID, Ticket_class_ID, Seat_name, IsDelete
    FROM   dbo.seats
    WHERE  Seat_ID = @Seat_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_seats_Insert
IF OBJECT_ID('dbo.usp_seats_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_seats_Insert
END 
GO
CREATE PROC dbo.usp_seats_Insert
    @Seat_ID varchar(20),
    @Ticket_class_ID varchar(20),
    @Seat_name nvarchar(10),
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.seats (Seat_ID, Ticket_class_ID, Seat_name, IsDelete)
    SELECT @Seat_ID, @Ticket_class_ID, @Seat_name, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Seat_ID, Ticket_class_ID, Seat_name, IsDelete
    FROM   dbo.seats
    WHERE  Seat_ID = @Seat_ID AND Ticket_class_ID = @Ticket_class_ID AND Seat_name = @Seat_name AND 
           IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_seats_Update
IF OBJECT_ID('dbo.usp_seats_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_seats_Update
END
GO
CREATE PROC dbo.usp_seats_Update
@Seat_ID varchar(20),
@Ticket_class_ID varchar(20),
@Seat_name nvarchar(10),
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.seats
    SET    Ticket_class_ID = @Ticket_class_ID, Seat_name = @Seat_name, IsDelete = @IsDelete
    WHERE  Seat_ID = @Seat_ID

    /*
    -- Begin Return row code block

    SELECT Ticket_class_ID, Seat_name, IsDelete
    FROM   dbo.seats
    WHERE  Seat_ID = @Seat_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_seats_Delete
IF OBJECT_ID('dbo.usp_seats_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_seats_Delete
END 
GO
CREATE PROC dbo.usp_seats_Delete
@Seat_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.seats
    SET    IsDelete = 1
    WHERE  Seat_ID = @Seat_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---TICKET CLASSES TABLE
---

--region PROCEDURE dbo.usp_ticket_classes_Read
IF OBJECT_ID('dbo.usp_ticket_classes_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_ticket_classes_Read
END
GO
CREATE PROC dbo.usp_ticket_classes_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Ticket_class_ID, Plane_ID, Class_name, Seats_quantity, IsDelete
    FROM   dbo.ticket_classes

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_ticket_classes_Select
IF OBJECT_ID('dbo.usp_ticket_classes_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_ticket_classes_Select 
END
GO
CREATE PROC dbo.usp_ticket_classes_Select
    @Ticket_class_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Ticket_class_ID, Plane_ID, Class_name, Seats_quantity, IsDelete
    FROM   dbo.ticket_classes
    WHERE  Ticket_class_ID = @Ticket_class_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_ticket_classes_Insert
IF OBJECT_ID('dbo.usp_ticket_classes_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_ticket_classes_Insert
END 
GO
CREATE PROC dbo.usp_ticket_classes_Insert
    @Ticket_class_ID varchar(20),
    @Plane_ID varchar(20),
    @Class_name nvarchar(50),
    @Seats_quantity int,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.ticket_classes (Ticket_class_ID, Plane_ID, Class_name, Seats_quantity, IsDelete)
    SELECT @Ticket_class_ID, @Plane_ID, @Class_name, @Seats_quantity, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Ticket_class_ID, Plane_ID, Class_name, Seats_quantity, IsDelete
    FROM   dbo.ticket_classes
    WHERE  Ticket_class_ID = @Ticket_class_ID AND Plane_ID = @Plane_ID AND Class_name = @Class_name AND 
           Seats_quantity = @Seats_quantity AND IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_ticket_classes_Update
IF OBJECT_ID('dbo.usp_ticket_classes_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_ticket_classes_Update
END
GO
CREATE PROC dbo.usp_ticket_classes_Update
@Ticket_class_ID varchar(20),
@Plane_ID varchar(20),
@Class_name nvarchar(50),
@Seats_quantity int,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.ticket_classes
    SET    Plane_ID = @Plane_ID, Class_name = @Class_name, Seats_quantity = @Seats_quantity, IsDelete = @IsDelete
    WHERE  Ticket_class_ID = @Ticket_class_ID

    /*
    -- Begin Return row code block

    SELECT Plane_ID, Class_name, Seats_quantity, IsDelete
    FROM   dbo.ticket_classes
    WHERE  Ticket_class_ID = @Ticket_class_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_ticket_classes_Delete
IF OBJECT_ID('dbo.usp_ticket_classes_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_ticket_classes_Delete
END 
GO
CREATE PROC dbo.usp_ticket_classes_Delete
@Ticket_class_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.ticket_classes
    SET    IsDelete = 1
    WHERE  Ticket_class_ID = @Ticket_class_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---TICKETS TABLE
---

--region PROCEDURE dbo.usp_tickets_Read
IF OBJECT_ID('dbo.usp_tickets_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_tickets_Read
END
GO
CREATE PROC dbo.usp_tickets_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Ticket_ID, Flight_ID, Gate_ID, Seat_ID, Import_price, Selling_price, Sold_out, IsDelete
    FROM   dbo.tickets

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_tickets_Select
IF OBJECT_ID('dbo.usp_tickets_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_tickets_Select 
END
GO
CREATE PROC dbo.usp_tickets_Select
    @Ticket_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT Ticket_ID, Flight_ID, Gate_ID, Seat_ID, Import_price, Selling_price, Sold_out, IsDelete
    FROM   dbo.tickets
    WHERE  Ticket_ID = @Ticket_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_tickets_Insert
IF OBJECT_ID('dbo.usp_tickets_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_tickets_Insert
END 
GO
CREATE PROC dbo.usp_tickets_Insert
    @Ticket_ID varchar(20),
    @Flight_ID varchar(20),
    @Gate_ID varchar(20),
    @Seat_ID varchar(20),
    @Import_price int,
    @Selling_price int,
    @Sold_out bit,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.tickets (Ticket_ID, Flight_ID, Gate_ID, Seat_ID, Import_price, Selling_price, Sold_out, 
                             IsDelete)
    SELECT @Ticket_ID, @Flight_ID, @Gate_ID, @Seat_ID, @Import_price, @Selling_price, @Sold_out, @IsDelete

    /*
    -- Begin Return row code block

    SELECT Ticket_ID, Flight_ID, Gate_ID, Seat_ID, Import_price, Selling_price, Sold_out, IsDelete
    FROM   dbo.tickets
    WHERE  Ticket_ID = @Ticket_ID AND Flight_ID = @Flight_ID AND Gate_ID = @Gate_ID AND Seat_ID = @Seat_ID AND 
           Import_price = @Import_price AND Selling_price = @Selling_price AND Sold_out = @Sold_out AND 
           IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_tickets_Update
IF OBJECT_ID('dbo.usp_tickets_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_tickets_Update
END
GO
CREATE PROC dbo.usp_tickets_Update
@Ticket_ID varchar(20),
@Flight_ID varchar(20),
@Gate_ID varchar(20),
@Seat_ID varchar(20),
@Import_price int,
@Selling_price int,
@Sold_out bit,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.tickets
    SET    Flight_ID = @Flight_ID, Gate_ID = @Gate_ID, Seat_ID = @Seat_ID, Import_price = @Import_price, 
           Selling_price = @Selling_price, Sold_out = @Sold_out, IsDelete = @IsDelete
    WHERE  Ticket_ID = @Ticket_ID

    /*
    -- Begin Return row code block

    SELECT Flight_ID, Gate_ID, Seat_ID, Import_price, Selling_price, Sold_out, IsDelete
    FROM   dbo.tickets
    WHERE  Ticket_ID = @Ticket_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_tickets_Delete
IF OBJECT_ID('dbo.usp_tickets_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_tickets_Delete
END 
GO
CREATE PROC dbo.usp_tickets_Delete
@Ticket_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.tickets
    SET    IsDelete = 1
    WHERE  Ticket_ID = @Ticket_ID

    COMMIT
GO
--endregion

---
---
---
---
---
---USERS TABLE
---

--region PROCEDURE dbo.usp_users_Read
IF OBJECT_ID('dbo.usp_users_Read') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_users_Read
END
GO
CREATE PROC dbo.usp_users_Read
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT User_ID, Role_ID, Username, Pwd, Real_name, DoB, Gender, Nation, User_address, Phone_number, CCCD, Email, Date_create, IsDelete
    FROM   dbo.users

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_users_Select
IF OBJECT_ID('dbo.usp_users_Select') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_users_Select 
END
GO
CREATE PROC dbo.usp_users_Select
    @User_ID varchar(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    SELECT User_ID, Role_ID, Username, Pwd, Real_name, DoB, Gender, Nation, User_address, Phone_number, CCCD, Email, Date_create, IsDelete
    FROM   dbo.users
    WHERE  User_ID = @User_ID 

    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_users_Insert
IF OBJECT_ID('dbo.usp_users_Insert') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_users_Insert
END 
GO
CREATE PROC dbo.usp_users_Insert
    @User_ID varchar(20),
    @Role_ID varchar(20),
    @Username varchar(20),
    @Pwd varchar(max),
    @Real_name nvarchar(50),
    @DoB date,
    @Gender nvarchar(10),
    @Nation nvarchar(20),
    @User_address nvarchar(100),
    @Phone_number varchar(11),
    @CCCD varchar(12),
    @Email varchar(50),
    @Date_create datetime,
    @IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    INSERT INTO dbo.users (User_ID, Role_ID, Username, Pwd, Real_name, DoB, Gender, Nation, User_address, 
                           Phone_number, CCCD, Email, Date_create, IsDelete)
    SELECT @User_ID, @Role_ID, @Username, @Pwd, @Real_name, @DoB, @Gender, @Nation, @User_address, @Phone_number, 
           @CCCD, @Email, @Date_create, @IsDelete

    /*
    -- Begin Return row code block

    SELECT User_ID, Role_ID, Username, Pwd, Real_name, DoB, Gender, Nation, User_address, Phone_number, 
           CCCD, Email, Date_create, IsDelete
    FROM   dbo.users
    WHERE  User_ID = @User_ID AND Role_ID = @Role_ID AND Username = @Username AND Pwd = @Pwd AND Real_name = @Real_name AND 
           DoB = @DoB AND Gender = @Gender AND Nation = @Nation AND User_address = @User_address AND 
           Phone_number = @Phone_number AND CCCD = @CCCD AND Email = @Email AND Date_create = @Date_create AND 
           IsDelete = @IsDelete

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_users_Update
IF OBJECT_ID('dbo.usp_users_Update') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_users_Update
END
GO
CREATE PROC dbo.usp_users_Update
@User_ID varchar(20),
@Role_ID varchar(20),
@Username varchar(20),
@Pwd varchar(max),
@Real_name nvarchar(50),
@DoB date,
@Gender nvarchar(10),
@Nation nvarchar(20),
@User_address nvarchar(100),
@Phone_number varchar(11),
@CCCD varchar(12),
@Email varchar(50),
@Date_create datetime,
@IsDelete bit
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.users
    SET    Role_ID = @Role_ID, Username = @Username, Pwd = @Pwd, Real_name = @Real_name, DoB = @DoB, 
           Gender = @Gender, Nation = @Nation, User_address = @User_address, Phone_number = @Phone_number, 
           CCCD = @CCCD, Email = @Email, Date_create = @Date_create, IsDelete = @IsDelete
    WHERE  User_ID = @User_ID

    /*
    -- Begin Return row code block

    SELECT Role_ID, Username, Pwd, Real_name, DoB, Gender, Nation, User_address, Phone_number, CCCD, 
           Email, Date_create, IsDelete
    FROM   dbo.users
    WHERE  User_ID = @User_ID

    -- End Return row code block

    */
    COMMIT
GO
--endregion

--region PROCEDURE dbo.usp_users_Delete
IF OBJECT_ID('dbo.usp_users_Delete') IS NOT NULL
BEGIN 
    DROP PROC dbo.usp_users_Delete
END 
GO
CREATE PROC dbo.usp_users_Delete
@User_ID varchar(20)
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRAN

    UPDATE dbo.users
    SET    IsDelete = 1
    WHERE  User_ID = @User_ID

    COMMIT
GO
--endregion
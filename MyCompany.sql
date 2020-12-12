if OBJECT_ID('sfe_positions') is not null
    drop table sfe_positions
go
create table sfe_positions(
    code varchar(10) not null primary key,
    name varchar(255) not null,
    description VARCHAR(max)
)

insert into sfe_positions VALUES
('admin', 'Administrador', 'privilegios completos'),
('manager', 'Gerente', 'privilegios de control a usuarios'),
('accounting', 'Contador', 'privilegios minimos')
go

IF OBJECT_ID('sfe_position_all') is not NULL
    drop proc sfe_position_all
GO
CREATE PROC sfe_position_all
as
    select
        code,
        name,
        description
    from sfe_positions
go

-------------
if OBJECT_ID('sfe_employees') is not null
drop table sfe_employees
go
create table sfe_employees(
    username varchar(50) not null primary key, 
    dni varchar (8) unique not null,
    first_name varchar(80) not null,
    last_name varchar(150) not null,
    email varchar(150) not null,
    birthday date,
    state VARCHAR(15),
    position_code varchar(10) not null,
    created_at datetime not null,
    updated_at datetime not null
)
insert into sfe_employees values
('juan', '65875422','Juan Gabriel', 'Gonzales','Juan@gmail.com','24/05/1995', 'Activo', 'admin', GETDATE(), GETDATE()),
('gonzalo', '10872893','Gonazalo', 'Perez','Gonazalo@gmail.com','20/05/1996', 'Activo', 'accounting', GETDATE(), GETDATE()),
('marta','00875424','Marta', 'Ccama','Marta@gmail.com','15/09/1986', 'Activo', 'manager', GETDATE(), GETDATE()),
('lisandro','22875413','Lisandro', 'Mojo','Lisandro@gmail.com','14/05/1989', 'Activo', 'accounting', GETDATE(), GETDATE()),
('anna','45875481','Anna Maria', 'Paredes','Anna@gmail.com','21/03/1993', 'Activo', 'accounting', GETDATE(), GETDATE())

go

if OBJECT_ID('sfe_employee_insert') is not NULL
drop proc sfe_employee_insert
go
create proc sfe_employee_insert
    @username varchar(50),
    @dni varchar (8),
    @first_name varchar(80),
    @last_name varchar(150),
    @email varchar(150),
    @birthday date,
    @state VARCHAR(15),
    @position_code varchar(10)
AS
    INSERT into sfe_employees
    (username, dni, first_name, last_name, email, birthday, state, position_code, created_at, updated_at)
    VALUES
    (@username, @dni, @first_name, @last_name, @email, @birthday, @state, @position_code, GETDATE(), GETDATE())
go

if OBJECT_ID('sfe_employee_update') is not NULL
    drop proc sfe_employee_update
go
create proc sfe_employee_update
    @username varchar(50),
    @dni varchar (8),
    @first_name varchar(80),
    @last_name varchar(150),
    @email varchar(150),
    @state VARCHAR(15),
    @birthday date
AS
    UPDATE sfe_employees SET
        dni = @dni,
        first_name = @first_name,
        last_name = @last_name,
        email = @email,
        birthday = @birthday,
        updated_at = GETDATE()
    WHERE username = @username
go

if OBJECT_ID('sfe_employee_delete') is not NULL
    drop proc sfe_employee_delete
go
create proc sfe_employee_delete
    @username varchar(50)
AS
    UPDATE sfe_employees SET
        state = 'Inactivo'
    WHERE username = @username
go

if OBJECT_ID('sfe_employee_all') is not NULL
    drop proc sfe_employee_all
go
create proc sfe_employee_all
AS
    SELECT
        username,
        dni,
        first_name,
        last_name,
        email,
        birthday,
        state,
        position_code,
        p.name as position,
        created_at,
        updated_at
    FROM sfe_employees e
    INNER JOIN sfe_positions p ON e.position_code = p.code
    WHERE [state] = 'Activo'
go

----------------
if OBJECT_ID('sfe_users') is not NULL
    drop table sfe_users
GO
create table sfe_users(
    username varchar(50),
    password VARCHAR(max)
)

insert into sfe_users values
('juan', '5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8'),
('gonzalo', '5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8'),
('marta', '5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8'),
('lisandro', '5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8'),
('anna', '5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8')

if OBJECT_ID('sfe_login') is not NULL
    drop proc sfe_login
GO
create proc sfe_login
    @username varchar(50),
    @password VARCHAR(max)
AS
    select
        TOP 1
        u.username,
        e.dni,
        e.first_name,
        e.last_name,
        e.email,
        e.birthday,
        e.state,
        e.position_code,
        p.name AS position
    from sfe_users u
    INNER JOIN sfe_employees e ON u.username = e.username
    INNER JOIN sfe_positions p ON e.position_code = p.code
    WHERE u.username = @username AND u.[password] = @password
go

exec sfe_login 'anna', 'password'
GO

Create PROC RegistroProveedor(
@NombreProveedor varchar(50),
@Telefono varchar(50),
@Direccion varchar(50),
@Email varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
    SET @Resultado = 0
    DECLARE @IdProveedor INT 
    IF NOT EXISTS (SELECT * FROM Proveedor WHERE NombreProveedor = @NombreProveedor)
    begin
        insert into Proveedor(NombreProveedor,Telefono,Direccion,Email) values (
        NombreProveedor,Telefono,Direccion,Email)
        set @Resultado = SCOPE_IDENTITY()
        end
        else
        set @Mensaje = 'El nombre ya existe'
        end
GO

Create PROC ModificarProveedor(
@IdProveedor int,
@NombreProveedor varchar(50),
@Telefono varchar(50),
@Direccion varchar(50),
@Email varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
    SET @Resultado = 1 
    DECLARE @IdProveedor INT 
    IF NOT EXISTS (SELECT * FROM Proveedor WHERE NombreProveedor = @NombreProveedor and IdProveedor != @IdProveedor)
    begin
    update Proveedor set 
    NombreProveedor = @NombreProveedor,
    Telefono = @Telefono,
    Direccion = @Direccion,
    Email = @Email
    where IdProveedor = @IdProveedor
    end
    else
    begin
    SET @Resultado = 0
    set @Mensaje = 'El nombre ya existe'
    end
end

GO

Create procedure EliminarProveedor(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
    SET @Resultado = 1
    IF NOT EXISTS (
    select * from Proveedor p
    inner join Compra c on p.IdProveedor = c.IdProveedor
    where p.IdProveedor = @IdProveedor
    )
    begin
 delete top(1) from Proveedor where IdProveedor = @IdProveedor
 end
 else
 begin
    SET @Resultado = 0
    SET @Mensaje = 'El Proveedor se encuentra relacionando una compra'
    end
 end
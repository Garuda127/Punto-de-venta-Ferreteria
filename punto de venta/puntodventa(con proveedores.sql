use ferreteria;
insert into categorias (Nombre)
values ('Material electrico');

insert into categorias (Nombre)
values ('Material para plomeria');

insert into categorias (Nombre)
values ('Hogar');

insert into categorias (Nombre)
values ('Jardin');

insert into categorias (Nombre)
values ('Proteccion');

select * from categorias;

select * from productos;

select * from productos where Nombre = 'Pilas ';

Delete  from productos where ID_producto = 3;

update productos set ID_Categorias = 2 where ID_producto = 5;

insert into productos(ID_producto,ID_Categorias,Nombre,Marca,Precio,Descripcion,InVentario)
values (1,2,'Clavija','Voltek',10.0,'Clavija plastica, negra, Voltek',10);

insert into productos(ID_producto,ID_Categorias,Nombre,Marca,Precio,Descripcion,InVentario)
values (2,3,'Tubo CPVC','Flowguard',110.0,'Tubo CPVC 1/2", azul, Flowguard',25);

insert into productos(ID_producto,ID_Categorias,Nombre,Marca,Precio,Descripcion,InVentario)
values (3,4,'Pilas AA','Voltek',12.0,'Pila alcalina AA, Voltek',20);
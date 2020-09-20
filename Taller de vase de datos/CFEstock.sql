create database CFE;
use CFE;

create table stock(
    Id int(11)  not null,
    Id_fusibles int(11) not null,
    Id_Paquete int(11) not null,
    Diponibles int(11) not null,
    primary key (Id))
    engine=innodb;

create table paquete(
    Id int(11)  not null,
    contenido int(11) not null,
    Surtido int(11) not null,
    primary key (Id))
    engine=innodb;

 
create table fusibles(
    Id int(11) not null,
    capacidad VARCHAR(32) not null,
    id_cuadrilla int(11) not null,
     primary key (Id))
    engine=innodb;


create table cuadrillas(
    id int(11) not null,
    capacidad VARCHAR(32) not null,
    Id_Stock int(11) not null,
    mes VARCHAR(32) not null,
    Cantidades int(16) not null,
    unidades int(16) not null,
     primary key (Id))
    engine=innodb;

alter table cuadrillas add foreign key(Id_Stock)
references  stock(Id)
ON UPDATE CASCADE ON DELETE CASCADE;

alter table cuadrillas drop id_fusibles;
alter table cuadrillas drop foreign key cuadrillas_ibfk_2;

 INSERT INTO paquete(Id,contenido,Surtido) VALUES(1,1,3);

 INSERT INTO  cuadrillas(id,capacidad,Id_Stock,mes,Cantidades,unidades) VALUES(51,1,1,"ago",1,3);
 INSERT INTO  cuadrillas(id,capacidad,Id_Stock,mes,Cantidades,unidades) VALUES(52,1,2,"Julio",1,3);
 INSERT INTO  cuadrillas(id,capacidad,Id_Stock,mes,Cantidades,unidades) VALUES(53,2,3,"Julio",2,6);


INSERT INTO  fusibles(Id,capacidad,id_cuadrilla) VALUES(151,"1/2 AMP 15KV",51);
 INSERT INTO  fusibles(Id,capacidad,id_cuadrilla) VALUES(152,"3/4 AMP 15KV",52);
 INSERT INTO  fusibles(Id,capacidad,id_cuadrilla) VALUES(153,"1/2 AMP 15KV",53);


 INSERT INTO  stock(id,Id_fusibles,Id_Paquete,Diponibles) VALUES(1,151,1,1);
 INSERT INTO  stock(id,Id_fusibles,Id_Paquete,Diponibles) VALUES(2,152,1,1);
 INSERT INTO  stock(id,Id_fusibles,Id_Paquete,Diponibles) VALUES(3,153,1,1);
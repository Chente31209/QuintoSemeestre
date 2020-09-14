 alter table pedidos add foreign key(idCliente)
    references cliente(id)
    on delete cascade on update cascade;

    
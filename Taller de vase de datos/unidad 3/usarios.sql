CREATE USER 'sasha'@'localhost' identified by 'sashaPw'
GRANT SELECT(ID,Name,CounttryCode), UPDATE(Name,CounttryCode) on world.city to 'sasha'@'localhost';
SELECT * from mysql.columns_priv WHERE user = 'sasha'\G

revoke GRANT OPTION  on world.* from 'Juan'@'localhost';

show grants for 'sasha'@'localhost';
show grants for 'amon'@'localhost';

revoke ALL peivlleges  on world.* from 'amon'@'localhost';

revoke UPDATE  on world.cyty from 'sasha'@'localhost';

show grants for 'sasha'@'localhost';
show grants for 'amon'@'localhost';
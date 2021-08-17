use sic;
show tables;

select * from bodegas;
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('1', 'Bodega1', 'A');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('2', 'Bodega2', 'A');

select * from lineas;
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('1', 'Linea1', 'A');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('2', 'Linea2', 'A');

select * from marcas;
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('1', 'Marca1', 'A');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('2', 'Marca2', 'A');

select * from productos;
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('100', 'Cereal', '1', '1', '100', 'A');
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('101', 'Leche', '2', '2', '50', 'A');

select * from existencias;
INSERT INTO `sic`.`existencias` (`codigo_bodega`, `codigo_producto`, `saldo_existencia`) VALUES ('1', '100', '100');

select * from vendedores;
INSERT INTO `sic`.`vendedores` (`codigo_vendedor`, `nombre_vendedor`, `direccion_vendedor`, `telefono_vendedor`, `nit_vendedor`, `estatus_vendedor`) VALUES ('50', 'Juan', 'Ciudad', '4565455', '15515-J', 'A');
INSERT INTO `sic`.`vendedores` (`codigo_vendedor`, `nombre_vendedor`, `direccion_vendedor`, `telefono_vendedor`, `nit_vendedor`, `estatus_vendedor`) VALUES ('51', 'Daniel', 'Ciudad', '14551', '4554-A', 'A');

select * from clientes;
INSERT INTO `sic`.`clientes` (`codigo_cliente`, `nombre_cliente`, `direccion_cliente`, `nit_cliente`, `telefono_cliente`, `codigo_vendedor`, `estatus_cliente`) VALUES ('75', 'Pablo', 'Ciudad', '456545-8', '125223', '50', 'A');

select * from existencias;
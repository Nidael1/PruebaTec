-- Construye una base de datos
-- Creación de la base de datos
CREATE DATABASE Prueba1;

-- Usar la base de datos recién creada
USE Prueba1;
-- finaliza el modo seguro
SET SQL_SAFE_UPDATES = 0;

-- Creación de la tabla empleados
CREATE TABLE empleados (
    userId char(8),  
    Sueldo double,
    FechaIngreso DATE,
    PRIMARY KEY (userId)  
);
-- ver tabla
SELECT * FROM empleados;
-- ver lineas
select count(*) from empleados;
-- borrar los espacios
delete from empleados where userId = ' ';
-- Actualizar el dato Sueldo en un 10 porciento a los empleados que tienen fechas entre el año 2000 y 2001 (5 puntos)
-- aumentar sueldo
UPDATE empleados
SET Sueldo = Sueldo * 1.10
WHERE YEAR(FechaIngreso) BETWEEN 2000 AND 2001;


-- --------------------------------------------------------------------------------
-- Creación de la tabla usuarios
-- se creo user id con char porque no permite int al tener letras
CREATE TABLE usuarios (
    userId char(8) PRIMARY KEY ,  
    Login VARCHAR(100),
    Nombre VARCHAR(100),
    Paterno VARCHAR(100),
    Materno VARCHAR(100)
);

-- ver tabla
SELECT * FROM usuarios;
-- ver lineas
select count(*) from usuarios;
-- borrar los espacios
delete from usuarios where userId = ' ';
-- Depurar solo los ID diferentes de 6,7,9 y 10 de la tabla usuarios (5 puntos)
-- DEPURAR--
delete from usuarios where userId != 'user06' AND userId !='user07' AND userId !='user09' AND userId !='user10';

-- ---------------------------------------------
-- Realiza una consulta para traer el nombre de usuario y fecha de ingreso de los usuarios que gananen mas de 10000 y su apellido comience con T ordernado del mas reciente al mas antiguo (10 puntos)
-- Nota Se crea de nuevo la tabla debido al que en el paso anterior fue eliminada registros, de otra manera el resultado es vacio porque la T fueron borrados.
Drop table usuarios;
CREATE TABLE usuarios (
    userId char(8) PRIMARY KEY ,  
    Login VARCHAR(100),
    Nombre VARCHAR(100),
    Paterno VARCHAR(100),
    Materno VARCHAR(100)
);

select u.nombre, e.FechaIngreso
from usuarios as u join empleados as e
where u.userId = e.userId 
and e.Sueldo > 10000
and substr(u.Paterno, 1,1) = 'T'
order by e.FechaIngreso;

-- Realiza una consulta donde agrupes a los empleados por sueldo, un grupo con los que ganan menos de 1200 y uno mayor o igual a 1200, cuantos hay en cada grupo?
-- 0 menor a 1200 y 46 mayor o igual a 1200 , debido a que no existe ningun empleado con sueldo menor a 1200,
-- Nota hice la simulacion usando 12,000 de manera que pudiera verse la funcionalidad de mi solucion.
select sum(case when Sueldo < 12000 then 1 else 0 end) as menor12000,
sum(case when Sueldo >= 12000 then 1 else 0 end) as mayorigual12000
from empleados;


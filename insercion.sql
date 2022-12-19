SELECT * FROM Persona
SELECT * FROM Usuario
SELECT * FROM Empleado

SELECT * FROM Especialidad
INSERT Especialidad (Especialidad) VALUES (N'Traumatólogo')

SELECT * FROM TipoTrabajador
INSERT TipoTrabajador (tipoTrabajador) VALUES (N'Médico')

SP_help  Direccion
SELECT * FROM Direccion
INSERT Direccion (Calle,Numero,Colonia,CP) VALUES (N'Felipe Angeles',N'2',N'Centro',N'42640')

SP_help  Jornada
--delete from Jornada where idJornada<1000
--DBCC CHECKIDENT ('Jornada', RESEED, 0);
SELECT * FROM Jornada
INSERT Jornada (horaInicio,horaFin) VALUES	(PARSE('00:00:00' AS time),PARSE('08:00:00'AS time)),
											(PARSE('08:00:00' AS time),PARSE('16:00:00'AS time)),
											(PARSE('16:00:00' AS time),PARSE('23:59:00'AS time))

SP_help  DiaJornada
ALTER TABLE DiaJornada ALTER COLUMN Dia varchar(25) NOT NULL
SELECT * FROM DiaJornada
INSERT DiaJornada (Dia,idJornada) VALUES (N'Entre semana',2)


SP_help  Persona
ALTER TABLE Persona ALTER COLUMN Telefono BIGINT NOT NULL
select *from Persona
--delete from Persona where idPersona<1000
--DBCC CHECKIDENT ('Persona', RESEED, 0);
INSERT Persona (Nombre,Paterno,Materno,idDireccion,Telefono,Mail,fechaNac,Sexo) 
	VALUES (N'Erik',N'Morales',N'Lopez',1,7721123074,N'erik.mofe@outlook.com',CAST(N'2002-12-14T00:00:00.000' AS datetime),0)

SP_help  Paciente
select *from Paciente


SP_help  Empleado
ALTER TABLE Empleado ALTER COLUMN idEspecialidad INT

ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Jornada FOREIGN KEY(idJornada)
REFERENCES DiaJornada (idDia)
ON DELETE CASCADE ON UPDATE CASCADE

select *from Empleado
--delete from Empleado where idEmpleado<10
--DBCC CHECKIDENT('Empleado',RESEED,0)
INSERT Empleado (idPersona,idTipoTrabajador,idEspecialidad,idJornada,Salario) VALUES (1,1,1,1,129658.0000)



SP_help  usuario
select * from usuario
INSERT Usuario (idUsuario,IdEmpleado,Contraseña) VALUES (N'Erik12',1,N'hola123')

SELECT IdEmpleado from Usuario where idUsuario='Erik12' and Contraseña='hola123'

SELECT idPersona, idTipoTrabajador
from Usuario join Empleado
on Usuario.IdEmpleado = Empleado.idEmpleado
where idUsuario='Erik12' and Contraseña='hola123'



SELECT Nombre + ' ' + paterno + ' ' + ISNULL(materno,''), idTipoTrabajador
FROM Usuario AS u
   INNER JOIN
   Empleado AS e
   ON u.IdEmpleado = e.idEmpleado
   INNER JOIN
   Persona AS p
   ON e.idPersona = p.idPersona
where u.idUsuario = 'Erik12' and u.Contraseña='hola123'

SELECT Nombre + ' ' + paterno + ' ' + ISNULL(materno,''), idTipoTrabajador FROM Usuario AS u INNER JOIN Empleado AS e ON u.IdEmpleado = e.idEmpleado INNER JOIN Persona AS p ON e.idPersona = p.idPersona where u.idUsuario = 'Erik12' and u.Contraseña='hola123'

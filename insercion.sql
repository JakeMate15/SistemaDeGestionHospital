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
delete from Persona where idPersona<1000
DBCC CHECKIDENT ('Persona', RESEED, 0);
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

SELECT IdEmpleado from Usuario where idUsuario='Erik12' and Contrase�a='hola123'

SELECT idPersona, idTipoTrabajador
from Usuario join Empleado
on Usuario.IdEmpleado = Empleado.idEmpleado
where idUsuario='Erik12' and Contrase�a='hola123'



SELECT Nombre + ' ' + paterno + ' ' + ISNULL(materno,''), idTipoTrabajador
FROM Usuario AS u
   INNER JOIN
   Empleado AS e
   ON u.IdEmpleado = e.idEmpleado
   INNER JOIN
   Persona AS p
   ON e.idPersona = p.idPersona
where u.idUsuario = 'Erik12' and u.Contrase�a='hola123'

SELECT Nombre + ' ' + paterno + ' ' + ISNULL(materno,''), idTipoTrabajador FROM Usuario AS u INNER JOIN Empleado AS e ON u.IdEmpleado = e.idEmpleado INNER JOIN Persona AS p ON e.idPersona = p.idPersona where u.idUsuario = 'Erik12' and u.Contrase�a='hola123'





---Sgundas inserciones
INSERT DiaJornada (Dia,idJornada) VALUES  (N'Entre semana',1),
                                          (N'Entre semana',3),
                                          (N'Fin de semana',2),
                                          (N'Fin de semana',1),
                                          (N'Fin de semana',3)


INSERT Especialidad (Especialidad) VALUES (N'Geratria')

INSERT TipoTrabajador (tipoTrabajador) VALUES   (N'Enfermera'),
                                                (N'Recepcionista')

INSERT Direccion (Calle,Numero,Colonia,CP) VALUES  (N'Av. Juan de Dios Bátiz',N'1',N' Nueva Industrial Vallejo',N'07320')
                                                   (N'Av. Paseo de la Reforma',N'222',N'Juárez',N'06600')
                                                   (N'Av. de los Insurgentes Sur',N'453',N'Condesa',N'06170')

INSERT Persona (Nombre,Paterno,Materno,idDireccion,Telefono,Mail,fechaNac,Sexo) 
	VALUES   (N'Erik',N'Morales',N'Lopez',1,7721123074,N'erik.mofe@outlook.com',CAST(N'2002-12-14T00:00:00.000' AS datetime),0),
            (N'Eduardo',N'Peña',N'Hernandez',2,7721139687,N'nc@mail.com',CAST(N'1987-05-10T00:00:00.000' AS datetime),0),
            (N'Frida',N'Hernandez','Zamora',3,7715897412,N'frida@mail.com',CAST(N'2000-11-10T00:00:00.000' AS datetime),1),
            (N'Erik',N'Lopez',N'Morales',4,5596157896,N'erik@mail.com',CAST(N'1999-11-02T00:00:00.000' AS datetime),0)

INSERT Empleado (idPersona,idTipoTrabajador,idEspecialidad,idJornada,Salario) VALUES   (1,1,1,1,129658.0000),
                                                                                       (2,3,NULL,6,56874.3000),
                                                                                       (3,2,2,2,51265.0000)

INSERT Paciente(idPersona,Altura,Peso) VALUES   (4,N'1.75',N'84.56')

INSERT Lugar(TipoLugar,Disponibilidad) VALUES   (N'Consultorio 1',1),
                                                (N'Consultorio 2',1),
                                                (N'Consultorio 3',1),
                                                (N'Consultorio 4',1),
                                                (N'Consultorio 5',1),
                                                (N'Consultorio 6',1),
                                                (N'Consultorio 7',1),
                                                (N'Consultorio 8',1),
                                                (N'Consultorio 9',1),
                                                (N'Consultorio 10',1),
                                                (N'Cuarto 1',1),
                                                (N'Cuarto 2',1),
                                                (N'Cuarto 3',1),
                                                (N'Cuarto 4',1),
                                                (N'Cuarto 5',1),
                                                (N'Cuarto 6',1),
                                                (N'Cuarto 7',1),
                                                (N'Cuarto 8',1),
                                                (N'Cuarto 9',1),
                                                (N'Cuarto 10',1)

INSERT Usuario (idUsuario,IdEmpleado,Contraseña) VALUES  (N'Erik12',1,N'hola123'),
                                                         (N'Lalo12',2,N'prueba123'),
                                                         (N'Frida14',3,N'prueba123')


INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (4,1,11,CAST(N'2022-12-19T00:00:00.000' AS datetime),CAST(N'2022-12-22T00:00:00.000' AS datetime))
INSERT Cita(idEmpleado,idPaciente,idLugar,fechaInicio,fechaSalida) values (2,1,1,CAST(N'2022-12-18T00:00:00.000' AS datetime),CAST(N'2022-12-18T00:00:00.000' AS datetime))

insert Medicamento(Nombre,Costo) values	(N'Parecetamol',200.0),
										(N'Ibuprofeno',100.0)

insert Estudios(Nombre,Costo) values	(N'Química sanguínea',500.0),
										(N'Pruebas genéticas',600)

select * from Historial
insert Historial(idCita,Descripcion)	values	(1,N'Revision mensual')

select * from HistorialMedicamento
insert HistorialMedicamento(idHistorial,idMedicamento)	values	(1,1),
																(1,2)

select * from HistorialEstudios
insert HistorialEstudios(idHistorial,idEstudio) values	(1,1)


select Nombre + ' ' + paterno + ' ' + ISNULL(materno,'') as Nombre, idCita
from Persona as per
	inner join
	Paciente as pac
	on per.idPersona = pac.idPersona
	INNER JOIN
	(SELECT idPaciente,idCita
					FROM Empleado AS e
					   INNER JOIN
					   TipoTrabajador as t
					   ON e.idTipoTrabajador = t.idTipoTrabajador
					   INNER JOIN
					   Persona AS p
					   ON e.idPersona = p.idPersona
					   INNER JOIN
					   Cita as c
					   ON c.idEmpleado = e.idEmpleado 
					where t.tipoTrabajador = 'Enfermera' and Nombre='Frida' and Paterno='Hernandez') as con
	ON con.idPaciente = pac.idPaciente
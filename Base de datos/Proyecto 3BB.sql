show databases;
create database Aplicacion;
use Aplicacion;


create table Persona(
CIp Int (9) Primary key not null ,
Nombre char (30) not null ,
Apellido Char (30) not null,
Calle Char (20) not null,
NumeroC Int (4) not null,
Telefono Char (11),
Celular Char (11) not null,
Sexo Char (1),
Edad Int (3) not null
);

create table Usuario(
ID_Usuario Int (7) Primary key auto_increment not null,
CIu Int (9) not null ,
foreign key (CIu) References Persona (CIp),
Ocupacion Char (20) not null,
Descripcion_Hogar Char (255)
);

create table Medicos (
CIm Int (9) not null,
ID_Medico Int (7) Primary key auto_increment not null,
foreign key (CIm) References Persona (CIp),
Especialidad Char (20) not null,
contraseña varchar (20) not null
);

create table Sintomas (
ID_Sintoma Int (7) Primary key auto_increment not null,
Estado VarChar (255) ,
Lugar VarChar (10) not null,
Tipo VarChar (15) not null
) ;

create table Enfermedad_Usuario (
ID_UsuarioE Int (7) not null,
ID_SintomaE Int (7) not null,
foreign key (ID_UsuarioE) references Usuario (ID_Usuario),
foreign key (ID_SintomaE) references Sintomas (ID_Sintoma)
);

create table Patologias(
ID_Patologia Int (10) Primary key auto_increment not null,
Nombre VarChar (10) not null,
ID_SintomaP Int (10) not null,
foreign key (ID_SintomaP) references Sintomas (ID_Sintoma)
) ;

create table Asociados(
ID_SintomaA Int (10) not null,
ID_PatologiaA Int (10) not null,
foreign key (ID_SintomaA) references Sintomas (ID_Sintoma),
foreign key (ID_PatologiaA) references Patologias (ID_patologia)
) ;


create table Diagnosticos (
ID_UsuarioD Int (7) primary key not null,
ID_SintomaD Int (7) not null,
ID_PatologiaD Int (10) not null,
Fecha Datetime not null,
foreign key (ID_UsuarioD) references Enfermedad_Usuario (ID_UsuarioE),
foreign key (ID_SintomaD) references Enfermedad_Usuario (ID_SintomaE),
foreign key (ID_PatologiaD) references Patologias (ID_Patologia)
) ;

create table Peticion(
ID_UsuarioPE Int (7) not null,
ID_SintomaPE Int (4) not null,
ID_PatologiaPE Int (10) not null,
ID_MedicoPE Int (5) not null,
Prioridad Int (1) not null,
foreign key (ID_UsuarioPE) references Diagnosticos (ID_UsuarioD),
foreign key (ID_SintomaPE) references Diagnosticos (ID_SintomaD),
foreign key (ID_PatologiaPE) references Diagnosticos (ID_PatologiaD),
foreign key (ID_MedicoPE) references Medicos (ID_Medico)
);

create table Chat (
ID_UsuarioC Int (7) not null,
ID_SintomaC Int (4) not null,
ID_PatologiaC Int (10) not null,
ID_MedicoC Int (5) not null,
Mesaje longtext,
Fecha datetime,
foreign key (ID_UsuarioC) references Peticion (ID_UsuarioPE),
foreign key (ID_SintomaC) references Peticion (ID_SintomaPE),
foreign key (ID_PatologiaC) references Peticion (ID_PatologiaPE),
foreign key (ID_MedicoC) references Peticion (ID_MedicoPE)
) ;


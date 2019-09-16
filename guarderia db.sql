-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-09-2019 a las 00:51:00
-- Versión del servidor: 10.1.40-MariaDB
-- Versión de PHP: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `guarderia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargo`
--

CREATE TABLE `cargo` (
  `cargo` varchar(30) NOT NULL,
  `cedu_staff` int(10) NOT NULL,
  `id_servi` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dueno`
--

CREATE TABLE `dueno` (
  `Nombre` varchar(40) NOT NULL,
  `num_doc` int(12) NOT NULL,
  `Correo` varchar(30) NOT NULL,
  `tel_dueno` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `dueno`
--

INSERT INTO `dueno` (`Nombre`, `num_doc`, `Correo`, `tel_dueno`) VALUES
('jaime castro', 124234, 'jaimejaimejaimei', '23424234'),
('javier', 112312422, 'jaismduehf', '3042126154'),
('angello', 1010101010, 'firufiru@hotmail.com', '300404040'),
('Jaime castro chica ', 1039474706, 'jaimejfsdkjfh', '234234234'),
('jaimecambiado', 1039474708, 'jaimecambiado', '304123'),
('cesar maestre', 1129496208, 'cessardavir14gmail.com', '3006899783'),
('brandon', 1143267421, 'bonillalens191998@gmail.com', '3015186641');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingreso`
--

CREATE TABLE `ingreso` (
  `id_regist` varchar(10) NOT NULL,
  `id_masco` varchar(10) NOT NULL,
  `cedu_due` int(12) NOT NULL,
  `id_serv` varchar(10) NOT NULL,
  `fecha_in` datetime NOT NULL,
  `fecha_out` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ingreso`
--

INSERT INTO `ingreso` (`id_regist`, `id_masco`, `cedu_due`, `id_serv`, `fecha_in`, `fecha_out`) VALUES
('40AB9F30D0', 'U9AD6', 1039474708, 'PC_Ent ', '2019-08-08 09:13:30', '2019-08-13 09:09:24'),
('ELV5BWLISS', 'ELV5B', 124234, 'PC_Ent ', '2019-08-15 11:39:47', NULL),
('GAWAID9F6N', 'GAWAI', 1010101010, 'PC_Ent ', '2019-08-21 11:19:01', '2019-08-21 11:34:10'),
('IPGSIRZUN0', 'IPGSI', 1129496208, 'PC_Ent ', '2019-08-12 09:22:40', '2019-08-13 11:16:19'),
('JSGIZPF984', 'JSGIZ', 112312422, 'PC_Ent ', '2019-08-11 22:36:41', '2019-08-12 08:18:02'),
('K1GJK5PWPY', 'K1GJK', 1143267421, 'PC_Ent ', '2019-08-12 09:10:16', '2019-08-12 09:10:40'),
('TZH7PBIFSK', 'TZH7P', 1039474708, 'PC_Ent ', '2019-08-08 09:51:16', '2019-08-13 19:12:42'),
('YMBCSWOS5W', 'YMBCS', 1039474708, 'PC_Ent ', '2019-08-13 19:12:22', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mascota`
--

CREATE TABLE `mascota` (
  `Nom_masc` varchar(15) NOT NULL,
  `raza` varchar(15) NOT NULL,
  `Tamaño` varchar(10) NOT NULL,
  `vacunas` varchar(5) DEFAULT NULL,
  `Genero` varchar(10) NOT NULL,
  `Foto` blob,
  `ID_masco` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mascota`
--

INSERT INTO `mascota` (`Nom_masc`, `raza`, `Tamaño`, `vacunas`, `Genero`, `Foto`, `ID_masco`) VALUES
('jaime', 'jaime', 'Mediano', 'si', 'Masculino', '', '0VK4T'),
('akuaku', 'akuaku', 'Grande', 'Si', 'Femenino', 0x53797374656d2e44726177696e672e4269746d6170, '10O8W'),
('kokui', 'rodwiler', 'Mediano', 'si', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, '2HFBN'),
('firiku', 'rodwailer', 'Grande', 'no', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, '3MW9D'),
('jaimecastro', 'sfaasd', 'Grande', 'si', 'Femenino', '', '4EC45'),
('Dante 8', 'gato blanco', 'Pequeño', 'si', 'Femenino', '', '4HDRI'),
('jaime', 'asdjas', 'Mediano', 'si', 'Femenino', '', 'CCSUT'),
('michifu', 'gato negro', 'Mediano', 'si', 'Masculino', '', 'DUZS0'),
('firulais', 'gato blanco', 'Mediano', 'si', 'Femenino', '', 'ELV5B'),
('kiriku', 'rodwailer', 'Grande', 'no', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, 'FMFEN'),
('firulai', 'firu', 'Mediano', 'si', 'Femenino', 0x53797374656d2e44726177696e672e4269746d6170, 'GAWAI'),
('juan', 'pitbul', 'Mediano', 'si', 'Femenino', 0x53797374656d2e44726177696e672e4269746d6170, 'HWTLT'),
('atan', 'golden', 'Mediano', 'si', 'Masculino', '', 'IPGSI'),
('dante', 'akuku', 'Mediano', 'si', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, 'JSGIZ'),
('luna', 'rottweiler', 'Grande', 'si', 'Femenino', '', 'K1GJK'),
('Dante', 'gato amarillo', 'Mediano', 'si', 'Femenino', '', 'PFRC2'),
('sdfsdf', 'sdfsdf', 'Grande', 'si', 'Femenino', '', 'PKYRZ'),
('jaime', 'jaime', 'Grande', 'si', 'Masculino', '', 'R4UQJ'),
('dante 10', '10', 'Mediano', 'si', 'Masculino', '', 'S0WR9'),
('dante2', 'gato2', 'Pequeño', 'si', 'Femenino', 0x53797374656d2e44726177696e672e4269746d6170, 'TZH7P'),
('Dante', 'Gato', 'Mediano', NULL, 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, 'U9AD6'),
('jaime', 'sdf', 'Mediano', 'si', 'Femenino', '', 'UCDVL'),
('jaime.castro03@', 'dobernan', 'Mediano', 'si', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, 'WDT38'),
('dante 84', 'doberman', 'Mediano', 'si', 'Masculino', 0x53797374656d2e44726177696e672e4269746d6170, 'YMBCS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `masc_vac`
--

CREATE TABLE `masc_vac` (
  `id_masc` varchar(10) NOT NULL,
  `id_vac` int(10) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicios`
--

CREATE TABLE `servicios` (
  `nom_serv` varchar(20) NOT NULL,
  `descrip` varchar(255) NOT NULL,
  `id_serv` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `servicios`
--

INSERT INTO `servicios` (`nom_serv`, `descrip`, `id_serv`) VALUES
('Entrenamiento', 'Se le ofrece a la mascota un entrenador personalizado para que se le enseñen diferentes técnicas de comportamiento', 'PC_Ent'),
('Guardería', 'Servicio en el que se le ofrece a la mascota cuidados durante varios días', 'PC_Guar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `staff`
--

CREATE TABLE `staff` (
  `Nombre` varchar(50) NOT NULL,
  `cedula` int(10) NOT NULL,
  `correo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `staff`
--

INSERT INTO `staff` (`Nombre`, `cedula`, `correo`) VALUES
('Brayan Lopez Benitez ', 1032679952, 'brayan.lopez@hotmail.com'),
('alvear juan', 1234567890, 'juan.alvear@outlook.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tel_staff`
--

CREATE TABLE `tel_staff` (
  `ced_staff` int(10) NOT NULL,
  `telefono` bigint(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tel_staff`
--

INSERT INTO `tel_staff` (`ced_staff`, `telefono`) VALUES
(1032679952, 3042126154),
(1234567890, 3030064);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacunas`
--

CREATE TABLE `vacunas` (
  `nomb_vac` varchar(20) NOT NULL,
  `id_vac` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vacunas`
--

INSERT INTO `vacunas` (`nomb_vac`, `id_vac`) VALUES
('Hexavalente', 123),
('Pentavalente', 132);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`cedu_staff`,`id_servi`),
  ADD KEY `id_servi` (`id_servi`);

--
-- Indices de la tabla `dueno`
--
ALTER TABLE `dueno`
  ADD PRIMARY KEY (`num_doc`);

--
-- Indices de la tabla `ingreso`
--
ALTER TABLE `ingreso`
  ADD PRIMARY KEY (`id_regist`),
  ADD KEY `id_masco` (`id_masco`,`cedu_due`,`id_serv`),
  ADD KEY `id_serv` (`id_serv`),
  ADD KEY `cedu_due` (`cedu_due`) USING HASH;

--
-- Indices de la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD PRIMARY KEY (`ID_masco`);

--
-- Indices de la tabla `masc_vac`
--
ALTER TABLE `masc_vac`
  ADD PRIMARY KEY (`id_masc`,`id_vac`),
  ADD KEY `id_vac` (`id_vac`);

--
-- Indices de la tabla `servicios`
--
ALTER TABLE `servicios`
  ADD PRIMARY KEY (`id_serv`);

--
-- Indices de la tabla `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`cedula`);

--
-- Indices de la tabla `tel_staff`
--
ALTER TABLE `tel_staff`
  ADD PRIMARY KEY (`ced_staff`);

--
-- Indices de la tabla `vacunas`
--
ALTER TABLE `vacunas`
  ADD PRIMARY KEY (`id_vac`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cargo`
--
ALTER TABLE `cargo`
  ADD CONSTRAINT `cargo_ibfk_1` FOREIGN KEY (`cedu_staff`) REFERENCES `staff` (`cedula`),
  ADD CONSTRAINT `cargo_ibfk_2` FOREIGN KEY (`id_servi`) REFERENCES `servicios` (`id_serv`);

--
-- Filtros para la tabla `ingreso`
--
ALTER TABLE `ingreso`
  ADD CONSTRAINT `ingreso_ibfk_1` FOREIGN KEY (`id_masco`) REFERENCES `mascota` (`ID_masco`),
  ADD CONSTRAINT `ingreso_ibfk_3` FOREIGN KEY (`id_serv`) REFERENCES `servicios` (`id_serv`),
  ADD CONSTRAINT `ingreso_ibfk_4` FOREIGN KEY (`cedu_due`) REFERENCES `dueno` (`num_doc`);

--
-- Filtros para la tabla `masc_vac`
--
ALTER TABLE `masc_vac`
  ADD CONSTRAINT `masc_vac_ibfk_1` FOREIGN KEY (`id_vac`) REFERENCES `vacunas` (`id_vac`),
  ADD CONSTRAINT `masc_vac_ibfk_2` FOREIGN KEY (`id_masc`) REFERENCES `mascota` (`ID_masco`);

--
-- Filtros para la tabla `tel_staff`
--
ALTER TABLE `tel_staff`
  ADD CONSTRAINT `tel_staff_ibfk_1` FOREIGN KEY (`ced_staff`) REFERENCES `staff` (`cedula`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

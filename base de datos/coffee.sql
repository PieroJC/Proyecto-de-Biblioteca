-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 20-08-2019 a las 23:56:29
-- Versión del servidor: 5.7.17-log
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `coffee`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `dniCliente` varchar(8) NOT NULL,
  `NomCliente` varchar(20) NOT NULL,
  `ApeCliente` varchar(20) NOT NULL,
  `DirecCliente` varchar(50) NOT NULL,
  `TlfCliente` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`dniCliente`, `NomCliente`, `ApeCliente`, `DirecCliente`, `TlfCliente`) VALUES
('00000001', 'Jose Fernando', 'Bendezu Vargas', 'Av Lima 123', 954416510),
('00000002', 'Melisa Brishet', 'Socualaya Mayta', 'Jr Lima 274', 965412859),
('00000003', 'Marjorie Siboney', 'Astucuri Calderon', 'Av Arica 145', 954789125),
('00000004', 'Marice Lisbeth', 'Marcelo de la Cruz', 'Ferrocarril 250', 958745125),
('00000005', 'Estrella Nycol', 'Ochoa Pinedo', 'Av Arequipa 254', 95412365),
('00000006', 'Jimena Lucero', 'Ramos Berrospi', 'Jr Puno 258', 987456123),
('00000007', 'Derek Luis', 'Fernandez Remusgo', 'Av Bolivia 385', 987654321),
('00000008', 'Deivi Rafael', 'Landa Jimenez', 'Av Agricultura 257', 965412365);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `idEmpleado` varchar(8) NOT NULL,
  `nomEmpleado` varchar(20) NOT NULL,
  `apeEmpleado` varchar(20) NOT NULL,
  `direcEmpleado` varchar(50) NOT NULL,
  `tldEmpleado` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`idEmpleado`, `nomEmpleado`, `apeEmpleado`, `direcEmpleado`, `tldEmpleado`) VALUES
('01', 'Pedro ', 'Buendia  Ramirez', 'Av Juliaca 245', '965210356'),
('02', 'Leonel ', 'Musucancha Camayo', 'Av Jeronimo 254', '966541258'),
('03', 'Kevin ', 'Barzola Vivanco', 'Av barrio 254', '954123685'),
('04', 'Bryan ', 'Vargas', 'Jr TeRobo 125', '974125847');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `NroFactura` varchar(8) NOT NULL,
  `idPedido` varchar(8) NOT NULL,
  `PrecioTotal` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`NroFactura`, `idPedido`, `PrecioTotal`) VALUES
('500', '0001', '150'),
('501', '0002', '20'),
('502', '0003', '14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `idPedido` varchar(8) NOT NULL,
  `idProducto` varchar(8) NOT NULL,
  `dniCliente` varchar(8) NOT NULL,
  `CantPedido` int(100) NOT NULL,
  `Fecha` date NOT NULL,
  `idEmpleado` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`idPedido`, `idProducto`, `dniCliente`, `CantPedido`, `Fecha`, `idEmpleado`) VALUES
('0001', '100', '00000001', 2, '2019-08-09', '01'),
('0002', '101', '00000003', 5, '2019-08-16', '04'),
('0003', '103', '00000008', 5, '2019-08-13', '02'),
('0004', '102', '00000004', 4, '2019-08-04', '02'),
('0005', '101', '00000002', 8, '2019-08-09', '02'),
('0006', '103', '00000007', 1, '2019-08-25', '03'),
('0007', '101', '00000005', 6, '2019-08-09', '04'),
('0008', '101', '00000006', 6, '2019-08-16', '02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idProducto` varchar(8) NOT NULL,
  `NomProducto` varchar(20) NOT NULL,
  `PrecioProducto` decimal(10,0) NOT NULL,
  `CantidadProducto` int(250) NOT NULL,
  `idProveedor` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `NomProducto`, `PrecioProducto`, `CantidadProducto`, `idProveedor`) VALUES
('100', 'Capuchino', '10', 25, '10'),
('101', 'Pie de Limon', '5', 40, '12'),
('102', 'Cafe Puro', '9', 50, '11'),
('103', 'Leche Entera', '6', 15, '10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` varchar(8) NOT NULL,
  `NomProveedor` varchar(20) NOT NULL,
  `TlfProveedor` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `NomProveedor`, `TlfProveedor`) VALUES
('10', 'Gloria', '123'),
('11', 'Nescafe', '124'),
('12', 'Lalos', '12');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`dniCliente`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`idEmpleado`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`NroFactura`),
  ADD KEY `idPedido` (`idPedido`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`idPedido`),
  ADD KEY `dniCliente` (`dniCliente`),
  ADD KEY `idProducto` (`idProducto`),
  ADD KEY `idEmpleado` (`idEmpleado`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idProducto`),
  ADD KEY `idProveedor` (`idProveedor`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `facturas_ibfk_1` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`);

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`dniCliente`) REFERENCES `cliente` (`dniCliente`),
  ADD CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`),
  ADD CONSTRAINT `pedido_ibfk_3` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

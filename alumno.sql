/*
MySQL Data Transfer
Source Host: localhost
Source Database: sergioposse
Target Host: localhost
Target Database: sergioposse
Date: 22/05/2012 07:55:23 a.m.
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for alumno
-- ----------------------------
DROP TABLE IF EXISTS `alumno`;
CREATE TABLE `alumno` (
  `alu_id` int(5) NOT NULL auto_increment,
  `alu_ape` varchar(25) default NULL,
  `alu_nom` varchar(25) default NULL,
  `alu_dni` int(8) default NULL,
  `alu_tel` varchar(30) default NULL,
  `alu_cod_loc` int(5) default NULL,
  `alu_dom` varchar(40) default NULL,
  `alu_cod_car` int(5) default NULL,
  `alu_fec_ini` varchar(56) default NULL,
  `alu_est` char(1) default NULL,
  `alu_foto` varchar(100) default NULL,
  PRIMARY KEY  (`alu_id`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for carrera
-- ----------------------------
DROP TABLE IF EXISTS `carrera`;
CREATE TABLE `carrera` (
  `car_id` int(5) NOT NULL auto_increment,
  `car_nom` varchar(40) default NULL,
  `car_dur` int(40) default NULL,
  PRIMARY KEY  (`car_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for localidad
-- ----------------------------
DROP TABLE IF EXISTS `localidad`;
CREATE TABLE `localidad` (
  `loc_id` int(5) NOT NULL auto_increment,
  `loc_nom` varchar(40) default NULL,
  `loc_cod_pro` int(5) default NULL,
  `loc_cod_pos` int(15) default NULL,
  PRIMARY KEY  (`loc_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for pais
-- ----------------------------
DROP TABLE IF EXISTS `pais`;
CREATE TABLE `pais` (
  `pai_id` int(5) NOT NULL auto_increment,
  `pai_nom` varchar(40) default NULL,
  PRIMARY KEY  (`pai_id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for provincia
-- ----------------------------
DROP TABLE IF EXISTS `provincia`;
CREATE TABLE `provincia` (
  `pro_id` int(5) NOT NULL auto_increment,
  `pro_nom` varchar(50) default NULL,
  `pro_cod_pai` int(5) default NULL,
  PRIMARY KEY  (`pro_id`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `alumno` VALUES ('1', 'Posse', 'Sergio', '34771269', '4780919', '3', 'Urquiza 1878', '3', '27/12/1889 08:48:29 a.m.', 'A', '/imagenes/1.jpg');
INSERT INTO `alumno` VALUES ('27', 'Dickinson', 'Bruce', '2909987', '35698876', '7', 'Jhonson 820', '5', '1974-02-12 07:47:49 ', 'A', '/imagenes/27.jpg');
INSERT INTO `alumno` VALUES ('23', 'Malmsteen', 'Yngwie ', '34875034', '32466322', '2', 'Jomomo 8334', '2', '25/04/2012 12:34:55 p.m.', 'E', '/imagenes/23.jpg');
INSERT INTO `alumno` VALUES ('26', 'Silveira', 'Joaquin', '4345678', '346764', '2', 'Los Angeles 298', '4', '1901-05-22 06:23:47 ', 'P', '/imagenes/26.jpg');
INSERT INTO `alumno` VALUES ('6', 'Nyu', 'Lucy', '3434637', '34536745', '2', 'Mimimi 234', '1', '09/04/2012 07:27:32 a.m.', 'P', '/imagenes/6.jpg');
INSERT INTO `alumno` VALUES ('7', 'Posse', 'Melody', '40984023', '34534534', '1', 'Urquiza 1980', '1', '04/04/2012 07:41:13 a.m.', 'A', '/imagenes/7.jpg');
INSERT INTO `alumno` VALUES ('17', 'Patton', 'MIke', '28987498', '154289239', '2', 'Jefferson 983', '2', '05/06/1984 08:48:29 a.m.', 'P', '/imagenes/17.jpg');
INSERT INTO `alumno` VALUES ('18', 'Yciz', 'Florencia', '30234985', '154890983', '3', 'Ubuntu 4300', '2', '13/04/2012 08:52:40 a.m.', 'E', '/imagenes/18.jpg');
INSERT INTO `alumno` VALUES ('22', 'Babini', 'Martin', '34578654', '154203442', '3', 'Pasaje Turbio 999', '3', '2012-04-25 12:28:33.672', 'A', '/imagenes/22.jpg');
INSERT INTO `alumno` VALUES ('21', 'Marchetti', 'Jenn', '39172944', '156025520', '3', 'Ricardo Gutierrez 24', '1', '03/04/2012 12:24:15 p.m.', 'A', '/imagenes/21.jpg');
INSERT INTO `alumno` VALUES ('24', 'Carnel', 'Santiago', '34678432', '34568907', '1', 'Pipa 823', '3', '25/04/2012 01:04:42 p.m.', 'A', '/imagenes/24.jpg');
INSERT INTO `carrera` VALUES ('1', 'Turismo', '5');
INSERT INTO `carrera` VALUES ('2', 'Mecanica', '4');
INSERT INTO `carrera` VALUES ('3', 'Analista De Sistemas', '3');
INSERT INTO `carrera` VALUES ('4', 'Piscologia', '6');
INSERT INTO `carrera` VALUES ('5', 'Administracion', '4');
INSERT INTO `localidad` VALUES ('1', 'Villa Maria', '17', '234');
INSERT INTO `localidad` VALUES ('2', 'Almafuerte', '17', '2349');
INSERT INTO `localidad` VALUES ('3', 'Rio Cuarto', '17', '2349');
INSERT INTO `localidad` VALUES ('5', 'Villa Mercedes', '17', '345345');
INSERT INTO `localidad` VALUES ('6', 'Berrotaran', '17', '345346');
INSERT INTO `localidad` VALUES ('7', 'Jualimas', '26', '47900');
INSERT INTO `pais` VALUES ('1', 'Argentina');
INSERT INTO `pais` VALUES ('2', 'Chile');
INSERT INTO `pais` VALUES ('3', 'Mexico');
INSERT INTO `pais` VALUES ('4', 'Nicaragua');
INSERT INTO `pais` VALUES ('5', 'Costa Rica');
INSERT INTO `pais` VALUES ('6', 'Belgica');
INSERT INTO `pais` VALUES ('7', 'Alemania');
INSERT INTO `pais` VALUES ('8', 'Marruecos');
INSERT INTO `pais` VALUES ('9', 'Francia');
INSERT INTO `pais` VALUES ('10', 'Italia');
INSERT INTO `pais` VALUES ('11', 'Rusia');
INSERT INTO `pais` VALUES ('12', 'Japon');
INSERT INTO `pais` VALUES ('13', 'Canada');
INSERT INTO `pais` VALUES ('14', 'Uruguay');
INSERT INTO `pais` VALUES ('15', 'Guatemala');
INSERT INTO `provincia` VALUES ('23', 'Guadalajara', '3');
INSERT INTO `provincia` VALUES ('24', 'Santiago', '2');
INSERT INTO `provincia` VALUES ('17', 'Cordoba', '1');
INSERT INTO `provincia` VALUES ('18', 'La Pampa', '1');
INSERT INTO `provincia` VALUES ('19', 'La Rioja', '1');
INSERT INTO `provincia` VALUES ('20', 'Mendoza', '1');
INSERT INTO `provincia` VALUES ('21', 'Okawa', '12');
INSERT INTO `provincia` VALUES ('22', 'Moscu', '7');
INSERT INTO `provincia` VALUES ('25', 'Paris', '9');
INSERT INTO `provincia` VALUES ('26', 'Rios Libres', '11');

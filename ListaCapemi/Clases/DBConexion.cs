﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi
{
    class DBConexion
    {
        public static SqlConnection ObtnerCOnexion()
        {
            
                SqlConnection Conn = new SqlConnection("Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn.Open();
                return Conn;
            
            /*
            {
                SqlConnection Conn1 = new SqlConnection("Data Source=localhost;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn1.Open();
                return Conn1;
            }*/
                
            

        }


    

    }
}


/*
CREATE DATABASE ListaVenta
GO
USE ListaVenta
GO

CREATE TABLE CATEGORIAS(
ID_CATEGORIA INT IDENTITY(1,1) NOT NULL,
CATEGORIA VARCHAR(20),
CONSTRAINT PK_ID_CATEGORIA PRIMARY KEY (ID_CATEGORIA)
)
CREATE TABLE GRUPO(
ID_GRUPO INT IDENTITY(1,1) NOT NULL,
GRUPO VARCHAR(20),
CONSTRAINT PK_ID_GRUPO PRIMARY KEY (ID_GRUPO)
)

CREATE TABLE ARTICULO
(ID_ARTICULO INT IDENTITY(1,1) NOT NULL,
CODIGO VARCHAR(30) NOT NULL,
DESCRIPCION VARCHAR(50) NOT NULL,
LANZAMIENTO DATE NOT NULL,
OEM_ VARCHAR(30) NOT NULL,
MARCA VARCHAR(50) NOT NULL,
MODELO VARCHAR(50) NOT NULL,
DIAM_EXT DECIMAL(5,2),
DIAM_INT DECIMAL(5,2),
LARGO_EXT DECIMAL(5,2),
LARGO_INT DECIMAL(5,2),
FOTO_ART IMAGE,
ANIO INT NOT NULL,
PRECIO DECIMAL(10,4),
ID_CATEGORIA INT NOT NULL,
ID_GRUPO INT NOT NULL
CONSTRAINT PK_DETALLE PRIMARY KEY (ID_ARTICULO),
CONSTRAINT FK_ID_CATEGORIA FOREIGN KEY (ID_CATEGORIA)REFERENCES CATEGORIAS(ID_CATEGORIA),
CONSTRAINT FK_ID_GRUPO FOREIGN KEY (ID_GRUPO)REFERENCES GRUPO(ID_GRUPO)
)
/*INSERTANDO REGISTROS CATEGORIAS

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('BUJES')

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('GOMA')

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('SOPORTES')

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('FUELLES')

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('KITS')

INSERT INTO[dbo].[CATEGORIAS]
([CATEGORIA])
VALUES('SUSPENKITS')

//INSERTANDO REGISTROS GRUPO

INSERT INTO[dbo].GRUPO(GRUPO)
VALUES('LIVIANO')

INSERT INTO[dbo].GRUPO(GRUPO)
VALUES('PESADO')

INSERT INTO[dbo].GRUPO(GRUPO)
VALUES('OTROS')

*/
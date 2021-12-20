CREATE DATABASE Biblioteka;
USE Biblioteka ;

CREATE TABLE Knjiga(
  id INT IDENTITY(1, 1),
  naziv_knjige VARCHAR (1000) NOT NULL,
  autor NVARCHAR(1000) NOT NULL,
  br_strana int  NOT NULL,
  povez VARCHAR(1000) NOT NULL
);


# FinancieraCore #

Sistema operaciones financieras básicas de ejemplo con arquitectura monolitica utilizando N-capas.

Desarrollado con la tecnologia **.NetCore 3.1**

## Capa de Dominio ##

---
Se aplica algunos patrones de DDD.

![Diagrama de clases](/FinancieraCore2020.Dominio/include.png)

## Capa de Persistencia con Entity Framwork ##

---
Puede generar la base de datos desde la capa de persistencia utilizando los siguientes comandos:

```bash
dotnet tool install --global dotnet-ef
```

```bash
cd .\FinancieraCore2020.Datos.EF\
```

```bash
dotnet ef migrations add CrearFinancieraBD
```

```bash
dotnet ef database update
```

Primero se debera configurar un gestor de base de datos relacional, configurar la cadena de conexion.

### MariaBD ###

```bash
docker run --name mariadb -e MYSQL_ROOT_PASSWORD=upt.2020 -d -p 3306:3306 mariadb
```

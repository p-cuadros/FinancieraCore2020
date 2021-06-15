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


docker run --rm -ti --name zalenium -p 4444:4444 -v /var/run/docker.sock:/var/run/docker.sock -v /c/Users/admin/temp/videos:/Users/admin/temp/videos --privileged dosel/zalenium start 

dotnet tool install --global coverlet.console
dotnet tool install --global dotnet-sonarscanner
dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet sonarscanner begin /k:"FinancieraCore" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="ca62c31e14c1605ca34e870ea073a4faa761cb0a"
dotnet sonarscanner end /d:sonar.login="ca62c31e14c1605ca34e870ea073a4faa761cb0a"
dotnet sonarscanner begin /k:"FinancieraCore" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="ca62c31e14c1605ca34e870ea073a4faa761cb0a" /d:sonar.cs.vscoveragexml.reportsPaths="*.coveragexml" /d:sonar.cs.vstest.reportsPaths="*.trx" /d:sonar.verbose=true /d:sonar.log.level="TRACE"

dotnet build
dotnet test --collect "Code Coverage" --logger trx --results-directory "TestsResults"
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=Coverage\

dotnet sonarscanner end /d:sonar.login="ca62c31e14c1605ca34e870ea073a4faa761cb0a"
dotnet test --logger "trx;LogFileName=TestResults.trx" --logger "nunit;LogFileName=TestResults.xml" --results-directory "Coverage" /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=Coverage /p:Exclude="[nunit.*]*
ReportGenerator "-reports:Coverage\coverage.cobertura.xml" "-targetdir:Coverage" -reporttypes:HTML
@Echo off
REM <-----   PARAMETROS ----->
REM --	1 Nombre de ambiente a limpiar cache
REM --	2 Usuario DataPower
REM --	3 Password DataPower
REM --	Ejemplo ejecucion:
REM --		Cache.bat DESARROLLO username password
REM <-----   PARAMETROS ----->


Echo ______ Data Power ______
Echo -- Desplegando sobre el dominio Data Power: %1%
set hostDP="10.76.60.17:5550"

if "%1%" == "PRE_DESA" (
set hostDP="10.76.60.18:5550"
)

if "%1%" == "DESARROLLO" (
set hostDP="10.76.60.18:5550"
)

if "%1%" == "DESARROLLO_XI50" (
set hostDP="10.76.60.18:5550"
)

if "%1%" == "TESTING" (
set hostDP="10.76.60.17:5550"
)

if "%1%" == "TESTING_XI50" (
set hostDP="10.76.60.17:5550"
)


Echo -- Realizando informe uso: 

(
  echo ^<env:Envelope xmlns:env="http://schemas.xmlsoap.org/soap/envelope/"^>
  echo ^<env:Body^>
  echo ^<dp:GetDomainListRequest xmlns:dp="http://www.datapower.com/schemas/appliance/management/1.0"/^>
  echo ^</env:Body^>
  echo ^</env:Envelope^>
) > RQ.xml
curl -s -k -u %2":"%3 --data-binary @RQ.xml https://%hostDP%/service/mgmt/amp/1.0 > informeRSP.xml
for /F "delims=" %%a in ('findstr /m /r "OK" informeRSP.xml') do set "salidaCache=%%a"

if "%salidaCache%" == "informeRSP.xml" (
	Echo -- Informe completado    
    Echo 200
	pause
) else (
    Echo -- Informe completado
	Echo 400
	pause
)
Exit /B 400
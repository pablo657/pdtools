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

set ip=10.95.182.84

Echo -- Ejecutando Ping al host: "%ip%"

(
  echo ^<env:Envelope xmlns:env="http://schemas.xmlsoap.org/soap/envelope/"^>
  echo ^<env:Body^>
  echo ^<dp:request domain="%1" xmlns:dp="http://www.datapower.com/schemas/management"^>
  echo ^<dp:do-action^>
  echo ^<Ping^>
  echo ^<RemoteHost^>%ip%^</RemoteHost^>
REM  echo ^<useIPv>default^</useIPv^>
  echo ^</Ping^>
  echo ^</dp:do-action^>
  echo ^</dp:request^>
  echo ^</env:Body^>
  echo ^</env:Envelope^>
) > direccionPing.xml
curl -s -k -u %2":"%3 --data-binary @direccionPing.xml https://%hostDP%/service/mgmt/3.0 > resultadoPing.xml
for /F "delims=" %%a in ('findstr /m /r "OK" resultadoPing.xml') do set "salidaCache=%%a"

if "%salidaCache%" == "resultadoPing.xml" (
	Echo -- Ping Exitoso.    
    Echo 200
	pause
) else (
    Echo -- Host no alcanzado
	Echo 400
	pause
)
Exit /B 400
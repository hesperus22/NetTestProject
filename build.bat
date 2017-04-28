@echo off

set SOURCES_DIR=%~dp0
set OUTPUT_DIR=%SOURCES_DIR%\bin-debug
set BUILDTARGET=Debug
echo Build Started in Debug mode

"%SOURCES_DIR%\Nuget\Nuget.exe" restore "%SOURCES_DIR%\NetTestProject.sln"
if %ERRORLEVEL% neq 0 (
	echo Warning: Nuget restore operation finished with errors, exit code: %ERRORLEVEL%>&2
)

if NOT DEFINED NUMBER_OF_PROCESSORS set NUMBER_OF_PROCESSORS=1

"%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" "%SOURCES_DIR%\NetTestProject.sln" "/p:OutputPath=%OUTPUT_DIR%" /t:Build /p:Configuration=%BUILDTARGET% /maxcpucount:%NUMBER_OF_PROCESSORS%
if %ERRORLEVEL% neq 0 (
	echo ERROR: Build failed, exit code: %ERRORLEVEL%>&2
	exit /B %ERRORLEVEL%
)

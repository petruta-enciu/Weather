#Allor script execute on  system
set-executionpolicy remotesigned
#Set The Path For Tools
$msbuild = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
$msdeploy="C:\Program Files (x86)\IIS\Microsoft Web Deploy\msdeploy.exe"
$fxcop="C:\Program Files (x86)\Microsoft FxCop 1.36"
$nunit="C:\Program Files (x86)\NUnit 2.6.1\bin\"
$ndepends="C:\NDepends\"

# MS BUILD SETTINGS  
$baseDir = "H:\WeatherApiGit\Weather.Api\"
$binDir = "H:\WeatherApiGit\Weather.Api\Weather.Api\bin"
$objDir="H:\WeatherApiGit\Weather.Api\Weather.Api\obj"
$options = " /p:Configuration=Release"
# if the output folder exists, delete it
if (  ([System.IO.Directory]::Exists($binDir)) -or ([System.IO.Directory]::Exists($objDir)) )
{
 
 [System.IO.Directory]::Delete($binDir, 1)
 [System.IO.Directory]::Delete($objDir, 1)
}

cd $baseDir
$clean = $msbuild + " ""Weather.Api.sln"" " + $options + " /t:Clean"
$build = $msbuild + " ""Weather.Api.sln"" " + $options + " /t:Build"
Invoke-Expression $clean
Invoke-Expression $build
$LASTEXITCODE 
WRITE-TOHOST $LASTEXITCODE 
BREAK 
clear

#FXCOP STEPS
cd $fxcop 
$fxcoproject=$baseDir+"WeatherFxCop.FxCop"
$fxcopcommand=.\FxCopCmd.exe /p:$fxcoproject /console
$fxcopcommand


#NDEPENDS STEPS
cd $ndepends
$ndependproject=$baseDir+"WeatherNdepends.ndproj"
$ndependscommand=.\NDepend.Console.exe $ndependproject
$ndependscommand


#NUNIT Step
cd $nunit
$nunitcommand=.\nunit-console.exe H:\WeatherApiGit\Weather.Api\Weather.Api.Tests\bin\Release\Weather.Api.Tests.dll
$nunitcommand

#MS DEPLOY PACKAGE
cd H:\WeatherApiGit\Weather.Api\Weather.Api
$package =$msbuild + " ""Weather.Api.csproj"" " + $options + " /t:Package"
Invoke-Expression $package

#PUBLISH TO UAT SERVER 








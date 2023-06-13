param(
    [string]$ApplicationPath,
    [string]$SourcePath,
    [string]$WebAppPool,
    [string]$ApplicationName,
    [string]$WebSiteName
)

Import-Module WebAdministration
New-WebApplication -Name "eshop" -Site "Default Web Site" -PhysicalPath ".\\csEshopWeb\\src\\Web" -ApplicationPool "DefaultAppPool" -Force

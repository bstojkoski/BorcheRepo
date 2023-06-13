param(
    [string]$ApplicationPath,
    [string]$SourcePath,
    [string]$WebAppPool,
    [string]$ApplicationName,
    [string]$WebSiteName
)

Import-Module WebAdministration
New-WebApplication "-Name eshop -Site 'Default Web Site' -PhysicalPath 'C:\\Program Files (x86)\\Go Agent\\pipelines\\e-Shop-build\\csEshopWeb' -ApplicationPool 'DefaultAppPool' -Force"

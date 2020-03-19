param(
    [string]$ApplicationPath,
    [string]$SourcePath,
    [string]$WebAppPool,
    [string]$ApplicationName,
    [string]$WebSiteName
)

New-WebApplication -Name $ApplicationName -Site $WebSiteName -PhysicalPath $ApplicationPath -ApplicationPool $WebAppPool -Force
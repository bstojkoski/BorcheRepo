cd 'C:\Program Files (x86)\Go Agent\pipelines\DeployPipeline\BuildArtifacts\csEshopWeb\src\Web'
dotnet run
ping http://localhost:5106
start http://localhost:5106
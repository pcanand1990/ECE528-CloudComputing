FROM mcr.microsoft.com/dotnet/sdk:7.0
COPY ./bin/Release/net7.0/publish /publish
WORKDIR /publish

EXPOSE 5175
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
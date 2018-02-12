FROM microsoft/dotnet:runtime
WORKDIR /app

MAINTAINER Vladimir Vladimir@akopyan.me 

COPY /build .

EXPOSE 1883 
ENTRYPOINT ["dotnet", "MQTTserver.dll"]
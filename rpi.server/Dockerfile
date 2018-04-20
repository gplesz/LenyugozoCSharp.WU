#a fordításhoz un. staged build-et használunk, ez az első stage, a build
FROM microsoft/aspnetcore-build:2.0 as builderenv
WORKDIR /app

#nuget csomagok telepítése
COPY rpi.server.csproj .
RUN dotnet restore ./rpi.server.csproj

#elkészítjük a futtatható végeredményt, linux-arm architektúrára
# Debug/Production
COPY . .
RUN dotnet publish -c Debug -o out -r linux-arm

#csomagolás: második stage
FROM microsoft/dotnet:2.0.0-runtime-deps-stretch-arm32v7
WORKDIR /app

COPY --from=builderenv /app/out .

ENV ASPNETCORE_URLS=http://+:5000
#Development/Production
ENV ASPNETCORE_ENVIRONMENT=Develpment 
EXPOSE 5000/tcp

#alkalmazás indítása
CMD ["./rpi.server"]
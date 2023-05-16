#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
# start workaround for exit code 125 -> https://stackoverflow.com/questions/58757587/how-to-fix-docker-command-failed-with-exit-code-125-when-using-visual-studio
#USER ContainerAdministrator
#RUN net localgroup administrators /add "User Manager\ContainerUser"
#USER ContainerUser
# end workaround
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Application Interface/Application Interface.csproj", "Application Interface/"]
RUN dotnet restore "Application Interface/Application Interface.csproj"
COPY . .
WORKDIR "/src/Application Interface"
RUN dotnet build "Application Interface.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Application Interface.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Application Interface.dll"]
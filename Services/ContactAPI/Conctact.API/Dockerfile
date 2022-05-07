#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/ContactAPI/Conctact.API/Conctact.API.csproj", "Services/ContactAPI/Conctact.API/"]
COPY ["Services/ContactAPI/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "Services/ContactAPI/Contact.API.Infrastructure/"]
COPY ["Services/ContactAPI/Contact.API.Models/Contact.API.Models.csproj", "Services/ContactAPI/Contact.API.Models/"]
COPY ["Services/ContactAPI/Contact.API.Services/Contact.API.Services.csproj", "Services/ContactAPI/Contact.API.Services/"]
RUN dotnet restore "Services/ContactAPI/Conctact.API/Conctact.API.csproj"
COPY . .
WORKDIR "/src/Services/ContactAPI/Conctact.API"
RUN dotnet build "Conctact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Conctact.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Conctact.API.dll"]
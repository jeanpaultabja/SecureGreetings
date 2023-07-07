#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN adduser \
  --disabled-password \
  --home /app \
  --gecos '' app \
  && chown -R app /app
USER app

WORKDIR /app
COPY ./publish .

ENV DOTNET_RUNNING_IN_CONTAINER=true \
  ASPNETCORE_URLS=https://+:8443
EXPOSE 8443
ENTRYPOINT ["dotnet", "SecureGreetings.dll"]
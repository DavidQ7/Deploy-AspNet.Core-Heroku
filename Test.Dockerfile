FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /output
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY Test/ Test/
WORKDIR Test
RUN dotnet publish -c Release -o output

FROM base AS final
COPY --from=build /src/Test/output .
CMD dotnet Test.dll



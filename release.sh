#!/bin/sh
if [ -z "$NUGET_API_KEY" ]; then echo "NUGET_API_KEY should be set to run the the release script"; exit 1; fi
sh ./build.sh
VERSION=$(awk -F'[<>]' '/<Version>/{print $3}' ThundraTemplates.nuspec)
nuget pack ThundraTemplates.nuspec
dotnet nuget push Thundra.Templates.$VERSION.nupkg -k $NUGET_API_KEY -s https://api.nuget.org/v3/index.json